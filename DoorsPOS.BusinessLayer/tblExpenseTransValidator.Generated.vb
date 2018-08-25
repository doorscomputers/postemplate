Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the tblExpenseTrans class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class tblExpenseTransValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the tblExpenseTransValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a tblExpenseTrans</param>
  Public Sub New(ByVal entity As tblExpenseTrans)
    MyBase.New()

    _Entity = entity
    ClassName = "tblExpenseTransValidator"

    ' Create Properties for each field in the tblExpenseTrans entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As tblExpenseTrans
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As tblExpenseTrans
    Get
      Return _Entity
    End Get
    Set(ByVal value As tblExpenseTrans)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current tblExpenseTrans
  ''' </summary>
  ''' <returns>A cloned tblExpenseTrans object</returns>
  Public Function CloneEntity() As tblExpenseTrans
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in tblExpenseTrans
  ''' </summary>
  ''' <returns>A cloned tblExpenseTrans object</returns>
  Public Function CloneEntity(ByVal entityToClone As tblExpenseTrans) As tblExpenseTrans
    Dim newEntity As New tblExpenseTrans()

    newEntity.exptransid = entityToClone.exptransid
    newEntity.expdate = entityToClone.expdate
    newEntity.expamount = entityToClone.expamount
    newEntity.expremarks = entityToClone.expremarks
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.expenseid = entityToClone.expenseid
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

    props.Add(PDSAProperty.Create(tblExpenseTransValidator.ColumnNames.exptransid, "exptransid", False, GetType(Integer), 10, "exptransid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblExpenseTransValidator.ColumnNames.expdate, "expdate", True, GetType(Date), -1, "expdate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(tblExpenseTransValidator.ColumnNames.expamount, "expamount", True, GetType(Decimal), 18, "expamount must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblExpenseTransValidator.ColumnNames.expremarks, "expremarks", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblExpenseTransValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblExpenseTransValidator.ColumnNames.expenseid, "expenseid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblExpenseTransValidator.ColumnNames.modifiedby, "modified by", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblExpenseTransValidator.ColumnNames.modifiedon, "modified on", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.exptransid = 0
    Entity.expdate = DateTime.Now
    Entity.expamount = 0
    Entity.expremarks = String.Empty
    Entity.sInsertid = String.Empty
    Entity.expenseid = 0
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

    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).SetAsNull = False Then
      Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).Value = Entity.exptransid
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).SetAsNull = False Then
      Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).Value = Entity.expdate
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).SetAsNull = False Then
      Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).Value = Entity.expamount
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).SetAsNull = False Then
      Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).Value = Entity.expremarks
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).SetAsNull = False Then
      Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).Value = Entity.expenseid
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).SetAsNull = False Then
      Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).Value = Entity.modifiedby
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).SetAsNull = False Then
      Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).Value = Entity.modifiedon
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

    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).IsNull = False Then
      Entity.exptransid = Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).GetAsInteger()
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).IsNull = False Then
      Entity.expdate = Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).GetAsDate()
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).IsNull = False Then
      Entity.expamount = Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).GetAsDecimal()
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).IsNull = False Then
      Entity.expremarks = Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).GetAsString()
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).IsNull = False Then
      Entity.expenseid = Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).GetAsInteger()
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).IsNull = False Then
      Entity.modifiedby = Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).GetAsString()
    End If
    If Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).IsNull = False Then
      Entity.modifiedon = Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).GetAsDate()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the tblExpenseTrans class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'exptransid'
    ''' </summary>
    Public Shared ReadOnly Property exptransid() As String
      Get
        Return "exptransid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'expdate'
    ''' </summary>
    Public Shared ReadOnly Property expdate() As String
      Get
        Return "expdate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'expamount'
    ''' </summary>
    Public Shared ReadOnly Property expamount() As String
      Get
        Return "expamount"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'expremarks'
    ''' </summary>
    Public Shared ReadOnly Property expremarks() As String
      Get
        Return "expremarks"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sInsert_id'
    ''' </summary>
    Public Shared ReadOnly Property sInsertid() As String
      Get
        Return "sInsert_id"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'expenseid'
    ''' </summary>
    Public Shared ReadOnly Property expenseid() As String
      Get
        Return "expenseid"
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
