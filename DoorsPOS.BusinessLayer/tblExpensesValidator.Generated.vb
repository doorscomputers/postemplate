Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the tblExpenses class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class tblExpensesValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the tblExpensesValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a tblExpenses</param>
  Public Sub New(ByVal entity As tblExpenses)
    MyBase.New()

    _Entity = entity
    ClassName = "tblExpensesValidator"

    ' Create Properties for each field in the tblExpenses entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As tblExpenses
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As tblExpenses
    Get
      Return _Entity
    End Get
    Set(ByVal value As tblExpenses)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current tblExpenses
  ''' </summary>
  ''' <returns>A cloned tblExpenses object</returns>
  Public Function CloneEntity() As tblExpenses
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in tblExpenses
  ''' </summary>
  ''' <returns>A cloned tblExpenses object</returns>
  Public Function CloneEntity(ByVal entityToClone As tblExpenses) As tblExpenses
    Dim newEntity As New tblExpenses()

    newEntity.expenseid = entityToClone.expenseid
    newEntity.expdesc = entityToClone.expdesc
    newEntity.sinsertid = entityToClone.sinsertid
    newEntity.sinsertdt = entityToClone.sinsertdt
    newEntity.modifiedby = entityToClone.modifiedby
    newEntity.modifiedon = entityToClone.modifiedon

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(tblExpensesValidator.ColumnNames.expenseid, "expenseid", False, GetType(Integer), 10, "expenseid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblExpensesValidator.ColumnNames.expdesc, "expdesc", True, GetType(String), 50, "expdesc must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblExpensesValidator.ColumnNames.sinsertid, "sinsertid", True, GetType(String), 50, "sinsertid must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblExpensesValidator.ColumnNames.sinsertdt, "sinsert dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(tblExpensesValidator.ColumnNames.modifiedby, "modified by", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblExpensesValidator.ColumnNames.modifiedon, "modified on", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.expenseid = 0
    Entity.expdesc = String.Empty
    Entity.sinsertid = String.Empty
    Entity.sinsertdt = DateTime.Now
    Entity.modifiedby = String.Empty
    Entity.modifiedon = DateTime.Now

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

    If Properties.GetByName(tblExpensesValidator.ColumnNames.expenseid).SetAsNull = False Then
      Properties.GetByName(tblExpensesValidator.ColumnNames.expenseid).Value = Entity.expenseid
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.expdesc).SetAsNull = False Then
      Properties.GetByName(tblExpensesValidator.ColumnNames.expdesc).Value = Entity.expdesc
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.sinsertid).SetAsNull = False Then
      Properties.GetByName(tblExpensesValidator.ColumnNames.sinsertid).Value = Entity.sinsertid
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.sinsertdt).SetAsNull = False Then
      Properties.GetByName(tblExpensesValidator.ColumnNames.sinsertdt).Value = Entity.sinsertdt
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.modifiedby).SetAsNull = False Then
      Properties.GetByName(tblExpensesValidator.ColumnNames.modifiedby).Value = Entity.modifiedby
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.modifiedon).SetAsNull = False Then
      Properties.GetByName(tblExpensesValidator.ColumnNames.modifiedon).Value = Entity.modifiedon
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

    If Properties.GetByName(tblExpensesValidator.ColumnNames.expenseid).IsNull = False Then
      Entity.expenseid = Properties.GetByName(tblExpensesValidator.ColumnNames.expenseid).GetAsInteger()
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.expdesc).IsNull = False Then
      Entity.expdesc = Properties.GetByName(tblExpensesValidator.ColumnNames.expdesc).GetAsString()
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.sinsertid).IsNull = False Then
      Entity.sinsertid = Properties.GetByName(tblExpensesValidator.ColumnNames.sinsertid).GetAsString()
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.sinsertdt).IsNull = False Then
      Entity.sinsertdt = Properties.GetByName(tblExpensesValidator.ColumnNames.sinsertdt).GetAsDate()
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.modifiedby).IsNull = False Then
      Entity.modifiedby = Properties.GetByName(tblExpensesValidator.ColumnNames.modifiedby).GetAsString()
    End If
    If Properties.GetByName(tblExpensesValidator.ColumnNames.modifiedon).IsNull = False Then
      Entity.modifiedon = Properties.GetByName(tblExpensesValidator.ColumnNames.modifiedon).GetAsDate()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the tblExpenses class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'expenseid'
    ''' </summary>
    Public Shared ReadOnly Property expenseid() As String
      Get
        Return "expenseid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'expdesc'
    ''' </summary>
    Public Shared ReadOnly Property expdesc() As String
      Get
        Return "expdesc"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sinsertid'
    ''' </summary>
    Public Shared ReadOnly Property sinsertid() As String
      Get
        Return "sinsertid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sinsert_dt'
    ''' </summary>
    Public Shared ReadOnly Property sinsertdt() As String
      Get
        Return "sinsert_dt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'modified_by'
    ''' </summary>
    Public Shared ReadOnly Property modifiedby() As String
      Get
        Return "modified_by"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'modified_on'
    ''' </summary>
    Public Shared ReadOnly Property modifiedon() As String
      Get
        Return "modified_on"
      End Get
    End Property
  End Class
#End Region
End Class
