Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the petty_cash table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class petty_cashManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the petty_cashManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the petty_cashManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As petty_cash
  Private _Validator As petty_cashValidator
  Private _DataObject As petty_cashData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As petty_cash
    Get
      Return _Entity
    End Get
    Set(ByVal value As petty_cash)
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
  Public Property Validator() As petty_cashValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As petty_cashValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As petty_cashData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As petty_cashData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New petty_cash()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New petty_cashValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New petty_cashData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "petty_cashManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of petty_cash classes based
  ''' </summary>
  ''' <returns>petty_cashCollection</returns>
  Public Function BuildCollection() As petty_cashCollection
    Dim coll As New petty_cashCollection()
    Dim newEntity As petty_cash
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

#Region "Getpetty_cashsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpetty_cashsByPrimaryKey() As petty_cashCollection
    DataObject.WhereFilter = petty_cashData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "Getpetty_cashsBypcrem Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpetty_cashsBypcrem() As petty_cashCollection
    DataObject.WhereFilter = petty_cashData.WhereFilters.pcrem

    Return BuildCollection()
  End Function
#End Region

#Region "Getpetty_cashsByLikepcrem Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpetty_cashsByLikepcrem() As petty_cashCollection
    DataObject.WhereFilter = petty_cashData.WhereFilters.Likepcrem

    Return BuildCollection()
  End Function
#End Region

End Class

