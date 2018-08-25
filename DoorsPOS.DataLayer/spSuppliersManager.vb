Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' This class is used to call the stored procedure spSuppliers
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class spSuppliersManager
  Inherits PDSADataClassManagerReadOnlyBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.New(dataProvider)

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As spSuppliers
  Private _DataObject As spSuppliersData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As spSuppliers
    Get
      Return _Entity
    End Get
    Set(ByVal value As spSuppliers)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As spSuppliersData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As spSuppliersData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If _Entity Is Nothing Then
      _Entity = New spSuppliers()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New spSuppliersData(DataProvider, Entity)
    End If

    ClassName = "spSuppliersManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of spSuppliers classes based
  ''' </summary>
  ''' <returns>spSuppliersCollection</returns>
  Public Function BuildCollection() As spSuppliersCollection
    Dim coll As New spSuppliersCollection()
    Dim newEntity As spSuppliers
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
  ''' Clones the current spSuppliers
  ''' </summary>
  ''' <returns>A cloned spSuppliers object</returns>
  Public Function CloneEntity() As spSuppliers
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in spSuppliers
  ''' </summary>
  ''' <returns>A cloned spSuppliers object</returns>
  Public Function CloneEntity(ByVal entityToClone As spSuppliers) As spSuppliers
    Dim newEntity As New spSuppliers()

    newEntity.supcode = entityToClone.supcode
    newEntity.Supplier = entityToClone.Supplier

    Return newEntity
  End Function
#End Region

End Class
