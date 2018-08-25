Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the tblExpenseTrans table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class tblExpenseTransManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the tblExpenseTransManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the tblExpenseTransManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As tblExpenseTrans
  Private _Validator As tblExpenseTransValidator
  Private _DataObject As tblExpenseTransData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As tblExpenseTrans
    Get
      Return _Entity
    End Get
    Set(ByVal value As tblExpenseTrans)
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
  Public Property Validator() As tblExpenseTransValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As tblExpenseTransValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As tblExpenseTransData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As tblExpenseTransData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New tblExpenseTrans()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New tblExpenseTransValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New tblExpenseTransData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "tblExpenseTransManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of tblExpenseTrans classes based
  ''' </summary>
  ''' <returns>tblExpenseTransCollection</returns>
  Public Function BuildCollection() As tblExpenseTransCollection
    Dim coll As New tblExpenseTransCollection()
    Dim newEntity As tblExpenseTrans
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

#Region "GettblExpenseTransByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GettblExpenseTransByPrimaryKey() As tblExpenseTransCollection
    DataObject.WhereFilter = tblExpenseTransData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GettblExpenseTransByexpremarks Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GettblExpenseTransByexpremarks() As tblExpenseTransCollection
    DataObject.WhereFilter = tblExpenseTransData.WhereFilters.expremarks

    Return BuildCollection()
  End Function
#End Region

#Region "GettblExpenseTransByLikeexpremarks Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GettblExpenseTransByLikeexpremarks() As tblExpenseTransCollection
    DataObject.WhereFilter = tblExpenseTransData.WhereFilters.Likeexpremarks

    Return BuildCollection()
  End Function
#End Region

#Region "GettblExpenseTransByexpenseid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GettblExpenseTransByexpenseid() As tblExpenseTransCollection
    DataObject.WhereFilter = tblExpenseTransData.WhereFilters.expenseid

    Return BuildCollection()
  End Function
#End Region

#Region "GettblExpenseTransByFK_tblExpenseTrans_tblExpensesEntity Method"
  Public Function GettblExpenseTransByFK_tblExpenseTrans_tblExpensesEntity(ByVal entityObject As tblExpenses) As tblExpenseTransCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = tblExpenseTransData.WhereFilters.expenseid
         End If
         Entity.expenseid = entityObject.expenseid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New tblExpenseTransCollection()
     End If
  End Function
#End Region

End Class

