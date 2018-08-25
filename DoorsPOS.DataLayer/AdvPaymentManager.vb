Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the AdvPayment table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class AdvPaymentManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the AdvPaymentManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the AdvPaymentManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As AdvPayment
  Private _Validator As AdvPaymentValidator
  Private _DataObject As AdvPaymentData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As AdvPayment
    Get
      Return _Entity
    End Get
    Set(ByVal value As AdvPayment)
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
  Public Property Validator() As AdvPaymentValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As AdvPaymentValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As AdvPaymentData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As AdvPaymentData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New AdvPayment()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New AdvPaymentValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New AdvPaymentData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "AdvPaymentManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of AdvPayment classes based
  ''' </summary>
  ''' <returns>AdvPaymentCollection</returns>
  Public Function BuildCollection() As AdvPaymentCollection
    Dim coll As New AdvPaymentCollection()
    Dim newEntity As AdvPayment
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

#Region "GetAdvPaymentsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetAdvPaymentsByPrimaryKey() As AdvPaymentCollection
    DataObject.WhereFilter = AdvPaymentData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetAdvPaymentsByRemarks Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetAdvPaymentsByRemarks() As AdvPaymentCollection
    DataObject.WhereFilter = AdvPaymentData.WhereFilters.Remarks

    Return BuildCollection()
  End Function
#End Region

#Region "GetAdvPaymentsByLikeRemarks Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetAdvPaymentsByLikeRemarks() As AdvPaymentCollection
    DataObject.WhereFilter = AdvPaymentData.WhereFilters.LikeRemarks

    Return BuildCollection()
  End Function
#End Region

#Region "GetAdvPaymentsBycustclaimed Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetAdvPaymentsBycustclaimed() As AdvPaymentCollection
    DataObject.WhereFilter = AdvPaymentData.WhereFilters.custclaimed

    Return BuildCollection()
  End Function
#End Region

End Class

