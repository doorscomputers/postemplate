Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the chkpay class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class chkpayValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the chkpayValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a chkpay</param>
  Public Sub New(ByVal entity As chkpay)
    MyBase.New()

    _Entity = entity
    ClassName = "chkpayValidator"

    ' Create Properties for each field in the chkpay entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As chkpay
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As chkpay
    Get
      Return _Entity
    End Get
    Set(ByVal value As chkpay)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current chkpay
  ''' </summary>
  ''' <returns>A cloned chkpay object</returns>
  Public Function CloneEntity() As chkpay
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in chkpay
  ''' </summary>
  ''' <returns>A cloned chkpay object</returns>
  Public Function CloneEntity(ByVal entityToClone As chkpay) As chkpay
    Dim newEntity As New chkpay()

    newEntity.chekid = entityToClone.chekid
    newEntity.chkdate = entityToClone.chkdate
    newEntity.payee = entityToClone.payee
    newEntity.amnt = entityToClone.amnt
    newEntity.chkno = entityToClone.chkno
    newEntity.bank = entityToClone.bank
    newEntity.chkremark = entityToClone.chkremark
    newEntity.cashier = entityToClone.cashier
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

    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.chekid, "chekid", False, GetType(Integer), 10, "chekid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.chkdate, "chkdate", True, GetType(Date), -1, "chkdate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.payee, "payee", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.amnt, "amnt", True, GetType(Decimal), 18, "amnt must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.chkno, "chkno", False, GetType(String), 20, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.bank, "bank", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.chkremark, "chkremark", False, GetType(String), 1073741823, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.cashier, "cashier", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(chkpayValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.chekid = 0
    Entity.chkdate = DateTime.Now
    Entity.payee = String.Empty
    Entity.amnt = 0
    Entity.chkno = String.Empty
    Entity.bank = String.Empty
    Entity.chkremark = String.Empty
    Entity.cashier = String.Empty
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

    If Properties.GetByName(chkpayValidator.ColumnNames.chekid).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.chekid).Value = Entity.chekid
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.chkdate).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.chkdate).Value = Entity.chkdate
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.payee).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.payee).Value = Entity.payee
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.amnt).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.amnt).Value = Entity.amnt
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.chkno).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.chkno).Value = Entity.chkno
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.bank).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.bank).Value = Entity.bank
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.chkremark).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.chkremark).Value = Entity.chkremark
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.cashier).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.cashier).Value = Entity.cashier
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(chkpayValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(chkpayValidator.ColumnNames.chekid).IsNull = False Then
      Entity.chekid = Properties.GetByName(chkpayValidator.ColumnNames.chekid).GetAsInteger()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.chkdate).IsNull = False Then
      Entity.chkdate = Properties.GetByName(chkpayValidator.ColumnNames.chkdate).GetAsDate()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.payee).IsNull = False Then
      Entity.payee = Properties.GetByName(chkpayValidator.ColumnNames.payee).GetAsString()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.amnt).IsNull = False Then
      Entity.amnt = Properties.GetByName(chkpayValidator.ColumnNames.amnt).GetAsDecimal()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.chkno).IsNull = False Then
      Entity.chkno = Properties.GetByName(chkpayValidator.ColumnNames.chkno).GetAsString()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.bank).IsNull = False Then
      Entity.bank = Properties.GetByName(chkpayValidator.ColumnNames.bank).GetAsString()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.chkremark).IsNull = False Then
      Entity.chkremark = Properties.GetByName(chkpayValidator.ColumnNames.chkremark).GetAsString()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.cashier).IsNull = False Then
      Entity.cashier = Properties.GetByName(chkpayValidator.ColumnNames.cashier).GetAsString()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(chkpayValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(chkpayValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(chkpayValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(chkpayValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(chkpayValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(chkpayValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the chkpay class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'chekid'
    ''' </summary>
    Public Shared ReadOnly Property chekid() As String
      Get
        Return "chekid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'chkdate'
    ''' </summary>
    Public Shared ReadOnly Property chkdate() As String
      Get
        Return "chkdate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'payee'
    ''' </summary>
    Public Shared ReadOnly Property payee() As String
      Get
        Return "payee"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'amnt'
    ''' </summary>
    Public Shared ReadOnly Property amnt() As String
      Get
        Return "amnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'chkno'
    ''' </summary>
    Public Shared ReadOnly Property chkno() As String
      Get
        Return "chkno"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'bank'
    ''' </summary>
    Public Shared ReadOnly Property bank() As String
      Get
        Return "bank"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'chkremark'
    ''' </summary>
    Public Shared ReadOnly Property chkremark() As String
      Get
        Return "chkremark"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cashier'
    ''' </summary>
    Public Shared ReadOnly Property cashier() As String
      Get
        Return "cashier"
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
