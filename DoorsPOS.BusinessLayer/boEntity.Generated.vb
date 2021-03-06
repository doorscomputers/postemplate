Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a bo.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class bo
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the bo class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "bo"
  End Sub
#End Region

  #Region "Private Variables"
  Private _boid As Integer = 0
  Private _supcode As Integer = 0
  Private _bodate As Date = DateTime.Now
  Private _stckid As Integer = 0
  Private _price As Decimal = 0
  Private _qty As Integer = 0
  Private _amnt As Decimal = 0
  Private _prevavlbl As Integer = 0
  Private _sInsertid As String = String.Empty
  Private _dtInsertdt As Date = DateTime.Now
  Private _sLastUpdateid As String = String.Empty
  Private _dtLastUpdatedt As Date = DateTime.Now
  Private _iConcurrencyid As Short = 0
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the boid value
  ''' </summary>
  <DataMember()> _
  Public Property boid() As Integer
    Get
      Return _boid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_boid, Value, "boid") Then
        _boid = Value
        RaisePropertyChanged("boid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the supcode value
  ''' </summary>
  <DataMember()> _
  Public Property supcode() As Integer
    Get
      Return _supcode
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_supcode, Value, "supcode") Then
        _supcode = Value
        RaisePropertyChanged("supcode")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the bodate value
  ''' </summary>
  <DataMember()> _
  Public Property bodate() As Date
    Get
      Return _bodate
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_bodate, Value, "bodate") Then
        _bodate = Value
        RaisePropertyChanged("bodate")
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
#End Region
End Class
