Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the dlvry_det table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class dlvry_detManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the dlvry_detManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the dlvry_detManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As dlvry_det
  Private _Validator As dlvry_detValidator
  Private _DataObject As dlvry_detData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As dlvry_det
    Get
      Return _Entity
    End Get
    Set(ByVal value As dlvry_det)
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
  Public Property Validator() As dlvry_detValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As dlvry_detValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As dlvry_detData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As dlvry_detData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New dlvry_det()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New dlvry_detValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New dlvry_detData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "dlvry_detManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of dlvry_det classes based
  ''' </summary>
  ''' <returns>dlvry_detCollection</returns>
  Public Function BuildCollection() As dlvry_detCollection
    Dim coll As New dlvry_detCollection()
    Dim newEntity As dlvry_det
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

#Region "Getdlvry_detsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_detsByPrimaryKey() As dlvry_detCollection
    DataObject.WhereFilter = dlvry_detData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_detsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_detsBysInsert_id() As dlvry_detCollection
    DataObject.WhereFilter = dlvry_detData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_detsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_detsByLikesInsert_id() As dlvry_detCollection
    DataObject.WhereFilter = dlvry_detData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_detsBystckid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_detsBystckid() As dlvry_detCollection
    DataObject.WhereFilter = dlvry_detData.WhereFilters.stckid

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_detsBydrid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_detsBydrid() As dlvry_detCollection
    DataObject.WhereFilter = dlvry_detData.WhereFilters.drid

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_detsByFK_dlvry_det_stocksEntity Method"
  Public Function Getdlvry_detsByFK_dlvry_det_stocksEntity(ByVal entityObject As stocks) As dlvry_detCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = dlvry_detData.WhereFilters.stckid
         End If
         Entity.stckid = entityObject.stckid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New dlvry_detCollection()
     End If
  End Function
#End Region

#Region "Getdlvry_detsByFK_dlvry_det_dlvry_hdrEntity Method"
  Public Function Getdlvry_detsByFK_dlvry_det_dlvry_hdrEntity(ByVal entityObject As dlvry_hdr) As dlvry_detCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = dlvry_detData.WhereFilters.drid
         End If
         Entity.drid = entityObject.drid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New dlvry_detCollection()
     End If
  End Function
#End Region

End Class

