Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a tblreading.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class tblreading
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the tblreading class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "tblreading"
  End Sub
#End Region

  #Region "Private Variables"
  Private _cashreadid As Integer = 0
  Private _cashier As String = String.Empty
  Private _datereading As Date = DateTime.Now
  Private _totalsales As Decimal = 0
  Private _totalcredit As Decimal = 0
  Private _totaldiscount As Decimal = 0
  Private _begincash As Decimal = 0
  Private _totalcheque As Decimal = 0
  Private _changeprice As Decimal = 0
  Private _transfer As Decimal = 0
  Private _thousndp As Decimal = 0
  Private _fiehundredp As Decimal = 0
  Private _twohundredp As Decimal = 0
  Private _onehundredp As Decimal = 0
  Private _fiftyp As Decimal = 0
  Private _twentyp As Decimal = 0
  Private _tenp As Decimal = 0
  Private _fivep As Decimal = 0
  Private _onep As Decimal = 0
  Private _twentyfive As Decimal = 0
  Private _overshort As Decimal = 0
  Private _status As Boolean? = False
  Private _timereading As Date = DateTime.Now
  Private _payments As Decimal = 0
  Private _readtime As Date = DateTime.Now
  Private _pickup As Decimal = 0
  Private _addcash As Decimal = 0
  Private _totalrefs As Decimal = 0
  Private _totalsales2 As Decimal = 0
  Private _cnttotalsales As Integer = 0
  Private _cnttotalrefunds As Integer = 0
  Private _cnttotaldiscounts As Integer = 0
  Private _cnttotaldep As Integer = 0
  Private _cntsenior As Integer = 0
  Private _cntdiscreg As Integer = 0
  Private _cntvoids As Integer = 0
  Private _cntreceipt As Integer = 0
  Private _begreceipt As String = String.Empty
  Private _endreceipt As String = String.Empty
  Private _prevtotal As Decimal = 0
  Private _terminal As Integer = 0
  Private _totvat As Decimal = 0
  Private _totnonvat As Decimal = 0
  Private _totzerorated As Decimal = 0
  Private _sumvat As Decimal = 0
  Private _cntcredits As Integer = 0
  Private _accutotsale As Decimal = 0
  Private _readingno As Integer = 0
  Private _ETwo As Decimal = 0
  Private _EOneHundred As Decimal = 0
  Private _EFifty As Decimal = 0
  Private _ETwenty As Decimal = 0
  Private _ETen As Decimal = 0
  Private _EFive As Decimal = 0
  Private _Eone As Decimal = 0
  Private _Ecents As Decimal = 0
  Private _TotRemit As Decimal = 0
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the cashreadid value
  ''' </summary>
  <DataMember()> _
  Public Property cashreadid() As Integer
    Get
      Return _cashreadid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cashreadid, Value, "cashreadid") Then
        _cashreadid = Value
        RaisePropertyChanged("cashreadid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cashier value
  ''' </summary>
  <DataMember()> _
  Public Property cashier() As String
    Get
      Return _cashier
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_cashier, Value, "cashier") Then
        _cashier = Value
        RaisePropertyChanged("cashier")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the datereading value
  ''' </summary>
  <DataMember()> _
  Public Property datereading() As Date
    Get
      Return _datereading
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_datereading, Value, "datereading") Then
        _datereading = Value
        RaisePropertyChanged("datereading")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totalsales value
  ''' </summary>
  <DataMember()> _
  Public Property totalsales() As Decimal
    Get
      Return _totalsales
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totalsales, Value, "totalsales") Then
        _totalsales = Value
        RaisePropertyChanged("totalsales")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totalcredit value
  ''' </summary>
  <DataMember()> _
  Public Property totalcredit() As Decimal
    Get
      Return _totalcredit
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totalcredit, Value, "totalcredit") Then
        _totalcredit = Value
        RaisePropertyChanged("totalcredit")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totaldiscount value
  ''' </summary>
  <DataMember()> _
  Public Property totaldiscount() As Decimal
    Get
      Return _totaldiscount
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totaldiscount, Value, "totaldiscount") Then
        _totaldiscount = Value
        RaisePropertyChanged("totaldiscount")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the begincash value
  ''' </summary>
  <DataMember()> _
  Public Property begincash() As Decimal
    Get
      Return _begincash
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_begincash, Value, "begincash") Then
        _begincash = Value
        RaisePropertyChanged("begincash")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totalcheque value
  ''' </summary>
  <DataMember()> _
  Public Property totalcheque() As Decimal
    Get
      Return _totalcheque
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totalcheque, Value, "totalcheque") Then
        _totalcheque = Value
        RaisePropertyChanged("totalcheque")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the changeprice value
  ''' </summary>
  <DataMember()> _
  Public Property changeprice() As Decimal
    Get
      Return _changeprice
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_changeprice, Value, "changeprice") Then
        _changeprice = Value
        RaisePropertyChanged("changeprice")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the transfer value
  ''' </summary>
  <DataMember()> _
  Public Property transfer() As Decimal
    Get
      Return _transfer
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_transfer, Value, "transfer") Then
        _transfer = Value
        RaisePropertyChanged("transfer")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the thousndp value
  ''' </summary>
  <DataMember()> _
  Public Property thousndp() As Decimal
    Get
      Return _thousndp
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_thousndp, Value, "thousndp") Then
        _thousndp = Value
        RaisePropertyChanged("thousndp")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the fiehundredp value
  ''' </summary>
  <DataMember()> _
  Public Property fiehundredp() As Decimal
    Get
      Return _fiehundredp
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_fiehundredp, Value, "fiehundredp") Then
        _fiehundredp = Value
        RaisePropertyChanged("fiehundredp")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the twohundredp value
  ''' </summary>
  <DataMember()> _
  Public Property twohundredp() As Decimal
    Get
      Return _twohundredp
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_twohundredp, Value, "twohundredp") Then
        _twohundredp = Value
        RaisePropertyChanged("twohundredp")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the onehundredp value
  ''' </summary>
  <DataMember()> _
  Public Property onehundredp() As Decimal
    Get
      Return _onehundredp
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_onehundredp, Value, "onehundredp") Then
        _onehundredp = Value
        RaisePropertyChanged("onehundredp")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the fiftyp value
  ''' </summary>
  <DataMember()> _
  Public Property fiftyp() As Decimal
    Get
      Return _fiftyp
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_fiftyp, Value, "fiftyp") Then
        _fiftyp = Value
        RaisePropertyChanged("fiftyp")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the twentyp value
  ''' </summary>
  <DataMember()> _
  Public Property twentyp() As Decimal
    Get
      Return _twentyp
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_twentyp, Value, "twentyp") Then
        _twentyp = Value
        RaisePropertyChanged("twentyp")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the tenp value
  ''' </summary>
  <DataMember()> _
  Public Property tenp() As Decimal
    Get
      Return _tenp
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_tenp, Value, "tenp") Then
        _tenp = Value
        RaisePropertyChanged("tenp")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the fivep value
  ''' </summary>
  <DataMember()> _
  Public Property fivep() As Decimal
    Get
      Return _fivep
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_fivep, Value, "fivep") Then
        _fivep = Value
        RaisePropertyChanged("fivep")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the onep value
  ''' </summary>
  <DataMember()> _
  Public Property onep() As Decimal
    Get
      Return _onep
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_onep, Value, "onep") Then
        _onep = Value
        RaisePropertyChanged("onep")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the twentyfive value
  ''' </summary>
  <DataMember()> _
  Public Property twentyfive() As Decimal
    Get
      Return _twentyfive
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_twentyfive, Value, "twentyfive") Then
        _twentyfive = Value
        RaisePropertyChanged("twentyfive")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the overshort value
  ''' </summary>
  <DataMember()> _
  Public Property overshort() As Decimal
    Get
      Return _overshort
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_overshort, Value, "overshort") Then
        _overshort = Value
        RaisePropertyChanged("overshort")
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
  ''' Get/Set the timereading value
  ''' </summary>
  <DataMember()> _
  Public Property timereading() As Date
    Get
      Return _timereading
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_timereading, Value, "timereading") Then
        _timereading = Value
        RaisePropertyChanged("timereading")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the payments value
  ''' </summary>
  <DataMember()> _
  Public Property payments() As Decimal
    Get
      Return _payments
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_payments, Value, "payments") Then
        _payments = Value
        RaisePropertyChanged("payments")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the readtime value
  ''' </summary>
  <DataMember()> _
  Public Property readtime() As Date
    Get
      Return _readtime
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_readtime, Value, "readtime") Then
        _readtime = Value
        RaisePropertyChanged("readtime")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the pickup value
  ''' </summary>
  <DataMember()> _
  Public Property pickup() As Decimal
    Get
      Return _pickup
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_pickup, Value, "pickup") Then
        _pickup = Value
        RaisePropertyChanged("pickup")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the addcash value
  ''' </summary>
  <DataMember()> _
  Public Property addcash() As Decimal
    Get
      Return _addcash
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_addcash, Value, "addcash") Then
        _addcash = Value
        RaisePropertyChanged("addcash")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totalrefs value
  ''' </summary>
  <DataMember()> _
  Public Property totalrefs() As Decimal
    Get
      Return _totalrefs
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totalrefs, Value, "totalrefs") Then
        _totalrefs = Value
        RaisePropertyChanged("totalrefs")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totalsales2 value
  ''' </summary>
  <DataMember()> _
  Public Property totalsales2() As Decimal
    Get
      Return _totalsales2
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totalsales2, Value, "totalsales2") Then
        _totalsales2 = Value
        RaisePropertyChanged("totalsales2")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cnttotalsales value
  ''' </summary>
  <DataMember()> _
  Public Property cnttotalsales() As Integer
    Get
      Return _cnttotalsales
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cnttotalsales, Value, "cnttotalsales") Then
        _cnttotalsales = Value
        RaisePropertyChanged("cnttotalsales")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cnttotalrefunds value
  ''' </summary>
  <DataMember()> _
  Public Property cnttotalrefunds() As Integer
    Get
      Return _cnttotalrefunds
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cnttotalrefunds, Value, "cnttotalrefunds") Then
        _cnttotalrefunds = Value
        RaisePropertyChanged("cnttotalrefunds")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cnttotaldiscounts value
  ''' </summary>
  <DataMember()> _
  Public Property cnttotaldiscounts() As Integer
    Get
      Return _cnttotaldiscounts
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cnttotaldiscounts, Value, "cnttotaldiscounts") Then
        _cnttotaldiscounts = Value
        RaisePropertyChanged("cnttotaldiscounts")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cnttotaldep value
  ''' </summary>
  <DataMember()> _
  Public Property cnttotaldep() As Integer
    Get
      Return _cnttotaldep
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cnttotaldep, Value, "cnttotaldep") Then
        _cnttotaldep = Value
        RaisePropertyChanged("cnttotaldep")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cntsenior value
  ''' </summary>
  <DataMember()> _
  Public Property cntsenior() As Integer
    Get
      Return _cntsenior
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cntsenior, Value, "cntsenior") Then
        _cntsenior = Value
        RaisePropertyChanged("cntsenior")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cntdiscreg value
  ''' </summary>
  <DataMember()> _
  Public Property cntdiscreg() As Integer
    Get
      Return _cntdiscreg
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cntdiscreg, Value, "cntdiscreg") Then
        _cntdiscreg = Value
        RaisePropertyChanged("cntdiscreg")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cntvoids value
  ''' </summary>
  <DataMember()> _
  Public Property cntvoids() As Integer
    Get
      Return _cntvoids
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cntvoids, Value, "cntvoids") Then
        _cntvoids = Value
        RaisePropertyChanged("cntvoids")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cntreceipt value
  ''' </summary>
  <DataMember()> _
  Public Property cntreceipt() As Integer
    Get
      Return _cntreceipt
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cntreceipt, Value, "cntreceipt") Then
        _cntreceipt = Value
        RaisePropertyChanged("cntreceipt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the begreceipt value
  ''' </summary>
  <DataMember()> _
  Public Property begreceipt() As String
    Get
      Return _begreceipt
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_begreceipt, Value, "begreceipt") Then
        _begreceipt = Value
        RaisePropertyChanged("begreceipt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the endreceipt value
  ''' </summary>
  <DataMember()> _
  Public Property endreceipt() As String
    Get
      Return _endreceipt
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_endreceipt, Value, "endreceipt") Then
        _endreceipt = Value
        RaisePropertyChanged("endreceipt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the prevtotal value
  ''' </summary>
  <DataMember()> _
  Public Property prevtotal() As Decimal
    Get
      Return _prevtotal
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_prevtotal, Value, "prevtotal") Then
        _prevtotal = Value
        RaisePropertyChanged("prevtotal")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the terminal value
  ''' </summary>
  <DataMember()> _
  Public Property terminal() As Integer
    Get
      Return _terminal
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_terminal, Value, "terminal") Then
        _terminal = Value
        RaisePropertyChanged("terminal")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totvat value
  ''' </summary>
  <DataMember()> _
  Public Property totvat() As Decimal
    Get
      Return _totvat
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totvat, Value, "totvat") Then
        _totvat = Value
        RaisePropertyChanged("totvat")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totnonvat value
  ''' </summary>
  <DataMember()> _
  Public Property totnonvat() As Decimal
    Get
      Return _totnonvat
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totnonvat, Value, "totnonvat") Then
        _totnonvat = Value
        RaisePropertyChanged("totnonvat")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the totzerorated value
  ''' </summary>
  <DataMember()> _
  Public Property totzerorated() As Decimal
    Get
      Return _totzerorated
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_totzerorated, Value, "totzerorated") Then
        _totzerorated = Value
        RaisePropertyChanged("totzerorated")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the sumvat value
  ''' </summary>
  <DataMember()> _
  Public Property sumvat() As Decimal
    Get
      Return _sumvat
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_sumvat, Value, "sumvat") Then
        _sumvat = Value
        RaisePropertyChanged("sumvat")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cntcredits value
  ''' </summary>
  <DataMember()> _
  Public Property cntcredits() As Integer
    Get
      Return _cntcredits
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_cntcredits, Value, "cntcredits") Then
        _cntcredits = Value
        RaisePropertyChanged("cntcredits")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the accutotsale value
  ''' </summary>
  <DataMember()> _
  Public Property accutotsale() As Decimal
    Get
      Return _accutotsale
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_accutotsale, Value, "accutotsale") Then
        _accutotsale = Value
        RaisePropertyChanged("accutotsale")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the readingno value
  ''' </summary>
  <DataMember()> _
  Public Property readingno() As Integer
    Get
      Return _readingno
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_readingno, Value, "readingno") Then
        _readingno = Value
        RaisePropertyChanged("readingno")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the ETwo value
  ''' </summary>
  <DataMember()> _
  Public Property ETwo() As Decimal
    Get
      Return _ETwo
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_ETwo, Value, "ETwo") Then
        _ETwo = Value
        RaisePropertyChanged("ETwo")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the EOneHundred value
  ''' </summary>
  <DataMember()> _
  Public Property EOneHundred() As Decimal
    Get
      Return _EOneHundred
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_EOneHundred, Value, "EOneHundred") Then
        _EOneHundred = Value
        RaisePropertyChanged("EOneHundred")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the EFifty value
  ''' </summary>
  <DataMember()> _
  Public Property EFifty() As Decimal
    Get
      Return _EFifty
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_EFifty, Value, "EFifty") Then
        _EFifty = Value
        RaisePropertyChanged("EFifty")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the ETwenty value
  ''' </summary>
  <DataMember()> _
  Public Property ETwenty() As Decimal
    Get
      Return _ETwenty
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_ETwenty, Value, "ETwenty") Then
        _ETwenty = Value
        RaisePropertyChanged("ETwenty")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the ETen value
  ''' </summary>
  <DataMember()> _
  Public Property ETen() As Decimal
    Get
      Return _ETen
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_ETen, Value, "ETen") Then
        _ETen = Value
        RaisePropertyChanged("ETen")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the EFive value
  ''' </summary>
  <DataMember()> _
  Public Property EFive() As Decimal
    Get
      Return _EFive
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_EFive, Value, "EFive") Then
        _EFive = Value
        RaisePropertyChanged("EFive")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Eone value
  ''' </summary>
  <DataMember()> _
  Public Property Eone() As Decimal
    Get
      Return _Eone
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_Eone, Value, "Eone") Then
        _Eone = Value
        RaisePropertyChanged("Eone")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Ecents value
  ''' </summary>
  <DataMember()> _
  Public Property Ecents() As Decimal
    Get
      Return _Ecents
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_Ecents, Value, "Ecents") Then
        _Ecents = Value
        RaisePropertyChanged("Ecents")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the TotRemit value
  ''' </summary>
  <DataMember()> _
  Public Property TotRemit() As Decimal
    Get
      Return _TotRemit
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_TotRemit, Value, "TotRemit") Then
        _TotRemit = Value
        RaisePropertyChanged("TotRemit")
      End If
    End Set
  End Property
#End Region
End Class
