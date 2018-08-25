Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwLowStocks
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwLowStocksManager
  Inherits PDSADataClassManagerReadOnlyBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  Public Sub New()
    Init()
  End Sub

  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As vwLowStocks 
  Private _DataObject As vwLowStocksData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwLowStocks
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwLowStocks)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwLowStocksData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwLowStocksData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwLowStocks()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwLowStocksData(DataProvider, Entity)
    End If

    ClassName = "vwLowStocksManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwLowStocks classes based
  ''' </summary>
  ''' <returns>vwLowStocksCollection</returns>
  Public Function BuildCollection() As vwLowStocksCollection
    Dim coll As New vwLowStocksCollection()
    Dim newEntity As vwLowStocks
    Dim ds As DataSet

    DataObject.Entity = Entity
    ds = DataObject.GetDataSet()

    If ds.Tables.Count > 0 Then
      For Each dr As DataRow In ds.Tables(ds.Tables.Count - 1).Rows
        newEntity = DataObject.CreateEntityFromDataRow(dr)
        
        ' You can set any additional properties here
        
        coll.Add(newEntity)
      Next
    End If

    Return coll
  End Function
#End Region

#Region "GetvwLowStocksByitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwLowStocksByitem_desc() As vwLowStocksCollection
    DataObject.WhereFilter = vwLowStocksData.WhereFilters.item_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwLowStocksByLikeitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwLowStocksByLikeitem_desc() As vwLowStocksCollection
    DataObject.WhereFilter = vwLowStocksData.WhereFilters.Likeitem_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwLowStocksByLoStock Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwLowStocksByLoStock() As vwLowStocksCollection
    DataObject.WhereFilter = vwLowStocksData.WhereFilters.LoStock

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwLowStocks
  ''' </summary>
  ''' <returns>A cloned vwLowStocks object</returns>
  Public Function CloneEntity() As vwLowStocks
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwLowStocks
  ''' </summary>
  ''' <returns>A cloned vwLowStocks object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwLowStocks) As vwLowStocks
    Dim newEntity As New vwLowStocks()

    newEntity.stckid = entityToClone.stckid
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.available = entityToClone.available
    newEntity.minimum = entityToClone.minimum

    Return newEntity
  End Function
#End Region

End Class
