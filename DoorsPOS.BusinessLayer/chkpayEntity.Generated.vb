Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a chkpay.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class chkpay
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the chkpay class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "chkpay"
  End Sub
#End Region

  #Region "Private Variables"
  Private _chekid As Integer = 0
  Private _chkdate As Date = DateTime.Now
  Private _payee As String = String.Empty
  Private _amnt As Decimal = 0
  Private _chkno As String = String.Empty
  Private _bank As String = String.Empty
  Private _chkremark As String = String.Empty
  Private _cashier As String = String.Empty
  Private _sInsertid As String = String.Empty
  Private _dtInsertdt As Date = DateTime.Now
  Private _sLastUpdateid As String = String.Empty
  Private _dtLastUpdatedt As Date = DateTime.Now
  Private _iConcurrencyid As Short = 0
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the chekid value
  ''' </summary>
  <DataMember()> _
  Public Property chekid() As Integer
    Get
      Return _chekid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_chekid, Value, "chekid") Then
        _chekid = Value
        RaisePropertyChanged("chekid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the chkdate value
  ''' </summary>
  <DataMember()> _
  Public Property chkdate() As Date
    Get
      Return _chkdate
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_chkdate, Value, "chkdate") Then
        _chkdate = Value
        RaisePropertyChanged("chkdate")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the payee value
  ''' </summary>
  <DataMember()> _
  Public Property payee() As String
    Get
      Return _payee
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_payee, Value, "payee") Then
        _payee = Value
        RaisePropertyChanged("payee")
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
  ''' Get/Set the chkno value
  ''' </summary>
  <DataMember()> _
  Public Property chkno() As String
    Get
      Return _chkno
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_chkno, Value, "chkno") Then
        _chkno = Value
        RaisePropertyChanged("chkno")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the bank value
  ''' </summary>
  <DataMember()> _
  Public Property bank() As String
    Get
      Return _bank
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_bank, Value, "bank") Then
        _bank = Value
        RaisePropertyChanged("bank")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the chkremark value
  ''' </summary>
  <DataMember()> _
  Public Property chkremark() As String
    Get
      Return _chkremark
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_chkremark, Value, "chkremark") Then
        _chkremark = Value
        RaisePropertyChanged("chkremark")
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
