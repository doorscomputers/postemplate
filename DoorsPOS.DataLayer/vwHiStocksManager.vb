Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwHiStocks
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwHiStocksManager
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
  Private _Entity As vwHiStocks 
  Private _DataObject As vwHiStocksData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwHiStocks
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwHiStocks)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwHiStocksData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwHiStocksData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwHiStocks()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwHiStocksData(DataProvider, Entity)
    End If

    ClassName = "vwHiStocksManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwHiStocks classes based
  ''' </summary>
  ''' <returns>vwHiStocksCollection</returns>
  Public Function BuildCollection() As vwHiStocksCollection
    Dim coll As New vwHiStocksCollection()
    Dim newEntity As vwHiStocks
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

#Region "GetvwHiStocksByitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwHiStocksByitem_desc() As vwHiStocksCollection
    DataObject.WhereFilter = vwHiStocksData.WhereFilters.item_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwHiStocksByLikeitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwHiStocksByLikeitem_desc() As vwHiStocksCollection
    DataObject.WhereFilter = vwHiStocksData.WhereFilters.Likeitem_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwHiStocksByHiStock Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwHiStocksByHiStock() As vwHiStocksCollection
    DataObject.WhereFilter = vwHiStocksData.WhereFilters.HiStock

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwHiStocks
  ''' </summary>
  ''' <returns>A cloned vwHiStocks object</returns>
  Public Function CloneEntity() As vwHiStocks
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwHiStocks
  ''' </summary>
  ''' <returns>A cloned vwHiStocks object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwHiStocks) As vwHiStocks
    Dim newEntity As New vwHiStocks()

    newEntity.stckid = entityToClone.stckid
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.available = entityToClone.available
    newEntity.maximum = entityToClone.maximum

    Return newEntity
  End Function
#End Region

End Class
