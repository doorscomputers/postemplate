Imports System
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses

'Imports DoorsPOS.WinApp

''' <summary>
''' This class is used to call the stored procedure spLowStocks
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class spLowStocksManager
  Inherits PDSAStoredProcExecuteManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region
  
#Region "Constructors"
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.New(dataProvider)

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As spLowStocks
  Private _DataObject As spLowStocksData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This is the class that contains one property for each parameter in the stored procedure.
  ''' Setting this property will also set the Entity class into the DataObject classes too.
  ''' </summary>
  Public Property Entity() As spLowStocks
    Get
      Return _Entity
    End Get
    Set(ByVal value As spLowStocks)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As spLowStocksData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As spLowStocksData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  ''' <summary>
  ''' Initialize this class to a valid start state
  ''' </summary>
  Protected Overrides Sub Init()
    ' Create Entity Class if not Created
    If Entity Is Nothing Then
      Entity = New spLowStocks()
    End If
    
    ' Create Data Class if not Created
    If DataObject Is Nothing Then
      DataObject = New spLowStocksData(DataProvider, Entity)
    End If

    ClassName = "spLowStocksManager"
  End Sub
#End Region
End Class
