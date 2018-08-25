Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwSuspendDlvry
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwSuspendDlvryManager
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
  Private _Entity As vwSuspendDlvry 
  Private _DataObject As vwSuspendDlvryData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwSuspendDlvry
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwSuspendDlvry)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwSuspendDlvryData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwSuspendDlvryData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwSuspendDlvry()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwSuspendDlvryData(DataProvider, Entity)
    End If

    ClassName = "vwSuspendDlvryManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwSuspendDlvry classes based
  ''' </summary>
  ''' <returns>vwSuspendDlvryCollection</returns>
  Public Function BuildCollection() As vwSuspendDlvryCollection
    Dim coll As New vwSuspendDlvryCollection()
    Dim newEntity As vwSuspendDlvry
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

#Region "GetvwSuspendDlvrysByLikesupplier Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendDlvrysByLikesupplier() As vwSuspendDlvryCollection
    DataObject.WhereFilter = vwSuspendDlvryData.WhereFilters.Likesupplier

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendDlvrysBysupplier Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendDlvrysBysupplier() As vwSuspendDlvryCollection
    DataObject.WhereFilter = vwSuspendDlvryData.WhereFilters.supplier

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendDlvrysByemployee Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendDlvrysByemployee() As vwSuspendDlvryCollection
    DataObject.WhereFilter = vwSuspendDlvryData.WhereFilters.employee

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendDlvrysBySuspendID Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendDlvrysBySuspendID() As vwSuspendDlvryCollection
    DataObject.WhereFilter = vwSuspendDlvryData.WhereFilters.SuspendID

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwSuspendDlvry
  ''' </summary>
  ''' <returns>A cloned vwSuspendDlvry object</returns>
  Public Function CloneEntity() As vwSuspendDlvry
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwSuspendDlvry
  ''' </summary>
  ''' <returns>A cloned vwSuspendDlvry object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwSuspendDlvry) As vwSuspendDlvry
    Dim newEntity As New vwSuspendDlvry()

    newEntity.dridtmp = entityToClone.dridtmp
    newEntity.drdate = entityToClone.drdate
    newEntity.supplier = entityToClone.supplier
    newEntity.supcode = entityToClone.supcode
    newEntity.drdue = entityToClone.drdue
    newEntity.sInsertid = entityToClone.sInsertid

    Return newEntity
  End Function
#End Region

End Class
