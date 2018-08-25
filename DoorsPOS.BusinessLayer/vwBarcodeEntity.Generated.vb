Imports System
Imports System.Runtime.Serialization

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a vwBarcode.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
<DataContract()> _
Partial Public Class vwBarcode
  Inherits PDSAEntityBase

#Region "Constructor"
  Public Sub New()
    ClassName = "vwBarcode"
  End Sub
#End Region

  #Region "Private Variables"
  Private _stckid As Integer = 0
  Private _itemdesc As String = String.Empty
  Private _available As Double = 0
  Private _retail As Decimal = 0
  Private _retail2 As Decimal = 0
  Private _sInsertid As String = String.Empty
  Private _packaging As Double = 0
  Private _barcode As String = String.Empty
#End Region

#Region "Public Properties"
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
  ''' Get/Set the available value
  ''' </summary>
   _
  Public Property available() As Double
    Get
      Return _available
    End Get
    Set(ByVal Value As Double)
      _available = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the retail value
  ''' </summary>
   _
  Public Property retail() As Decimal
    Get
      Return _retail
    End Get
    Set(ByVal Value As Decimal)
      _retail = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the retail2 value
  ''' </summary>
   _
  Public Property retail2() As Decimal
    Get
      Return _retail2
    End Get
    Set(ByVal Value As Decimal)
      _retail2 = Value
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
  ''' Get/Set the packaging value
  ''' </summary>
   _
  Public Property packaging() As Double
    Get
      Return _packaging
    End Get
    Set(ByVal Value As Double)
      _packaging = Value
    End Set
  End Property
  ''' <summary>
  ''' Get/Set the barcode value
  ''' </summary>
   _
  Public Property barcode() As String
    Get
      Return _barcode
    End Get
    Set(ByVal Value As String)
      _barcode = Value
    End Set
  End Property
#End Region
End Class
