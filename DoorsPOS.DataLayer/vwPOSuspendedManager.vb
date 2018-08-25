Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwPOSuspended
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwPOSuspendedManager
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
  Private _Entity As vwPOSuspended 
  Private _DataObject As vwPOSuspendedData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwPOSuspended
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwPOSuspended)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwPOSuspendedData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwPOSuspendedData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwPOSuspended()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwPOSuspendedData(DataProvider, Entity)
    End If

    ClassName = "vwPOSuspendedManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwPOSuspended classes based
  ''' </summary>
  ''' <returns>vwPOSuspendedCollection</returns>
  Public Function BuildCollection() As vwPOSuspendedCollection
    Dim coll As New vwPOSuspendedCollection()
    Dim newEntity As vwPOSuspended
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

#Region "GetvwPOSuspendedsBypoinv Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwPOSuspendedsBypoinv() As vwPOSuspendedCollection
    DataObject.WhereFilter = vwPOSuspendedData.WhereFilters.poinv

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwPOSuspendedsByLikepoinv Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwPOSuspendedsByLikepoinv() As vwPOSuspendedCollection
    DataObject.WhereFilter = vwPOSuspendedData.WhereFilters.Likepoinv

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwPOSuspendedsBypoid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwPOSuspendedsBypoid() As vwPOSuspendedCollection
    DataObject.WhereFilter = vwPOSuspendedData.WhereFilters.poid

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwPOSuspended
  ''' </summary>
  ''' <returns>A cloned vwPOSuspended object</returns>
  Public Function CloneEntity() As vwPOSuspended
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwPOSuspended
  ''' </summary>
  ''' <returns>A cloned vwPOSuspended object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwPOSuspended) As vwPOSuspended
    Dim newEntity As New vwPOSuspended()

    newEntity.poidtmp = entityToClone.poidtmp
    newEntity.podate = entityToClone.podate
    newEntity.supcode = entityToClone.supcode
    newEntity.poinv = entityToClone.poinv
    newEntity.stckid = entityToClone.stckid
    newEntity.cost = entityToClone.cost
    newEntity.qty = entityToClone.qty
    newEntity.podetamnt = entityToClone.podetamnt
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.supplier = entityToClone.supplier

    Return newEntity
  End Function
#End Region

End Class
