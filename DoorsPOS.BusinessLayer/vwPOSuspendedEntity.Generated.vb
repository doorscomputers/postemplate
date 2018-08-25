Imports System
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a vwPOSuspended.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class vwPOSuspended
  Inherits PDSAEntityBase

#Region "Constructor"
  Public Sub New()
    ClassName = "vwPOSuspended"
  End Sub
#End Region

  #Region "Private Variables"
  Private _poidtmp As Integer = 0
  Private _podate As Date = DateTime.Now
  Private _supcode As Integer = 0
  Private _poinv As String = String.Empty
  Private _stckid As Integer = 0
  Private _cost As Decimal = 0
  Private _qty As Integer = 0
  Private _podetamnt As Decimal = 0
  Private _itemdesc As String = String.Empty
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
  ''' Get/Set the poinv value
  ''' </summary>
   _
  Public Property poinv() As String
    Get
      Return _poinv
    End Get
    Set(ByVal Value As String)
      _poinv = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the stckid value
  ''' </summary>
   _
  Public Property stckid() As Integer
    Get
      Return _stckid
    End Get
    Set(ByVal Value As Integer)
      _stckid = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the cost value
  ''' </summary>
   _
  Public Property cost() As Decimal
    Get
      Return _cost
    End Get
    Set(ByVal Value As Decimal)
      _cost = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the qty value
  ''' </summary>
   _
  Public Property qty() As Integer
    Get
      Return _qty
    End Get
    Set(ByVal Value As Integer)
      _qty = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the podetamnt value
  ''' </summary>
   _
  Public Property podetamnt() As Decimal
    Get
      Return _podetamnt
    End Get
    Set(ByVal Value As Decimal)
      _podetamnt = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the itemdesc value
  ''' </summary>
   _
  Public Property itemdesc() As String
    Get
      Return _itemdesc
    End Get
    Set(ByVal Value As String)
      _itemdesc = Value
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
