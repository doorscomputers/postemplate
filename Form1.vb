
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Management

Namespace SystemInfo
	Public Partial Class frmserial
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private MyHDDGen As FiveSevenNine

		Private Sub button1_Click(sender As Object, e As EventArgs)
			'  FiveSevenNine MyHDDGen = new FiveSevenNine();
			If rdHDD.Checked Then
				MyHDDGen.GenerateFromHDD()
			ElseIf rdMAC.Checked Then
				MyHDDGen.GenerateFromMAC()
			Else
				If chkHex.Checked Then
					MyHDDGen.GenerateForNumber(CInt(Int64.Parse(txtNumber.Text, System.Globalization.NumberStyles.HexNumber)))
				Else
					MyHDDGen.GenerateForNumber(CInt(Int64.Parse(txtNumber.Text)))
				End If
			End If

			Me.lblFive.Text = MyHDDGen.Five.ToString()
			Me.lblSeven.Text = MyHDDGen.Seven.ToString()
			Me.lblNine.Text = MyHDDGen.Nine.ToString()

		End Sub

		Private Sub btnGenerate_Click(sender As Object, e As EventArgs)
			Dim MySerial As New SerialNumber()
			Dim Randomizer As New Random(99999)
			txtSerial.Text = MySerial.GenerateSerial(Randomizer.[Next](999, 99999), MyHDDGen.Five, MyHDDGen.Seven, MyHDDGen.Nine)
		End Sub

		Private Sub frmserial_Load(sender As Object, e As EventArgs)
			MyHDDGen = New FiveSevenNine()
		End Sub

		Private Sub btnCheck_Click(sender As Object, e As EventArgs)
			Dim MySerial As New SerialNumber()
			If MySerial.CheckSerial(txtSerial.Text, MyHDDGen.Five, MyHDDGen.Seven, MyHDDGen.Nine) Then
				lblChkResult.Text = "Correct"
			Else
				lblChkResult.Text = "Incorrect"
			End If

		End Sub
	End Class

	Public Partial Class SerialNumber
		Public Function GenerateSerial(seed As Integer, five__1 As Integer, seven__2 As Integer, nine__3 As Integer) As String
			If five__1 <= 2 OrElse seven__2 <= 2 OrElse nine__3 <= 2 Then
				Return "0000-0000-0000"
			End If
			Dim Five__4 As Integer, Seven__5 As Integer, Nine__6 As Integer, Scaler As Integer
			Dim Ranomizer As New Random()
			Dim Done As Boolean = False
			Scaler = Ranomizer.[Next](2, 20)
			Five__4 = seed * Scaler + 5
			sleep(100)
			Scaler = Ranomizer.[Next](2, 20)
			Seven__5 = seed * Scaler + 7
			sleep(100)
			Scaler = Ranomizer.[Next](2, 20)
			Nine__6 = seed * Scaler + 9

			While Not Done
				Done = True
				If Five__4 Mod five__1 <> 0 Then
					Five__4 -= 1
					Done = False
				End If
				If Seven__5 Mod seven__2 <> 0 Then
					Seven__5 -= 1
					Done = False
				End If
				If Nine__6 Mod nine__3 <> 0 Then
					Nine__6 -= 1
					Done = False
				End If
			End While
			'while
			Return Five__4.ToString() + "-" + Seven__5.ToString() + "-" + Nine__6.ToString()
		End Function

		Public Function CheckSerial(Serial As String, Five__1 As Integer, Seven__2 As Integer, Nine__3 As Integer) As Boolean
			If Five__1 <= 2 OrElse Seven__2 <= 2 OrElse Nine__3 <= 2 Then
				Return False
			End If
			Dim five__4 As Integer = Integer.Parse(Serial.Split("-"C)(0))
			Dim seven__5 As Integer = Integer.Parse(Serial.Split("-"C)(1))
			Dim nine__6 As Integer = Integer.Parse(Serial.Split("-"C)(2))
			If five__4 <= 2 OrElse seven__5 <= 2 OrElse nine__6 <= 2 Then
				Return False
			End If
			If (five__4 Mod Five__1 = 0) AndAlso (seven__5 Mod Seven__2 = 0) AndAlso (nine__6 Mod Nine__3 = 0) Then
				Return True
			End If
			Return False
		End Function
		Private Sub sleep(Time As Integer)
			System.Threading.Thread.Sleep(Time)
		End Sub
	End Class
	'class serial number

	Public Partial Class FiveSevenNine
		Private m_FIVE As Integer
		Private m_SEVEN As Integer
		Private m_NINE As Integer

		Public ReadOnly Property Five() As Integer
			Get
				Return m_FIVE
			End Get
		End Property
		Public ReadOnly Property Seven() As Integer
			Get
				Return m_SEVEN
			End Get
		End Property
		Public ReadOnly Property Nine() As Integer
			Get
				Return m_NINE
			End Get
		End Property
		Public Sub GenerateFromHDD()
			Dim drive As String = "C"
			Dim HDDNum As Integer
			Dim disk As New ManagementObject((Convert.ToString("win32_logicaldisk.deviceid=""") & drive) + ":""")
			'bind our management object
			disk.[Get]()
			'return the serial number
			HDDNum = Integer.Parse(disk("VolumeSerialNumber").ToString(), System.Globalization.NumberStyles.HexNumber)
			GenerateFromDevID(HDDNum)
		End Sub


		Public Sub GenerateFromMAC()
			Dim MACAdd As Int64 = Int64.Parse(GetMACAddress(), System.Globalization.NumberStyles.HexNumber)
			GenerateFromDevID(CInt(MACAdd And &HffffffffUI))
		End Sub

		Public Sub GenerateForNumber(Number As Integer)
			GenerateFromDevID(Number)
		End Sub
		Private Sub GenerateFromDevID(MACorHDD As Integer)
			m_FIVE = CInt(MACorHDD And &Hff)
			m_SEVEN = CInt(MACorHDD And &Hff00) >> 8
			m_NINE = CInt(MACorHDD And &Hff0000) >> 16
		End Sub

		Private Function GetMACAddress() As String
			Dim mc As New ManagementClass("Win32_NetworkAdapterConfiguration")
			Dim moc As ManagementObjectCollection = mc.GetInstances()
			Dim MACAddress As String = [String].Empty
			For Each mo As ManagementObject In moc
				If MACAddress = [String].Empty Then
					' only return MAC Address from first card
					If CBool(mo("IPEnabled")) = True Then
						MACAddress = mo("MacAddress").ToString()
					End If
				End If
				mo.Dispose()
			Next

			MACAddress = MACAddress.Replace(":", "")
			Return MACAddress
		End Function


	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
