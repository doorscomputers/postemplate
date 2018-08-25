Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the ChkIssued class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class ChkIssuedValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the ChkIssuedValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a ChkIssued</param>
  Public Sub New(ByVal entity As ChkIssued)
    MyBase.New()

    _Entity = entity
    ClassName = "ChkIssuedValidator"

    ' Create Properties for each field in the ChkIssued entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As ChkIssued
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As ChkIssued
    Get
      Return _Entity
    End Get
    Set(ByVal value As ChkIssued)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current ChkIssued
  ''' </summary>
  ''' <returns>A cloned ChkIssued object</returns>
  Public Function CloneEntity() As ChkIssued
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in ChkIssued
  ''' </summary>
  ''' <returns>A cloned ChkIssued object</returns>
  Public Function CloneEntity(ByVal entityToClone As ChkIssued) As ChkIssued
    Dim newEntity As New ChkIssued()

    newEntity.chkisueid = entityToClone.chkisueid
    newEntity.Trandate = entityToClone.Trandate
    newEntity.bankid = entityToClone.bankid
    newEntity.Payee = entityToClone.Payee
    newEntity.Chkdate = entityToClone.Chkdate
    newEntity.Chkno = entityToClone.Chkno
    newEntity.ChkAmnt = entityToClone.ChkAmnt
    newEntity.AmountWords = entityToClone.AmountWords
    newEntity.Cleared = entityToClone.Cleared
    newEntity.DateClrd = entityToClone.DateClrd
    newEntity.Cancelled = entityToClone.Cancelled
    newEntity.Remarks = entityToClone.Remarks
    newEntity.Invoice = entityToClone.Invoice
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdatedt = entityToClone.sLastUpdatedt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
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

    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.chkisueid, "chkisueid", False, GetType(Integer), 10, "chkisueid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.Trandate, "Trandate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.bankid, "bankid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.Payee, "Payee", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.Chkdate, "Chkdate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.Chkno, "Chkno", False, GetType(String), 12, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.ChkAmnt, "Chk Amnt", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.AmountWords, "Amount Words", False, GetType(String), 150, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.Cleared, "Cleared", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.DateClrd, "Date Clrd", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.Cancelled, "Cancelled", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.Remarks, "Remarks", False, GetType(String), 100, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.Invoice, "Invoice", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.sLastUpdatedt, "s Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(ChkIssuedValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.chkisueid = 0
    Entity.Trandate = DateTime.Now
    Entity.bankid = 0
    Entity.Payee = String.Empty
    Entity.Chkdate = DateTime.Now
    Entity.Chkno = String.Empty
    Entity.ChkAmnt = 0
    Entity.AmountWords = String.Empty
    Entity.Cleared = False
    Entity.DateClrd = DateTime.Now
    Entity.Cancelled = False
    Entity.Remarks = String.Empty
    Entity.Invoice = String.Empty
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdatedt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
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

    If Properties.GetByName(ChkIssuedValidator.ColumnNames.chkisueid).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.chkisueid).Value = Entity.chkisueid
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Trandate).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.Trandate).Value = Entity.Trandate
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.bankid).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.bankid).Value = Entity.bankid
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Payee).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.Payee).Value = Entity.Payee
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Chkdate).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.Chkdate).Value = Entity.Chkdate
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Chkno).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.Chkno).Value = Entity.Chkno
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.ChkAmnt).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.ChkAmnt).Value = Entity.ChkAmnt
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.AmountWords).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.AmountWords).Value = Entity.AmountWords
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Cleared).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.Cleared).Value = Entity.Cleared
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.DateClrd).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.DateClrd).Value = Entity.DateClrd
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Cancelled).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.Cancelled).Value = Entity.Cancelled
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Remarks).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.Remarks).Value = Entity.Remarks
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Invoice).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.Invoice).Value = Entity.Invoice
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.sLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.sLastUpdatedt).Value = Entity.sLastUpdatedt
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(ChkIssuedValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(ChkIssuedValidator.ColumnNames.chkisueid).IsNull = False Then
      Entity.chkisueid = Properties.GetByName(ChkIssuedValidator.ColumnNames.chkisueid).GetAsInteger()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Trandate).IsNull = False Then
      Entity.Trandate = Properties.GetByName(ChkIssuedValidator.ColumnNames.Trandate).GetAsDate()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.bankid).IsNull = False Then
      Entity.bankid = Properties.GetByName(ChkIssuedValidator.ColumnNames.bankid).GetAsInteger()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Payee).IsNull = False Then
      Entity.Payee = Properties.GetByName(ChkIssuedValidator.ColumnNames.Payee).GetAsString()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Chkdate).IsNull = False Then
      Entity.Chkdate = Properties.GetByName(ChkIssuedValidator.ColumnNames.Chkdate).GetAsDate()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Chkno).IsNull = False Then
      Entity.Chkno = Properties.GetByName(ChkIssuedValidator.ColumnNames.Chkno).GetAsString()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.ChkAmnt).IsNull = False Then
      Entity.ChkAmnt = Properties.GetByName(ChkIssuedValidator.ColumnNames.ChkAmnt).GetAsDecimal()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.AmountWords).IsNull = False Then
      Entity.AmountWords = Properties.GetByName(ChkIssuedValidator.ColumnNames.AmountWords).GetAsString()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Cleared).IsNull = False Then
      Entity.Cleared = Properties.GetByName(ChkIssuedValidator.ColumnNames.Cleared).GetValueAsBoolean()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.DateClrd).IsNull = False Then
      Entity.DateClrd = Properties.GetByName(ChkIssuedValidator.ColumnNames.DateClrd).GetAsDate()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Cancelled).IsNull = False Then
      Entity.Cancelled = Properties.GetByName(ChkIssuedValidator.ColumnNames.Cancelled).GetValueAsBoolean()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Remarks).IsNull = False Then
      Entity.Remarks = Properties.GetByName(ChkIssuedValidator.ColumnNames.Remarks).GetAsString()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.Invoice).IsNull = False Then
      Entity.Invoice = Properties.GetByName(ChkIssuedValidator.ColumnNames.Invoice).GetAsString()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(ChkIssuedValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(ChkIssuedValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.sLastUpdatedt).IsNull = False Then
      Entity.sLastUpdatedt = Properties.GetByName(ChkIssuedValidator.ColumnNames.sLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(ChkIssuedValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(ChkIssuedValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(ChkIssuedValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the ChkIssued class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'chkisueid'
    ''' </summary>
    Public Shared ReadOnly Property chkisueid() As String
      Get
        Return "chkisueid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Trandate'
    ''' </summary>
    Public Shared ReadOnly Property Trandate() As String
      Get
        Return "Trandate"
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
    ''' Returns 'Payee'
    ''' </summary>
    Public Shared ReadOnly Property Payee() As String
      Get
        Return "Payee"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Chkdate'
    ''' </summary>
    Public Shared ReadOnly Property Chkdate() As String
      Get
        Return "Chkdate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Chkno'
    ''' </summary>
    Public Shared ReadOnly Property Chkno() As String
      Get
        Return "Chkno"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ChkAmnt'
    ''' </summary>
    Public Shared ReadOnly Property ChkAmnt() As String
      Get
        Return "ChkAmnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'AmountWords'
    ''' </summary>
    Public Shared ReadOnly Property AmountWords() As String
      Get
        Return "AmountWords"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Cleared'
    ''' </summary>
    Public Shared ReadOnly Property Cleared() As String
      Get
        Return "Cleared"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'DateClrd'
    ''' </summary>
    Public Shared ReadOnly Property DateClrd() As String
      Get
        Return "DateClrd"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Cancelled'
    ''' </summary>
    Public Shared ReadOnly Property Cancelled() As String
      Get
        Return "Cancelled"
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
    ''' Returns 'Invoice'
    ''' </summary>
    Public Shared ReadOnly Property Invoice() As String
      Get
        Return "Invoice"
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
    ''' Returns 'sLastUpdate_dt'
    ''' </summary>
    Public Shared ReadOnly Property sLastUpdatedt() As String
      Get
        Return "sLastUpdate_dt"
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
