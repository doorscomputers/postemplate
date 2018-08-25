Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwReceipt
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwReceiptManager
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
  Private _Entity As vwReceipt 
  Private _DataObject As vwReceiptData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwReceipt
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwReceipt)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwReceiptData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwReceiptData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwReceipt()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwReceiptData(DataProvider, Entity)
    End If

    ClassName = "vwReceiptManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwReceipt classes based
  ''' </summary>
  ''' <returns>vwReceiptCollection</returns>
  Public Function BuildCollection() As vwReceiptCollection
    Dim coll As New vwReceiptCollection()
    Dim newEntity As vwReceipt
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

#Region "GetvwReceiptsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwReceiptsBysInsert_id() As vwReceiptCollection
    DataObject.WhereFilter = vwReceiptData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwReceiptsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwReceiptsByLikesInsert_id() As vwReceiptCollection
    DataObject.WhereFilter = vwReceiptData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwReceipt
  ''' </summary>
  ''' <returns>A cloned vwReceipt object</returns>
  Public Function CloneEntity() As vwReceipt
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwReceipt
  ''' </summary>
  ''' <returns>A cloned vwReceipt object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwReceipt) As vwReceipt
    Dim newEntity As New vwReceipt()

    newEntity.postmphdrid = entityToClone.postmphdrid
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.posdate = entityToClone.posdate
    newEntity.discamnt = entityToClone.discamnt
    newEntity.postme = entityToClone.postme
    newEntity.custid = entityToClone.custid
    newEntity.posamnt = entityToClone.posamnt
    newEntity.tendered = entityToClone.tendered
    newEntity.Cheyns = entityToClone.Cheyns
    newEntity.mowd = entityToClone.mowd
    newEntity.Sc = entityToClone.Sc
    newEntity.totsales = entityToClone.totsales
    newEntity.lessvat = entityToClone.lessvat
    newEntity.nov = entityToClone.nov
    newEntity.lesssc = entityToClone.lesssc
    newEntity.vatable = entityToClone.vatable
    newEntity.exempt = entityToClone.exempt
    newEntity.vatamnt = entityToClone.vatamnt
    newEntity.tid = entityToClone.tid
    newEntity.wtid = entityToClone.wtid
    newEntity.stckid = entityToClone.stckid
    newEntity.cost = entityToClone.cost
    newEntity.price = entityToClone.price
    newEntity.detamnt = entityToClone.detamnt
    newEntity.qty = entityToClone.qty
    newEntity.barcode = entityToClone.barcode
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.lastname = entityToClone.lastname
    newEntity.firstname = entityToClone.firstname
    newEntity.incentiv = entityToClone.incentiv
    newEntity.active = entityToClone.active
    newEntity.subtot = entityToClone.subtot
    newEntity.paidamnt = entityToClone.paidamnt
    newEntity.idnum = entityToClone.idnum
    newEntity.Receipt = entityToClone.Receipt

    Return newEntity
  End Function
#End Region

End Class
