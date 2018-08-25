Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a payment.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class payment
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the payment class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "payment"
  End Sub
#End Region

  #Region "Private Variables"
  Private _PayID As Integer = 0
  Private _CustID As Integer = 0
  Private _FP As String = String.Empty
  Private _PayDate As Date = DateTime.Now
  Private _CheckNo As String = String.Empty
  Private _AccountName As String = String.Empty
  Private _DateIssued As Date = DateTime.Now
  Private _DateDue As Date = DateTime.Now
  Private _AccountNo As String = String.Empty
  Private _BankName As String = String.Empty
  Private _Amount As Decimal = 0
  Private _Remarks As String = String.Empty
  Private _Cleared As Boolean? = False
  Private _Posted As Boolean? = False
  Private _Terminal As Short = 0
  Private _InvoiceNum As String = String.Empty
  Private _Receipt As String = String.Empty
  Private _OldBal As Decimal = 0
  Private _NewBal As Decimal = 0
  Private _TimeEncoded As Date = DateTime.Now
  Private _sInsertid As String = String.Empty
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the PayID value
  ''' </summary>
  <DataMember()> _
  Public Property PayID() As Integer
    Get
      Return _PayID
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_PayID, Value, "PayID") Then
        _PayID = Value
        RaisePropertyChanged("PayID")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the CustID value
  ''' </summary>
  <DataMember()> _
  Public Property CustID() As Integer
    Get
      Return _CustID
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_CustID, Value, "CustID") Then
        _CustID = Value
        RaisePropertyChanged("CustID")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the FP value
  ''' </summary>
  <DataMember()> _
  Public Property FP() As String
    Get
      Return _FP
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_FP, Value, "FP") Then
        _FP = Value
        RaisePropertyChanged("FP")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the PayDate value
  ''' </summary>
  <DataMember()> _
  Public Property PayDate() As Date
    Get
      Return _PayDate
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_PayDate, Value, "PayDate") Then
        _PayDate = Value
        RaisePropertyChanged("PayDate")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the CheckNo value
  ''' </summary>
  <DataMember()> _
  Public Property CheckNo() As String
    Get
      Return _CheckNo
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_CheckNo, Value, "CheckNo") Then
        _CheckNo = Value
        RaisePropertyChanged("CheckNo")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the AccountName value
  ''' </summary>
  <DataMember()> _
  Public Property AccountName() As String
    Get
      Return _AccountName
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_AccountName, Value, "AccountName") Then
        _AccountName = Value
        RaisePropertyChanged("AccountName")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the DateIssued value
  ''' </summary>
  <DataMember()> _
  Public Property DateIssued() As Date
    Get
      Return _DateIssued
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_DateIssued, Value, "DateIssued") Then
        _DateIssued = Value
        RaisePropertyChanged("DateIssued")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the DateDue value
  ''' </summary>
  <DataMember()> _
  Public Property DateDue() As Date
    Get
      Return _DateDue
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_DateDue, Value, "DateDue") Then
        _DateDue = Value
        RaisePropertyChanged("DateDue")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the AccountNo value
  ''' </summary>
  <DataMember()> _
  Public Property AccountNo() As String
    Get
      Return _AccountNo
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_AccountNo, Value, "AccountNo") Then
        _AccountNo = Value
        RaisePropertyChanged("AccountNo")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the BankName value
  ''' </summary>
  <DataMember()> _
  Public Property BankName() As String
    Get
      Return _BankName
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_BankName, Value, "BankName") Then
        _BankName = Value
        RaisePropertyChanged("BankName")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Amount value
  ''' </summary>
  <DataMember()> _
  Public Property Amount() As Decimal
    Get
      Return _Amount
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_Amount, Value, "Amount") Then
        _Amount = Value
        RaisePropertyChanged("Amount")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Remarks value
  ''' </summary>
  <DataMember()> _
  Public Property Remarks() As String
    Get
      Return _Remarks
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_Remarks, Value, "Remarks") Then
        _Remarks = Value
        RaisePropertyChanged("Remarks")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Cleared value
  ''' </summary>
  <DataMember()> _
  Public Property Cleared() As Boolean?
    Get
      Return _Cleared
    End Get
    Set(ByVal Value As Boolean?)
      If HasValueChanged(_Cleared, Value, "Cleared") Then
        _Cleared = Value
        RaisePropertyChanged("Cleared")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Posted value
  ''' </summary>
  <DataMember()> _
  Public Property Posted() As Boolean?
    Get
      Return _Posted
    End Get
    Set(ByVal Value As Boolean?)
      If HasValueChanged(_Posted, Value, "Posted") Then
        _Posted = Value
        RaisePropertyChanged("Posted")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Terminal value
  ''' </summary>
  <DataMember()> _
  Public Property Terminal() As Short
    Get
      Return _Terminal
    End Get
    Set(ByVal Value As Short)
      If HasValueChanged(_Terminal, Value, "Terminal") Then
        _Terminal = Value
        RaisePropertyChanged("Terminal")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the InvoiceNum value
  ''' </summary>
  <DataMember()> _
  Public Property InvoiceNum() As String
    Get
      Return _InvoiceNum
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_InvoiceNum, Value, "InvoiceNum") Then
        _InvoiceNum = Value
        RaisePropertyChanged("InvoiceNum")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Receipt value
  ''' </summary>
  <DataMember()> _
  Public Property Receipt() As String
    Get
      Return _Receipt
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_Receipt, Value, "Receipt") Then
        _Receipt = Value
        RaisePropertyChanged("Receipt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the OldBal value
  ''' </summary>
  <DataMember()> _
  Public Property OldBal() As Decimal
    Get
      Return _OldBal
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_OldBal, Value, "OldBal") Then
        _OldBal = Value
        RaisePropertyChanged("OldBal")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the NewBal value
  ''' </summary>
  <DataMember()> _
  Public Property NewBal() As Decimal
    Get
      Return _NewBal
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_NewBal, Value, "NewBal") Then
        _NewBal = Value
        RaisePropertyChanged("NewBal")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the TimeEncoded value
  ''' </summary>
  <DataMember()> _
  Public Property TimeEncoded() As Date
    Get
      Return _TimeEncoded
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_TimeEncoded, Value, "TimeEncoded") Then
        _TimeEncoded = Value
        RaisePropertyChanged("TimeEncoded")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the sInsertid value
  ''' </summary>
  <DataMember()> _
  Public Property sInsertid() As String
    Get
      Return _sInsertid
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_sInsertid, Value, "sInsert_id") Then
        _sInsertid = Value
        RaisePropertyChanged("sInsertid")
      End If
    End Set
  End Property
#End Region
End Class