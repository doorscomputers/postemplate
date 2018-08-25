Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the members class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class membersValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the membersValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a members</param>
  Public Sub New(ByVal entity As members)
    MyBase.New()

    _Entity = entity
    ClassName = "membersValidator"

    ' Create Properties for each field in the members entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As members
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As members
    Get
      Return _Entity
    End Get
    Set(ByVal value As members)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current members
  ''' </summary>
  ''' <returns>A cloned members object</returns>
  Public Function CloneEntity() As members
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in members
  ''' </summary>
  ''' <returns>A cloned members object</returns>
  Public Function CloneEntity(ByVal entityToClone As members) As members
    Dim newEntity As New members()

    newEntity.CustID = entityToClone.CustID
    newEntity.lastname = entityToClone.lastname
    newEntity.firstname = entityToClone.firstname
    newEntity.middlename = entityToClone.middlename
    newEntity.address1 = entityToClone.address1
    newEntity.address2 = entityToClone.address2
    newEntity.address3 = entityToClone.address3
    newEntity.contactno = entityToClone.contactno
    newEntity.idnum = entityToClone.idnum
    newEntity.pointdiv = entityToClone.pointdiv
    newEntity.poynts = entityToClone.poynts
    newEntity.pa = entityToClone.pa
    newEntity.Balance = entityToClone.Balance
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

    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.CustID, "Cust ID", False, GetType(Integer), 10, "Cust ID must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.lastname, "lastname", True, GetType(String), 50, "lastname must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.firstname, "firstname", True, GetType(String), 50, "firstname must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.middlename, "middlename", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.address1, "address1", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.address2, "address2", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.address3, "address3", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.contactno, "contact no", False, GetType(String), 11, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.idnum, "id num", False, GetType(String), 15, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.pointdiv, "point div", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.poynts, "poynts", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.pa, "pa", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.Balance, "Balance", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(membersValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.CustID = 0
    Entity.lastname = String.Empty
    Entity.firstname = String.Empty
    Entity.middlename = String.Empty
    Entity.address1 = String.Empty
    Entity.address2 = String.Empty
    Entity.address3 = String.Empty
    Entity.contactno = String.Empty
    Entity.idnum = String.Empty
    Entity.pointdiv = 0
    Entity.poynts = 0
    Entity.pa = 0
    Entity.Balance = 0
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

    If Properties.GetByName(membersValidator.ColumnNames.CustID).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.CustID).Value = Entity.CustID
    End If
    If Properties.GetByName(membersValidator.ColumnNames.lastname).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.lastname).Value = Entity.lastname
    End If
    If Properties.GetByName(membersValidator.ColumnNames.firstname).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.firstname).Value = Entity.firstname
    End If
    If Properties.GetByName(membersValidator.ColumnNames.middlename).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.middlename).Value = Entity.middlename
    End If
    If Properties.GetByName(membersValidator.ColumnNames.address1).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.address1).Value = Entity.address1
    End If
    If Properties.GetByName(membersValidator.ColumnNames.address2).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.address2).Value = Entity.address2
    End If
    If Properties.GetByName(membersValidator.ColumnNames.address3).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.address3).Value = Entity.address3
    End If
    If Properties.GetByName(membersValidator.ColumnNames.contactno).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.contactno).Value = Entity.contactno
    End If
    If Properties.GetByName(membersValidator.ColumnNames.idnum).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.idnum).Value = Entity.idnum
    End If
    If Properties.GetByName(membersValidator.ColumnNames.pointdiv).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.pointdiv).Value = Entity.pointdiv
    End If
    If Properties.GetByName(membersValidator.ColumnNames.poynts).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.poynts).Value = Entity.poynts
    End If
    If Properties.GetByName(membersValidator.ColumnNames.pa).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.pa).Value = Entity.pa
    End If
    If Properties.GetByName(membersValidator.ColumnNames.Balance).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.Balance).Value = Entity.Balance
    End If
    If Properties.GetByName(membersValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(membersValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(membersValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(membersValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(membersValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(membersValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(membersValidator.ColumnNames.CustID).IsNull = False Then
      Entity.CustID = Properties.GetByName(membersValidator.ColumnNames.CustID).GetAsInteger()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.lastname).IsNull = False Then
      Entity.lastname = Properties.GetByName(membersValidator.ColumnNames.lastname).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.firstname).IsNull = False Then
      Entity.firstname = Properties.GetByName(membersValidator.ColumnNames.firstname).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.middlename).IsNull = False Then
      Entity.middlename = Properties.GetByName(membersValidator.ColumnNames.middlename).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.address1).IsNull = False Then
      Entity.address1 = Properties.GetByName(membersValidator.ColumnNames.address1).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.address2).IsNull = False Then
      Entity.address2 = Properties.GetByName(membersValidator.ColumnNames.address2).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.address3).IsNull = False Then
      Entity.address3 = Properties.GetByName(membersValidator.ColumnNames.address3).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.contactno).IsNull = False Then
      Entity.contactno = Properties.GetByName(membersValidator.ColumnNames.contactno).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.idnum).IsNull = False Then
      Entity.idnum = Properties.GetByName(membersValidator.ColumnNames.idnum).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.pointdiv).IsNull = False Then
      Entity.pointdiv = Properties.GetByName(membersValidator.ColumnNames.pointdiv).GetAsInteger()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.poynts).IsNull = False Then
      Entity.poynts = Properties.GetByName(membersValidator.ColumnNames.poynts).GetAsDecimal()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.pa).IsNull = False Then
      Entity.pa = Properties.GetByName(membersValidator.ColumnNames.pa).GetAsDecimal()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.Balance).IsNull = False Then
      Entity.Balance = Properties.GetByName(membersValidator.ColumnNames.Balance).GetAsDecimal()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(membersValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(membersValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(membersValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(membersValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(membersValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(membersValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the members class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'CustID'
    ''' </summary>
    Public Shared ReadOnly Property CustID() As String
      Get
        Return "CustID"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'lastname'
    ''' </summary>
    Public Shared ReadOnly Property lastname() As String
      Get
        Return "lastname"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'firstname'
    ''' </summary>
    Public Shared ReadOnly Property firstname() As String
      Get
        Return "firstname"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'middlename'
    ''' </summary>
    Public Shared ReadOnly Property middlename() As String
      Get
        Return "middlename"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'address1'
    ''' </summary>
    Public Shared ReadOnly Property address1() As String
      Get
        Return "address1"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'address2'
    ''' </summary>
    Public Shared ReadOnly Property address2() As String
      Get
        Return "address2"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'address3'
    ''' </summary>
    Public Shared ReadOnly Property address3() As String
      Get
        Return "address3"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'contact_no'
    ''' </summary>
    Public Shared ReadOnly Property contactno() As String
      Get
        Return "contact_no"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'id_num'
    ''' </summary>
    Public Shared ReadOnly Property idnum() As String
      Get
        Return "id_num"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'point_div'
    ''' </summary>
    Public Shared ReadOnly Property pointdiv() As String
      Get
        Return "point_div"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'poynts'
    ''' </summary>
    Public Shared ReadOnly Property poynts() As String
      Get
        Return "poynts"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pa'
    ''' </summary>
    Public Shared ReadOnly Property pa() As String
      Get
        Return "pa"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Balance'
    ''' </summary>
    Public Shared ReadOnly Property Balance() As String
      Get
        Return "Balance"
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
