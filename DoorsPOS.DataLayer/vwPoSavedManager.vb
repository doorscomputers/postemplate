Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwPoSaved
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwPoSavedManager
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
  Private _Entity As vwPoSaved 
  Private _DataObject As vwPoSavedData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwPoSaved
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwPoSaved)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwPoSavedData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwPoSavedData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwPoSaved()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwPoSavedData(DataProvider, Entity)
    End If

    ClassName = "vwPoSavedManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwPoSaved classes based
  ''' </summary>
  ''' <returns>vwPoSavedCollection</returns>
  Public Function BuildCollection() As vwPoSavedCollection
    Dim coll As New vwPoSavedCollection()
    Dim newEntity As vwPoSaved
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

#Region "GetvwPoSavedsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwPoSavedsBysInsert_id() As vwPoSavedCollection
    DataObject.WhereFilter = vwPoSavedData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwPoSavedsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwPoSavedsByLikesInsert_id() As vwPoSavedCollection
    DataObject.WhereFilter = vwPoSavedData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwPoSaved
  ''' </summary>
  ''' <returns>A cloned vwPoSaved object</returns>
  Public Function CloneEntity() As vwPoSaved
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwPoSaved
  ''' </summary>
  ''' <returns>A cloned vwPoSaved object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwPoSaved) As vwPoSaved
    Dim newEntity As New vwPoSaved()

    newEntity.poidtmp = entityToClone.poidtmp
    newEntity.podate = entityToClone.podate
    newEntity.supcode = entityToClone.supcode
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dlivered = entityToClone.dlivered
    newEntity.supplier = entityToClone.supplier

    Return newEntity
  End Function
#End Region

End Class
