Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the AdvPayment class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class AdvPaymentValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the AdvPaymentValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a AdvPayment</param>
  Public Sub New(ByVal entity As AdvPayment)
    MyBase.New()

    _Entity = entity
    ClassName = "AdvPaymentValidator"

    ' Create Properties for each field in the AdvPayment entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As AdvPayment
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As AdvPayment
    Get
      Return _Entity
    End Get
    Set(ByVal value As AdvPayment)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current AdvPayment
  ''' </summary>
  ''' <returns>A cloned AdvPayment object</returns>
  Public Function CloneEntity() As AdvPayment
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in AdvPayment
  ''' </summary>
  ''' <returns>A cloned AdvPayment object</returns>
  Public Function CloneEntity(ByVal entityToClone As AdvPayment) As AdvPayment
    Dim newEntity As New AdvPayment()

    newEntity.advid = entityToClone.advid
    newEntity.datepaid = entityToClone.datepaid
    newEntity.custid = entityToClone.custid
    newEntity.amountpaid = entityToClone.amountpaid
    newEntity.claimed = entityToClone.claimed
    newEntity.Remarks = entityToClone.Remarks
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

    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.advid, "advid", False, GetType(Integer), 10, "advid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.datepaid, "datepaid", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.custid, "custid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.amountpaid, "amountpaid", False, GetType(Decimal), 8, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.claimed, "claimed", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.Remarks, "Remarks", False, GetType(String), 1073741823, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(AdvPaymentValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.advid = 0
    Entity.datepaid = DateTime.Now
    Entity.custid = 0
    Entity.amountpaid = 0
    Entity.claimed = False
    Entity.Remarks = String.Empty
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

    If Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).Value = Entity.advid
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).Value = Entity.datepaid
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).Value = Entity.custid
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).Value = Entity.amountpaid
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).Value = Entity.claimed
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).Value = Entity.Remarks
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).IsNull = False Then
      Entity.advid = Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).GetAsInteger()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).IsNull = False Then
      Entity.datepaid = Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).GetAsDate()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).IsNull = False Then
      Entity.custid = Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).GetAsInteger()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).IsNull = False Then
      Entity.amountpaid = Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).GetAsDecimal()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).IsNull = False Then
      Entity.claimed = Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).GetValueAsBoolean()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).IsNull = False Then
      Entity.Remarks = Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).GetAsString()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the AdvPayment class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'advid'
    ''' </summary>
    Public Shared ReadOnly Property advid() As String
      Get
        Return "advid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'datepaid'
    ''' </summary>
    Public Shared ReadOnly Property datepaid() As String
      Get
        Return "datepaid"
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
    ''' Returns 'amountpaid'
    ''' </summary>
    Public Shared ReadOnly Property amountpaid() As String
      Get
        Return "amountpaid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'claimed'
    ''' </summary>
    Public Shared ReadOnly Property claimed() As String
      Get
        Return "claimed"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Remarks'
    ''' </summary>
    Public Shared ReadOnly Property Remarks() As String
      Get
        Return "Remarks"
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
