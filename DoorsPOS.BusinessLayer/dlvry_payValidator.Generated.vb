Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the dlvry_pay class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class dlvry_payValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the dlvry_payValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a dlvry_pay</param>
  Public Sub New(ByVal entity As dlvry_pay)
    MyBase.New()

    _Entity = entity
    ClassName = "dlvry_payValidator"

    ' Create Properties for each field in the dlvry_pay entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As dlvry_pay
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As dlvry_pay
    Get
      Return _Entity
    End Get
    Set(ByVal value As dlvry_pay)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current dlvry_pay
  ''' </summary>
  ''' <returns>A cloned dlvry_pay object</returns>
  Public Function CloneEntity() As dlvry_pay
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in dlvry_pay
  ''' </summary>
  ''' <returns>A cloned dlvry_pay object</returns>
  Public Function CloneEntity(ByVal entityToClone As dlvry_pay) As dlvry_pay
    Dim newEntity As New dlvry_pay()

    newEntity.payid = entityToClone.payid
    newEntity.paydate = entityToClone.paydate
    newEntity.prevbal = entityToClone.prevbal
    newEntity.amntpaid = entityToClone.amntpaid
    newEntity.chqno = entityToClone.chqno
    newEntity.chqdate = entityToClone.chqdate
    newEntity.supcode = entityToClone.supcode
    newEntity.remarks = entityToClone.remarks
    newEntity.drinv = entityToClone.drinv
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid
    newEntity.drid = entityToClone.drid

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.payid, "payid", False, GetType(Integer), 10, "payid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.paydate, "paydate", True, GetType(Date), -1, "paydate must be filled in", Convert.ToDateTime("01/01/1953 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.prevbal, "prevbal", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.amntpaid, "amntpaid", True, GetType(Decimal), 19, "amntpaid must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.chqno, "chqno", False, GetType(String), 20, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.chqdate, "chqdate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/53 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/99 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.supcode, "supcode", False, GetType(String), 4, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.remarks, "remarks", False, GetType(String), 100, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.drinv, "drinv", False, GetType(String), 15, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/53 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/99 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/53 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/99 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_payValidator.ColumnNames.drid, "drid", True, GetType(Integer), 10, "drid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.payid = 0
    Entity.paydate = DateTime.Now
    Entity.prevbal = 0
    Entity.amntpaid = 0
    Entity.chqno = String.Empty
    Entity.chqdate = DateTime.Now
    Entity.supcode = String.Empty
    Entity.remarks = String.Empty
    Entity.drinv = String.Empty
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0
    Entity.drid = 0

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

    If Properties.GetByName(dlvry_payValidator.ColumnNames.payid).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.payid).Value = Entity.payid
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.paydate).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.paydate).Value = Entity.paydate
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.prevbal).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.prevbal).Value = Entity.prevbal
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.amntpaid).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.amntpaid).Value = Entity.amntpaid
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.chqno).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.chqno).Value = Entity.chqno
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.chqdate).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.chqdate).Value = Entity.chqdate
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.supcode).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.supcode).Value = Entity.supcode
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.remarks).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.remarks).Value = Entity.remarks
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.drinv).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.drinv).Value = Entity.drinv
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.drid).SetAsNull = False Then
      Properties.GetByName(dlvry_payValidator.ColumnNames.drid).Value = Entity.drid
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

    If Properties.GetByName(dlvry_payValidator.ColumnNames.payid).IsNull = False Then
      Entity.payid = Properties.GetByName(dlvry_payValidator.ColumnNames.payid).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.paydate).IsNull = False Then
      Entity.paydate = Properties.GetByName(dlvry_payValidator.ColumnNames.paydate).GetAsDate()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.prevbal).IsNull = False Then
      Entity.prevbal = Properties.GetByName(dlvry_payValidator.ColumnNames.prevbal).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.amntpaid).IsNull = False Then
      Entity.amntpaid = Properties.GetByName(dlvry_payValidator.ColumnNames.amntpaid).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.chqno).IsNull = False Then
      Entity.chqno = Properties.GetByName(dlvry_payValidator.ColumnNames.chqno).GetAsString()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.chqdate).IsNull = False Then
      Entity.chqdate = Properties.GetByName(dlvry_payValidator.ColumnNames.chqdate).GetAsDate()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = Properties.GetByName(dlvry_payValidator.ColumnNames.supcode).GetAsString()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.remarks).IsNull = False Then
      Entity.remarks = Properties.GetByName(dlvry_payValidator.ColumnNames.remarks).GetAsString()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.drinv).IsNull = False Then
      Entity.drinv = Properties.GetByName(dlvry_payValidator.ColumnNames.drinv).GetAsString()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(dlvry_payValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(dlvry_payValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(dlvry_payValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(dlvry_payValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(dlvry_payValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
    If Properties.GetByName(dlvry_payValidator.ColumnNames.drid).IsNull = False Then
      Entity.drid = Properties.GetByName(dlvry_payValidator.ColumnNames.drid).GetAsInteger()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the dlvry_pay class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'payid'
    ''' </summary>
    Public Shared ReadOnly Property payid() As String
      Get
        Return "payid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'paydate'
    ''' </summary>
    Public Shared ReadOnly Property paydate() As String
      Get
        Return "paydate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'prevbal'
    ''' </summary>
    Public Shared ReadOnly Property prevbal() As String
      Get
        Return "prevbal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'amntpaid'
    ''' </summary>
    Public Shared ReadOnly Property amntpaid() As String
      Get
        Return "amntpaid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'chqno'
    ''' </summary>
    Public Shared ReadOnly Property chqno() As String
      Get
        Return "chqno"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'chqdate'
    ''' </summary>
    Public Shared ReadOnly Property chqdate() As String
      Get
        Return "chqdate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'supcode'
    ''' </summary>
    Public Shared ReadOnly Property supcode() As String
      Get
        Return "supcode"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'remarks'
    ''' </summary>
    Public Shared ReadOnly Property remarks() As String
      Get
        Return "remarks"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drinv'
    ''' </summary>
    Public Shared ReadOnly Property drinv() As String
      Get
        Return "drinv"
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
    ''' <summary>
    ''' Returns 'drid'
    ''' </summary>
    Public Shared ReadOnly Property drid() As String
      Get
        Return "drid"
      End Get
    End Property
  End Class
#End Region
End Class
