Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwBarcode
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwBarcodeManager
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
  Private _Entity As vwBarcode 
  Private _DataObject As vwBarcodeData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwBarcode
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwBarcode)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwBarcodeData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwBarcodeData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwBarcode()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwBarcodeData(DataProvider, Entity)
    End If

    ClassName = "vwBarcodeManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwBarcode classes based
  ''' </summary>
  ''' <returns>vwBarcodeCollection</returns>
  Public Function BuildCollection() As vwBarcodeCollection
    Dim coll As New vwBarcodeCollection()
    Dim newEntity As vwBarcode
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

#Region "GetvwBarcodesByitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwBarcodesByitem_desc() As vwBarcodeCollection
    DataObject.WhereFilter = vwBarcodeData.WhereFilters.item_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwBarcodesByLikeitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwBarcodesByLikeitem_desc() As vwBarcodeCollection
    DataObject.WhereFilter = vwBarcodeData.WhereFilters.Likeitem_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwBarcodesBybarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwBarcodesBybarcode() As vwBarcodeCollection
    DataObject.WhereFilter = vwBarcodeData.WhereFilters.barcode

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwBarcode
  ''' </summary>
  ''' <returns>A cloned vwBarcode object</returns>
  Public Function CloneEntity() As vwBarcode
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwBarcode
  ''' </summary>
  ''' <returns>A cloned vwBarcode object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwBarcode) As vwBarcode
    Dim newEntity As New vwBarcode()

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
