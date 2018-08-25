Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the convertstck class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class convertstckValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the convertstckValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a convertstck</param>
  Public Sub New(ByVal entity As convertstck)
    MyBase.New()

    _Entity = entity
    ClassName = "convertstckValidator"

    ' Create Properties for each field in the convertstck entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As convertstck
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As convertstck
    Get
      Return _Entity
    End Get
    Set(ByVal value As convertstck)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current convertstck
  ''' </summary>
  ''' <returns>A cloned convertstck object</returns>
  Public Function CloneEntity() As convertstck
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in convertstck
  ''' </summary>
  ''' <returns>A cloned convertstck object</returns>
  Public Function CloneEntity(ByVal entityToClone As convertstck) As convertstck
    Dim newEntity As New convertstck()

    newEntity.convertid = entityToClone.convertid
    newEntity.condate = entityToClone.condate
    newEntity.fromstckid = entityToClone.fromstckid
    newEntity.tostckid = entityToClone.tostckid
    newEntity.fromqty = entityToClone.fromqty
    newEntity.toqty = entityToClone.toqty
    newEntity.innerqty = entityToClone.innerqty
    newEntity.InsertedBy = entityToClone.InsertedBy
    newEntity.InsertedOn = entityToClone.InsertedOn
    newEntity.ModifiedBy = entityToClone.ModifiedBy
    newEntity.ModifiedOn = entityToClone.ModifiedOn

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.convertid, "convertid", False, GetType(Integer), 10, "convertid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.condate, "condate", True, GetType(Date), -1, "condate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.fromstckid, "fromstckid", True, GetType(Integer), 10, "fromstckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.tostckid, "tostckid", True, GetType(Integer), 10, "tostckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.fromqty, "fromqty", True, GetType(Integer), 10, "fromqty must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.toqty, "toqty", True, GetType(Integer), 10, "toqty must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.innerqty, "innerqty", True, GetType(Integer), 10, "innerqty must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.InsertedBy, "Inserted By", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.InsertedOn, "Inserted On", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.ModifiedBy, "Modified By", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(convertstckValidator.ColumnNames.ModifiedOn, "Modified On", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.convertid = 0
    Entity.condate = DateTime.Now
    Entity.fromstckid = 0
    Entity.tostckid = 0
    Entity.fromqty = 0
    Entity.toqty = 0
    Entity.innerqty = 0
    Entity.InsertedBy = String.Empty
    Entity.InsertedOn = DateTime.Now
    Entity.ModifiedBy = String.Empty
    Entity.ModifiedOn = DateTime.Now

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

    If Properties.GetByName(convertstckValidator.ColumnNames.convertid).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.convertid).Value = Entity.convertid
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.condate).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.condate).Value = Entity.condate
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.fromstckid).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.fromstckid).Value = Entity.fromstckid
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.tostckid).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.tostckid).Value = Entity.tostckid
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.fromqty).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.fromqty).Value = Entity.fromqty
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.toqty).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.toqty).Value = Entity.toqty
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.innerqty).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.innerqty).Value = Entity.innerqty
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.InsertedBy).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.InsertedBy).Value = Entity.InsertedBy
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.InsertedOn).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.InsertedOn).Value = Entity.InsertedOn
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.ModifiedBy).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.ModifiedBy).Value = Entity.ModifiedBy
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.ModifiedOn).SetAsNull = False Then
      Properties.GetByName(convertstckValidator.ColumnNames.ModifiedOn).Value = Entity.ModifiedOn
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

    If Properties.GetByName(convertstckValidator.ColumnNames.convertid).IsNull = False Then
      Entity.convertid = Properties.GetByName(convertstckValidator.ColumnNames.convertid).GetAsInteger()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.condate).IsNull = False Then
      Entity.condate = Properties.GetByName(convertstckValidator.ColumnNames.condate).GetAsDate()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.fromstckid).IsNull = False Then
      Entity.fromstckid = Properties.GetByName(convertstckValidator.ColumnNames.fromstckid).GetAsInteger()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.tostckid).IsNull = False Then
      Entity.tostckid = Properties.GetByName(convertstckValidator.ColumnNames.tostckid).GetAsInteger()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.fromqty).IsNull = False Then
      Entity.fromqty = Properties.GetByName(convertstckValidator.ColumnNames.fromqty).GetAsInteger()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.toqty).IsNull = False Then
      Entity.toqty = Properties.GetByName(convertstckValidator.ColumnNames.toqty).GetAsInteger()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.innerqty).IsNull = False Then
      Entity.innerqty = Properties.GetByName(convertstckValidator.ColumnNames.innerqty).GetAsInteger()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.InsertedBy).IsNull = False Then
      Entity.InsertedBy = Properties.GetByName(convertstckValidator.ColumnNames.InsertedBy).GetAsString()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.InsertedOn).IsNull = False Then
      Entity.InsertedOn = Properties.GetByName(convertstckValidator.ColumnNames.InsertedOn).GetAsDate()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.ModifiedBy).IsNull = False Then
      Entity.ModifiedBy = Properties.GetByName(convertstckValidator.ColumnNames.ModifiedBy).GetAsString()
    End If
    If Properties.GetByName(convertstckValidator.ColumnNames.ModifiedOn).IsNull = False Then
      Entity.ModifiedOn = Properties.GetByName(convertstckValidator.ColumnNames.ModifiedOn).GetAsDate()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the convertstck class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'convertid'
    ''' </summary>
    Public Shared ReadOnly Property convertid() As String
      Get
        Return "convertid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'condate'
    ''' </summary>
    Public Shared ReadOnly Property condate() As String
      Get
        Return "condate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'fromstckid'
    ''' </summary>
    Public Shared ReadOnly Property fromstckid() As String
      Get
        Return "fromstckid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'tostckid'
    ''' </summary>
    Public Shared ReadOnly Property tostckid() As String
      Get
        Return "tostckid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'fromqty'
    ''' </summary>
    Public Shared ReadOnly Property fromqty() As String
      Get
        Return "fromqty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'toqty'
    ''' </summary>
    Public Shared ReadOnly Property toqty() As String
      Get
        Return "toqty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'innerqty'
    ''' </summary>
    Public Shared ReadOnly Property innerqty() As String
      Get
        Return "innerqty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'InsertedBy'
    ''' </summary>
    Public Shared ReadOnly Property InsertedBy() As String
      Get
        Return "InsertedBy"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'InsertedOn'
    ''' </summary>
    Public Shared ReadOnly Property InsertedOn() As String
      Get
        Return "InsertedOn"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ModifiedBy'
    ''' </summary>
    Public Shared ReadOnly Property ModifiedBy() As String
      Get
        Return "ModifiedBy"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ModifiedOn'
    ''' </summary>
    Public Shared ReadOnly Property ModifiedOn() As String
      Get
        Return "ModifiedOn"
      End Get
    End Property
  End Class
#End Region
End Class
