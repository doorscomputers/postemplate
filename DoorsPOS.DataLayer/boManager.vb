Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the bo table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class boManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the boManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the boManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As bo
  Private _Validator As boValidator
  Private _DataObject As boData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As bo
    Get
      Return _Entity
    End Get
    Set(ByVal value As bo)
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
  Public Property Validator() As boValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As boValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As boData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As boData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New bo()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New boValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New boData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "boManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of bo classes based
  ''' </summary>
  ''' <returns>boCollection</returns>
  Public Function BuildCollection() As boCollection
    Dim coll As New boCollection()
    Dim newEntity As bo
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

#Region "GetbosByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetbosByLikesInsert_id() As boCollection
    DataObject.WhereFilter = boData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetbosByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetbosByPrimaryKey() As boCollection
    DataObject.WhereFilter = boData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetbosBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetbosBysInsert_id() As boCollection
    DataObject.WhereFilter = boData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetbosBysupcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetbosBysupcode() As boCollection
    DataObject.WhereFilter = boData.WhereFilters.supcode

    Return BuildCollection()
  End Function
#End Region

#Region "GetbosBystckid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetbosBystckid() As boCollection
    DataObject.WhereFilter = boData.WhereFilters.stckid

    Return BuildCollection()
  End Function
#End Region

#Region "GetbosByFK_bo_suppliersEntity Method"
  Public Function GetbosByFK_bo_suppliersEntity(ByVal entityObject As suppliers) As boCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = boData.WhereFilters.supcode
         End If
         Entity.supcode = entityObject.supcode
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New boCollection()
     End If
  End Function
#End Region

#Region "GetbosByFK_bo_stocksEntity Method"
  Public Function GetbosByFK_bo_stocksEntity(ByVal entityObject As stocks) As boCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = boData.WhereFilters.stckid
         End If
         Entity.stckid = entityObject.stckid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New boCollection()
     End If
  End Function
#End Region

End Class

