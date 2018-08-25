Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwSuspended
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwSuspendedManager
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
  Private _Entity As vwSuspended 
  Private _DataObject As vwSuspendedData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwSuspended
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwSuspended)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwSuspendedData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwSuspendedData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwSuspended()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwSuspendedData(DataProvider, Entity)
    End If

    ClassName = "vwSuspendedManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwSuspended classes based
  ''' </summary>
  ''' <returns>vwSuspendedCollection</returns>
  Public Function BuildCollection() As vwSuspendedCollection
    Dim coll As New vwSuspendedCollection()
    Dim newEntity As vwSuspended
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

#Region "GetvwSuspendedsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendedsByLikesInsert_id() As vwSuspendedCollection
    DataObject.WhereFilter = vwSuspendedData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendedsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendedsBysInsert_id() As vwSuspendedCollection
    DataObject.WhereFilter = vwSuspendedData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendedsBySuspendId Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendedsBySuspendId() As vwSuspendedCollection
    DataObject.WhereFilter = vwSuspendedData.WhereFilters.SuspendId

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwSuspended
  ''' </summary>
  ''' <returns>A cloned vwSuspended object</returns>
  Public Function CloneEntity() As vwSuspended
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwSuspended
  ''' </summary>
  ''' <returns>A cloned vwSuspended object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwSuspended) As vwSuspended
    Dim newEntity As New vwSuspended()

    newEntity.postmphdrid = entityToClone.postmphdrid
    newEntity.posdate = entityToClone.posdate
    newEntity.custid = entityToClone.custid
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.stckid = entityToClone.stckid
    newEntity.barcode = entityToClone.barcode
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.cost = entityToClone.cost
    newEntity.price = entityToClone.price
    newEntity.detamnt = entityToClone.detamnt
    newEntity.qty = entityToClone.qty
    newEntity.lastname = entityToClone.lastname
    newEntity.firstname = entityToClone.firstname
    newEntity.detdisc = entityToClone.detdisc
    newEntity.incentiv = entityToClone.incentiv

    Return newEntity
  End Function
#End Region

End Class
