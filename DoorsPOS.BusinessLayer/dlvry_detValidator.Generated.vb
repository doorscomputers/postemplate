Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the dlvry_det class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class dlvry_detValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the dlvry_detValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a dlvry_det</param>
  Public Sub New(ByVal entity As dlvry_det)
    MyBase.New()

    _Entity = entity
    ClassName = "dlvry_detValidator"

    ' Create Properties for each field in the dlvry_det entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As dlvry_det
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As dlvry_det
    Get
      Return _Entity
    End Get
    Set(ByVal value As dlvry_det)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current dlvry_det
  ''' </summary>
  ''' <returns>A cloned dlvry_det object</returns>
  Public Function CloneEntity() As dlvry_det
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in dlvry_det
  ''' </summary>
  ''' <returns>A cloned dlvry_det object</returns>
  Public Function CloneEntity(ByVal entityToClone As dlvry_det) As dlvry_det
    Dim newEntity As New dlvry_det()

    newEntity.drdetid = entityToClone.drdetid
    newEntity.drid = entityToClone.drid
    newEntity.stckid = entityToClone.stckid
    newEntity.cost = entityToClone.cost
    newEntity.qty = entityToClone.qty
    newEntity.freee = entityToClone.freee
    newEntity.disc = entityToClone.disc
    newEntity.discamnt = entityToClone.discamnt
    newEntity.drdetamnt = entityToClone.drdetamnt
    newEntity.drpck = entityToClone.drpck
    newEntity.dravlbl = entityToClone.dravlbl
    newEntity.preavlbl = entityToClone.preavlbl
    newEntity.pcs = entityToClone.pcs
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid
    newEntity.lotno = entityToClone.lotno
    newEntity.expdate = entityToClone.expdate

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.drdetid, "drdetid", False, GetType(Integer), 10, "drdetid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.drid, "drid", True, GetType(Integer), 10, "drid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.cost, "cost", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.qty, "qty", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.freee, "freee", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.disc, "disc", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.discamnt, "discamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.drdetamnt, "drdetamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.drpck, "drpck", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.dravlbl, "dravlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.preavlbl, "preavlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.pcs, "pcs", False, GetType(Decimal), 11, "", Convert.ToDecimal("-999999999.99"), Convert.ToDecimal("999999999.99"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.lotno, "lotno", False, GetType(String), 15, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(dlvry_detValidator.ColumnNames.expdate, "expdate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.drdetid = 0
    Entity.drid = 0
    Entity.stckid = 0
    Entity.cost = 0
    Entity.qty = 0
    Entity.freee = 0
    Entity.disc = 0
    Entity.discamnt = 0
    Entity.drdetamnt = 0
    Entity.drpck = 0
    Entity.dravlbl = 0
    Entity.preavlbl = 0
    Entity.pcs = 0
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0
    Entity.lotno = String.Empty
    Entity.expdate = DateTime.Now

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

    If Properties.GetByName(dlvry_detValidator.ColumnNames.drdetid).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.drdetid).Value = Entity.drdetid
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.drid).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.drid).Value = Entity.drid
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.cost).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.cost).Value = Entity.cost
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.qty).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.qty).Value = Entity.qty
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.freee).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.freee).Value = Entity.freee
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.disc).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.disc).Value = Entity.disc
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.discamnt).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.discamnt).Value = Entity.discamnt
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.drdetamnt).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.drdetamnt).Value = Entity.drdetamnt
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.drpck).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.drpck).Value = Entity.drpck
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.dravlbl).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.dravlbl).Value = Entity.dravlbl
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.preavlbl).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.preavlbl).Value = Entity.preavlbl
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.pcs).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.pcs).Value = Entity.pcs
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.lotno).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.lotno).Value = Entity.lotno
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.expdate).SetAsNull = False Then
      Properties.GetByName(dlvry_detValidator.ColumnNames.expdate).Value = Entity.expdate
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

    If Properties.GetByName(dlvry_detValidator.ColumnNames.drdetid).IsNull = False Then
      Entity.drdetid = Properties.GetByName(dlvry_detValidator.ColumnNames.drdetid).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.drid).IsNull = False Then
      Entity.drid = Properties.GetByName(dlvry_detValidator.ColumnNames.drid).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(dlvry_detValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.cost).IsNull = False Then
      Entity.cost = Properties.GetByName(dlvry_detValidator.ColumnNames.cost).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.qty).IsNull = False Then
      Entity.qty = Properties.GetByName(dlvry_detValidator.ColumnNames.qty).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.freee).IsNull = False Then
      Entity.freee = Properties.GetByName(dlvry_detValidator.ColumnNames.freee).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.disc).IsNull = False Then
      Entity.disc = Properties.GetByName(dlvry_detValidator.ColumnNames.disc).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.discamnt).IsNull = False Then
      Entity.discamnt = Properties.GetByName(dlvry_detValidator.ColumnNames.discamnt).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.drdetamnt).IsNull = False Then
      Entity.drdetamnt = Properties.GetByName(dlvry_detValidator.ColumnNames.drdetamnt).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.drpck).IsNull = False Then
      Entity.drpck = Properties.GetByName(dlvry_detValidator.ColumnNames.drpck).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.dravlbl).IsNull = False Then
      Entity.dravlbl = Properties.GetByName(dlvry_detValidator.ColumnNames.dravlbl).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.preavlbl).IsNull = False Then
      Entity.preavlbl = Properties.GetByName(dlvry_detValidator.ColumnNames.preavlbl).GetAsInteger()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.pcs).IsNull = False Then
      Entity.pcs = Properties.GetByName(dlvry_detValidator.ColumnNames.pcs).GetAsDecimal()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(dlvry_detValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(dlvry_detValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(dlvry_detValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(dlvry_detValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(dlvry_detValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.lotno).IsNull = False Then
      Entity.lotno = Properties.GetByName(dlvry_detValidator.ColumnNames.lotno).GetAsString()
    End If
    If Properties.GetByName(dlvry_detValidator.ColumnNames.expdate).IsNull = False Then
      Entity.expdate = Properties.GetByName(dlvry_detValidator.ColumnNames.expdate).GetAsDate()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the dlvry_det class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'drdetid'
    ''' </summary>
    Public Shared ReadOnly Property drdetid() As String
      Get
        Return "drdetid"
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
    ''' <summary>
    ''' Returns 'stckid'
    ''' </summary>
    Public Shared ReadOnly Property stckid() As String
      Get
        Return "stckid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cost'
    ''' </summary>
    Public Shared ReadOnly Property cost() As String
      Get
        Return "cost"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'qty'
    ''' </summary>
    Public Shared ReadOnly Property qty() As String
      Get
        Return "qty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'freee'
    ''' </summary>
    Public Shared ReadOnly Property freee() As String
      Get
        Return "freee"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'disc'
    ''' </summary>
    Public Shared ReadOnly Property disc() As String
      Get
        Return "disc"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'discamnt'
    ''' </summary>
    Public Shared ReadOnly Property discamnt() As String
      Get
        Return "discamnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drdetamnt'
    ''' </summary>
    Public Shared ReadOnly Property drdetamnt() As String
      Get
        Return "drdetamnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drpck'
    ''' </summary>
    Public Shared ReadOnly Property drpck() As String
      Get
        Return "drpck"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'dravlbl'
    ''' </summary>
    Public Shared ReadOnly Property dravlbl() As String
      Get
        Return "dravlbl"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'preavlbl'
    ''' </summary>
    Public Shared ReadOnly Property preavlbl() As String
      Get
        Return "preavlbl"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pcs'
    ''' </summary>
    Public Shared ReadOnly Property pcs() As String
      Get
        Return "pcs"
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
    ''' Returns 'lotno'
    ''' </summary>
    Public Shared ReadOnly Property lotno() As String
      Get
        Return "lotno"
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
  End Class
#End Region
End Class
