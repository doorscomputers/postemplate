Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the suppliers class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class suppliersValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the suppliersValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a suppliers</param>
  Public Sub New(ByVal entity As suppliers)
    MyBase.New()

    _Entity = entity
    ClassName = "suppliersValidator"

    ' Create Properties for each field in the suppliers entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As suppliers
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As suppliers
    Get
      Return _Entity
    End Get
    Set(ByVal value As suppliers)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current suppliers
  ''' </summary>
  ''' <returns>A cloned suppliers object</returns>
  Public Function CloneEntity() As suppliers
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in suppliers
  ''' </summary>
  ''' <returns>A cloned suppliers object</returns>
  Public Function CloneEntity(ByVal entityToClone As suppliers) As suppliers
    Dim newEntity As New suppliers()

    newEntity.supcode = entityToClone.supcode
    newEntity.supplier = entityToClone.supplier
    newEntity.address = entityToClone.address
    newEntity.balance = entityToClone.balance
    newEntity.agent = entityToClone.agent
    newEntity.phone1 = entityToClone.phone1
    newEntity.telno = entityToClone.telno
    newEntity.faxno = entityToClone.faxno
    newEntity.tinno = entityToClone.tinno
    newEntity.consignmnt = entityToClone.consignmnt
    newEntity.lasttran = entityToClone.lasttran
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

    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.supcode, "supcode", False, GetType(Integer), 10, "supcode must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.supplier, "supplier", True, GetType(String), 50, "supplier must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.address, "address", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.balance, "balance", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.agent, "agent", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.phone1, "phone1", False, GetType(String), 30, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.telno, "telno", False, GetType(String), 15, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.faxno, "faxno", False, GetType(String), 15, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.tinno, "tinno", False, GetType(String), 20, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.consignmnt, "consignmnt", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.lasttran, "lasttran", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/53 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/99 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Nothing, Nothing, 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Nothing, Nothing, 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(suppliersValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.supcode = 0
    Entity.supplier = String.Empty
    Entity.address = String.Empty
    Entity.balance = 0
    Entity.agent = String.Empty
    Entity.phone1 = String.Empty
    Entity.telno = String.Empty
    Entity.faxno = String.Empty
    Entity.tinno = String.Empty
    Entity.consignmnt = False
    Entity.lasttran = DateTime.Now
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

    If Properties.GetByName(suppliersValidator.ColumnNames.supcode).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.supcode).Value = Entity.supcode
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.supplier).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.supplier).Value = Entity.supplier
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.address).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.address).Value = Entity.address
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.balance).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.balance).Value = Entity.balance
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.agent).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.agent).Value = Entity.agent
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.phone1).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.phone1).Value = Entity.phone1
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.telno).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.telno).Value = Entity.telno
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.faxno).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.faxno).Value = Entity.faxno
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.tinno).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.tinno).Value = Entity.tinno
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.consignmnt).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.consignmnt).Value = Entity.consignmnt
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.lasttran).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.lasttran).Value = Entity.lasttran
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(suppliersValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(suppliersValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = Properties.GetByName(suppliersValidator.ColumnNames.supcode).GetAsInteger()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.supplier).IsNull = False Then
      Entity.supplier = Properties.GetByName(suppliersValidator.ColumnNames.supplier).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.address).IsNull = False Then
      Entity.address = Properties.GetByName(suppliersValidator.ColumnNames.address).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.balance).IsNull = False Then
      Entity.balance = Properties.GetByName(suppliersValidator.ColumnNames.balance).GetAsDecimal()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.agent).IsNull = False Then
      Entity.agent = Properties.GetByName(suppliersValidator.ColumnNames.agent).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.phone1).IsNull = False Then
      Entity.phone1 = Properties.GetByName(suppliersValidator.ColumnNames.phone1).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.telno).IsNull = False Then
      Entity.telno = Properties.GetByName(suppliersValidator.ColumnNames.telno).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.faxno).IsNull = False Then
      Entity.faxno = Properties.GetByName(suppliersValidator.ColumnNames.faxno).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.tinno).IsNull = False Then
      Entity.tinno = Properties.GetByName(suppliersValidator.ColumnNames.tinno).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.consignmnt).IsNull = False Then
      Entity.consignmnt = Properties.GetByName(suppliersValidator.ColumnNames.consignmnt).GetValueAsBoolean()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.lasttran).IsNull = False Then
      Entity.lasttran = Properties.GetByName(suppliersValidator.ColumnNames.lasttran).GetAsDate()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(suppliersValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(suppliersValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(suppliersValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(suppliersValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(suppliersValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(suppliersValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the suppliers class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'supcode'
    ''' </summary>
    Public Shared ReadOnly Property supcode() As String
      Get
        Return "supcode"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'supplier'
    ''' </summary>
    Public Shared ReadOnly Property supplier() As String
      Get
        Return "supplier"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'address'
    ''' </summary>
    Public Shared ReadOnly Property address() As String
      Get
        Return "address"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'balance'
    ''' </summary>
    Public Shared ReadOnly Property balance() As String
      Get
        Return "balance"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'agent'
    ''' </summary>
    Public Shared ReadOnly Property agent() As String
      Get
        Return "agent"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'phone1'
    ''' </summary>
    Public Shared ReadOnly Property phone1() As String
      Get
        Return "phone1"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'telno'
    ''' </summary>
    Public Shared ReadOnly Property telno() As String
      Get
        Return "telno"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'faxno'
    ''' </summary>
    Public Shared ReadOnly Property faxno() As String
      Get
        Return "faxno"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'tinno'
    ''' </summary>
    Public Shared ReadOnly Property tinno() As String
      Get
        Return "tinno"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'consignmnt'
    ''' </summary>
    Public Shared ReadOnly Property consignmnt() As String
      Get
        Return "consignmnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'lasttran'
    ''' </summary>
    Public Shared ReadOnly Property lasttran() As String
      Get
        Return "lasttran"
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
