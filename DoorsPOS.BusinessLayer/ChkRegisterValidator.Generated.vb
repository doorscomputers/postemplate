Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the ChkRegister class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class ChkRegisterValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the ChkRegisterValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a ChkRegister</param>
  Public Sub New(ByVal entity As ChkRegister)
    MyBase.New()

    _Entity = entity
    ClassName = "ChkRegisterValidator"

    ' Create Properties for each field in the ChkRegister entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As ChkRegister
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As ChkRegister
    Get
      Return _Entity
    End Get
    Set(ByVal value As ChkRegister)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current ChkRegister
  ''' </summary>
  ''' <returns>A cloned ChkRegister object</returns>
  Public Function CloneEntity() As ChkRegister
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in ChkRegister
  ''' </summary>
  ''' <returns>A cloned ChkRegister object</returns>
  Public Function CloneEntity(ByVal entityToClone As ChkRegister) As ChkRegister
    Dim newEntity As New ChkRegister()

    newEntity.RegId = entityToClone.RegId
    newEntity.RegDate = entityToClone.RegDate
    newEntity.ChkNo = entityToClone.ChkNo
    newEntity.ChkDate = entityToClone.ChkDate
    newEntity.Issued = entityToClone.Issued
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

    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.RegId, "Reg Id", False, GetType(Integer), 10, "Reg Id must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.RegDate, "Reg Date", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.ChkNo, "Chk No", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.ChkDate, "Chk Date", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.Issued, "Issued", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkRegisterValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.RegId = 0
    Entity.RegDate = DateTime.Now
    Entity.ChkNo = 0
    Entity.ChkDate = DateTime.Now
    Entity.Issued = False
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

    If Properties.GetByName(ChkRegisterValidator.ColumnNames.RegId).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.RegId).Value = Entity.RegId
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.RegDate).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.RegDate).Value = Entity.RegDate
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.ChkNo).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.ChkNo).Value = Entity.ChkNo
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.ChkDate).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.ChkDate).Value = Entity.ChkDate
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.Issued).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.Issued).Value = Entity.Issued
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(ChkRegisterValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(ChkRegisterValidator.ColumnNames.RegId).IsNull = False Then
      Entity.RegId = Properties.GetByName(ChkRegisterValidator.ColumnNames.RegId).GetAsInteger()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.RegDate).IsNull = False Then
      Entity.RegDate = Properties.GetByName(ChkRegisterValidator.ColumnNames.RegDate).GetAsDate()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.ChkNo).IsNull = False Then
      Entity.ChkNo = Properties.GetByName(ChkRegisterValidator.ColumnNames.ChkNo).GetAsDecimal()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.ChkDate).IsNull = False Then
      Entity.ChkDate = Properties.GetByName(ChkRegisterValidator.ColumnNames.ChkDate).GetAsDate()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.Issued).IsNull = False Then
      Entity.Issued = Properties.GetByName(ChkRegisterValidator.ColumnNames.Issued).GetValueAsBoolean()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(ChkRegisterValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(ChkRegisterValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(ChkRegisterValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(ChkRegisterValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(ChkRegisterValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(ChkRegisterValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the ChkRegister class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'RegId'
    ''' </summary>
    Public Shared ReadOnly Property RegId() As String
      Get
        Return "RegId"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'RegDate'
    ''' </summary>
    Public Shared ReadOnly Property RegDate() As String
      Get
        Return "RegDate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ChkNo'
    ''' </summary>
    Public Shared ReadOnly Property ChkNo() As String
      Get
        Return "ChkNo"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ChkDate'
    ''' </summary>
    Public Shared ReadOnly Property ChkDate() As String
      Get
        Return "ChkDate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Issued'
    ''' </summary>
    Public Shared ReadOnly Property Issued() As String
      Get
        Return "Issued"
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
