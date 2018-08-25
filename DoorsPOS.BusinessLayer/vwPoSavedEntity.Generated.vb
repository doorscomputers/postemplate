Imports System
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a vwPoSaved.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class vwPoSaved
  Inherits PDSAEntityBase

#Region "Constructor"
  Public Sub New()
    ClassName = "vwPoSaved"
  End Sub
#End Region

  #Region "Private Variables"
  Private _poidtmp As Integer = 0
  Private _podate As Date = DateTime.Now
  Private _supcode As Integer = 0
  Private _sInsertid As String = String.Empty
  Private _dlivered As Boolean? = False
  Private _supplier As String = String.Empty
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the poidtmp value
  ''' </summary>
   _
  Public Property poidtmp() As Integer
    Get
      Return _poidtmp
    End Get
    Set(ByVal Value As Integer)
      _poidtmp = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the podate value
  ''' </summary>
   _
  Public Property podate() As Date
    Get
      Return _podate
    End Get
    Set(ByVal Value As Date)
      _podate = Value
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
  ''' Get/Set the dlivered value
  ''' </summary>
   _
  Public Property dlivered() As Boolean?
    Get
      Return _dlivered
    End Get
    Set(ByVal Value As Boolean?)
      _dlivered = Value
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
#End Region
End Class