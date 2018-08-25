Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the posVoid class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class posVoidValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the posVoidValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a posVoid</param>
  Public Sub New(ByVal entity As posVoid)
    MyBase.New()

    _Entity = entity
    ClassName = "posVoidValidator"

    ' Create Properties for each field in the posVoid entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As posVoid
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As posVoid
    Get
      Return _Entity
    End Get
    Set(ByVal value As posVoid)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current posVoid
  ''' </summary>
  ''' <returns>A cloned posVoid object</returns>
  Public Function CloneEntity() As posVoid
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in posVoid
  ''' </summary>
  ''' <returns>A cloned posVoid object</returns>
  Public Function CloneEntity(ByVal entityToClone As posVoid) As posVoid
    Dim newEntity As New posVoid()

    newEntity.voidid = entityToClone.voidid
    newEntity.stckid = entityToClone.stckid
    newEntity.barcode = entityToClone.barcode
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.cost = entityToClone.cost
    newEntity.price = entityToClone.price
    newEntity.pckqty = entityToClone.pckqty
    newEntity.qty = entityToClone.qty
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.voidid, "voidid", False, GetType(Integer), 10, "voidid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.stckid, "stckid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.barcode, "barcode", False, GetType(String), 22, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.itemdesc, "item desc", False, GetType(String), 1073741823, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.cost, "cost", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.price, "price", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.pckqty, "pck qty", False, GetType(Integer), 6, "", Convert.ToInt32("-999999"), Convert.ToInt32("999999"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.qty, "qty", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(posVoidValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.voidid = 0
    Entity.stckid = 0
    Entity.barcode = String.Empty
    Entity.itemdesc = String.Empty
    Entity.cost = 0
    Entity.price = 0
    Entity.pckqty = 0
    Entity.qty = 0
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now

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

    If Properties.GetByName(posVoidValidator.ColumnNames.voidid).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.voidid).Value = Entity.voidid
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.barcode).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.barcode).Value = Entity.barcode
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.itemdesc).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.itemdesc).Value = Entity.itemdesc
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.cost).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.cost).Value = Entity.cost
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.price).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.price).Value = Entity.price
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.pckqty).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.pckqty).Value = Entity.pckqty
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.qty).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.qty).Value = Entity.qty
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(posVoidValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
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

    If Properties.GetByName(posVoidValidator.ColumnNames.voidid).IsNull = False Then
      Entity.voidid = Properties.GetByName(posVoidValidator.ColumnNames.voidid).GetAsInteger()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(posVoidValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.barcode).IsNull = False Then
      Entity.barcode = Properties.GetByName(posVoidValidator.ColumnNames.barcode).GetAsString()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.itemdesc).IsNull = False Then
      Entity.itemdesc = Properties.GetByName(posVoidValidator.ColumnNames.itemdesc).GetAsString()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.cost).IsNull = False Then
      Entity.cost = Properties.GetByName(posVoidValidator.ColumnNames.cost).GetAsDecimal()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.price).IsNull = False Then
      Entity.price = Properties.GetByName(posVoidValidator.ColumnNames.price).GetAsDecimal()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.pckqty).IsNull = False Then
      Entity.pckqty = Properties.GetByName(posVoidValidator.ColumnNames.pckqty).GetAsInteger()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.qty).IsNull = False Then
      Entity.qty = Properties.GetByName(posVoidValidator.ColumnNames.qty).GetAsDouble()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(posVoidValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(posVoidValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(posVoidValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the posVoid class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'voidid'
    ''' </summary>
    Public Shared ReadOnly Property voidid() As String
      Get
        Return "voidid"
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
    ''' Returns 'barcode'
    ''' </summary>
    Public Shared ReadOnly Property barcode() As String
      Get
        Return "barcode"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'item_desc'
    ''' </summary>
    Public Shared ReadOnly Property itemdesc() As String
      Get
        Return "item_desc"
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
    ''' Returns 'price'
    ''' </summary>
    Public Shared ReadOnly Property price() As String
      Get
        Return "price"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pck_qty'
    ''' </summary>
    Public Shared ReadOnly Property pckqty() As String
      Get
        Return "pck_qty"
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
  End Class
#End Region
End Class
