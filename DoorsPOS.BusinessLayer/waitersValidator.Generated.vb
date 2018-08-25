Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the waiters class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class waitersValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the waitersValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a waiters</param>
  Public Sub New(ByVal entity As waiters)
    MyBase.New()

    _Entity = entity
    ClassName = "waitersValidator"

    ' Create Properties for each field in the waiters entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As waiters
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As waiters
    Get
      Return _Entity
    End Get
    Set(ByVal value As waiters)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current waiters
  ''' </summary>
  ''' <returns>A cloned waiters object</returns>
  Public Function CloneEntity() As waiters
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in waiters
  ''' </summary>
  ''' <returns>A cloned waiters object</returns>
  Public Function CloneEntity(ByVal entityToClone As waiters) As waiters
    Dim newEntity As New waiters()

    newEntity.wtid = entityToClone.wtid
    newEntity.waiter = entityToClone.waiter
    newEntity.pword = entityToClone.pword

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(waitersValidator.ColumnNames.wtid, "wtid", False, GetType(Integer), 10, "wtid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(waitersValidator.ColumnNames.waiter, "waiter", True, GetType(String), 50, "waiter must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(waitersValidator.ColumnNames.pword, "pword", False, GetType(String), 10, "", Nothing, Nothing, 0, String.Empty, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.wtid = 0
    Entity.waiter = String.Empty
    Entity.pword = String.Empty

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

    If Properties.GetByName(waitersValidator.ColumnNames.wtid).SetAsNull = False Then
      Properties.GetByName(waitersValidator.ColumnNames.wtid).Value = Entity.wtid
    End If
    If Properties.GetByName(waitersValidator.ColumnNames.waiter).SetAsNull = False Then
      Properties.GetByName(waitersValidator.ColumnNames.waiter).Value = Entity.waiter
    End If
    If Properties.GetByName(waitersValidator.ColumnNames.pword).SetAsNull = False Then
      Properties.GetByName(waitersValidator.ColumnNames.pword).Value = Entity.pword
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

    If Properties.GetByName(waitersValidator.ColumnNames.wtid).IsNull = False Then
      Entity.wtid = Properties.GetByName(waitersValidator.ColumnNames.wtid).GetAsInteger()
    End If
    If Properties.GetByName(waitersValidator.ColumnNames.waiter).IsNull = False Then
      Entity.waiter = Properties.GetByName(waitersValidator.ColumnNames.waiter).GetAsString()
    End If
    If Properties.GetByName(waitersValidator.ColumnNames.pword).IsNull = False Then
      Entity.pword = Properties.GetByName(waitersValidator.ColumnNames.pword).GetAsString()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the waiters class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'wtid'
    ''' </summary>
    Public Shared ReadOnly Property wtid() As String
      Get
        Return "wtid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'waiter'
    ''' </summary>
    Public Shared ReadOnly Property waiter() As String
      Get
        Return "waiter"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pword'
    ''' </summary>
    Public Shared ReadOnly Property pword() As String
      Get
        Return "pword"
      End Get
    End Property
  End Class
#End Region
End Class
