Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the tbls class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class tblsValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the tblsValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a tbls</param>
  Public Sub New(ByVal entity As tbls)
    MyBase.New()

    _Entity = entity
    ClassName = "tblsValidator"

    ' Create Properties for each field in the tbls entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As tbls
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As tbls
    Get
      Return _Entity
    End Get
    Set(ByVal value As tbls)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current tbls
  ''' </summary>
  ''' <returns>A cloned tbls object</returns>
  Public Function CloneEntity() As tbls
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in tbls
  ''' </summary>
  ''' <returns>A cloned tbls object</returns>
  Public Function CloneEntity(ByVal entityToClone As tbls) As tbls
    Dim newEntity As New tbls()

    newEntity.tid = entityToClone.tid
    newEntity.tdesc = entityToClone.tdesc

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(tblsValidator.ColumnNames.tid, "tid", True, GetType(String), 10, "tid must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblsValidator.ColumnNames.tdesc, "tdesc", True, GetType(String), 50, "tdesc must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.tid = String.Empty
    Entity.tdesc = String.Empty

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

    If Properties.GetByName(tblsValidator.ColumnNames.tid).SetAsNull = False Then
      Properties.GetByName(tblsValidator.ColumnNames.tid).Value = Entity.tid
    End If
    If Properties.GetByName(tblsValidator.ColumnNames.tdesc).SetAsNull = False Then
      Properties.GetByName(tblsValidator.ColumnNames.tdesc).Value = Entity.tdesc
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

    If Properties.GetByName(tblsValidator.ColumnNames.tid).IsNull = False Then
      Entity.tid = Properties.GetByName(tblsValidator.ColumnNames.tid).GetAsString()
    End If
    If Properties.GetByName(tblsValidator.ColumnNames.tdesc).IsNull = False Then
      Entity.tdesc = Properties.GetByName(tblsValidator.ColumnNames.tdesc).GetAsString()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the tbls class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'tid'
    ''' </summary>
    Public Shared ReadOnly Property tid() As String
      Get
        Return "tid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'tdesc'
    ''' </summary>
    Public Shared ReadOnly Property tdesc() As String
      Get
        Return "tdesc"
      End Get
    End Property
  End Class
#End Region
End Class
