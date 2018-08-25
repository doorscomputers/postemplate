Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the dlvry_hdr class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class dlvry_hdrValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the dlvry_hdrValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a dlvry_hdr</param>
  Public Sub New(ByVal entity As dlvry_hdr)
    MyBase.New()

    _Entity = entity
    ClassName = "dlvry_hdrValidator"

    ' Create Properties for each field in the dlvry_hdr entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As dlvry_hdr
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As dlvry_hdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As dlvry_hdr)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current dlvry_hdr
  ''' </summary>
  ''' <returns>A cloned dlvry_hdr object</returns>
  Public Function CloneEntity() As dlvry_hdr
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in dlvry_hdr
  ''' </summary>
  ''' <returns>A cloned dlvry_hdr object</returns>
  Public Function CloneEntity(ByVal entityToClone As dlvry_hdr) As dlvry_hdr
    Dim newEntity As New dlvry_hdr()

    newEntity.drid = entityToClone.drid
    newEntity.drdate = entityToClone.drdate
    newEntity.drinv = entityToClone.drinv
    newEntity.supcode = entityToClone.supcode
    newEntity.terms = entityToClone.terms
    newEntity.drdue = entityToClone.drdue
    newEntity.dramnt = entityToClone.dramnt
    newEntity.drdisc = entityToClone.drdisc
    newEntity.drdscamnt = entityToClone.drdscamnt
    newEntity.drsubtot = entityToClone.drsubtot
    newEntity.drbal = entityToClone.drbal
    newEntity.paid = entityToClone.paid
    newEntity.drpsted = entityToClone.drpsted
    newEntity.ttype = entityToClone.ttype
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

    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drid, "drid", False, GetType(Integer), 10, "drid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drdate, "drdate", True, GetType(Date), -1, "drdate must be filled in", Convert.ToDateTime("01/01/1953 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drinv, "drinv", True, GetType(String), 15, "Invoice no must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.supcode, "supcode", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.terms, "terms", False, GetType(Short), 3, "", Convert.ToInt16("-999"), Convert.ToInt16("999"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drdue, "drdue", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1953 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.dramnt, "dramnt", True, GetType(Decimal), 19, "dramnt must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drdisc, "drdisc", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drdscamnt, "drdscamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drsubtot, "drsubtot", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drbal, "drbal", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.paid, "paid", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.drpsted, "drpsted", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.ttype, "ttype", False, GetType(String), 25, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1953 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1953 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_hdrValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.drid = 0
    Entity.drdate = DateTime.Now
    Entity.drinv = String.Empty
    Entity.supcode = 0
    Entity.terms = 0
    Entity.drdue = DateTime.Now
    Entity.dramnt = 0
    Entity.drdisc = 0
    Entity.drdscamnt = 0
    Entity.drsubtot = 0
    Entity.drbal = 0
    Entity.paid = False
    Entity.drpsted = False
    Entity.ttype = String.Empty
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

    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drid).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drid).Value = Entity.drid
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdate).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdate).Value = Entity.drdate
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drinv).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drinv).Value = Entity.drinv
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.supcode).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.supcode).Value = Entity.supcode
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.terms).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.terms).Value = Entity.terms
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdue).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdue).Value = Entity.drdue
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.dramnt).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.dramnt).Value = Entity.dramnt
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdisc).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdisc).Value = Entity.drdisc
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdscamnt).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdscamnt).Value = Entity.drdscamnt
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drsubtot).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drsubtot).Value = Entity.drsubtot
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drbal).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drbal).Value = Entity.drbal
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.paid).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.paid).Value = Entity.paid
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drpsted).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.drpsted).Value = Entity.drpsted
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.ttype).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.ttype).Value = Entity.ttype
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(dlvry_hdrValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drid).IsNull = False Then
      Entity.drid = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drid).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdate).IsNull = False Then
      Entity.drdate = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdate).GetAsDate()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drinv).IsNull = False Then
      Entity.drinv = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drinv).GetAsString()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = Properties.GetByName(dlvry_hdrValidator.ColumnNames.supcode).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.terms).IsNull = False Then
      Entity.terms = Properties.GetByName(dlvry_hdrValidator.ColumnNames.terms).GetAsShort()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdue).IsNull = False Then
      Entity.drdue = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdue).GetAsDate()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.dramnt).IsNull = False Then
      Entity.dramnt = Properties.GetByName(dlvry_hdrValidator.ColumnNames.dramnt).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdisc).IsNull = False Then
      Entity.drdisc = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdisc).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdscamnt).IsNull = False Then
      Entity.drdscamnt = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drdscamnt).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drsubtot).IsNull = False Then
      Entity.drsubtot = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drsubtot).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drbal).IsNull = False Then
      Entity.drbal = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drbal).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.paid).IsNull = False Then
      Entity.paid = Properties.GetByName(dlvry_hdrValidator.ColumnNames.paid).GetValueAsBoolean()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.drpsted).IsNull = False Then
      Entity.drpsted = Properties.GetByName(dlvry_hdrValidator.ColumnNames.drpsted).GetValueAsBoolean()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.ttype).IsNull = False Then
      Entity.ttype = Properties.GetByName(dlvry_hdrValidator.ColumnNames.ttype).GetAsString()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(dlvry_hdrValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(dlvry_hdrValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(dlvry_hdrValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(dlvry_hdrValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(dlvry_hdrValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(dlvry_hdrValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the dlvry_hdr class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'drid'
    ''' </summary>
    Public Shared ReadOnly Property drid() As String
      Get
        Return "drid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drdate'
    ''' </summary>
    Public Shared ReadOnly Property drdate() As String
      Get
        Return "drdate"
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
    ''' Returns 'supcode'
    ''' </summary>
    Public Shared ReadOnly Property supcode() As String
      Get
        Return "supcode"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'terms'
    ''' </summary>
    Public Shared ReadOnly Property terms() As String
      Get
        Return "terms"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drdue'
    ''' </summary>
    Public Shared ReadOnly Property drdue() As String
      Get
        Return "drdue"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'dramnt'
    ''' </summary>
    Public Shared ReadOnly Property dramnt() As String
      Get
        Return "dramnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drdisc'
    ''' </summary>
    Public Shared ReadOnly Property drdisc() As String
      Get
        Return "drdisc"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drdscamnt'
    ''' </summary>
    Public Shared ReadOnly Property drdscamnt() As String
      Get
        Return "drdscamnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drsubtot'
    ''' </summary>
    Public Shared ReadOnly Property drsubtot() As String
      Get
        Return "drsubtot"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drbal'
    ''' </summary>
    Public Shared ReadOnly Property drbal() As String
      Get
        Return "drbal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'paid'
    ''' </summary>
    Public Shared ReadOnly Property paid() As String
      Get
        Return "paid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drpsted'
    ''' </summary>
    Public Shared ReadOnly Property drpsted() As String
      Get
        Return "drpsted"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ttype'
    ''' </summary>
    Public Shared ReadOnly Property ttype() As String
      Get
        Return "ttype"
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
