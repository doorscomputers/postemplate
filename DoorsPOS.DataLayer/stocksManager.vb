Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the stocks table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class stocksManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the stocksManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the stocksManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As stocks
  Private _Validator As stocksValidator
  Private _DataObject As stocksData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As stocks
    Get
      Return _Entity
    End Get
    Set(ByVal value As stocks)
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
  Public Property Validator() As stocksValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As stocksValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As stocksData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As stocksData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New stocks()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New stocksValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New stocksData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "stocksManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of stocks classes based
  ''' </summary>
  ''' <returns>stocksCollection</returns>
  Public Function BuildCollection() As stocksCollection
    Dim coll As New stocksCollection()
    Dim newEntity As stocks
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

#Region "GetstocksBybarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksBybarcode() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.barcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksBycategoryid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksBycategoryid() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.categoryid

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksBydept Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksBydept() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.dept

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksByitem_desc Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksByitem_desc() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.item_desc

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksByitems Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksByitems() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.items

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksByLikebarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksByLikebarcode() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.Likebarcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksBylikeitem Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksBylikeitem() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.likeitem

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksByPrimaryKey() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksBysizeid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksBysizeid() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.sizeid

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksBysupcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetstocksBysupcode() As stocksCollection
    DataObject.WhereFilter = stocksData.WhereFilters.supcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetstocksByFK_stocks_categoriesEntity Method"
  Public Function GetstocksByFK_stocks_categoriesEntity(ByVal entityObject As categories) As stocksCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = stocksData.WhereFilters.categoryid
         End If
         Entity.categoryid = entityObject.categoryid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New stocksCollection()
     End If
  End Function
#End Region

#Region "GetstocksByFK_stocks_suppliersEntity Method"
  Public Function GetstocksByFK_stocks_suppliersEntity(ByVal entityObject As suppliers) As stocksCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = stocksData.WhereFilters.supcode
         End If
         Entity.supcode = entityObject.supcode
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New stocksCollection()
     End If
  End Function
#End Region

End Class

