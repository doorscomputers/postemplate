Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwDlvry
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwDlvryManager
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
  Private _Entity As vwDlvry 
  Private _DataObject As vwDlvryData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwDlvry
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwDlvry)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwDlvryData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwDlvryData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwDlvry()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwDlvryData(DataProvider, Entity)
    End If

    ClassName = "vwDlvryManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwDlvry classes based
  ''' </summary>
  ''' <returns>vwDlvryCollection</returns>
  Public Function BuildCollection() As vwDlvryCollection
    Dim coll As New vwDlvryCollection()
    Dim newEntity As vwDlvry
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

#Region "GetvwDlvrysBydrinv Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwDlvrysBydrinv() As vwDlvryCollection
    DataObject.WhereFilter = vwDlvryData.WhereFilters.drinv

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwDlvrysByLikedrinv Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwDlvrysByLikedrinv() As vwDlvryCollection
    DataObject.WhereFilter = vwDlvryData.WhereFilters.Likedrinv

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwDlvry
  ''' </summary>
  ''' <returns>A cloned vwDlvry object</returns>
  Public Function CloneEntity() As vwDlvry
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwDlvry
  ''' </summary>
  ''' <returns>A cloned vwDlvry object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwDlvry) As vwDlvry
    Dim newEntity As New vwDlvry()

    newEntity.drinv = entityToClone.drinv
    newEntity.drdate = entityToClone.drdate
    newEntity.supcode = entityToClone.supcode
    newEntity.supplier = entityToClone.supplier
    newEntity.paid = entityToClone.paid
    newEntity.drbal = entityToClone.drbal
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.drid = entityToClone.drid

    Return newEntity
  End Function
#End Region

End Class
