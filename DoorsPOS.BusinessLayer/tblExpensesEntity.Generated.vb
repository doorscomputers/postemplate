Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a tblExpenses.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class tblExpenses
  Inherits PDSAEntityBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the tblExpenses class
  ''' </summary>
  Public Sub New()
    MyBase.New()
    
    ClassName = "tblExpenses"
  End Sub
#End Region

  #Region "Private Variables"
  Private _expenseid As Integer = 0
  Private _expdesc As String = String.Empty
  Private _sinsertid As String = String.Empty
  Private _sinsertdt As Date = DateTime.Now
  Private _modifiedby As String = String.Empty
  Private _modifiedon As Date = DateTime.Now
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the expenseid value
  ''' </summary>
  <DataMember()> _
  Public Property expenseid() As Integer
    Get
      Return _expenseid
    End Get
    Set(ByVal Value As Integer)
      If HasValueChanged(_expenseid, Value, "expenseid") Then
        _expenseid = Value
        RaisePropertyChanged("expenseid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the expdesc value
  ''' </summary>
  <DataMember()> _
  Public Property expdesc() As String
    Get
      Return _expdesc
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_expdesc, Value, "expdesc") Then
        _expdesc = Value
        RaisePropertyChanged("expdesc")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the sinsertid value
  ''' </summary>
  <DataMember()> _
  Public Property sinsertid() As String
    Get
      Return _sinsertid
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_sinsertid, Value, "sinsertid") Then
        _sinsertid = Value
        RaisePropertyChanged("sinsertid")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the sinsertdt value
  ''' </summary>
  <DataMember()> _
  Public Property sinsertdt() As Date
    Get
      Return _sinsertdt
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_sinsertdt, Value, "sinsert_dt") Then
        _sinsertdt = Value
        RaisePropertyChanged("sinsertdt")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the modifiedby value
  ''' </summary>
  <DataMember()> _
  Public Property modifiedby() As String
    Get
      Return _modifiedby
    End Get
    Set(ByVal Value As String)
      If HasValueChanged(_modifiedby, Value, "modified_by") Then
        _modifiedby = Value
        RaisePropertyChanged("modifiedby")
      End If
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the modifiedon value
  ''' </summary>
  <DataMember()> _
  Public Property modifiedon() As Date
    Get
      Return _modifiedon
    End Get
    Set(ByVal Value As Date)
      If HasValueChanged(_modifiedon, Value, "modified_on") Then
        _modifiedon = Value
        RaisePropertyChanged("modifiedon")
      End If
    End Set
  End Property
#End Region
End Class
