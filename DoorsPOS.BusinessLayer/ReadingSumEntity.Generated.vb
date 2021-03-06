Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a ReadingSum.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class ReadingSum
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the ReadingSum class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "ReadingSum"
  End Sub
#End Region

  #Region "Private Variables"
  Private _ReadingId As Integer = 0
  Private _ReadingDate As Date = DateTime.Now
  Private _Location As String = String.Empty
  Private _Cashier As String = String.Empty
  Private _TotalSales As Decimal = 0
  Private _BegCash As Decimal = 0
  Private _CashEnd As Decimal = 0
  Private _xShort As Decimal = 0
  Private _OverAmount As Decimal = 0
  Private _Remittance As Decimal = 0
  Private _AddFund As Decimal = 0
  Private _PettyCash As Decimal = 0
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the ReadingId value
  ''' </summary>
  <DataMember()> _
  Public Property ReadingId() As Integer
    Get
      Return _ReadingId
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_ReadingId, Value, "ReadingId") Then
        _ReadingId = Value
        RaisePropertyChanged("ReadingId")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the ReadingDate value
  ''' </summary>
  <DataMember()> _
  Public Property ReadingDate() As Date
    Get
      Return _ReadingDate
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_ReadingDate, Value, "ReadingDate") Then
        _ReadingDate = Value
        RaisePropertyChanged("ReadingDate")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Location value
  ''' </summary>
  <DataMember()> _
  Public Property Location() As String
    Get
      Return _Location
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_Location, Value, "Location") Then
        _Location = Value
        RaisePropertyChanged("Location")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Cashier value
  ''' </summary>
  <DataMember()> _
  Public Property Cashier() As String
    Get
      Return _Cashier
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_Cashier, Value, "Cashier") Then
        _Cashier = Value
        RaisePropertyChanged("Cashier")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the TotalSales value
  ''' </summary>
  <DataMember()> _
  Public Property TotalSales() As Decimal
    Get
      Return _TotalSales
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_TotalSales, Value, "TotalSales") Then
        _TotalSales = Value
        RaisePropertyChanged("TotalSales")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the BegCash value
  ''' </summary>
  <DataMember()> _
  Public Property BegCash() As Decimal
    Get
      Return _BegCash
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_BegCash, Value, "BegCash") Then
        _BegCash = Value
        RaisePropertyChanged("BegCash")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the CashEnd value
  ''' </summary>
  <DataMember()> _
  Public Property CashEnd() As Decimal
    Get
      Return _CashEnd
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_CashEnd, Value, "CashEnd") Then
        _CashEnd = Value
        RaisePropertyChanged("CashEnd")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the xShort value
  ''' </summary>
  <DataMember()> _
  Public Property xShort() As Decimal
    Get
      Return _xShort
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_xShort, Value, "Short") Then
        _xShort = Value
        RaisePropertyChanged("xShort")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the OverAmount value
  ''' </summary>
  <DataMember()> _
  Public Property OverAmount() As Decimal
    Get
      Return _OverAmount
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_OverAmount, Value, "OverAmount") Then
        _OverAmount = Value
        RaisePropertyChanged("OverAmount")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the Remittance value
  ''' </summary>
  <DataMember()> _
  Public Property Remittance() As Decimal
    Get
      Return _Remittance
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_Remittance, Value, "Remittance") Then
        _Remittance = Value
        RaisePropertyChanged("Remittance")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the AddFund value
  ''' </summary>
  <DataMember()> _
  Public Property AddFund() As Decimal
    Get
      Return _AddFund
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_AddFund, Value, "AddFund") Then
        _AddFund = Value
        RaisePropertyChanged("AddFund")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the PettyCash value
  ''' </summary>
  <DataMember()> _
  Public Property PettyCash() As Decimal
    Get
      Return _PettyCash
    End Get
    Set(ByVal Value As Decimal)
      If HasValueChanged(_PettyCash, Value, "PettyCash") Then
        _PettyCash = Value
        RaisePropertyChanged("PettyCash")
      End If
    End Set
  End Property
#End Region
End Class
