Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the podettmp class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class podettmpValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the podettmpValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a podettmp</param>
  Public Sub New(ByVal entity As podettmp)
    MyBase.New()

    _Entity = entity
    ClassName = "podettmpValidator"

    ' Create Properties for each field in the podettmp entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As podettmp
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As podettmp
    Get
      Return _Entity
    End Get
    Set(ByVal value As podettmp)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current podettmp
  ''' </summary>
  ''' <returns>A cloned podettmp object</returns>
  Public Function CloneEntity() As podettmp
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in podettmp
  ''' </summary>
  ''' <returns>A cloned podettmp object</returns>
  Public Function CloneEntity(ByVal entityToClone As podettmp) As podettmp
    Dim newEntity As New podettmp()

    newEntity.podetid = entityToClone.podetid
    newEntity.poidtmp = entityToClone.poidtmp
    newEntity.stckid = entityToClone.stckid
    newEntity.cost = entityToClone.cost
    newEntity.qty = entityToClone.qty
    newEntity.podetamnt = entityToClone.podetamnt
    newEntity.dravlbl = entityToClone.dravlbl
    newEntity.preavlbl = entityToClone.preavlbl
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

    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.podetid, "podetid", False, GetType(Integer), 10, "podetid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.poidtmp, "poidtmp", True, GetType(Integer), 10, "poidtmp must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.cost, "cost", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.qty, "qty", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.podetamnt, "podetamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.dravlbl, "dravlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.preavlbl, "preavlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(podettmpValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.podetid = 0
    Entity.poidtmp = 0
    Entity.stckid = 0
    Entity.cost = 0
    Entity.qty = 0
    Entity.podetamnt = 0
    Entity.dravlbl = 0
    Entity.preavlbl = 0
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

    If Properties.GetByName(podettmpValidator.ColumnNames.podetid).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.podetid).Value = Entity.podetid
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.poidtmp).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.poidtmp).Value = Entity.poidtmp
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.cost).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.cost).Value = Entity.cost
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.qty).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.qty).Value = Entity.qty
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.podetamnt).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.podetamnt).Value = Entity.podetamnt
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.dravlbl).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.dravlbl).Value = Entity.dravlbl
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.preavlbl).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.preavlbl).Value = Entity.preavlbl
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(podettmpValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(podettmpValidator.ColumnNames.podetid).IsNull = False Then
      Entity.podetid = Properties.GetByName(podettmpValidator.ColumnNames.podetid).GetAsInteger()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.poidtmp).IsNull = False Then
      Entity.poidtmp = Properties.GetByName(podettmpValidator.ColumnNames.poidtmp).GetAsInteger()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(podettmpValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.cost).IsNull = False Then
      Entity.cost = Properties.GetByName(podettmpValidator.ColumnNames.cost).GetAsDecimal()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.qty).IsNull = False Then
      Entity.qty = Properties.GetByName(podettmpValidator.ColumnNames.qty).GetAsInteger()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.podetamnt).IsNull = False Then
      Entity.podetamnt = Properties.GetByName(podettmpValidator.ColumnNames.podetamnt).GetAsDecimal()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.dravlbl).IsNull = False Then
      Entity.dravlbl = Properties.GetByName(podettmpValidator.ColumnNames.dravlbl).GetAsInteger()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.preavlbl).IsNull = False Then
      Entity.preavlbl = Properties.GetByName(podettmpValidator.ColumnNames.preavlbl).GetAsInteger()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(podettmpValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(podettmpValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(podettmpValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(podettmpValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(podettmpValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(podettmpValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the podettmp class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'podetid'
    ''' </summary>
    Public Shared ReadOnly Property podetid() As String
      Get
        Return "podetid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'poidtmp'
    ''' </summary>
    Public Shared ReadOnly Property poidtmp() As String
      Get
        Return "poidtmp"
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
    ''' Returns 'podetamnt'
    ''' </summary>
    Public Shared ReadOnly Property podetamnt() As String
      Get
        Return "podetamnt"
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
