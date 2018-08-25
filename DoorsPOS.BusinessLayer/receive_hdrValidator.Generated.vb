Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the receive_hdr class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class receive_hdrValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the receive_hdrValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a receive_hdr</param>
  Public Sub New(ByVal entity As receive_hdr)
    MyBase.New()

    _Entity = entity
    ClassName = "receive_hdrValidator"

    ' Create Properties for each field in the receive_hdr entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As receive_hdr
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As receive_hdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As receive_hdr)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current receive_hdr
  ''' </summary>
  ''' <returns>A cloned receive_hdr object</returns>
  Public Function CloneEntity() As receive_hdr
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in receive_hdr
  ''' </summary>
  ''' <returns>A cloned receive_hdr object</returns>
  Public Function CloneEntity(ByVal entityToClone As receive_hdr) As receive_hdr
    Dim newEntity As New receive_hdr()

    newEntity.rid = entityToClone.rid
    newEntity.ReceiveNo = entityToClone.ReceiveNo
    newEntity.rdate = entityToClone.rdate
    newEntity.ramnt = entityToClone.ramnt
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

    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.rid, "rid", False, GetType(Integer), 10, "rid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.ReceiveNo, "Receive No", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.rdate, "rdate", True, GetType(Date), -1, "rdate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.ramnt, "ramnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.locid, "locid", True, GetType(Integer), 10, "locid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(receive_hdrValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.rid = 0
    Entity.ReceiveNo = 0
    Entity.rdate = DateTime.Now
    Entity.ramnt = 0
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

    If Properties.GetByName(receive_hdrValidator.ColumnNames.rid).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.rid).Value = Entity.rid
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.ReceiveNo).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.ReceiveNo).Value = Entity.ReceiveNo
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.rdate).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.rdate).Value = Entity.rdate
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.ramnt).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.ramnt).Value = Entity.ramnt
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.locid).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.locid).Value = Entity.locid
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(receive_hdrValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(receive_hdrValidator.ColumnNames.rid).IsNull = False Then
      Entity.rid = Properties.GetByName(receive_hdrValidator.ColumnNames.rid).GetAsInteger()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.ReceiveNo).IsNull = False Then
      Entity.ReceiveNo = Properties.GetByName(receive_hdrValidator.ColumnNames.ReceiveNo).GetAsInteger()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.rdate).IsNull = False Then
      Entity.rdate = Properties.GetByName(receive_hdrValidator.ColumnNames.rdate).GetAsDate()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.ramnt).IsNull = False Then
      Entity.ramnt = Properties.GetByName(receive_hdrValidator.ColumnNames.ramnt).GetAsDecimal()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.locid).IsNull = False Then
      Entity.locid = Properties.GetByName(receive_hdrValidator.ColumnNames.locid).GetAsInteger()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(receive_hdrValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(receive_hdrValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(receive_hdrValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(receive_hdrValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(receive_hdrValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(receive_hdrValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the receive_hdr class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'rid'
    ''' </summary>
    Public Shared ReadOnly Property rid() As String
      Get
        Return "rid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ReceiveNo'
    ''' </summary>
    Public Shared ReadOnly Property ReceiveNo() As String
      Get
        Return "ReceiveNo"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'rdate'
    ''' </summary>
    Public Shared ReadOnly Property rdate() As String
      Get
        Return "rdate"
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
