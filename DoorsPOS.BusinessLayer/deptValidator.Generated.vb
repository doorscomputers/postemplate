Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the dept class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class deptValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the deptValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a dept</param>
  Public Sub New(ByVal entity As dept)
    MyBase.New()

    _Entity = entity
    ClassName = "deptValidator"

    ' Create Properties for each field in the dept entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As dept
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As dept
    Get
      Return _Entity
    End Get
    Set(ByVal value As dept)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current dept
  ''' </summary>
  ''' <returns>A cloned dept object</returns>
  Public Function CloneEntity() As dept
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in dept
  ''' </summary>
  ''' <returns>A cloned dept object</returns>
  Public Function CloneEntity(ByVal entityToClone As dept) As dept
    Dim newEntity As New dept()

    newEntity.deptid = entityToClone.deptid
    newEntity.DEPT = entityToClone.DEPT
    newEntity.DEPTD = entityToClone.DEPTD
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(deptValidator.ColumnNames.deptid, "deptid", False, GetType(Integer), 10, "deptid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(deptValidator.ColumnNames.DEPT, "DEPT", False, GetType(String), 20, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(deptValidator.ColumnNames.DEPTD, "DEPTD", True, GetType(String), 50, "Brand must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(deptValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(deptValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(deptValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(deptValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(deptValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.deptid = 0
    Entity.DEPT = String.Empty
    Entity.DEPTD = String.Empty
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0

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

    If Properties.GetByName(deptValidator.ColumnNames.deptid).SetAsNull = False Then
      Properties.GetByName(deptValidator.ColumnNames.deptid).Value = Entity.deptid
    End If
    If Properties.GetByName(deptValidator.ColumnNames.DEPT).SetAsNull = False Then
      Properties.GetByName(deptValidator.ColumnNames.DEPT).Value = Entity.DEPT
    End If
    If Properties.GetByName(deptValidator.ColumnNames.DEPTD).SetAsNull = False Then
      Properties.GetByName(deptValidator.ColumnNames.DEPTD).Value = Entity.DEPTD
    End If
    If Properties.GetByName(deptValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(deptValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(deptValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(deptValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(deptValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(deptValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(deptValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(deptValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(deptValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(deptValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(deptValidator.ColumnNames.deptid).IsNull = False Then
      Entity.deptid = Properties.GetByName(deptValidator.ColumnNames.deptid).GetAsInteger()
    End If
    If Properties.GetByName(deptValidator.ColumnNames.DEPT).IsNull = False Then
      Entity.DEPT = Properties.GetByName(deptValidator.ColumnNames.DEPT).GetAsString()
    End If
    If Properties.GetByName(deptValidator.ColumnNames.DEPTD).IsNull = False Then
      Entity.DEPTD = Properties.GetByName(deptValidator.ColumnNames.DEPTD).GetAsString()
    End If
    If Properties.GetByName(deptValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(deptValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(deptValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(deptValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(deptValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(deptValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(deptValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(deptValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(deptValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(deptValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the dept class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'deptid'
    ''' </summary>
    Public Shared ReadOnly Property deptid() As String
      Get
        Return "deptid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'DEPT'
    ''' </summary>
    Public Shared ReadOnly Property DEPT() As String
      Get
        Return "DEPT"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'DEPTD'
    ''' </summary>
    Public Shared ReadOnly Property DEPTD() As String
      Get
        Return "DEPTD"
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
    ''' Returns 'dtInsert_dt'
    ''' </summary>
    Public Shared ReadOnly Property dtInsertdt() As String
      Get
        Return "dtInsert_dt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sLastUpdate_id'
    ''' </summary>
    Public Shared ReadOnly Property sLastUpdateid() As String
      Get
        Return "sLastUpdate_id"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'dtLastUpdate_dt'
    ''' </summary>
    Public Shared ReadOnly Property dtLastUpdatedt() As String
      Get
        Return "dtLastUpdate_dt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'iConcurrency_id'
    ''' </summary>
    Public Shared ReadOnly Property iConcurrencyid() As String
      Get
        Return "iConcurrency_id"
      End Get
    End Property
  End Class
#End Region
End Class
