Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwSuspendHdr
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwSuspendHdrManager
  Inherits PDSADataClassManagerReadOnlyBase

#Region "Your Custom Properties and Methods"
    
#End Region

#Region "Constructors"
  Public Sub New()
    Init()
  End Sub

  Public Sub New(ByVal dataProvider As PDSADataProvider)
    MyBase.DataProvider = dataProvider

    Init()
  End Sub
#End Region

#Region "Private Variables"
  ' NOTE: Do not initialize these here.
  Private _Entity As vwSuspendHdr 
  Private _DataObject As vwSuspendHdrData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwSuspendHdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwSuspendHdr)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwSuspendHdrData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwSuspendHdrData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwSuspendHdr()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwSuspendHdrData(DataProvider, Entity)
    End If

    ClassName = "vwSuspendHdrManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwSuspendHdr classes based
  ''' </summary>
  ''' <returns>vwSuspendHdrCollection</returns>
  Public Function BuildCollection() As vwSuspendHdrCollection
    Dim coll As New vwSuspendHdrCollection()
    Dim newEntity As vwSuspendHdr
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

#Region "GetvwSuspendHdrsByCashier Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendHdrsByCashier() As vwSuspendHdrCollection
    DataObject.WhereFilter = vwSuspendHdrData.WhereFilters.Cashier

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendHdrsByLikesInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendHdrsByLikesInsert_id() As vwSuspendHdrCollection
    DataObject.WhereFilter = vwSuspendHdrData.WhereFilters.LikesInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendHdrsBysInsert_id Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendHdrsBysInsert_id() As vwSuspendHdrCollection
    DataObject.WhereFilter = vwSuspendHdrData.WhereFilters.sInsert_id

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwSuspendHdrsBycashstatus Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwSuspendHdrsBycashstatus() As vwSuspendHdrCollection
    DataObject.WhereFilter = vwSuspendHdrData.WhereFilters.cashstatus

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwSuspendHdr
  ''' </summary>
  ''' <returns>A cloned vwSuspendHdr object</returns>
  Public Function CloneEntity() As vwSuspendHdr
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwSuspendHdr
  ''' </summary>
  ''' <returns>A cloned vwSuspendHdr object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwSuspendHdr) As vwSuspendHdr
    Dim newEntity As New vwSuspendHdr()

    newEntity.postmphdrid = entityToClone.postmphdrid
    newEntity.posdate = entityToClone.posdate
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.status = entityToClone.status

    Return newEntity
  End Function
#End Region

End Class
