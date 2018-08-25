Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the pos_det table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class pos_detManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the pos_detManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the pos_detManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As pos_det
  Private _Validator As pos_detValidator
  Private _DataObject As pos_detData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As pos_det
    Get
      Return _Entity
    End Get
    Set(ByVal value As pos_det)
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
  Public Property Validator() As pos_detValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As pos_detValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As pos_detData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As pos_detData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New pos_det()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New pos_detValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New pos_detData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "pos_detManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of pos_det classes based
  ''' </summary>
  ''' <returns>pos_detCollection</returns>
  Public Function BuildCollection() As pos_detCollection
    Dim coll As New pos_detCollection()
    Dim newEntity As pos_det
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

#Region "Getpos_detsBybarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_detsBybarcode() As pos_detCollection
    DataObject.WhereFilter = pos_detData.WhereFilters.barcode

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_detsByLikebarcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_detsByLikebarcode() As pos_detCollection
    DataObject.WhereFilter = pos_detData.WhereFilters.Likebarcode

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_detsBypostmp_hdrid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_detsBypostmp_hdrid() As pos_detCollection
    DataObject.WhereFilter = pos_detData.WhereFilters.postmp_hdrid

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_detsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_detsByPrimaryKey() As pos_detCollection
    DataObject.WhereFilter = pos_detData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_detsBystckid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_detsBystckid() As pos_detCollection
    DataObject.WhereFilter = pos_detData.WhereFilters.stckid

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_detsByforRefunds Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getpos_detsByforRefunds() As pos_detCollection
    DataObject.WhereFilter = pos_detData.WhereFilters.forRefunds

    Return BuildCollection()
  End Function
#End Region

#Region "Getpos_detsByFK_pos_det_pos_hdrEntity Method"
  Public Function Getpos_detsByFK_pos_det_pos_hdrEntity(ByVal entityObject As pos_hdr) As pos_detCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = pos_detData.WhereFilters.postmp_hdrid
         End If
         Entity.postmphdrid = entityObject.postmphdrid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New pos_detCollection()
     End If
  End Function
#End Region

#Region "Getpos_detsByFK_pos_det_stocksEntity Method"
  Public Function Getpos_detsByFK_pos_det_stocksEntity(ByVal entityObject As stocks) As pos_detCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = pos_detData.WhereFilters.stckid
         End If
         Entity.stckid = entityObject.stckid
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New pos_detCollection()
     End If
  End Function
#End Region

End Class

