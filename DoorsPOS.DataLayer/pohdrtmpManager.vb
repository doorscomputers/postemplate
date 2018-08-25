Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the pohdrtmp table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class pohdrtmpManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the pohdrtmpManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the pohdrtmpManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As pohdrtmp
  Private _Validator As pohdrtmpValidator
  Private _DataObject As pohdrtmpData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As pohdrtmp
    Get
      Return _Entity
    End Get
    Set(ByVal value As pohdrtmp)
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
  Public Property Validator() As pohdrtmpValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As pohdrtmpValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As pohdrtmpData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As pohdrtmpData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New pohdrtmp()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New pohdrtmpValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New pohdrtmpData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "pohdrtmpManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of pohdrtmp classes based
  ''' </summary>
  ''' <returns>pohdrtmpCollection</returns>
  Public Function BuildCollection() As pohdrtmpCollection
    Dim coll As New pohdrtmpCollection()
    Dim newEntity As pohdrtmp
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

#Region "GetpohdrtmpsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpohdrtmpsByPrimaryKey() As pohdrtmpCollection
    DataObject.WhereFilter = pohdrtmpData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetpohdrtmpsBypoinv Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpohdrtmpsBypoinv() As pohdrtmpCollection
    DataObject.WhereFilter = pohdrtmpData.WhereFilters.poinv

    Return BuildCollection()
  End Function
#End Region

#Region "GetpohdrtmpsByLikepoinv Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpohdrtmpsByLikepoinv() As pohdrtmpCollection
    DataObject.WhereFilter = pohdrtmpData.WhereFilters.Likepoinv

    Return BuildCollection()
  End Function
#End Region

End Class

