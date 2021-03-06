Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a paymntdetl.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class paymntdetl
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the paymntdetl class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "paymntdetl"
  End Sub
#End Region

  #Region "Private Variables"
  Private _pmntdetid As Integer = 0
  Private _payid As Integer = 0
  Private _drinv As String = String.Empty
  Private _drid As Integer = 0
  Private _amnt As Decimal = 0
  Private _remarks As String = String.Empty
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the pmntdetid value
  ''' </summary>
  <DataMember()> _
  Public Property pmntdetid() As Integer
    Get
      Return _pmntdetid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_pmntdetid, Value, "pmntdetid") Then
        _pmntdetid = Value
        RaisePropertyChanged("pmntdetid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the payid value
  ''' </summary>
  <DataMember()> _
  Public Property payid() As Integer
    Get
      Return _payid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_payid, Value, "payid") Then
        _payid = Value
        RaisePropertyChanged("payid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the drinv value
  ''' </summary>
  <DataMember()> _
  Public Property drinv() As String
    Get
      Return _drinv
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_drinv, Value, "drinv") Then
        _drinv = Value
        RaisePropertyChanged("drinv")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the drid value
  ''' </summary>
  <DataMember()> _
  Public Property drid() As Integer
    Get
      Return _drid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_drid, Value, "drid") Then
        _drid = Value
        RaisePropertyChanged("drid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the amnt value
  ''' </summary>
  <DataMember()> _
  Public Property amnt() As Decimal
    Get
      Return _amnt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_amnt, Value, "amnt") Then
        _amnt = Value
        RaisePropertyChanged("amnt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the remarks value
  ''' </summary>
  <DataMember()> _
  Public Property remarks() As String
    Get
      Return _remarks
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_remarks, Value, "remarks") Then
        _remarks = Value
        RaisePropertyChanged("remarks")
      End If
    End Set
  End Property
#End Region
End Class
