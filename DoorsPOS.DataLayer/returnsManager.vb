Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the returns table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class returnsManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the returnsManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the returnsManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As returns
  Private _Validator As returnsValidator
  Private _DataObject As returnsData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As returns
    Get
      Return _Entity
    End Get
    Set(ByVal value As returns)
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
  Public Property Validator() As returnsValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As returnsValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As returnsData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As returnsData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New returns()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New returnsValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New returnsData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "returnsManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of returns classes based
  ''' </summary>
  ''' <returns>returnsCollection</returns>
  Public Function BuildCollection() As returnsCollection
    Dim coll As New returnsCollection()
    Dim newEntity As returns
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

#Region "GetreturnsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreturnsByPrimaryKey() As returnsCollection
    DataObject.WhereFilter = returnsData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "GetreturnsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreturnsBysInsert_id() As returnsCollection
    DataObject.WhereFilter = returnsData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetreturnsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreturnsByLikesInsert_id() As returnsCollection
    DataObject.WhereFilter = returnsData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetreturnsBycustid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreturnsBycustid() As returnsCollection
    DataObject.WhereFilter = returnsData.WhereFilters.custid

    Return BuildCollection()
  End Function
#End Region

#Region "GetreturnsBystckid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetreturnsBystckid() As returnsCollection
    DataObject.WhereFilter = returnsData.WhereFilters.stckid

    Return BuildCollection()
  End Function
#End Region

#Region "GetreturnsByFK_returns_membersEntity Method"
  Public Function GetreturnsByFK_returns_membersEntity(ByVal entityObject As members) As returnsCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = returnsData.WhereFilters.custid
         End If
         Entity.custid = entityObject.custid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New returnsCollection()
     End If
  End Function
#End Region

#Region "GetreturnsByFK_returns_stocksEntity Method"
  Public Function GetreturnsByFK_returns_stocksEntity(ByVal entityObject As stocks) As returnsCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = returnsData.WhereFilters.stckid
         End If
         Entity.stckid = entityObject.stckid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New returnsCollection()
     End If
  End Function
#End Region

End Class

