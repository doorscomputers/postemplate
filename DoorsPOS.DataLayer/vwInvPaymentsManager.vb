Imports System
Imports System.Collections.Generic
Imports System.Data

Imports PDSA
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class is used to call the view vwInvPayments
''' This class is generated using the Haystack Code Generator for .NET Utility.
''' You may add additional methods to this class.
''' </summary>
Partial Public Class vwInvPaymentsManager
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
  Private _Entity As vwInvPayments 
  Private _DataObject As vwInvPaymentsData
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the entity class. This the class that contains one property for each column in the table.
  ''' Setting this property will also set the Entity class in the DataObject class too.
  ''' </summary>
  Public Property Entity() As vwInvPayments
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwInvPayments)
      _Entity = value
      If _DataObject IsNot Nothing Then
        _DataObject.Entity = value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set the data class that contains the logic for loading the Entity class
  ''' </summary>
  Public Property DataObject() As vwInvPaymentsData
    Get
      Return _DataObject
    End Get
    Set(ByVal value As vwInvPaymentsData)
      _DataObject = value
    End Set
  End Property
#End Region

#Region "Init Method"
  Protected Overrides Sub Init()
    ' Create Entity Class if not created
    If Entity Is Nothing Then
      Entity = New vwInvPayments()
    End If

    ' Create Data Class if not created
    If _DataObject Is Nothing Then
      _DataObject = New vwInvPaymentsData(DataProvider, Entity)
    End If

    ClassName = "vwInvPaymentsManager"
  End Sub
#End Region

#Region "BuildCollection Method"
  ''' <summary>
  ''' Returns a collection of vwInvPayments classes based
  ''' </summary>
  ''' <returns>vwInvPaymentsCollection</returns>
  Public Function BuildCollection() As vwInvPaymentsCollection
    Dim coll As New vwInvPaymentsCollection()
    Dim newEntity As vwInvPayments
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

#Region "GetvwInvPaymentsBysupplier Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwInvPaymentsBysupplier() As vwInvPaymentsCollection
    DataObject.WhereFilter = vwInvPaymentsData.WhereFilters.supplier

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwInvPaymentsByLikesupplier Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwInvPaymentsByLikesupplier() As vwInvPaymentsCollection
    DataObject.WhereFilter = vwInvPaymentsData.WhereFilters.Likesupplier

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwInvPaymentsBybetweenpaydate Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwInvPaymentsBybetweenpaydate() As vwInvPaymentsCollection
    DataObject.WhereFilter = vwInvPaymentsData.WhereFilters.betweenpaydate

    Return BuildCollection()
  End Function
#End Region

#Region "GetvwInvPaymentsBychq Method"
  ''' <summary>
  ''' Set the specified WhereFilter and call the BuildCollection() method
  ''' </summary>
  Public Function GetvwInvPaymentsBychq() As vwInvPaymentsCollection
    DataObject.WhereFilter = vwInvPaymentsData.WhereFilters.chq

    Return BuildCollection()
  End Function
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current vwInvPayments
  ''' </summary>
  ''' <returns>A cloned vwInvPayments object</returns>
  Public Function CloneEntity() As vwInvPayments
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in vwInvPayments
  ''' </summary>
  ''' <returns>A cloned vwInvPayments object</returns>
  Public Function CloneEntity(ByVal entityToClone As vwInvPayments) As vwInvPayments
    Dim newEntity As New vwInvPayments()

    newEntity.payid = entityToClone.payid
    newEntity.paydate = entityToClone.paydate
    newEntity.supcode = entityToClone.supcode
    newEntity.amntpaid = entityToClone.amntpaid
    newEntity.supplier = entityToClone.supplier
    newEntity.chqno = entityToClone.chqno
    newEntity.bank = entityToClone.bank
    newEntity.drinv = entityToClone.drinv
    newEntity.amnt = entityToClone.amnt

    Return newEntity
  End Function
#End Region

End Class
