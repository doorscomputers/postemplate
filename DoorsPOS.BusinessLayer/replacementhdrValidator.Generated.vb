Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the replacementhdr class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class replacementhdrValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the replacementhdrValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a replacementhdr</param>
  Public Sub New(ByVal entity As replacementhdr)
    MyBase.New()

    _Entity = entity
    ClassName = "replacementhdrValidator"

    ' Create Properties for each field in the replacementhdr entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As replacementhdr
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As replacementhdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As replacementhdr)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current replacementhdr
  ''' </summary>
  ''' <returns>A cloned replacementhdr object</returns>
  Public Function CloneEntity() As replacementhdr
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in replacementhdr
  ''' </summary>
  ''' <returns>A cloned replacementhdr object</returns>
  Public Function CloneEntity(ByVal entityToClone As replacementhdr) As replacementhdr
    Dim newEntity As New replacementhdr()

    newEntity.repid = entityToClone.repid
    newEntity.ReplacementNo = entityToClone.ReplacementNo
    newEntity.rdate = entityToClone.rdate
    newEntity.ramnt = entityToClone.ramnt
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

    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.repid, "repid", False, GetType(Integer), 10, "repid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.ReplacementNo, "Replacement No", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.rdate, "rdate", True, GetType(Date), -1, "rdate must be filled in", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.ramnt, "ramnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(replacementhdrValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.repid = 0
    Entity.ReplacementNo = 0
    Entity.rdate = DateTime.Now
    Entity.ramnt = 0
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

    If Properties.GetByName(replacementhdrValidator.ColumnNames.repid).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.repid).Value = Entity.repid
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).Value = Entity.ReplacementNo
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).Value = Entity.rdate
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).Value = Entity.ramnt
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
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

    If Properties.GetByName(replacementhdrValidator.ColumnNames.repid).IsNull = False Then
      Entity.repid = Properties.GetByName(replacementhdrValidator.ColumnNames.repid).GetAsInteger()
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).IsNull = False Then
      Entity.ReplacementNo = Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).GetAsInteger()
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).IsNull = False Then
      Entity.rdate = Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).GetAsDate()
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).IsNull = False Then
      Entity.ramnt = Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).GetAsDecimal()
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the replacementhdr class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'repid'
    ''' </summary>
    Public Shared ReadOnly Property repid() As String
      Get
        Return "repid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ReplacementNo'
    ''' </summary>
    Public Shared ReadOnly Property ReplacementNo() As String
      Get
        Return "ReplacementNo"
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
