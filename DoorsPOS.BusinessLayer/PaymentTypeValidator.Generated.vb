Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the PaymentType class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class PaymentTypeValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the PaymentTypeValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a PaymentType</param>
  Public Sub New(ByVal entity As PaymentType)
    MyBase.New()

    _Entity = entity
    ClassName = "PaymentTypeValidator"

    ' Create Properties for each field in the PaymentType entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As PaymentType
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As PaymentType
    Get
      Return _Entity
    End Get
    Set(ByVal value As PaymentType)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current PaymentType
  ''' </summary>
  ''' <returns>A cloned PaymentType object</returns>
  Public Function CloneEntity() As PaymentType
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in PaymentType
  ''' </summary>
  ''' <returns>A cloned PaymentType object</returns>
  Public Function CloneEntity(ByVal entityToClone As PaymentType) As PaymentType
    Dim newEntity As New PaymentType()

    newEntity.paytypeid = entityToClone.paytypeid
    newEntity.PaymentType = entityToClone.PaymentType

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(PaymentTypeValidator.ColumnNames.paytypeid, "paytypeid", False, GetType(Integer), 10, "paytypeid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(PaymentTypeValidator.ColumnNames.PaymentType, "Payment Type", True, GetType(String), 7, "Payment Type must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.paytypeid = 0
    Entity.PaymentType = String.Empty

    Entity.ResetAllIsDirtyProperties()
  End Sub
#End Region

#Region "InitProperties Method"
  ''' <summary>
  ''' Called by the constructor to create the PDSAProperties collection of all properties that will be validated.
  ''' </summary>
  Protected Overrides Sub InitProperties()
    ' Set the Properties collection to the collection of Entity Properties
    Properties = CreateProperties()
  End Sub
#End Region

#Region "EntityDataToProperties Method"
  ''' <summary>
  ''' Moves the Entity class data into the Properties collection.
  ''' </summary>
  Protected Overrides Sub EntityDataToProperties()
    If Properties Is Nothing Then
      InitProperties()
    End If

    If Properties.GetByName(PaymentTypeValidator.ColumnNames.paytypeid).SetAsNull = False Then
      Properties.GetByName(PaymentTypeValidator.ColumnNames.paytypeid).Value = Entity.paytypeid
    End If
    If Properties.GetByName(PaymentTypeValidator.ColumnNames.PaymentType).SetAsNull = False Then
      Properties.GetByName(PaymentTypeValidator.ColumnNames.PaymentType).Value = Entity.PaymentType
    End If
  End Sub
#End Region

#Region "PropertiesToEntityData Method"
  ''' <summary>
  ''' Moves the Properties collection objects into the Entity properties
  ''' </summary>
  Protected Overrides Sub PropertiesToEntityData()
    If Properties Is Nothing Then
      InitProperties()
    End If

    If Properties.GetByName(PaymentTypeValidator.ColumnNames.paytypeid).IsNull = False Then
      Entity.paytypeid = Properties.GetByName(PaymentTypeValidator.ColumnNames.paytypeid).GetAsInteger()
    End If
    If Properties.GetByName(PaymentTypeValidator.ColumnNames.PaymentType).IsNull = False Then
      Entity.PaymentType = Properties.GetByName(PaymentTypeValidator.ColumnNames.PaymentType).GetAsString()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the PaymentType class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'paytypeid'
    ''' </summary>
    Public Shared ReadOnly Property paytypeid() As String
      Get
        Return "paytypeid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'PaymentType'
    ''' </summary>
    Public Shared ReadOnly Property PaymentType() As String
      Get
        Return "PaymentType"
      End Get
    End Property
  End Class
#End Region
End Class
