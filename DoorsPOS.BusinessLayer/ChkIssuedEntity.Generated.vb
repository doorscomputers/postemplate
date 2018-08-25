Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a ChkIssued.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class ChkIssued
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the ChkIssued class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "ChkIssued"
  End Sub
#End Region

  #Region "Private Variables"
  Private _chkisueid As Integer = 0
  Private _Trandate As Date = DateTime.Now
  Private _bankid As Integer = 0
  Private _Payee As String = String.Empty
  Private _Chkdate As Date = DateTime.Now
  Private _Chkno As String = String.Empty
  Private _ChkAmnt As Decimal = 0
  Private _AmountWords As String = String.Empty
  Private _Cleared As Boolean? = False
  Private _DateClrd As Date = DateTime.Now
  Private _Cancelled As Boolean? = False
  Private _Remarks As String = String.Empty
  Private _Invoice As String = String.Empty
  Private _sInsertid As String = String.Empty
  Private _dtInsertdt As Date = DateTime.Now
  Private _sLastUpdatedt As Date = DateTime.Now
  Private _sLastUpdateid As String = String.Empty
  Private _iConcurrencyid As Short = 0
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the chkisueid value
  ''' </summary>
  <DataMember()> _
  Public Property chkisueid() As Integer
    Get
      Return _chkisueid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_chkisueid, Value, "chkisueid") Then
        _chkisueid = Value
        RaisePropertyChanged("chkisueid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Trandate value
  ''' </summary>
  <DataMember()> _
  Public Property Trandate() As Date
    Get
      Return _Trandate
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_Trandate, Value, "Trandate") Then
        _Trandate = Value
        RaisePropertyChanged("Trandate")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the bankid value
  ''' </summary>
  <DataMember()> _
  Public Property bankid() As Integer
    Get
      Return _bankid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_bankid, Value, "bankid") Then
        _bankid = Value
        RaisePropertyChanged("bankid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Payee value
  ''' </summary>
  <DataMember()> _
  Public Property Payee() As String
    Get
      Return _Payee
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_Payee, Value, "Payee") Then
        _Payee = Value
        RaisePropertyChanged("Payee")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Chkdate value
  ''' </summary>
  <DataMember()> _
  Public Property Chkdate() As Date
    Get
      Return _Chkdate
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_Chkdate, Value, "Chkdate") Then
        _Chkdate = Value
        RaisePropertyChanged("Chkdate")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Chkno value
  ''' </summary>
  <DataMember()> _
  Public Property Chkno() As String
    Get
      Return _Chkno
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_Chkno, Value, "Chkno") Then
        _Chkno = Value
        RaisePropertyChanged("Chkno")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the ChkAmnt value
  ''' </summary>
  <DataMember()> _
  Public Property ChkAmnt() As Decimal
    Get
      Return _ChkAmnt
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_ChkAmnt, Value, "ChkAmnt") Then
        _ChkAmnt = Value
        RaisePropertyChanged("ChkAmnt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the AmountWords value
  ''' </summary>
  <DataMember()> _
  Public Property AmountWords() As String
    Get
      Return _AmountWords
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_AmountWords, Value, "AmountWords") Then
        _AmountWords = Value
        RaisePropertyChanged("AmountWords")
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
  ''' Get/Set the DateClrd value
  ''' </summary>
  <DataMember()> _
  Public Property DateClrd() As Date
    Get
      Return _DateClrd
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_DateClrd, Value, "DateClrd") Then
        _DateClrd = Value
        RaisePropertyChanged("DateClrd")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Cancelled value
  ''' </summary>
  <DataMember()> _
  Public Property Cancelled() As Boolean?
    Get
      Return _Cancelled
    End Get
    Set(ByVal Value As Boolean?)
      If HasValueChanged(_Cancelled, Value, "Cancelled") Then
        _Cancelled = Value
        RaisePropertyChanged("Cancelled")
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
  ''' Get/Set the Invoice value
  ''' </summary>
  <DataMember()> _
  Public Property Invoice() As String
    Get
      Return _Invoice
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_Invoice, Value, "Invoice") Then
        _Invoice = Value
        RaisePropertyChanged("Invoice")
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
  ''' Get/Set the sLastUpdatedt value
  ''' </summary>
  <DataMember()> _
  Public Property sLastUpdatedt() As Date
    Get
      Return _sLastUpdatedt
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_sLastUpdatedt, Value, "sLastUpdate_dt") Then
        _sLastUpdatedt = Value
        RaisePropertyChanged("sLastUpdatedt")
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