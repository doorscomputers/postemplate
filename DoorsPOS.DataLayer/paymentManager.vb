Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the payment table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class paymentManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the paymentManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the paymentManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As payment
  Private _Validator As paymentValidator
  Private _DataObject As paymentData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As payment
    Get
      Return _Entity
    End Get
    Set(ByVal value As payment)
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
  Public Property Validator() As paymentValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As paymentValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As paymentData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As paymentData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New payment()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New paymentValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New paymentData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "paymentManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of payment classes based
  ''' </summary>
  ''' <returns>paymentCollection</returns>
  Public Function BuildCollection() As paymentCollection
    Dim coll As New paymentCollection()
    Dim newEntity As payment
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

#Region "GetpaymentsByCustID Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpaymentsByCustID() As paymentCollection
    DataObject.WhereFilter = paymentData.WhereFilters.CustID

    Return BuildCollection()
  End Function
#End Region

#Region "GetpaymentsByFP Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpaymentsByFP() As paymentCollection
    DataObject.WhereFilter = paymentData.WhereFilters.FP

    Return BuildCollection()
  End Function
#End Region

#Region "GetpaymentsByLikeFP Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpaymentsByLikeFP() As paymentCollection
    DataObject.WhereFilter = paymentData.WhereFilters.LikeFP

    Return BuildCollection()
  End Function
#End Region

#Region "GetpaymentsByPayID Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpaymentsByPayID() As paymentCollection
    DataObject.WhereFilter = paymentData.WhereFilters.PayID

    Return BuildCollection()
  End Function
#End Region

#Region "GetpaymentsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpaymentsByPrimaryKey() As paymentCollection
    DataObject.WhereFilter = paymentData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetpaymentsByFK_payment_membersEntity Method"
  Public Function GetpaymentsByFK_payment_membersEntity(ByVal entityObject As members) As paymentCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = paymentData.WhereFilters.CustID
         End If
         Entity.CustID = entityObject.CustID
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New paymentCollection()
     End If
  End Function
#End Region

End Class

