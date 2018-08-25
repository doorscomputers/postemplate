Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the podettmp table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class podettmpManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the podettmpManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the podettmpManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As podettmp
  Private _Validator As podettmpValidator
  Private _DataObject As podettmpData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As podettmp
    Get
      Return _Entity
    End Get
    Set(ByVal value As podettmp)
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
  Public Property Validator() As podettmpValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As podettmpValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As podettmpData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As podettmpData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New podettmp()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New podettmpValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New podettmpData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "podettmpManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of podettmp classes based
  ''' </summary>
  ''' <returns>podettmpCollection</returns>
  Public Function BuildCollection() As podettmpCollection
    Dim coll As New podettmpCollection()
    Dim newEntity As podettmp
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

#Region "GetpodettmpsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpodettmpsByPrimaryKey() As podettmpCollection
    DataObject.WhereFilter = podettmpData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetpodettmpsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpodettmpsBysInsert_id() As podettmpCollection
    DataObject.WhereFilter = podettmpData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetpodettmpsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpodettmpsByLikesInsert_id() As podettmpCollection
    DataObject.WhereFilter = podettmpData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetpodettmpsBypoidtmp Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpodettmpsBypoidtmp() As podettmpCollection
    DataObject.WhereFilter = podettmpData.WhereFilters.poidtmp

    Return BuildCollection()
  End Function
#End Region

#Region "GetpodettmpsBystckid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetpodettmpsBystckid() As podettmpCollection
    DataObject.WhereFilter = podettmpData.WhereFilters.stckid

    Return BuildCollection()
  End Function
#End Region

#Region "GetpodettmpsByFK_podettmp_pohdrtmpEntity Method"
  Public Function GetpodettmpsByFK_podettmp_pohdrtmpEntity(ByVal entityObject As pohdrtmp) As podettmpCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = podettmpData.WhereFilters.poidtmp
         End If
         Entity.poidtmp = entityObject.poidtmp
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New podettmpCollection()
     End If
  End Function
#End Region

#Region "GetpodettmpsByFK_podettmp_stocksEntity Method"
  Public Function GetpodettmpsByFK_podettmp_stocksEntity(ByVal entityObject As stocks) As podettmpCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = podettmpData.WhereFilters.stckid
         End If
         Entity.stckid = entityObject.stckid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New podettmpCollection()
     End If
  End Function
#End Region

End Class

