Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the stocks class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class stocksValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the stocksValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a stocks</param>
  Public Sub New(ByVal entity As stocks)
    MyBase.New()

    _Entity = entity
    ClassName = "stocksValidator"

    ' Create Properties for each field in the stocks entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As stocks
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As stocks
    Get
      Return _Entity
    End Get
    Set(ByVal value As stocks)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current stocks
  ''' </summary>
  ''' <returns>A cloned stocks object</returns>
  Public Function CloneEntity() As stocks
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in stocks
  ''' </summary>
  ''' <returns>A cloned stocks object</returns>
  Public Function CloneEntity(ByVal entityToClone As stocks) As stocks
    Dim newEntity As New stocks()

    newEntity.stckid = entityToClone.stckid
    newEntity.barcode = entityToClone.barcode
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.available = entityToClone.available
    newEntity.pckgqty = entityToClone.pckgqty
    newEntity.packaging = entityToClone.packaging
    newEntity.supcode = entityToClone.supcode
    newEntity.categoryid = entityToClone.categoryid
    newEntity.beginvstock = entityToClone.beginvstock
    newEntity.dept = entityToClone.dept
    newEntity.pckgcost = entityToClone.pckgcost
    newEntity.cost = entityToClone.cost
    newEntity.retail = entityToClone.retail
    newEntity.wsale = entityToClone.wsale
    newEntity.markup = entityToClone.markup
    newEntity.markup2 = entityToClone.markup2
    newEntity.retail2 = entityToClone.retail2
    newEntity.minimum = entityToClone.minimum
    newEntity.lastprice = entityToClone.lastprice
    newEntity.lastdlvry = entityToClone.lastdlvry
    newEntity.maximum = entityToClone.maximum
    newEntity.sravlbl = entityToClone.sravlbl
    newEntity.srpckqty = entityToClone.srpckqty
    newEntity.srdlvry = entityToClone.srdlvry
    newEntity.sizeid = entityToClone.sizeid
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid
    newEntity.lastcost = entityToClone.lastcost
    newEntity.lastwholesale = entityToClone.lastwholesale
    newEntity.incentive = entityToClone.incentive
    newEntity.active = entityToClone.active
    newEntity.vat = entityToClone.vat
    newEntity.markup3 = entityToClone.markup3
    newEntity.markup4 = entityToClone.markup4
    newEntity.markup5 = entityToClone.markup5
    newEntity.retail3 = entityToClone.retail3
    newEntity.retail4 = entityToClone.retail4
    newEntity.retail5 = entityToClone.retail5

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.stckid, "stckid", False, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.barcode, "barcode", False, GetType(String), 22, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.itemdesc, "item desc", False, GetType(String), 100, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.available, "available", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.pckgqty, "pckgqty", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.packaging, "packaging", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.supcode, "supcode", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.categoryid, "categoryid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.beginvstock, "beginvstock", False, GetType(Decimal), 10, "", Convert.ToDecimal("-99999999.99"), Convert.ToDecimal("99999999.99"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.dept, "dept", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.pckgcost, "pckg cost", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.cost, "cost", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.retail, "retail", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.wsale, "wsale", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.markup, "markup", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.markup2, "markup2", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.retail2, "retail2", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.minimum, "minimum", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.lastprice, "lastprice", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.lastdlvry, "lastdlvry", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.maximum, "maximum", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.sravlbl, "sravlbl", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.srpckqty, "srpckqty", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.srdlvry, "sr dlvry", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.sizeid, "sizeid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.lastcost, "lastcost", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.lastwholesale, "lastwholesale", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.incentive, "incentive", False, GetType(Decimal), 18, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.active, "active", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.vat, "vat", False, GetType(Boolean?), 5, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), -2147483648, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.markup3, "markup3", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.markup4, "markup4", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.markup5, "markup5", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.retail3, "retail3", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.retail4, "retail4", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(stocksValidator.ColumnNames.retail5, "retail5", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.stckid = 0
    Entity.barcode = String.Empty
    Entity.itemdesc = String.Empty
    Entity.available = 0
    Entity.pckgqty = 0
    Entity.packaging = 0
    Entity.supcode = 0
    Entity.categoryid = 0
    Entity.beginvstock = 0
    Entity.dept = 0
    Entity.pckgcost = 0
    Entity.cost = 0
    Entity.retail = 0
    Entity.wsale = 0
    Entity.markup = 0
    Entity.markup2 = 0
    Entity.retail2 = 0
    Entity.minimum = 0
    Entity.lastprice = 0
    Entity.lastdlvry = DateTime.Now
    Entity.maximum = 0
    Entity.sravlbl = 0
    Entity.srpckqty = 0
    Entity.srdlvry = 0
    Entity.sizeid = 0
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0
    Entity.lastcost = 0
    Entity.lastwholesale = 0
    Entity.incentive = 0
    Entity.active = False
    Entity.vat = 0
    Entity.markup3 = 0
    Entity.markup4 = 0
    Entity.markup5 = 0
    Entity.retail3 = 0
    Entity.retail4 = 0
    Entity.retail5 = 0

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

    If Properties.GetByName(stocksValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.barcode).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.barcode).Value = Entity.barcode
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.itemdesc).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.itemdesc).Value = Entity.itemdesc
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.available).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.available).Value = Entity.available
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.pckgqty).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.pckgqty).Value = Entity.pckgqty
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.packaging).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.packaging).Value = Entity.packaging
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.supcode).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.supcode).Value = Entity.supcode
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.categoryid).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.categoryid).Value = Entity.categoryid
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.beginvstock).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.beginvstock).Value = Entity.beginvstock
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.dept).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.dept).Value = Entity.dept
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.pckgcost).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.pckgcost).Value = Entity.pckgcost
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.cost).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.cost).Value = Entity.cost
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.retail).Value = Entity.retail
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.wsale).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.wsale).Value = Entity.wsale
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.markup).Value = Entity.markup
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup2).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.markup2).Value = Entity.markup2
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail2).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.retail2).Value = Entity.retail2
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.minimum).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.minimum).Value = Entity.minimum
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.lastprice).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.lastprice).Value = Entity.lastprice
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.lastdlvry).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.lastdlvry).Value = Entity.lastdlvry
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.maximum).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.maximum).Value = Entity.maximum
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.sravlbl).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.sravlbl).Value = Entity.sravlbl
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.srpckqty).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.srpckqty).Value = Entity.srpckqty
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.srdlvry).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.srdlvry).Value = Entity.srdlvry
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.sizeid).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.sizeid).Value = Entity.sizeid
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.lastcost).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.lastcost).Value = Entity.lastcost
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.lastwholesale).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.lastwholesale).Value = Entity.lastwholesale
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.incentive).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.incentive).Value = Entity.incentive
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.active).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.active).Value = Entity.active
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.vat).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.vat).Value = Entity.vat
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup3).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.markup3).Value = Entity.markup3
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup4).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.markup4).Value = Entity.markup4
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup5).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.markup5).Value = Entity.markup5
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail3).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.retail3).Value = Entity.retail3
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail4).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.retail4).Value = Entity.retail4
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail5).SetAsNull = False Then
      Properties.GetByName(stocksValidator.ColumnNames.retail5).Value = Entity.retail5
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

    If Properties.GetByName(stocksValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(stocksValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.barcode).IsNull = False Then
      Entity.barcode = Properties.GetByName(stocksValidator.ColumnNames.barcode).GetAsString()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.itemdesc).IsNull = False Then
      Entity.itemdesc = Properties.GetByName(stocksValidator.ColumnNames.itemdesc).GetAsString()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.available).IsNull = False Then
      Entity.available = Properties.GetByName(stocksValidator.ColumnNames.available).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.pckgqty).IsNull = False Then
      Entity.pckgqty = Properties.GetByName(stocksValidator.ColumnNames.pckgqty).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.packaging).IsNull = False Then
      Entity.packaging = Properties.GetByName(stocksValidator.ColumnNames.packaging).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = Properties.GetByName(stocksValidator.ColumnNames.supcode).GetAsInteger()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.categoryid).IsNull = False Then
      Entity.categoryid = Properties.GetByName(stocksValidator.ColumnNames.categoryid).GetAsInteger()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.beginvstock).IsNull = False Then
      Entity.beginvstock = Properties.GetByName(stocksValidator.ColumnNames.beginvstock).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.dept).IsNull = False Then
      Entity.dept = Properties.GetByName(stocksValidator.ColumnNames.dept).GetAsInteger()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.pckgcost).IsNull = False Then
      Entity.pckgcost = Properties.GetByName(stocksValidator.ColumnNames.pckgcost).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.cost).IsNull = False Then
      Entity.cost = Properties.GetByName(stocksValidator.ColumnNames.cost).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail).IsNull = False Then
      Entity.retail = Properties.GetByName(stocksValidator.ColumnNames.retail).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.wsale).IsNull = False Then
      Entity.wsale = Properties.GetByName(stocksValidator.ColumnNames.wsale).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup).IsNull = False Then
      Entity.markup = Properties.GetByName(stocksValidator.ColumnNames.markup).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup2).IsNull = False Then
      Entity.markup2 = Properties.GetByName(stocksValidator.ColumnNames.markup2).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail2).IsNull = False Then
      Entity.retail2 = Properties.GetByName(stocksValidator.ColumnNames.retail2).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.minimum).IsNull = False Then
      Entity.minimum = Properties.GetByName(stocksValidator.ColumnNames.minimum).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.lastprice).IsNull = False Then
      Entity.lastprice = Properties.GetByName(stocksValidator.ColumnNames.lastprice).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.lastdlvry).IsNull = False Then
      Entity.lastdlvry = Properties.GetByName(stocksValidator.ColumnNames.lastdlvry).GetAsDate()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.maximum).IsNull = False Then
      Entity.maximum = Properties.GetByName(stocksValidator.ColumnNames.maximum).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.sravlbl).IsNull = False Then
      Entity.sravlbl = Properties.GetByName(stocksValidator.ColumnNames.sravlbl).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.srpckqty).IsNull = False Then
      Entity.srpckqty = Properties.GetByName(stocksValidator.ColumnNames.srpckqty).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.srdlvry).IsNull = False Then
      Entity.srdlvry = Properties.GetByName(stocksValidator.ColumnNames.srdlvry).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.sizeid).IsNull = False Then
      Entity.sizeid = Properties.GetByName(stocksValidator.ColumnNames.sizeid).GetAsInteger()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(stocksValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(stocksValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(stocksValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(stocksValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(stocksValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.lastcost).IsNull = False Then
      Entity.lastcost = Properties.GetByName(stocksValidator.ColumnNames.lastcost).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.lastwholesale).IsNull = False Then
      Entity.lastwholesale = Properties.GetByName(stocksValidator.ColumnNames.lastwholesale).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.incentive).IsNull = False Then
      Entity.incentive = Properties.GetByName(stocksValidator.ColumnNames.incentive).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.active).IsNull = False Then
      Entity.active = Properties.GetByName(stocksValidator.ColumnNames.active).GetValueAsBoolean()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.vat).IsNull = False Then
      Entity.vat = Properties.GetByName(stocksValidator.ColumnNames.vat).GetAsInteger()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup3).IsNull = False Then
      Entity.markup3 = Properties.GetByName(stocksValidator.ColumnNames.markup3).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup4).IsNull = False Then
      Entity.markup4 = Properties.GetByName(stocksValidator.ColumnNames.markup4).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.markup5).IsNull = False Then
      Entity.markup5 = Properties.GetByName(stocksValidator.ColumnNames.markup5).GetAsDouble()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail3).IsNull = False Then
      Entity.retail3 = Properties.GetByName(stocksValidator.ColumnNames.retail3).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail4).IsNull = False Then
      Entity.retail4 = Properties.GetByName(stocksValidator.ColumnNames.retail4).GetAsDecimal()
    End If
    If Properties.GetByName(stocksValidator.ColumnNames.retail5).IsNull = False Then
      Entity.retail5 = Properties.GetByName(stocksValidator.ColumnNames.retail5).GetAsDecimal()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the stocks class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
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
    ''' Returns 'available'
    ''' </summary>
    Public Shared ReadOnly Property available() As String
      Get
        Return "available"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pckgqty'
    ''' </summary>
    Public Shared ReadOnly Property pckgqty() As String
      Get
        Return "pckgqty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'packaging'
    ''' </summary>
    Public Shared ReadOnly Property packaging() As String
      Get
        Return "packaging"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'supcode'
    ''' </summary>
    Public Shared ReadOnly Property supcode() As String
      Get
        Return "supcode"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'categoryid'
    ''' </summary>
    Public Shared ReadOnly Property categoryid() As String
      Get
        Return "categoryid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'beginvstock'
    ''' </summary>
    Public Shared ReadOnly Property beginvstock() As String
      Get
        Return "beginvstock"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'dept'
    ''' </summary>
    Public Shared ReadOnly Property dept() As String
      Get
        Return "dept"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pckg_cost'
    ''' </summary>
    Public Shared ReadOnly Property pckgcost() As String
      Get
        Return "pckg_cost"
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
    ''' Returns 'retail'
    ''' </summary>
    Public Shared ReadOnly Property retail() As String
      Get
        Return "retail"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'wsale'
    ''' </summary>
    Public Shared ReadOnly Property wsale() As String
      Get
        Return "wsale"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'markup'
    ''' </summary>
    Public Shared ReadOnly Property markup() As String
      Get
        Return "markup"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'markup2'
    ''' </summary>
    Public Shared ReadOnly Property markup2() As String
      Get
        Return "markup2"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'retail2'
    ''' </summary>
    Public Shared ReadOnly Property retail2() As String
      Get
        Return "retail2"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'minimum'
    ''' </summary>
    Public Shared ReadOnly Property minimum() As String
      Get
        Return "minimum"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'lastprice'
    ''' </summary>
    Public Shared ReadOnly Property lastprice() As String
      Get
        Return "lastprice"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'lastdlvry'
    ''' </summary>
    Public Shared ReadOnly Property lastdlvry() As String
      Get
        Return "lastdlvry"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'maximum'
    ''' </summary>
    Public Shared ReadOnly Property maximum() As String
      Get
        Return "maximum"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sravlbl'
    ''' </summary>
    Public Shared ReadOnly Property sravlbl() As String
      Get
        Return "sravlbl"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'srpckqty'
    ''' </summary>
    Public Shared ReadOnly Property srpckqty() As String
      Get
        Return "srpckqty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sr_dlvry'
    ''' </summary>
    Public Shared ReadOnly Property srdlvry() As String
      Get
        Return "sr_dlvry"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sizeid'
    ''' </summary>
    Public Shared ReadOnly Property sizeid() As String
      Get
        Return "sizeid"
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
    ''' Returns 'lastcost'
    ''' </summary>
    Public Shared ReadOnly Property lastcost() As String
      Get
        Return "lastcost"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'lastwholesale'
    ''' </summary>
    Public Shared ReadOnly Property lastwholesale() As String
      Get
        Return "lastwholesale"
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
    ''' <summary>
    ''' Returns 'active'
    ''' </summary>
    Public Shared ReadOnly Property active() As String
      Get
        Return "active"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'vat'
    ''' </summary>
    Public Shared ReadOnly Property vat() As String
      Get
        Return "vat"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'markup3'
    ''' </summary>
    Public Shared ReadOnly Property markup3() As String
      Get
        Return "markup3"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'markup4'
    ''' </summary>
    Public Shared ReadOnly Property markup4() As String
      Get
        Return "markup4"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'markup5'
    ''' </summary>
    Public Shared ReadOnly Property markup5() As String
      Get
        Return "markup5"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'retail3'
    ''' </summary>
    Public Shared ReadOnly Property retail3() As String
      Get
        Return "retail3"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'retail4'
    ''' </summary>
    Public Shared ReadOnly Property retail4() As String
      Get
        Return "retail4"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'retail5'
    ''' </summary>
    Public Shared ReadOnly Property retail5() As String
      Get
        Return "retail5"
      End Get
    End Property
  End Class
#End Region
End Class
