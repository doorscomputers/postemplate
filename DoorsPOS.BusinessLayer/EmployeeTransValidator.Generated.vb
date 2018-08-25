Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the EmployeeTrans class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class EmployeeTransValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the EmployeeTransValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a EmployeeTrans</param>
  Public Sub New(ByVal entity As EmployeeTrans)
    MyBase.New()

    _Entity = entity
    ClassName = "EmployeeTransValidator"

    ' Create Properties for each field in the EmployeeTrans entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As EmployeeTrans
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As EmployeeTrans
    Get
      Return _Entity
    End Get
    Set(ByVal value As EmployeeTrans)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current EmployeeTrans
  ''' </summary>
  ''' <returns>A cloned EmployeeTrans object</returns>
  Public Function CloneEntity() As EmployeeTrans
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in EmployeeTrans
  ''' </summary>
  ''' <returns>A cloned EmployeeTrans object</returns>
  Public Function CloneEntity(ByVal entityToClone As EmployeeTrans) As EmployeeTrans
    Dim newEntity As New EmployeeTrans()

    newEntity.linoutid = entityToClone.linoutid
    newEntity.empin = entityToClone.empin
    newEntity.empbreak = entityToClone.empbreak
    newEntity.empbreakin = entityToClone.empbreakin
    newEntity.empout = entityToClone.empout
    newEntity.fkwtid = entityToClone.fkwtid
    newEntity.stats = entityToClone.stats
    newEntity.trandate = entityToClone.trandate
    newEntity.bempin = entityToClone.bempin
    newEntity.bempbreak = entityToClone.bempbreak
    newEntity.bempbreakin = entityToClone.bempbreakin
    newEntity.bbreakout = entityToClone.bbreakout

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.linoutid, "linoutid", False, GetType(Integer), 10, "linoutid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.empin, "empin", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.empbreak, "empbreak", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.empbreakin, "empbreakin", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.empout, "empout", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.fkwtid, "fkwtid", True, GetType(Integer), 10, "fkwtid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.stats, "stats", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.trandate, "trandate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.bempin, "bempin", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.bempbreak, "bempbreak", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.bempbreakin, "bempbreakin", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(EmployeeTransValidator.ColumnNames.bbreakout, "bbreakout", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.linoutid = 0
    Entity.empin = DateTime.Now
    Entity.empbreak = DateTime.Now
    Entity.empbreakin = DateTime.Now
    Entity.empout = DateTime.Now
    Entity.fkwtid = 0
    Entity.stats = False
    Entity.trandate = DateTime.Now
    Entity.bempin = False
    Entity.bempbreak = False
    Entity.bempbreakin = False
    Entity.bbreakout = False

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

    If Properties.GetByName(EmployeeTransValidator.ColumnNames.linoutid).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.linoutid).Value = Entity.linoutid
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.empin).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.empin).Value = Entity.empin
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.empbreak).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.empbreak).Value = Entity.empbreak
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.empbreakin).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.empbreakin).Value = Entity.empbreakin
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.empout).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.empout).Value = Entity.empout
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.fkwtid).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.fkwtid).Value = Entity.fkwtid
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.stats).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.stats).Value = Entity.stats
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.trandate).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.trandate).Value = Entity.trandate
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.bempin).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.bempin).Value = Entity.bempin
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.bempbreak).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.bempbreak).Value = Entity.bempbreak
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.bempbreakin).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.bempbreakin).Value = Entity.bempbreakin
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.bbreakout).SetAsNull = False Then
      Properties.GetByName(EmployeeTransValidator.ColumnNames.bbreakout).Value = Entity.bbreakout
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

    If Properties.GetByName(EmployeeTransValidator.ColumnNames.linoutid).IsNull = False Then
      Entity.linoutid = Properties.GetByName(EmployeeTransValidator.ColumnNames.linoutid).GetAsInteger()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.empin).IsNull = False Then
      Entity.empin = Properties.GetByName(EmployeeTransValidator.ColumnNames.empin).GetAsDate()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.empbreak).IsNull = False Then
      Entity.empbreak = Properties.GetByName(EmployeeTransValidator.ColumnNames.empbreak).GetAsDate()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.empbreakin).IsNull = False Then
      Entity.empbreakin = Properties.GetByName(EmployeeTransValidator.ColumnNames.empbreakin).GetAsDate()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.empout).IsNull = False Then
      Entity.empout = Properties.GetByName(EmployeeTransValidator.ColumnNames.empout).GetAsDate()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.fkwtid).IsNull = False Then
      Entity.fkwtid = Properties.GetByName(EmployeeTransValidator.ColumnNames.fkwtid).GetAsInteger()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.stats).IsNull = False Then
      Entity.stats = Properties.GetByName(EmployeeTransValidator.ColumnNames.stats).GetValueAsBoolean()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.trandate).IsNull = False Then
      Entity.trandate = Properties.GetByName(EmployeeTransValidator.ColumnNames.trandate).GetAsDate()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.bempin).IsNull = False Then
      Entity.bempin = Properties.GetByName(EmployeeTransValidator.ColumnNames.bempin).GetValueAsBoolean()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.bempbreak).IsNull = False Then
      Entity.bempbreak = Properties.GetByName(EmployeeTransValidator.ColumnNames.bempbreak).GetValueAsBoolean()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.bempbreakin).IsNull = False Then
      Entity.bempbreakin = Properties.GetByName(EmployeeTransValidator.ColumnNames.bempbreakin).GetValueAsBoolean()
    End If
    If Properties.GetByName(EmployeeTransValidator.ColumnNames.bbreakout).IsNull = False Then
      Entity.bbreakout = Properties.GetByName(EmployeeTransValidator.ColumnNames.bbreakout).GetValueAsBoolean()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the EmployeeTrans class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'linoutid'
    ''' </summary>
    Public Shared ReadOnly Property linoutid() As String
      Get
        Return "linoutid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'empin'
    ''' </summary>
    Public Shared ReadOnly Property empin() As String
      Get
        Return "empin"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'empbreak'
    ''' </summary>
    Public Shared ReadOnly Property empbreak() As String
      Get
        Return "empbreak"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'empbreakin'
    ''' </summary>
    Public Shared ReadOnly Property empbreakin() As String
      Get
        Return "empbreakin"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'empout'
    ''' </summary>
    Public Shared ReadOnly Property empout() As String
      Get
        Return "empout"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'fkwtid'
    ''' </summary>
    Public Shared ReadOnly Property fkwtid() As String
      Get
        Return "fkwtid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'stats'
    ''' </summary>
    Public Shared ReadOnly Property stats() As String
      Get
        Return "stats"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'trandate'
    ''' </summary>
    Public Shared ReadOnly Property trandate() As String
      Get
        Return "trandate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'bempin'
    ''' </summary>
    Public Shared ReadOnly Property bempin() As String
      Get
        Return "bempin"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'bempbreak'
    ''' </summary>
    Public Shared ReadOnly Property bempbreak() As String
      Get
        Return "bempbreak"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'bempbreakin'
    ''' </summary>
    Public Shared ReadOnly Property bempbreakin() As String
      Get
        Return "bempbreakin"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'bbreakout'
    ''' </summary>
    Public Shared ReadOnly Property bbreakout() As String
      Get
        Return "bbreakout"
      End Get
    End Property
  End Class
#End Region
End Class
