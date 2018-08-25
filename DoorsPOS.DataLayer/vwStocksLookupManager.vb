Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwStocksLookup
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwStocksLookupManager
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
  Private _Entity As vwStocksLookup 
  Private _DataObject As vwStocksLookupData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwStocksLookup
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwStocksLookup)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwStocksLookupData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwStocksLookupData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwStocksLookup()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwStocksLookupData(DataProvider, Entity)
    End If

    ClassName = "vwStocksLookupManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwStocksLookup classes based
  ''' </summary>
  ''' <returns>vwStocksLookupCollection</returns>
  Public Function BuildCollection() As vwStocksLookupCollection
    Dim coll As New vwStocksLookupCollection()
    Dim newEntity As vwStocksLookup
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

#Region "GetvwStocksLookupsBybarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwStocksLookupsBybarcode() As vwStocksLookupCollection
    DataObject.WhereFilter = vwStocksLookupData.WhereFilters.barcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwStocksLookupsByLikebarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwStocksLookupsByLikebarcode() As vwStocksLookupCollection
    DataObject.WhereFilter = vwStocksLookupData.WhereFilters.Likebarcode

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwStocksLookup
  ''' </summary>
  ''' <returns>A cloned vwStocksLookup object</returns>
  Public Function CloneEntity() As vwStocksLookup
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwStocksLookup
  ''' </summary>
  ''' <returns>A cloned vwStocksLookup object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwStocksLookup) As vwStocksLookup
    Dim newEntity As New vwStocksLookup()

    newEntity.barcode = entityToClone.barcode
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.available = entityToClone.available
    newEntity.retail = entityToClone.retail
    newEntity.retail2 = entityToClone.retail2

    Return newEntity
  End Function
#End Region

End Class
