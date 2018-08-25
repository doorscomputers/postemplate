Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the replacementdet table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class replacementdetManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the replacementdetManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the replacementdetManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As replacementdet
  Private _Validator As replacementdetValidator
  Private _DataObject As replacementdetData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As replacementdet
    Get
      Return _Entity
    End Get
    Set(ByVal value As replacementdet)
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
  Public Property Validator() As replacementdetValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As replacementdetValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As replacementdetData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As replacementdetData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New replacementdet()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New replacementdetValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New replacementdetData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "replacementdetManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of replacementdet classes based
  ''' </summary>
  ''' <returns>replacementdetCollection</returns>
  Public Function BuildCollection() As replacementdetCollection
    Dim coll As New replacementdetCollection()
    Dim newEntity As replacementdet
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

#Region "GetreplacementdetsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreplacementdetsByPrimaryKey() As replacementdetCollection
    DataObject.WhereFilter = replacementdetData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetreplacementdetsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreplacementdetsBysInsert_id() As replacementdetCollection
    DataObject.WhereFilter = replacementdetData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetreplacementdetsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreplacementdetsByLikesInsert_id() As replacementdetCollection
    DataObject.WhereFilter = replacementdetData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetreplacementdetsByrepid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreplacementdetsByrepid() As replacementdetCollection
    DataObject.WhereFilter = replacementdetData.WhereFilters.repid

    Return BuildCollection()
  End Function
#End Region

#Region "GetreplacementdetsBystckid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreplacementdetsBystckid() As replacementdetCollection
    DataObject.WhereFilter = replacementdetData.WhereFilters.stckid

    Return BuildCollection()
  End Function
#End Region

#Region "GetreplacementdetsByFK_replacementdet_replacementhdrEntity Method"
  Public Function GetreplacementdetsByFK_replacementdet_replacementhdrEntity(ByVal entityObject As replacementhdr) As replacementdetCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = replacementdetData.WhereFilters.repid
         End If
         Entity.repid = entityObject.repid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New replacementdetCollection()
     End If
  End Function
#End Region

#Region "GetreplacementdetsByFK_replacementdet_stocksEntity Method"
  Public Function GetreplacementdetsByFK_replacementdet_stocksEntity(ByVal entityObject As stocks) As replacementdetCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = replacementdetData.WhereFilters.stckid
         End If
         Entity.stckid = entityObject.stckid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New replacementdetCollection()
     End If
  End Function
#End Region

End Class

