Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a convertstck.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class convertstck
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the convertstck class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "convertstck"
  End Sub
#End Region

  #Region "Private Variables"
  Private _convertid As Integer = 0
  Private _condate As Date = DateTime.Now
  Private _fromstckid As Integer = 0
  Private _tostckid As Integer = 0
  Private _fromqty As Integer = 0
  Private _toqty As Integer = 0
  Private _innerqty As Integer = 0
  Private _InsertedBy As String = String.Empty
  Private _InsertedOn As Date = DateTime.Now
  Private _ModifiedBy As String = String.Empty
  Private _ModifiedOn As Date = DateTime.Now
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the convertid value
  ''' </summary>
  <DataMember()> _
  Public Property convertid() As Integer
    Get
      Return _convertid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_convertid, Value, "convertid") Then
        _convertid = Value
        RaisePropertyChanged("convertid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the condate value
  ''' </summary>
  <DataMember()> _
  Public Property condate() As Date
    Get
      Return _condate
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_condate, Value, "condate") Then
        _condate = Value
        RaisePropertyChanged("condate")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the fromstckid value
  ''' </summary>
  <DataMember()> _
  Public Property fromstckid() As Integer
    Get
      Return _fromstckid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_fromstckid, Value, "fromstckid") Then
        _fromstckid = Value
        RaisePropertyChanged("fromstckid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the tostckid value
  ''' </summary>
  <DataMember()> _
  Public Property tostckid() As Integer
    Get
      Return _tostckid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_tostckid, Value, "tostckid") Then
        _tostckid = Value
        RaisePropertyChanged("tostckid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the fromqty value
  ''' </summary>
  <DataMember()> _
  Public Property fromqty() As Integer
    Get
      Return _fromqty
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_fromqty, Value, "fromqty") Then
        _fromqty = Value
        RaisePropertyChanged("fromqty")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the toqty value
  ''' </summary>
  <DataMember()> _
  Public Property toqty() As Integer
    Get
      Return _toqty
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_toqty, Value, "toqty") Then
        _toqty = Value
        RaisePropertyChanged("toqty")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the innerqty value
  ''' </summary>
  <DataMember()> _
  Public Property innerqty() As Integer
    Get
      Return _innerqty
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_innerqty, Value, "innerqty") Then
        _innerqty = Value
        RaisePropertyChanged("innerqty")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the InsertedBy value
  ''' </summary>
  <DataMember()> _
  Public Property InsertedBy() As String
    Get
      Return _InsertedBy
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_InsertedBy, Value, "InsertedBy") Then
        _InsertedBy = Value
        RaisePropertyChanged("InsertedBy")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the InsertedOn value
  ''' </summary>
  <DataMember()> _
  Public Property InsertedOn() As Date
    Get
      Return _InsertedOn
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_InsertedOn, Value, "InsertedOn") Then
        _InsertedOn = Value
        RaisePropertyChanged("InsertedOn")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the ModifiedBy value
  ''' </summary>
  <DataMember()> _
  Public Property ModifiedBy() As String
    Get
      Return _ModifiedBy
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_ModifiedBy, Value, "ModifiedBy") Then
        _ModifiedBy = Value
        RaisePropertyChanged("ModifiedBy")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the ModifiedOn value
  ''' </summary>
  <DataMember()> _
  Public Property ModifiedOn() As Date
    Get
      Return _ModifiedOn
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_ModifiedOn, Value, "ModifiedOn") Then
        _ModifiedOn = Value
        RaisePropertyChanged("ModifiedOn")
      End If
    End Set
  End Property
#End Region
End Class
