Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a pos_hdrtmp.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class pos_hdrtmp
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the pos_hdrtmp class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "pos_hdrtmp"
  End Sub
#End Region

  #Region "Private Variables"
  Private _postmphdrid As Integer = 0
  Private _posdate As Date = DateTime.Now
  Private _Receipt As Integer = 0
  Private _custid As Integer = 0
  Private _disc As Double = 0
  Private _posamnt As Decimal = 0
  Private _discamnt As Decimal = 0
  Private _tendered As Decimal = 0
  Private _Cheyns As Decimal = 0
  Private _subtot As Decimal = 0
  Private _posted As Boolean? = False
  Private _postme As Date = DateTime.Now
  Private _costamnt As Decimal = 0
  Private _sInsertid As String = String.Empty
  Private _dtInsertdt As Date = DateTime.Now
  Private _sLastUpdateid As String = String.Empty
  Private _dtLastUpdatedt As Date = DateTime.Now
  Private _iConcurrencyid As Short = 0
  Private _cheque As String = String.Empty
  Private _mowd As String = String.Empty
  Private _paidamnt As Decimal = 0
  Private _status As Boolean? = False
  Private _bal As Decimal = 0
  Private _Custnum As Integer = 0
  Private _Sc As Integer = 0
  Private _totsales As Decimal = 0
  Private _lessvat As Decimal = 0
  Private _nov As Decimal = 0
  Private _lesssc As Decimal = 0
  Private _vatable As Decimal = 0
  Private _exempt As Decimal = 0
  Private _vatamnt As Decimal = 0
  Private _tid As String = String.Empty
  Private _wtid As Integer = 0
  Private _trminal As Integer = 0
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the postmphdrid value
  ''' </summary>
  <DataMember()> _
  Public Property postmphdrid() As Integer
    Get
      Return _postmphdrid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_postmphdrid, Value, "postmp_hdrid") Then
        _postmphdrid = Value
        RaisePropertyChanged("postmphdrid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the posdate value
  ''' </summary>
  <DataMember()> _
  Public Property posdate() As Date
    Get
      Return _posdate
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_posdate, Value, "pos_date") Then
        _posdate = Value
        RaisePropertyChanged("posdate")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Receipt value
  ''' </summary>
  <DataMember()> _
  Public Property Receipt() As Integer
    Get
      Return _Receipt
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_Receipt, Value, "Receipt") Then
        _Receipt = Value
        RaisePropertyChanged("Receipt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the custid value
  ''' </summary>
  <DataMember()> _
  Public Property custid() As Integer
    Get
      Return _custid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_custid, Value, "custid") Then
        _custid = Value
        RaisePropertyChanged("custid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the disc value
  ''' </summary>
  <DataMember()> _
  Public Property disc() As Double
    Get
      Return _disc
    End Get
    Set(ByVal Value As Double)
      If HasValueChanged(_disc, Value, "disc") Then
        _disc = Value
        RaisePropertyChanged("disc")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the posamnt value
  ''' </summary>
  <DataMember()> _
  Public Property posamnt() As Decimal
    Get
      Return _posamnt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_posamnt, Value, "pos_amnt") Then
        _posamnt = Value
        RaisePropertyChanged("posamnt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the discamnt value
  ''' </summary>
  <DataMember()> _
  Public Property discamnt() As Decimal
    Get
      Return _discamnt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_discamnt, Value, "disc_amnt") Then
        _discamnt = Value
        RaisePropertyChanged("discamnt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the tendered value
  ''' </summary>
  <DataMember()> _
  Public Property tendered() As Decimal
    Get
      Return _tendered
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_tendered, Value, "tendered") Then
        _tendered = Value
        RaisePropertyChanged("tendered")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Cheyns value
  ''' </summary>
  <DataMember()> _
  Public Property Cheyns() As Decimal
    Get
      Return _Cheyns
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_Cheyns, Value, "Cheyns") Then
        _Cheyns = Value
        RaisePropertyChanged("Cheyns")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the subtot value
  ''' </summary>
  <DataMember()> _
  Public Property subtot() As Decimal
    Get
      Return _subtot
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_subtot, Value, "subtot") Then
        _subtot = Value
        RaisePropertyChanged("subtot")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the posted value
  ''' </summary>
  <DataMember()> _
  Public Property posted() As Boolean?
    Get
      Return _posted
    End Get
    Set(ByVal Value As Boolean?)
      If HasValueChanged(_posted, Value, "posted") Then
        _posted = Value
        RaisePropertyChanged("posted")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the postme value
  ''' </summary>
  <DataMember()> _
  Public Property postme() As Date
    Get
      Return _postme
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_postme, Value, "pos_tme") Then
        _postme = Value
        RaisePropertyChanged("postme")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the costamnt value
  ''' </summary>
  <DataMember()> _
  Public Property costamnt() As Decimal
    Get
      Return _costamnt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_costamnt, Value, "cost_amnt") Then
        _costamnt = Value
        RaisePropertyChanged("costamnt")
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
  ''' Get/Set the cheque value
  ''' </summary>
  <DataMember()> _
  Public Property cheque() As String
    Get
      Return _cheque
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_cheque, Value, "cheque") Then
        _cheque = Value
        RaisePropertyChanged("cheque")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the mowd value
  ''' </summary>
  <DataMember()> _
  Public Property mowd() As String
    Get
      Return _mowd
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_mowd, Value, "mowd") Then
        _mowd = Value
        RaisePropertyChanged("mowd")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the paidamnt value
  ''' </summary>
  <DataMember()> _
  Public Property paidamnt() As Decimal
    Get
      Return _paidamnt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_paidamnt, Value, "paidamnt") Then
        _paidamnt = Value
        RaisePropertyChanged("paidamnt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the status value
  ''' </summary>
  <DataMember()> _
  Public Property status() As Boolean?
    Get
      Return _status
    End Get
    Set(ByVal Value As Boolean?)
      If HasValueChanged(_status, Value, "status") Then
        _status = Value
        RaisePropertyChanged("status")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the bal value
  ''' </summary>
  <DataMember()> _
  Public Property bal() As Decimal
    Get
      Return _bal
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_bal, Value, "bal") Then
        _bal = Value
        RaisePropertyChanged("bal")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Custnum value
  ''' </summary>
  <DataMember()> _
  Public Property Custnum() As Integer
    Get
      Return _Custnum
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_Custnum, Value, "Custnum") Then
        _Custnum = Value
        RaisePropertyChanged("Custnum")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Sc value
  ''' </summary>
  <DataMember()> _
  Public Property Sc() As Integer
    Get
      Return _Sc
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_Sc, Value, "Sc") Then
        _Sc = Value
        RaisePropertyChanged("Sc")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totsales value
  ''' </summary>
  <DataMember()> _
  Public Property totsales() As Decimal
    Get
      Return _totsales
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totsales, Value, "totsales") Then
        _totsales = Value
        RaisePropertyChanged("totsales")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the lessvat value
  ''' </summary>
  <DataMember()> _
  Public Property lessvat() As Decimal
    Get
      Return _lessvat
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_lessvat, Value, "less_vat") Then
        _lessvat = Value
        RaisePropertyChanged("lessvat")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the nov value
  ''' </summary>
  <DataMember()> _
  Public Property nov() As Decimal
    Get
      Return _nov
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_nov, Value, "nov") Then
        _nov = Value
        RaisePropertyChanged("nov")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the lesssc value
  ''' </summary>
  <DataMember()> _
  Public Property lesssc() As Decimal
    Get
      Return _lesssc
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_lesssc, Value, "less_sc") Then
        _lesssc = Value
        RaisePropertyChanged("lesssc")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the vatable value
  ''' </summary>
  <DataMember()> _
  Public Property vatable() As Decimal
    Get
      Return _vatable
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_vatable, Value, "vatable") Then
        _vatable = Value
        RaisePropertyChanged("vatable")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the exempt value
  ''' </summary>
  <DataMember()> _
  Public Property exempt() As Decimal
    Get
      Return _exempt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_exempt, Value, "exempt") Then
        _exempt = Value
        RaisePropertyChanged("exempt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the vatamnt value
  ''' </summary>
  <DataMember()> _
  Public Property vatamnt() As Decimal
    Get
      Return _vatamnt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_vatamnt, Value, "vatamnt") Then
        _vatamnt = Value
        RaisePropertyChanged("vatamnt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the tid value
  ''' </summary>
  <DataMember()> _
  Public Property tid() As String
    Get
      Return _tid
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_tid, Value, "tid") Then
        _tid = Value
        RaisePropertyChanged("tid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the wtid value
  ''' </summary>
  <DataMember()> _
  Public Property wtid() As Integer
    Get
      Return _wtid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_wtid, Value, "wtid") Then
        _wtid = Value
        RaisePropertyChanged("wtid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the trminal value
  ''' </summary>
  <DataMember()> _
  Public Property trminal() As Integer
    Get
      Return _trminal
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_trminal, Value, "trminal") Then
        _trminal = Value
        RaisePropertyChanged("trminal")
      End If
    End Set
  End Property
#End Region
End Class
