Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the pos_det class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class pos_detValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the pos_detValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a pos_det</param>
  Public Sub New(ByVal entity As pos_det)
    MyBase.New()

    _Entity = entity
    ClassName = "pos_detValidator"

    ' Create Properties for each field in the pos_det entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As pos_det
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As pos_det
    Get
      Return _Entity
    End Get
    Set(ByVal value As pos_det)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current pos_det
  ''' </summary>
  ''' <returns>A cloned pos_det object</returns>
  Public Function CloneEntity() As pos_det
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in pos_det
  ''' </summary>
  ''' <returns>A cloned pos_det object</returns>
  Public Function CloneEntity(ByVal entityToClone As pos_det) As pos_det
    Dim newEntity As New pos_det()

    newEntity.detid = entityToClone.detid
    newEntity.postmphdrid = entityToClone.postmphdrid
    newEntity.stckid = entityToClone.stckid
    newEntity.barcode = entityToClone.barcode
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.cost = entityToClone.cost
    newEntity.price = entityToClone.price
    newEntity.pck = entityToClone.pck
    newEntity.quantity = entityToClone.quantity
    newEntity.detamnt = entityToClone.detamnt
    newEntity.detdisc = entityToClone.detdisc
    newEntity.psted = entityToClone.psted
    newEntity.detcost = entityToClone.detcost
    newEntity.pckqty = entityToClone.pckqty
    newEntity.ws = entityToClone.ws
    newEntity.qty = entityToClone.qty
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid
    newEntity.wtid = entityToClone.wtid
    newEntity.incentive = entityToClone.incentive

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.detid, "det id", False, GetType(Integer), 10, "det id must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.postmphdrid, "postmp hdrid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.stckid, "stckid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.barcode, "barcode", False, GetType(String), 22, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.itemdesc, "item desc", False, GetType(String), 1073741823, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.cost, "cost", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.price, "price", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.pck, "pck", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.quantity, "quantity", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.detamnt, "det amnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.detdisc, "det disc", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.psted, "psted", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.detcost, "det cost", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.pckqty, "pck qty", False, GetType(Integer), 6, "", Convert.ToInt32("-999999"), Convert.ToInt32("999999"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.ws, "ws", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.qty, "qty", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.wtid, "wtid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_detValidator.ColumnNames.incentive, "incentive", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.detid = 0
    Entity.postmphdrid = 0
    Entity.stckid = 0
    Entity.barcode = String.Empty
    Entity.itemdesc = String.Empty
    Entity.cost = 0
    Entity.price = 0
    Entity.pck = 0
    Entity.quantity = 0
    Entity.detamnt = 0
    Entity.detdisc = 0
    Entity.psted = False
    Entity.detcost = 0
    Entity.pckqty = 0
    Entity.ws = 0
    Entity.qty = 0
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0
    Entity.wtid = 0
    Entity.incentive = 0

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

    If Properties.GetByName(pos_detValidator.ColumnNames.detid).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.detid).Value = Entity.detid
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.postmphdrid).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.postmphdrid).Value = Entity.postmphdrid
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.barcode).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.barcode).Value = Entity.barcode
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.itemdesc).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.itemdesc).Value = Entity.itemdesc
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.cost).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.cost).Value = Entity.cost
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.price).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.price).Value = Entity.price
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.pck).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.pck).Value = Entity.pck
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.quantity).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.quantity).Value = Entity.quantity
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.detamnt).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.detamnt).Value = Entity.detamnt
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.detdisc).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.detdisc).Value = Entity.detdisc
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.psted).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.psted).Value = Entity.psted
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.detcost).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.detcost).Value = Entity.detcost
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.pckqty).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.pckqty).Value = Entity.pckqty
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.ws).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.ws).Value = Entity.ws
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.qty).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.qty).Value = Entity.qty
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.wtid).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.wtid).Value = Entity.wtid
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.incentive).SetAsNull = False Then
      Properties.GetByName(pos_detValidator.ColumnNames.incentive).Value = Entity.incentive
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

    If Properties.GetByName(pos_detValidator.ColumnNames.detid).IsNull = False Then
      Entity.detid = Properties.GetByName(pos_detValidator.ColumnNames.detid).GetAsInteger()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.postmphdrid).IsNull = False Then
      Entity.postmphdrid = Properties.GetByName(pos_detValidator.ColumnNames.postmphdrid).GetAsInteger()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(pos_detValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.barcode).IsNull = False Then
      Entity.barcode = Properties.GetByName(pos_detValidator.ColumnNames.barcode).GetAsString()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.itemdesc).IsNull = False Then
      Entity.itemdesc = Properties.GetByName(pos_detValidator.ColumnNames.itemdesc).GetAsString()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.cost).IsNull = False Then
      Entity.cost = Properties.GetByName(pos_detValidator.ColumnNames.cost).GetAsDecimal()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.price).IsNull = False Then
      Entity.price = Properties.GetByName(pos_detValidator.ColumnNames.price).GetAsDecimal()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.pck).IsNull = False Then
      Entity.pck = Properties.GetByName(pos_detValidator.ColumnNames.pck).GetAsDouble()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.quantity).IsNull = False Then
      Entity.quantity = Properties.GetByName(pos_detValidator.ColumnNames.quantity).GetAsDouble()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.detamnt).IsNull = False Then
      Entity.detamnt = Properties.GetByName(pos_detValidator.ColumnNames.detamnt).GetAsDecimal()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.detdisc).IsNull = False Then
      Entity.detdisc = Properties.GetByName(pos_detValidator.ColumnNames.detdisc).GetAsDecimal()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.psted).IsNull = False Then
      Entity.psted = Properties.GetByName(pos_detValidator.ColumnNames.psted).GetValueAsBoolean()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.detcost).IsNull = False Then
      Entity.detcost = Properties.GetByName(pos_detValidator.ColumnNames.detcost).GetAsDecimal()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.pckqty).IsNull = False Then
      Entity.pckqty = Properties.GetByName(pos_detValidator.ColumnNames.pckqty).GetAsInteger()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.ws).IsNull = False Then
      Entity.ws = Properties.GetByName(pos_detValidator.ColumnNames.ws).GetAsDecimal()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.qty).IsNull = False Then
      Entity.qty = Properties.GetByName(pos_detValidator.ColumnNames.qty).GetAsDouble()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(pos_detValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(pos_detValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(pos_detValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(pos_detValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(pos_detValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.wtid).IsNull = False Then
      Entity.wtid = Properties.GetByName(pos_detValidator.ColumnNames.wtid).GetAsInteger()
    End If
    If Properties.GetByName(pos_detValidator.ColumnNames.incentive).IsNull = False Then
      Entity.incentive = Properties.GetByName(pos_detValidator.ColumnNames.incentive).GetAsDecimal()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the pos_det class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'det_id'
    ''' </summary>
    Public Shared ReadOnly Property detid() As String
      Get
        Return "det_id"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'postmp_hdrid'
    ''' </summary>
    Public Shared ReadOnly Property postmphdrid() As String
      Get
        Return "postmp_hdrid"
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
    ''' Returns 'pck'
    ''' </summary>
    Public Shared ReadOnly Property pck() As String
      Get
        Return "pck"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'quantity'
    ''' </summary>
    Public Shared ReadOnly Property quantity() As String
      Get
        Return "quantity"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'det_amnt'
    ''' </summary>
    Public Shared ReadOnly Property detamnt() As String
      Get
        Return "det_amnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'det_disc'
    ''' </summary>
    Public Shared ReadOnly Property detdisc() As String
      Get
        Return "det_disc"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'psted'
    ''' </summary>
    Public Shared ReadOnly Property psted() As String
      Get
        Return "psted"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'det_cost'
    ''' </summary>
    Public Shared ReadOnly Property detcost() As String
      Get
        Return "det_cost"
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
    ''' Returns 'ws'
    ''' </summary>
    Public Shared ReadOnly Property ws() As String
      Get
        Return "ws"
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
    ''' Returns 'wtid'
    ''' </summary>
    Public Shared ReadOnly Property wtid() As String
      Get
        Return "wtid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'incentive'
    ''' </summary>
    Public Shared ReadOnly Property incentive() As String
      Get
        Return "incentive"
      End Get
    End Property
  End Class
#End Region
End Class
