Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwBarcodeMore
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwBarcodeMoreManager
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
  Private _Entity As vwBarcodeMore 
  Private _DataObject As vwBarcodeMoreData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwBarcodeMore
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwBarcodeMore)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwBarcodeMoreData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwBarcodeMoreData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwBarcodeMore()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwBarcodeMoreData(DataProvider, Entity)
    End If

    ClassName = "vwBarcodeMoreManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwBarcodeMore classes based
  ''' </summary>
  ''' <returns>vwBarcodeMoreCollection</returns>
  Public Function BuildCollection() As vwBarcodeMoreCollection
    Dim coll As New vwBarcodeMoreCollection()
    Dim newEntity As vwBarcodeMore
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

#Region "GetvwBarcodeMoresBybarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwBarcodeMoresBybarcode() As vwBarcodeMoreCollection
    DataObject.WhereFilter = vwBarcodeMoreData.WhereFilters.barcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwBarcodeMoresByitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwBarcodeMoresByitem_desc() As vwBarcodeMoreCollection
    DataObject.WhereFilter = vwBarcodeMoreData.WhereFilters.item_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwBarcodeMoresByLikeitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwBarcodeMoresByLikeitem_desc() As vwBarcodeMoreCollection
    DataObject.WhereFilter = vwBarcodeMoreData.WhereFilters.Likeitem_desc

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwBarcodeMore
  ''' </summary>
  ''' <returns>A cloned vwBarcodeMore object</returns>
  Public Function CloneEntity() As vwBarcodeMore
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwBarcodeMore
  ''' </summary>
  ''' <returns>A cloned vwBarcodeMore object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwBarcodeMore) As vwBarcodeMore
    Dim newEntity As New vwBarcodeMore()

    newEntity.stckid = entityToClone.stckid
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.available = entityToClone.available
    newEntity.retail = entityToClone.retail
    newEntity.retail2 = entityToClone.retail2
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.packaging = entityToClone.packaging
    newEntity.barcode = entityToClone.barcode

    Return newEntity
  End Function
#End Region

End Class
