Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the transfer_hdr class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class transfer_hdrValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the transfer_hdrValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a transfer_hdr</param>
  Public Sub New(ByVal entity As transfer_hdr)
    MyBase.New()

    _Entity = entity
    ClassName = "transfer_hdrValidator"

    ' Create Properties for each field in the transfer_hdr entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As transfer_hdr
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As transfer_hdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As transfer_hdr)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current transfer_hdr
  ''' </summary>
  ''' <returns>A cloned transfer_hdr object</returns>
  Public Function CloneEntity() As transfer_hdr
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in transfer_hdr
  ''' </summary>
  ''' <returns>A cloned transfer_hdr object</returns>
  Public Function CloneEntity(ByVal entityToClone As transfer_hdr) As transfer_hdr
    Dim newEntity As New transfer_hdr()

    newEntity.tid = entityToClone.tid
    newEntity.TransferNo = entityToClone.TransferNo
    newEntity.tdate = entityToClone.tdate
    newEntity.tamnt = entityToClone.tamnt
    newEntity.locid = entityToClone.locid
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

    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.tid, "tid", False, GetType(Integer), 10, "tid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.TransferNo, "Transfer No", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.tdate, "tdate", True, GetType(Date), -1, "tdate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.tamnt, "tamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.locid, "locid", True, GetType(Integer), 10, "locid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(transfer_hdrValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.tid = 0
    Entity.TransferNo = 0
    Entity.tdate = DateTime.Now
    Entity.tamnt = 0
    Entity.locid = 0
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

    If Properties.GetByName(transfer_hdrValidator.ColumnNames.tid).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.tid).Value = Entity.tid
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.TransferNo).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.TransferNo).Value = Entity.TransferNo
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.tdate).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.tdate).Value = Entity.tdate
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.tamnt).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.tamnt).Value = Entity.tamnt
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.locid).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.locid).Value = Entity.locid
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(transfer_hdrValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(transfer_hdrValidator.ColumnNames.tid).IsNull = False Then
      Entity.tid = Properties.GetByName(transfer_hdrValidator.ColumnNames.tid).GetAsInteger()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.TransferNo).IsNull = False Then
      Entity.TransferNo = Properties.GetByName(transfer_hdrValidator.ColumnNames.TransferNo).GetAsInteger()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.tdate).IsNull = False Then
      Entity.tdate = Properties.GetByName(transfer_hdrValidator.ColumnNames.tdate).GetAsDate()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.tamnt).IsNull = False Then
      Entity.tamnt = Properties.GetByName(transfer_hdrValidator.ColumnNames.tamnt).GetAsDecimal()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.locid).IsNull = False Then
      Entity.locid = Properties.GetByName(transfer_hdrValidator.ColumnNames.locid).GetAsInteger()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(transfer_hdrValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(transfer_hdrValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(transfer_hdrValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(transfer_hdrValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(transfer_hdrValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(transfer_hdrValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the transfer_hdr class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'tid'
    ''' </summary>
    Public Shared ReadOnly Property tid() As String
      Get
        Return "tid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'TransferNo'
    ''' </summary>
    Public Shared ReadOnly Property TransferNo() As String
      Get
        Return "TransferNo"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'tdate'
    ''' </summary>
    Public Shared ReadOnly Property tdate() As String
      Get
        Return "tdate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'tamnt'
    ''' </summary>
    Public Shared ReadOnly Property tamnt() As String
      Get
        Return "tamnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'locid'
    ''' </summary>
    Public Shared ReadOnly Property locid() As String
      Get
        Return "locid"
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
