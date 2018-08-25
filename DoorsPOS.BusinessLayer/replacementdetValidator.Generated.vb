Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the replacementdet class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class replacementdetValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the replacementdetValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a replacementdet</param>
  Public Sub New(ByVal entity As replacementdet)
    MyBase.New()

    _Entity = entity
    ClassName = "replacementdetValidator"

    ' Create Properties for each field in the replacementdet entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As replacementdet
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As replacementdet
    Get
      Return _Entity
    End Get
    Set(ByVal value As replacementdet)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current replacementdet
  ''' </summary>
  ''' <returns>A cloned replacementdet object</returns>
  Public Function CloneEntity() As replacementdet
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in replacementdet
  ''' </summary>
  ''' <returns>A cloned replacementdet object</returns>
  Public Function CloneEntity(ByVal entityToClone As replacementdet) As replacementdet
    Dim newEntity As New replacementdet()

    newEntity.repdetid = entityToClone.repdetid
    newEntity.repid = entityToClone.repid
    newEntity.stckid = entityToClone.stckid
    newEntity.price = entityToClone.price
    newEntity.qty = entityToClone.qty
    newEntity.ramnt = entityToClone.ramnt
    newEntity.prevavlbl = entityToClone.prevavlbl
    newEntity.currentavlbl = entityToClone.currentavlbl
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid
    newEntity.rrpsted = entityToClone.rrpsted

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.repdetid, "repdetid", False, GetType(Integer), 10, "repdetid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.repid, "repid", True, GetType(Integer), 10, "repid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.price, "price", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.qty, "qty", True, GetType(Integer), 10, "qty must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.ramnt, "ramnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.prevavlbl, "prevavlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.currentavlbl, "currentavlbl", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementdetValidator.ColumnNames.rrpsted, "rrpsted", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.repdetid = 0
    Entity.repid = 0
    Entity.stckid = 0
    Entity.price = 0
    Entity.qty = 0
    Entity.ramnt = 0
    Entity.prevavlbl = 0
    Entity.currentavlbl = 0
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0
    Entity.rrpsted = False

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

    If Properties.GetByName(replacementdetValidator.ColumnNames.repdetid).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.repdetid).Value = Entity.repdetid
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.repid).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.repid).Value = Entity.repid
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.price).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.price).Value = Entity.price
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.qty).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.qty).Value = Entity.qty
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.ramnt).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.ramnt).Value = Entity.ramnt
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.prevavlbl).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.prevavlbl).Value = Entity.prevavlbl
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.currentavlbl).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.currentavlbl).Value = Entity.currentavlbl
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.rrpsted).SetAsNull = False Then
      Properties.GetByName(replacementdetValidator.ColumnNames.rrpsted).Value = Entity.rrpsted
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

    If Properties.GetByName(replacementdetValidator.ColumnNames.repdetid).IsNull = False Then
      Entity.repdetid = Properties.GetByName(replacementdetValidator.ColumnNames.repdetid).GetAsInteger()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.repid).IsNull = False Then
      Entity.repid = Properties.GetByName(replacementdetValidator.ColumnNames.repid).GetAsInteger()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(replacementdetValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.price).IsNull = False Then
      Entity.price = Properties.GetByName(replacementdetValidator.ColumnNames.price).GetAsDecimal()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.qty).IsNull = False Then
      Entity.qty = Properties.GetByName(replacementdetValidator.ColumnNames.qty).GetAsInteger()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.ramnt).IsNull = False Then
      Entity.ramnt = Properties.GetByName(replacementdetValidator.ColumnNames.ramnt).GetAsDecimal()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.prevavlbl).IsNull = False Then
      Entity.prevavlbl = Properties.GetByName(replacementdetValidator.ColumnNames.prevavlbl).GetAsInteger()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.currentavlbl).IsNull = False Then
      Entity.currentavlbl = Properties.GetByName(replacementdetValidator.ColumnNames.currentavlbl).GetAsInteger()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(replacementdetValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(replacementdetValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(replacementdetValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(replacementdetValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(replacementdetValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
    If Properties.GetByName(replacementdetValidator.ColumnNames.rrpsted).IsNull = False Then
      Entity.rrpsted = Properties.GetByName(replacementdetValidator.ColumnNames.rrpsted).GetValueAsBoolean()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the replacementdet class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'repdetid'
    ''' </summary>
    Public Shared ReadOnly Property repdetid() As String
      Get
        Return "repdetid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'repid'
    ''' </summary>
    Public Shared ReadOnly Property repid() As String
      Get
        Return "repid"
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
    ''' Returns 'ramnt'
    ''' </summary>
    Public Shared ReadOnly Property ramnt() As String
      Get
        Return "ramnt"
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
    ''' Returns 'rrpsted'
    ''' </summary>
    Public Shared ReadOnly Property rrpsted() As String
      Get
        Return "rrpsted"
      End Get
    End Property
  End Class
#End Region
End Class
