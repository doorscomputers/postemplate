Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwMaxSaleNum
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwMaxSaleNumManager
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
  Private _Entity As vwMaxSaleNum 
  Private _DataObject As vwMaxSaleNumData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwMaxSaleNum
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwMaxSaleNum)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwMaxSaleNumData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwMaxSaleNumData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwMaxSaleNum()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwMaxSaleNumData(DataProvider, Entity)
    End If

    ClassName = "vwMaxSaleNumManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwMaxSaleNum classes based
  ''' </summary>
  ''' <returns>vwMaxSaleNumCollection</returns>
  Public Function BuildCollection() As vwMaxSaleNumCollection
    Dim coll As New vwMaxSaleNumCollection()
    Dim newEntity As vwMaxSaleNum
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



#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwMaxSaleNum
  ''' </summary>
  ''' <returns>A cloned vwMaxSaleNum object</returns>
  Public Function CloneEntity() As vwMaxSaleNum
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwMaxSaleNum
  ''' </summary>
  ''' <returns>A cloned vwMaxSaleNum object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwMaxSaleNum) As vwMaxSaleNum
    Dim newEntity As New vwMaxSaleNum()

    newEntity.MaxSaleNum = entityToClone.MaxSaleNum

    Return newEntity
  End Function
#End Region

End Class
