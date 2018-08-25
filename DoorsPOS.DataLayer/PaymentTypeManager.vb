Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the PaymentType table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class PaymentTypeManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the PaymentTypeManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the PaymentTypeManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As PaymentType
  Private _Validator As PaymentTypeValidator
  Private _DataObject As PaymentTypeData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As PaymentType
    Get
      Return _Entity
    End Get
    Set(ByVal value As PaymentType)
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
  Public Property Validator() As PaymentTypeValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As PaymentTypeValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As PaymentTypeData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As PaymentTypeData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New PaymentType()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New PaymentTypeValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New PaymentTypeData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "PaymentTypeManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of PaymentType classes based
  ''' </summary>
  ''' <returns>PaymentTypeCollection</returns>
  Public Function BuildCollection() As PaymentTypeCollection
    Dim coll As New PaymentTypeCollection()
    Dim newEntity As PaymentType
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

#Region "GetPaymentTypesByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetPaymentTypesByPrimaryKey() As PaymentTypeCollection
    DataObject.WhereFilter = PaymentTypeData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetPaymentTypesByPaymentType Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetPaymentTypesByPaymentType() As PaymentTypeCollection
    DataObject.WhereFilter = PaymentTypeData.WhereFilters.PaymentType

    Return BuildCollection()
  End Function
#End Region

#Region "GetPaymentTypesByLikePaymentType Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetPaymentTypesByLikePaymentType() As PaymentTypeCollection
    DataObject.WhereFilter = PaymentTypeData.WhereFilters.LikePaymentType

    Return BuildCollection()
  End Function
#End Region

End Class

