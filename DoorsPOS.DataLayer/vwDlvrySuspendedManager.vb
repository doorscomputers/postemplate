Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwDlvrySuspended
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwDlvrySuspendedManager
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
  Private _Entity As vwDlvrySuspended 
  Private _DataObject As vwDlvrySuspendedData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwDlvrySuspended
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwDlvrySuspended)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwDlvrySuspendedData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwDlvrySuspendedData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwDlvrySuspended()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwDlvrySuspendedData(DataProvider, Entity)
    End If

    ClassName = "vwDlvrySuspendedManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwDlvrySuspended classes based
  ''' </summary>
  ''' <returns>vwDlvrySuspendedCollection</returns>
  Public Function BuildCollection() As vwDlvrySuspendedCollection
    Dim coll As New vwDlvrySuspendedCollection()
    Dim newEntity As vwDlvrySuspended
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

#Region "GetvwDlvrySuspendedsByDrKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwDlvrySuspendedsByDrKey() As vwDlvrySuspendedCollection
    DataObject.WhereFilter = vwDlvrySuspendedData.WhereFilters.DrKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwDlvrySuspendedsByLikesupplier Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwDlvrySuspendedsByLikesupplier() As vwDlvrySuspendedCollection
    DataObject.WhereFilter = vwDlvrySuspendedData.WhereFilters.Likesupplier

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwDlvrySuspendedsBysupplier Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwDlvrySuspendedsBysupplier() As vwDlvrySuspendedCollection
    DataObject.WhereFilter = vwDlvrySuspendedData.WhereFilters.supplier

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwDlvrySuspended
  ''' </summary>
  ''' <returns>A cloned vwDlvrySuspended object</returns>
  Public Function CloneEntity() As vwDlvrySuspended
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwDlvrySuspended
  ''' </summary>
  ''' <returns>A cloned vwDlvrySuspended object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwDlvrySuspended) As vwDlvrySuspended
    Dim newEntity As New vwDlvrySuspended()

    newEntity.dridtmp = entityToClone.dridtmp
    newEntity.drinv = entityToClone.drinv
    newEntity.drdate = entityToClone.drdate
    newEntity.supcode = entityToClone.supcode
    newEntity.supplier = entityToClone.supplier
    newEntity.drdue = entityToClone.drdue
    newEntity.terms = entityToClone.terms
    newEntity.stckid = entityToClone.stckid
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.cost = entityToClone.cost
    newEntity.qty = entityToClone.qty
    newEntity.freee = entityToClone.freee
    newEntity.drdetamnt = entityToClone.drdetamnt

    Return newEntity
  End Function
#End Region

End Class
