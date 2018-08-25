Imports System
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a vwDlvry.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class vwDlvry
  Inherits PDSAEntityBase

#Region "Constructor"
  Public Sub New()
    ClassName = "vwDlvry"
  End Sub
#End Region

  #Region "Private Variables"
  Private _drinv As String = String.Empty
  Private _drdate As Date = DateTime.Now
  Private _supcode As Integer = 0
  Private _supplier As String = String.Empty
  Private _paid As Boolean? = False
  Private _drbal As Decimal = 0
  Private _sInsertid As String = String.Empty
  Private _drid As Integer = 0
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the drinv value
  ''' </summary>
   _
  Public Property drinv() As String
    Get
      Return _drinv
    End Get
    Set(ByVal Value As String)
      _drinv = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the drdate value
  ''' </summary>
   _
  Public Property drdate() As Date
    Get
      Return _drdate
    End Get
    Set(ByVal Value As Date)
      _drdate = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the supcode value
  ''' </summary>
   _
  Public Property supcode() As Integer
    Get
      Return _supcode
    End Get
    Set(ByVal Value As Integer)
      _supcode = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the supplier value
  ''' </summary>
   _
  Public Property supplier() As String
    Get
      Return _supplier
    End Get
    Set(ByVal Value As String)
      _supplier = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the paid value
  ''' </summary>
   _
  Public Property paid() As Boolean?
    Get
      Return _paid
    End Get
    Set(ByVal Value As Boolean?)
      _paid = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the drbal value
  ''' </summary>
   _
  Public Property drbal() As Decimal
    Get
      Return _drbal
    End Get
    Set(ByVal Value As Decimal)
      _drbal = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the sInsertid value
  ''' </summary>
   _
  Public Property sInsertid() As String
    Get
      Return _sInsertid
    End Get
    Set(ByVal Value As String)
      _sInsertid = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the drid value
  ''' </summary>
   _
  Public Property drid() As Integer
    Get
      Return _drid
    End Get
    Set(ByVal Value As Integer)
      _drid = Value
    End Set
  End Property
#End Region
End Class