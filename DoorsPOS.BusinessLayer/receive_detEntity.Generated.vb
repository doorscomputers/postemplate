Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a receive_det.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class receive_det
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the receive_det class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "receive_det"
  End Sub
#End Region

  #Region "Private Variables"
  Private _rdetid As Integer = 0
  Private _rid As Integer = 0
  Private _stckid As Integer = 0
  Private _price As Decimal = 0
  Private _qty As Integer = 0
  Private _ramnt As Decimal = 0
  Private _prevavlbl As Integer = 0
  Private _currentavlbl As Integer = 0
  Private _sInsertid As String = String.Empty
  Private _dtInsertdt As Date = DateTime.Now
  Private _sLastUpdateid As String = String.Empty
  Private _dtLastUpdatedt As Date = DateTime.Now
  Private _iConcurrencyid As Short = 0
  Private _rrpsted As Boolean? = False
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the rdetid value
  ''' </summary>
  <DataMember()> _
  Public Property rdetid() As Integer
    Get
      Return _rdetid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_rdetid, Value, "rdetid") Then
        _rdetid = Value
        RaisePropertyChanged("rdetid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the rid value
  ''' </summary>
  <DataMember()> _
  Public Property rid() As Integer
    Get
      Return _rid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_rid, Value, "rid") Then
        _rid = Value
        RaisePropertyChanged("rid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the stckid value
  ''' </summary>
  <DataMember()> _
  Public Property stckid() As Integer
    Get
      Return _stckid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_stckid, Value, "stckid") Then
        _stckid = Value
        RaisePropertyChanged("stckid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the price value
  ''' </summary>
  <DataMember()> _
  Public Property price() As Decimal
    Get
      Return _price
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_price, Value, "price") Then
        _price = Value
        RaisePropertyChanged("price")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the qty value
  ''' </summary>
  <DataMember()> _
  Public Property qty() As Integer
    Get
      Return _qty
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_qty, Value, "qty") Then
        _qty = Value
        RaisePropertyChanged("qty")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the ramnt value
  ''' </summary>
  <DataMember()> _
  Public Property ramnt() As Decimal
    Get
      Return _ramnt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_ramnt, Value, "ramnt") Then
        _ramnt = Value
        RaisePropertyChanged("ramnt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the prevavlbl value
  ''' </summary>
  <DataMember()> _
  Public Property prevavlbl() As Integer
    Get
      Return _prevavlbl
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_prevavlbl, Value, "prevavlbl") Then
        _prevavlbl = Value
        RaisePropertyChanged("prevavlbl")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the currentavlbl value
  ''' </summary>
  <DataMember()> _
  Public Property currentavlbl() As Integer
    Get
      Return _currentavlbl
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_currentavlbl, Value, "currentavlbl") Then
        _currentavlbl = Value
        RaisePropertyChanged("currentavlbl")
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
  ''' <summary>
  ''' Get/Set the dtInsertdt value
  ''' </summary>
  <DataMember()> _
  Public Property dtInsertdt() As Date
    Get
      Return _dtInsertdt
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_dtInsertdt, Value, "dtInsert_dt") Then
        _dtInsertdt = Value
        RaisePropertyChanged("dtInsertdt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the sLastUpdateid value
  ''' </summary>
  <DataMember()> _
  Public Property sLastUpdateid() As String
    Get
      Return _sLastUpdateid
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_sLastUpdateid, Value, "sLastUpdate_id") Then
        _sLastUpdateid = Value
        RaisePropertyChanged("sLastUpdateid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the dtLastUpdatedt value
  ''' </summary>
  <DataMember()> _
  Public Property dtLastUpdatedt() As Date
    Get
      Return _dtLastUpdatedt
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_dtLastUpdatedt, Value, "dtLastUpdate_dt") Then
        _dtLastUpdatedt = Value
        RaisePropertyChanged("dtLastUpdatedt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the iConcurrencyid value
  ''' </summary>
  <DataMember()> _
  Public Property iConcurrencyid() As Short
    Get
      Return _iConcurrencyid
    End Get
    Set(ByVal Value As Short)
      If HasValueChanged(_iConcurrencyid, Value, "iConcurrency_id") Then
        _iConcurrencyid = Value
        RaisePropertyChanged("iConcurrencyid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the rrpsted value
  ''' </summary>
  <DataMember()> _
  Public Property rrpsted() As Boolean?
    Get
      Return _rrpsted
    End Get
    Set(ByVal Value As Boolean?)
      If HasValueChanged(_rrpsted, Value, "rrpsted") Then
        _rrpsted = Value
        RaisePropertyChanged("rrpsted")
      End If
    End Set
  End Property
#End Region
End Class