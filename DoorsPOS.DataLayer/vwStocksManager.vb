Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwStocks
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwStocksManager
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
  Private _Entity As vwStocks 
  Private _DataObject As vwStocksData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwStocks
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwStocks)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwStocksData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwStocksData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwStocks()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwStocksData(DataProvider, Entity)
    End If

    ClassName = "vwStocksManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwStocks classes based
  ''' </summary>
  ''' <returns>vwStocksCollection</returns>
  Public Function BuildCollection() As vwStocksCollection
    Dim coll As New vwStocksCollection()
    Dim newEntity As vwStocks
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

#Region "GetvwStocksBybarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwStocksBybarcode() As vwStocksCollection
    DataObject.WhereFilter = vwStocksData.WhereFilters.barcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwStocksByLikebarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwStocksByLikebarcode() As vwStocksCollection
    DataObject.WhereFilter = vwStocksData.WhereFilters.Likebarcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwStocksByStakid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwStocksByStakid() As vwStocksCollection
    DataObject.WhereFilter = vwStocksData.WhereFilters.Stakid

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwStocksBylikeitem Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwStocksBylikeitem() As vwStocksCollection
    DataObject.WhereFilter = vwStocksData.WhereFilters.likeitem

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwStocks
  ''' </summary>
  ''' <returns>A cloned vwStocks object</returns>
  Public Function CloneEntity() As vwStocks
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwStocks
  ''' </summary>
  ''' <returns>A cloned vwStocks object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwStocks) As vwStocks
    Dim newEntity As New vwStocks()

    newEntity.stckid = entityToClone.stckid
    newEntity.barcode = entityToClone.barcode
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.available = entityToClone.available
    newEntity.cost = entityToClone.cost
    newEntity.retail = entityToClone.retail
    newEntity.wsale = entityToClone.wsale
    newEntity.retail2 = entityToClone.retail2

    Return newEntity
  End Function
#End Region

End Class
