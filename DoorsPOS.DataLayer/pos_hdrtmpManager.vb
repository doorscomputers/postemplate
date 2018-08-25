Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the pos_hdrtmp table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class pos_hdrtmpManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the pos_hdrtmpManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the pos_hdrtmpManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As pos_hdrtmp
  Private _Validator As pos_hdrtmpValidator
  Private _DataObject As pos_hdrtmpData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As pos_hdrtmp
    Get
      Return _Entity
    End Get
    Set(ByVal value As pos_hdrtmp)
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
  Public Property Validator() As pos_hdrtmpValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As pos_hdrtmpValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As pos_hdrtmpData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As pos_hdrtmpData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New pos_hdrtmp()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New pos_hdrtmpValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New pos_hdrtmpData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "pos_hdrtmpManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of pos_hdrtmp classes based
  ''' </summary>
  ''' <returns>pos_hdrtmpCollection</returns>
  Public Function BuildCollection() As pos_hdrtmpCollection
    Dim coll As New pos_hdrtmpCollection()
    Dim newEntity As pos_hdrtmp
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

#Region "Getpos_hdrtmpsByCashMode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_hdrtmpsByCashMode() As pos_hdrtmpCollection
    DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.CashMode

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_hdrtmpsByCreditMode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_hdrtmpsByCreditMode() As pos_hdrtmpCollection
    DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.CreditMode

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_hdrtmpsBycustid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_hdrtmpsBycustid() As pos_hdrtmpCollection
    DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.custid

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_hdrtmpsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_hdrtmpsByLikesInsert_id() As pos_hdrtmpCollection
    DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_hdrtmpsBypostmp_hdrid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_hdrtmpsBypostmp_hdrid() As pos_hdrtmpCollection
    DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.postmp_hdrid

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_hdrtmpsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_hdrtmpsByPrimaryKey() As pos_hdrtmpCollection
    DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_hdrtmpsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_hdrtmpsBysInsert_id() As pos_hdrtmpCollection
    DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_hdrtmpsBytblstatus Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_hdrtmpsBytblstatus() As pos_hdrtmpCollection
    DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.tblstatus

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_hdrtmpsByFK_pos_hdrtmp_membersEntity Method"
  Public Function Getpos_hdrtmpsByFK_pos_hdrtmp_membersEntity(ByVal entityObject As members) As pos_hdrtmpCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.custid
         End If
         Entity.custid = entityObject.custid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New pos_hdrtmpCollection()
     End If
  End Function
#End Region

End Class

