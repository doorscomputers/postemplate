Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the transfer_det class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class transfer_detValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the transfer_detValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a transfer_det</param>
  Public Sub New(ByVal entity As transfer_det)
    MyBase.New()

    _Entity = entity
    ClassName = "transfer_detValidator"

    ' Create Properties for each field in the transfer_det entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As transfer_det
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As transfer_det
    Get
      Return _Entity
    End Get
    Set(ByVal value As transfer_det)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current transfer_det
  ''' </summary>
  ''' <returns>A cloned transfer_det object</returns>
  Public Function CloneEntity() As transfer_det
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in transfer_det
  ''' </summary>
  ''' <returns>A cloned transfer_det object</returns>
  Public Function CloneEntity(ByVal entityToClone As transfer_det) As transfer_det
    Dim newEntity As New transfer_det()

    newEntity.tdetid = entityToClone.tdetid
    newEntity.tid = entityToClone.tid
    newEntity.stckid = entityToClone.stckid
    newEntity.price = entityToClone.price
    newEntity.qty = entityToClone.qty
    newEntity.tamnt = entityToClone.tamnt
    newEntity.prevavlbl = entityToClone.prevavlbl
    newEntity.currentavlbl = entityToClone.currentavlbl
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid
    newEntity.trpsted = entityToClone.trpsted

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.tdetid, "tdetid", False, GetType(Integer), 10, "tdetid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.tid, "tid", True, GetType(Integer), 10, "tid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.price, "price", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.qty, "qty", True, GetType(Integer), 10, "qty must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.tamnt, "tamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.prevavlbl, "prevavlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.currentavlbl, "currentavlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(transfer_detValidator.ColumnNames.trpsted, "trpsted", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.tdetid = 0
    Entity.tid = 0
    Entity.stckid = 0
    Entity.price = 0
    Entity.qty = 0
    Entity.tamnt = 0
    Entity.prevavlbl = 0
    Entity.currentavlbl = 0
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0
    Entity.trpsted = False

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

    If Properties.GetByName(transfer_detValidator.ColumnNames.tdetid).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.tdetid).Value = Entity.tdetid
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.tid).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.tid).Value = Entity.tid
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.price).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.price).Value = Entity.price
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.qty).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.qty).Value = Entity.qty
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.tamnt).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.tamnt).Value = Entity.tamnt
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.prevavlbl).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.prevavlbl).Value = Entity.prevavlbl
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.currentavlbl).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.currentavlbl).Value = Entity.currentavlbl
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.trpsted).SetAsNull = False Then
      Properties.GetByName(transfer_detValidator.ColumnNames.trpsted).Value = Entity.trpsted
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

    If Properties.GetByName(transfer_detValidator.ColumnNames.tdetid).IsNull = False Then
      Entity.tdetid = Properties.GetByName(transfer_detValidator.ColumnNames.tdetid).GetAsInteger()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.tid).IsNull = False Then
      Entity.tid = Properties.GetByName(transfer_detValidator.ColumnNames.tid).GetAsInteger()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(transfer_detValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.price).IsNull = False Then
      Entity.price = Properties.GetByName(transfer_detValidator.ColumnNames.price).GetAsDecimal()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.qty).IsNull = False Then
      Entity.qty = Properties.GetByName(transfer_detValidator.ColumnNames.qty).GetAsInteger()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.tamnt).IsNull = False Then
      Entity.tamnt = Properties.GetByName(transfer_detValidator.ColumnNames.tamnt).GetAsDecimal()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.prevavlbl).IsNull = False Then
      Entity.prevavlbl = Properties.GetByName(transfer_detValidator.ColumnNames.prevavlbl).GetAsInteger()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.currentavlbl).IsNull = False Then
      Entity.currentavlbl = Properties.GetByName(transfer_detValidator.ColumnNames.currentavlbl).GetAsInteger()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(transfer_detValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(transfer_detValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(transfer_detValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(transfer_detValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(transfer_detValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
    If Properties.GetByName(transfer_detValidator.ColumnNames.trpsted).IsNull = False Then
      Entity.trpsted = Properties.GetByName(transfer_detValidator.ColumnNames.trpsted).GetValueAsBoolean()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the transfer_det class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'tdetid'
    ''' </summary>
    Public Shared ReadOnly Property tdetid() As String
      Get
        Return "tdetid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'tid'
    ''' </summary>
    Public Shared ReadOnly Property tid() As String
      Get
        Return "tid"
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
    ''' Returns 'price'
    ''' </summary>
    Public Shared ReadOnly Property price() As String
      Get
        Return "price"
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
    ''' Returns 'tamnt'
    ''' </summary>
    Public Shared ReadOnly Property tamnt() As String
      Get
        Return "tamnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'prevavlbl'
    ''' </summary>
    Public Shared ReadOnly Property prevavlbl() As String
      Get
        Return "prevavlbl"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'currentavlbl'
    ''' </summary>
    Public Shared ReadOnly Property currentavlbl() As String
      Get
        Return "currentavlbl"
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
    ''' Returns 'trpsted'
    ''' </summary>
    Public Shared ReadOnly Property trpsted() As String
      Get
        Return "trpsted"
      End Get
    End Property
  End Class
#End Region
End Class
