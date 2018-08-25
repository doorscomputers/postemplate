Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwPos
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwPosManager
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
  Private _Entity As vwPos 
  Private _DataObject As vwPosData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwPos
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwPos)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwPosData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwPosData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwPos()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwPosData(DataProvider, Entity)
    End If

    ClassName = "vwPosManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwPos classes based
  ''' </summary>
  ''' <returns>vwPosCollection</returns>
  Public Function BuildCollection() As vwPosCollection
    Dim coll As New vwPosCollection()
    Dim newEntity As vwPos
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

#Region "GetvwPosBybarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwPosBybarcode() As vwPosCollection
    DataObject.WhereFilter = vwPosData.WhereFilters.barcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwPosByLikebarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwPosByLikebarcode() As vwPosCollection
    DataObject.WhereFilter = vwPosData.WhereFilters.Likebarcode

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwPos
  ''' </summary>
  ''' <returns>A cloned vwPos object</returns>
  Public Function CloneEntity() As vwPos
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwPos
  ''' </summary>
  ''' <returns>A cloned vwPos object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwPos) As vwPos
    Dim newEntity As New vwPos()

    newEntity.barcode = entityToClone.barcode
    newEntity.Items = entityToClone.Items
    newEntity.stckid = entityToClone.stckid
    newEntity.cost = entityToClone.cost
    newEntity.qty = entityToClone.qty
    newEntity.price = entityToClone.price
    newEntity.detamnt = entityToClone.detamnt
    newEntity.tdesc = entityToClone.tdesc
    newEntity.waiter = entityToClone.waiter
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
    newEntity.Expr2 = entityToClone.Expr2
    newEntity.wtid = entityToClone.wtid

    Return newEntity
  End Function
#End Region

End Class
