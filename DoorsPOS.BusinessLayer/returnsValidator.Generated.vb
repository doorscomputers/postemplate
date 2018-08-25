Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the returns class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class returnsValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the returnsValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a returns</param>
  Public Sub New(ByVal entity As returns)
    MyBase.New()

    _Entity = entity
    ClassName = "returnsValidator"

    ' Create Properties for each field in the returns entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As returns
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As returns
    Get
      Return _Entity
    End Get
    Set(ByVal value As returns)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current returns
  ''' </summary>
  ''' <returns>A cloned returns object</returns>
  Public Function CloneEntity() As returns
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in returns
  ''' </summary>
  ''' <returns>A cloned returns object</returns>
  Public Function CloneEntity(ByVal entityToClone As returns) As returns
    Dim newEntity As New returns()

    newEntity.retid = entityToClone.retid
    newEntity.custid = entityToClone.custid
    newEntity.posdate = entityToClone.posdate
    newEntity.stckid = entityToClone.stckid
    newEntity.rprice = entityToClone.rprice
    newEntity.rqty = entityToClone.rqty
    newEntity.ramnt = entityToClone.ramnt
    newEntity.rdisc = entityToClone.rdisc
    newEntity.rdiscamnt = entityToClone.rdiscamnt
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

    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.retid, "retid", False, GetType(Integer), 10, "retid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.custid, "custid", True, GetType(Integer), 10, "custid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.posdate, "posdate", True, GetType(Date), -1, "posdate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.rprice, "rprice", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.rqty, "rqty", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.ramnt, "ramnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.rdisc, "rdisc", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.rdiscamnt, "rdiscamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(returnsValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.retid = 0
    Entity.custid = 0
    Entity.posdate = DateTime.Now
    Entity.stckid = 0
    Entity.rprice = 0
    Entity.rqty = 0
    Entity.ramnt = 0
    Entity.rdisc = 0
    Entity.rdiscamnt = 0
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

    If Properties.GetByName(returnsValidator.ColumnNames.retid).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.retid).Value = Entity.retid
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.custid).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.custid).Value = Entity.custid
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.posdate).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.posdate).Value = Entity.posdate
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.rprice).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.rprice).Value = Entity.rprice
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.rqty).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.rqty).Value = Entity.rqty
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.ramnt).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.ramnt).Value = Entity.ramnt
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.rdisc).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.rdisc).Value = Entity.rdisc
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.rdiscamnt).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.rdiscamnt).Value = Entity.rdiscamnt
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(returnsValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(returnsValidator.ColumnNames.retid).IsNull = False Then
      Entity.retid = Properties.GetByName(returnsValidator.ColumnNames.retid).GetAsInteger()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.custid).IsNull = False Then
      Entity.custid = Properties.GetByName(returnsValidator.ColumnNames.custid).GetAsInteger()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.posdate).IsNull = False Then
      Entity.posdate = Properties.GetByName(returnsValidator.ColumnNames.posdate).GetAsDate()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(returnsValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.rprice).IsNull = False Then
      Entity.rprice = Properties.GetByName(returnsValidator.ColumnNames.rprice).GetAsDecimal()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.rqty).IsNull = False Then
      Entity.rqty = Properties.GetByName(returnsValidator.ColumnNames.rqty).GetAsInteger()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.ramnt).IsNull = False Then
      Entity.ramnt = Properties.GetByName(returnsValidator.ColumnNames.ramnt).GetAsDecimal()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.rdisc).IsNull = False Then
      Entity.rdisc = Properties.GetByName(returnsValidator.ColumnNames.rdisc).GetAsInteger()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.rdiscamnt).IsNull = False Then
      Entity.rdiscamnt = Properties.GetByName(returnsValidator.ColumnNames.rdiscamnt).GetAsDecimal()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(returnsValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(returnsValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(returnsValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(returnsValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(returnsValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(returnsValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the returns class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'retid'
    ''' </summary>
    Public Shared ReadOnly Property retid() As String
      Get
        Return "retid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'custid'
    ''' </summary>
    Public Shared ReadOnly Property custid() As String
      Get
        Return "custid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'posdate'
    ''' </summary>
    Public Shared ReadOnly Property posdate() As String
      Get
        Return "posdate"
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
    ''' Returns 'rprice'
    ''' </summary>
    Public Shared ReadOnly Property rprice() As String
      Get
        Return "rprice"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'rqty'
    ''' </summary>
    Public Shared ReadOnly Property rqty() As String
      Get
        Return "rqty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ramnt'
    ''' </summary>
    Public Shared ReadOnly Property ramnt() As String
      Get
        Return "ramnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'rdisc'
    ''' </summary>
    Public Shared ReadOnly Property rdisc() As String
      Get
        Return "rdisc"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'rdiscamnt'
    ''' </summary>
    Public Shared ReadOnly Property rdiscamnt() As String
      Get
        Return "rdiscamnt"
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
