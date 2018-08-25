Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the transfer_det table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class transfer_detManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the transfer_detManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the transfer_detManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As transfer_det
  Private _Validator As transfer_detValidator
  Private _DataObject As transfer_detData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As transfer_det
    Get
      Return _Entity
    End Get
    Set(ByVal value As transfer_det)
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
  Public Property Validator() As transfer_detValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As transfer_detValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As transfer_detData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As transfer_detData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New transfer_det()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New transfer_detValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New transfer_detData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "transfer_detManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of transfer_det classes based
  ''' </summary>
  ''' <returns>transfer_detCollection</returns>
  Public Function BuildCollection() As transfer_detCollection
    Dim coll As New transfer_detCollection()
    Dim newEntity As transfer_det
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

#Region "Gettransfer_detsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Gettransfer_detsByLikesInsert_id() As transfer_detCollection
    DataObject.WhereFilter = transfer_detData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "Gettransfer_detsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Gettransfer_detsByPrimaryKey() As transfer_detCollection
    DataObject.WhereFilter = transfer_detData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "Gettransfer_detsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Gettransfer_detsBysInsert_id() As transfer_detCollection
    DataObject.WhereFilter = transfer_detData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "Gettransfer_detsBystckid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Gettransfer_detsBystckid() As transfer_detCollection
    DataObject.WhereFilter = transfer_detData.WhereFilters.stckid

    Return BuildCollection()
  End Function
#End Region

#Region "Gettransfer_detsBytid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Gettransfer_detsBytid() As transfer_detCollection
    DataObject.WhereFilter = transfer_detData.WhereFilters.tid

    Return BuildCollection()
  End Function
#End Region

#Region "Gettransfer_detsByFK_transfer_det_transfer_hdrEntity Method"
  Public Function Gettransfer_detsByFK_transfer_det_transfer_hdrEntity(ByVal entityObject As transfer_hdr) As transfer_detCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = transfer_detData.WhereFilters.tid
         End If
         Entity.tid = entityObject.tid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New transfer_detCollection()
     End If
  End Function
#End Region

#Region "Gettransfer_detsByFK_transfer_det_stocksEntity Method"
  Public Function Gettransfer_detsByFK_transfer_det_stocksEntity(ByVal entityObject As stocks) As transfer_detCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = transfer_detData.WhereFilters.stckid
         End If
         Entity.stckid = entityObject.stckid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New transfer_detCollection()
     End If
  End Function
#End Region

End Class

