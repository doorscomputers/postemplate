Imports System
Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value returned, or parameter to be input/output from the spGetReceiptNo stored procedure.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
''' </summary>
'<DataContract()> _
Partial Public Class spGetReceiptNo
   Inherits PDSAEntityBase

#Region "Constructor"
 Public Sub New()
    ClassName = "spGetReceiptNo"
 End Sub
#End Region

  #Region "Private Variables"
  Private _ReceiptNo As Integer = 0
  Private _RETURNVALUE As Integer = 0
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the ReceiptNo value
  ''' </summary>
   _
  Public Property ReceiptNo() As Integer
    Get
      Return _ReceiptNo
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_ReceiptNo, Value, "@ReceiptNo") Then
        _ReceiptNo = Value
        RaisePropertyChanged("ReceiptNo")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the RETURNVALUE value
  ''' </summary>
   _
  Public Property RETURNVALUE() As Integer
    Get
      Return _RETURNVALUE
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_RETURNVALUE, Value, "@RETURN_VALUE") Then
        _RETURNVALUE = Value
        RaisePropertyChanged("RETURNVALUE")
      End If
    End Set
  End Property
#End Region
End Class
