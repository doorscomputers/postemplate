Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the paymnthdr class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class paymnthdrValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the paymnthdrValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a paymnthdr</param>
  Public Sub New(ByVal entity As paymnthdr)
    MyBase.New()

    _Entity = entity
    ClassName = "paymnthdrValidator"

    ' Create Properties for each field in the paymnthdr entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As paymnthdr
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As paymnthdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As paymnthdr)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current paymnthdr
  ''' </summary>
  ''' <returns>A cloned paymnthdr object</returns>
  Public Function CloneEntity() As paymnthdr
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in paymnthdr
  ''' </summary>
  ''' <returns>A cloned paymnthdr object</returns>
  Public Function CloneEntity(ByVal entityToClone As paymnthdr) As paymnthdr
    Dim newEntity As New paymnthdr()

    newEntity.payid = entityToClone.payid
    newEntity.paydate = entityToClone.paydate
    newEntity.supcode = entityToClone.supcode
    newEntity.paytypeid = entityToClone.paytypeid
    newEntity.amntpaid = entityToClone.amntpaid
    newEntity.amntwords = entityToClone.amntwords
    newEntity.discount = entityToClone.discount
    newEntity.chqno = entityToClone.chqno
    newEntity.bankid = entityToClone.bankid
    newEntity.chqdate = entityToClone.chqdate
    newEntity.remarks = entityToClone.remarks
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

    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.payid, "payid", False, GetType(Integer), 10, "payid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.paydate, "paydate", True, GetType(Date), -1, "paydate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.supcode, "supcode", True, GetType(Integer), 10, "supcode must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.paytypeid, "paytypeid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.amntpaid, "amntpaid", True, GetType(Decimal), 19, "amntpaid must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.amntwords, "amntwords", False, GetType(String), 150, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.discount, "discount", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.chqno, "chqno", True, GetType(String), 20, "chqno must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.bankid, "bankid", True, GetType(Integer), 10, "bankid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.chqdate, "chqdate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.remarks, "remarks", False, GetType(String), 150, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Nothing, Nothing, 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Nothing, Nothing, 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(paymnthdrValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
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
    Entity.supcode = 0
    Entity.paytypeid = 0
    Entity.amntpaid = 0
    Entity.amntwords = String.Empty
    Entity.discount = 0
    Entity.chqno = String.Empty
    Entity.bankid = 0
    Entity.chqdate = DateTime.Now
    Entity.remarks = String.Empty
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

    If Properties.GetByName(paymnthdrValidator.ColumnNames.payid).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.payid).Value = Entity.payid
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).Value = Entity.paydate
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).Value = Entity.supcode
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).Value = Entity.paytypeid
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).Value = Entity.amntpaid
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).Value = Entity.amntwords
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.discount).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.discount).Value = Entity.discount
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).Value = Entity.chqno
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).Value = Entity.bankid
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).Value = Entity.chqdate
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).Value = Entity.remarks
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(paymnthdrValidator.ColumnNames.payid).IsNull = False Then
      Entity.payid = Properties.GetByName(paymnthdrValidator.ColumnNames.payid).GetAsInteger()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).IsNull = False Then
      Entity.paydate = Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).GetAsDate()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).GetAsInteger()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).IsNull = False Then
      Entity.paytypeid = Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).GetAsInteger()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).IsNull = False Then
      Entity.amntpaid = Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).GetAsDecimal()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).IsNull = False Then
      Entity.amntwords = Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).GetAsString()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.discount).IsNull = False Then
      Entity.discount = Properties.GetByName(paymnthdrValidator.ColumnNames.discount).GetAsDecimal()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).IsNull = False Then
      Entity.chqno = Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).GetAsString()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).IsNull = False Then
      Entity.bankid = Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).GetAsInteger()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).IsNull = False Then
      Entity.chqdate = Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).GetAsDate()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).IsNull = False Then
      Entity.remarks = Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).GetAsString()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the paymnthdr class.
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
    ''' Returns 'supcode'
    ''' </summary>
    Public Shared ReadOnly Property supcode() As String
      Get
        Return "supcode"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'paytypeid'
    ''' </summary>
    Public Shared ReadOnly Property paytypeid() As String
      Get
        Return "paytypeid"
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
    ''' Returns 'amntwords'
    ''' </summary>
    Public Shared ReadOnly Property amntwords() As String
      Get
        Return "amntwords"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'discount'
    ''' </summary>
    Public Shared ReadOnly Property discount() As String
      Get
        Return "discount"
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
    ''' Returns 'bankid'
    ''' </summary>
    Public Shared ReadOnly Property bankid() As String
      Get
        Return "bankid"
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
    ''' Returns 'remarks'
    ''' </summary>
    Public Shared ReadOnly Property remarks() As String
      Get
        Return "remarks"
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
