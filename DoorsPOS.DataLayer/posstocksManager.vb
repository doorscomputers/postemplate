Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the posstocks table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class posstocksManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the posstocksManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the posstocksManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As posstocks
  Private _Validator As posstocksValidator
  Private _DataObject As posstocksData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As posstocks
    Get
      Return _Entity
    End Get
    Set(ByVal value As posstocks)
      _Entity = value
      If _Validator IsNot Nothing Then
        _Validator.Entity = value
      End If
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the validator class. This is the class that contains the business rules for the Entity class.
  ''' </summary>
  Public Property Validator() As posstocksValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As posstocksValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As posstocksData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As posstocksData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New posstocks()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New posstocksValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New posstocksData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "posstocksManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of posstocks classes based
  ''' </summary>
  ''' <returns>posstocksCollection</returns>
  Public Function BuildCollection() As posstocksCollection
    Dim coll As New posstocksCollection()
    Dim newEntity As posstocks
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

#Region "GetposstocksBycashier Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetposstocksBycashier() As posstocksCollection
    DataObject.WhereFilter = posstocksData.WhereFilters.cashier

    Return BuildCollection()
  End Function
#End Region

#Region "GetposstocksByitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetposstocksByitem_desc() As posstocksCollection
    DataObject.WhereFilter = posstocksData.WhereFilters.item_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetposstocksByLikeitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetposstocksByLikeitem_desc() As posstocksCollection
    DataObject.WhereFilter = posstocksData.WhereFilters.Likeitem_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetposstocksByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetposstocksByPrimaryKey() As posstocksCollection
    DataObject.WhereFilter = posstocksData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

End Class

