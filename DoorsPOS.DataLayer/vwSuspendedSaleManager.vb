Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwSuspendedSale
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwSuspendedSaleManager
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
  Private _Entity As vwSuspendedSale 
  Private _DataObject As vwSuspendedSaleData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwSuspendedSale
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwSuspendedSale)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwSuspendedSaleData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwSuspendedSaleData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwSuspendedSale()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwSuspendedSaleData(DataProvider, Entity)
    End If

    ClassName = "vwSuspendedSaleManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwSuspendedSale classes based
  ''' </summary>
  ''' <returns>vwSuspendedSaleCollection</returns>
  Public Function BuildCollection() As vwSuspendedSaleCollection
    Dim coll As New vwSuspendedSaleCollection()
    Dim newEntity As vwSuspendedSale
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

#Region "GetvwSuspendedSalesBycashstatus Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendedSalesBycashstatus() As vwSuspendedSaleCollection
    DataObject.WhereFilter = vwSuspendedSaleData.WhereFilters.cashstatus

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendedSalesByhdrid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendedSalesByhdrid() As vwSuspendedSaleCollection
    DataObject.WhereFilter = vwSuspendedSaleData.WhereFilters.hdrid

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendedSalesByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendedSalesByLikesInsert_id() As vwSuspendedSaleCollection
    DataObject.WhereFilter = vwSuspendedSaleData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendedSalesBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendedSalesBysInsert_id() As vwSuspendedSaleCollection
    DataObject.WhereFilter = vwSuspendedSaleData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwSuspendedSale
  ''' </summary>
  ''' <returns>A cloned vwSuspendedSale object</returns>
  Public Function CloneEntity() As vwSuspendedSale
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwSuspendedSale
  ''' </summary>
  ''' <returns>A cloned vwSuspendedSale object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwSuspendedSale) As vwSuspendedSale
    Dim newEntity As New vwSuspendedSale()

    newEntity.postmphdrid = entityToClone.postmphdrid
    newEntity.posdate = entityToClone.posdate
    newEntity.custid = entityToClone.custid
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.stckid = entityToClone.stckid
    newEntity.barcode = entityToClone.barcode
    newEntity.cost = entityToClone.cost
    newEntity.price = entityToClone.price
    newEntity.detamnt = entityToClone.detamnt
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.status = entityToClone.status
    newEntity.qty = entityToClone.qty

    Return newEntity
  End Function
#End Region

End Class
