Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwpostmp
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwpostmpManager
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
  Private _Entity As vwpostmp 
  Private _DataObject As vwpostmpData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwpostmp
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwpostmp)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwpostmpData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwpostmpData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwpostmp()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwpostmpData(DataProvider, Entity)
    End If

    ClassName = "vwpostmpManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwpostmp classes based
  ''' </summary>
  ''' <returns>vwpostmpCollection</returns>
  Public Function BuildCollection() As vwpostmpCollection
    Dim coll As New vwpostmpCollection()
    Dim newEntity As vwpostmp
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

#Region "GetvwpostmpsBybarcodes Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwpostmpsBybarcodes() As vwpostmpCollection
    DataObject.WhereFilter = vwpostmpData.WhereFilters.barcodes

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwpostmpsBybetwin Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwpostmpsBybetwin() As vwpostmpCollection
    DataObject.WhereFilter = vwpostmpData.WhereFilters.betwin

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwpostmpsByLikeItems Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwpostmpsByLikeItems() As vwpostmpCollection
    DataObject.WhereFilter = vwpostmpData.WhereFilters.LikeItems

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwpostmpsByLiketid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwpostmpsByLiketid() As vwpostmpCollection
    DataObject.WhereFilter = vwpostmpData.WhereFilters.Liketid

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwpostmpsBysalesid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwpostmpsBysalesid() As vwpostmpCollection
    DataObject.WhereFilter = vwpostmpData.WhereFilters.salesid

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwpostmpsBytid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwpostmpsBytid() As vwpostmpCollection
    DataObject.WhereFilter = vwpostmpData.WhereFilters.tid

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwpostmp
  ''' </summary>
  ''' <returns>A cloned vwpostmp object</returns>
  Public Function CloneEntity() As vwpostmp
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwpostmp
  ''' </summary>
  ''' <returns>A cloned vwpostmp object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwpostmp) As vwpostmp
    Dim newEntity As New vwpostmp()

    newEntity.postmphdrid = entityToClone.postmphdrid
    newEntity.posdate = entityToClone.posdate
    newEntity.custid = entityToClone.custid
    newEntity.posamnt = entityToClone.posamnt
    newEntity.tendered = entityToClone.tendered
    newEntity.Cheyns = entityToClone.Cheyns
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
    newEntity.qty = entityToClone.qty
    newEntity.barcode = entityToClone.barcode
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.tdesc = entityToClone.tdesc
    newEntity.waiter = entityToClone.waiter
    newEntity.Custnum = entityToClone.Custnum
    newEntity.detamnt = entityToClone.detamnt

    Return newEntity
  End Function
#End Region

End Class
