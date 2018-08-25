Imports System
Imports System.Data

Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' This class should be used when you need to add, edit, delete, select and validate data for the dlvry_hdr table.
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class dlvry_hdrManager
  Inherits PDSADataClassManagerBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the dlvry_hdrManager class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    ' The base constructor calls the Init() method
  End Sub

  ''' <summary>
  ''' Constructor for the dlvry_hdrManager class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As dlvry_hdr
  Private _Validator As dlvry_hdrValidator
  Private _DataObject As dlvry_hdrData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the Validator class too.
  ''' </summary>
  Public Property Entity() As dlvry_hdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As dlvry_hdr)
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
  Public Property Validator() As dlvry_hdrValidator
    Get
      Return _Validator
    End Get
    Set(ByVal value As dlvry_hdrValidator)
      _Validator = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the CRUD logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As dlvry_hdrData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As dlvry_hdrData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New dlvry_hdr()
    End If
   
    ' Create Validator Class if not created
    If Validator Is Nothing Then
      Validator = New dlvry_hdrValidator(Entity)
    End If
    
    ' Create Data Class if not created
    If DataObject Is Nothing Then
      DataObject = New dlvry_hdrData(DataProvider, Entity, Validator)
    Else
      DataObject.DataProvider = DataProvider
      DataObject.ValidatorObject = Validator
      DataObject.Entity = Entity
    End If
        
    ClassName = "dlvry_hdrManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of dlvry_hdr classes based
  ''' </summary>
  ''' <returns>dlvry_hdrCollection</returns>
  Public Function BuildCollection() As dlvry_hdrCollection
    Dim coll As New dlvry_hdrCollection()
    Dim newEntity As dlvry_hdr
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

#Region "Getdlvry_hdrsBydrinv Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_hdrsBydrinv() As dlvry_hdrCollection
    DataObject.WhereFilter = dlvry_hdrData.WhereFilters.drinv

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_hdrsByLikedrinv Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_hdrsByLikedrinv() As dlvry_hdrCollection
    DataObject.WhereFilter = dlvry_hdrData.WhereFilters.Likedrinv

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_hdrsByPrimaryKey Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_hdrsByPrimaryKey() As dlvry_hdrCollection
    DataObject.WhereFilter = dlvry_hdrData.WhereFilters.PrimaryKey

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_hdrsBysupcode Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_hdrsBysupcode() As dlvry_hdrCollection
    DataObject.WhereFilter = dlvry_hdrData.WhereFilters.supcode

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_hdrsBySupplierUnpd Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_hdrsBySupplierUnpd() As dlvry_hdrCollection
    DataObject.WhereFilter = dlvry_hdrData.WhereFilters.SupplierUnpd

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_hdrsByunpaid Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function Getdlvry_hdrsByunpaid() As dlvry_hdrCollection
    DataObject.WhereFilter = dlvry_hdrData.WhereFilters.unpaid

    Return BuildCollection()
  End Function
#End Region

#Region "Getdlvry_hdrsByFK_dlvry_hdr_suppliersEntity Method"
  Public Function Getdlvry_hdrsByFK_dlvry_hdr_suppliersEntity(ByVal entityObject As suppliers) As dlvry_hdrCollection
     If entityObject IsNot Nothing Then
       Try
         If DataObject.UseStoredProcs Then
         Else
           DataObject.WhereFilter = dlvry_hdrData.WhereFilters.supcode
         End If
         Entity.supcode = entityObject.supcode
             
      Catch ex As Exception
        ' This is here for design time exceptions
        System.Diagnostics.Debug.WriteLine(ex.Message)

      End Try

       Return BuildCollection()
     Else
       Return New dlvry_hdrCollection()
     End If
  End Function
#End Region

End Class

