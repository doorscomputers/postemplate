Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' This class is used to call the stored procedure spBanks
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class spBanksManager
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
  Private _Entity As spBanks
  Private _DataObject As spBanksData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As spBanks
    Get
      Return _Entity
    End Get
    Set(ByVal value As spBanks)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As spBanksData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As spBanksData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If _Entity Is Nothing Then
      _Entity = New spBanks()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New spBanksData(DataProvider, Entity)
    End If

    ClassName = "spBanksManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of spBanks classes based
  ''' </summary>
  ''' <returns>spBanksCollection</returns>
  Public Function BuildCollection() As spBanksCollection
    Dim coll As New spBanksCollection()
    Dim newEntity As spBanks
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
  ''' Clones the current spBanks
  ''' </summary>
  ''' <returns>A cloned spBanks object</returns>
  Public Function CloneEntity() As spBanks
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in spBanks
  ''' </summary>
  ''' <returns>A cloned spBanks object</returns>
  Public Function CloneEntity(ByVal entityToClone As spBanks) As spBanks
    Dim newEntity As New spBanks()

    newEntity.bankid = entityToClone.bankid
    newEntity.bank = entityToClone.bank
    newEntity.accountno = entityToClone.accountno

    Return newEntity
  End Function
#End Region

End Class
