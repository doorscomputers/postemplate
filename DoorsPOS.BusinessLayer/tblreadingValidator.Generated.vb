Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the tblreading class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class tblreadingValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the tblreadingValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a tblreading</param>
  Public Sub New(ByVal entity As tblreading)
    MyBase.New()

    _Entity = entity
    ClassName = "tblreadingValidator"

    ' Create Properties for each field in the tblreading entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As tblreading
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As tblreading
    Get
      Return _Entity
    End Get
    Set(ByVal value As tblreading)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current tblreading
  ''' </summary>
  ''' <returns>A cloned tblreading object</returns>
  Public Function CloneEntity() As tblreading
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in tblreading
  ''' </summary>
  ''' <returns>A cloned tblreading object</returns>
  Public Function CloneEntity(ByVal entityToClone As tblreading) As tblreading
    Dim newEntity As New tblreading()

    newEntity.cashreadid = entityToClone.cashreadid
    newEntity.cashier = entityToClone.cashier
    newEntity.datereading = entityToClone.datereading
    newEntity.totalsales = entityToClone.totalsales
    newEntity.totalcredit = entityToClone.totalcredit
    newEntity.totaldiscount = entityToClone.totaldiscount
    newEntity.begincash = entityToClone.begincash
    newEntity.totalcheque = entityToClone.totalcheque
    newEntity.changeprice = entityToClone.changeprice
    newEntity.transfer = entityToClone.transfer
    newEntity.thousndp = entityToClone.thousndp
    newEntity.fiehundredp = entityToClone.fiehundredp
    newEntity.twohundredp = entityToClone.twohundredp
    newEntity.onehundredp = entityToClone.onehundredp
    newEntity.fiftyp = entityToClone.fiftyp
    newEntity.twentyp = entityToClone.twentyp
    newEntity.tenp = entityToClone.tenp
    newEntity.fivep = entityToClone.fivep
    newEntity.onep = entityToClone.onep
    newEntity.twentyfive = entityToClone.twentyfive
    newEntity.overshort = entityToClone.overshort
    newEntity.status = entityToClone.status
    newEntity.timereading = entityToClone.timereading
    newEntity.payments = entityToClone.payments
    newEntity.readtime = entityToClone.readtime
    newEntity.pickup = entityToClone.pickup
    newEntity.addcash = entityToClone.addcash
    newEntity.totalrefs = entityToClone.totalrefs
    newEntity.totalsales2 = entityToClone.totalsales2
    newEntity.cnttotalsales = entityToClone.cnttotalsales
    newEntity.cnttotalrefunds = entityToClone.cnttotalrefunds
    newEntity.cnttotaldiscounts = entityToClone.cnttotaldiscounts
    newEntity.cnttotaldep = entityToClone.cnttotaldep
    newEntity.cntsenior = entityToClone.cntsenior
    newEntity.cntdiscreg = entityToClone.cntdiscreg
    newEntity.cntvoids = entityToClone.cntvoids
    newEntity.cntreceipt = entityToClone.cntreceipt
    newEntity.begreceipt = entityToClone.begreceipt
    newEntity.endreceipt = entityToClone.endreceipt
    newEntity.prevtotal = entityToClone.prevtotal
    newEntity.terminal = entityToClone.terminal
    newEntity.totvat = entityToClone.totvat
    newEntity.totnonvat = entityToClone.totnonvat
    newEntity.totzerorated = entityToClone.totzerorated
    newEntity.sumvat = entityToClone.sumvat
    newEntity.cntcredits = entityToClone.cntcredits
    newEntity.accutotsale = entityToClone.accutotsale
    newEntity.readingno = entityToClone.readingno
    newEntity.ETwo = entityToClone.ETwo
    newEntity.EOneHundred = entityToClone.EOneHundred
    newEntity.EFifty = entityToClone.EFifty
    newEntity.ETwenty = entityToClone.ETwenty
    newEntity.ETen = entityToClone.ETen
    newEntity.EFive = entityToClone.EFive
    newEntity.Eone = entityToClone.Eone
    newEntity.Ecents = entityToClone.Ecents
    newEntity.TotRemit = entityToClone.TotRemit

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cashreadid, "cashreadid", False, GetType(Integer), 10, "cashreadid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cashier, "cashier", True, GetType(String), 50, "cashier must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.datereading, "datereading", True, GetType(Date), -1, "datereading must be filled in", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totalsales, "totalsales", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totalcredit, "totalcredit", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totaldiscount, "totaldiscount", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.begincash, "begincash", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totalcheque, "totalcheque", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.changeprice, "changeprice", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.transfer, "transfer", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.thousndp, "thousndp", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.fiehundredp, "fiehundredp", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.twohundredp, "twohundredp", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.onehundredp, "onehundredp", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.fiftyp, "fiftyp", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.twentyp, "twentyp", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.tenp, "tenp", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.fivep, "fivep", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.onep, "onep", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.twentyfive, "twentyfive", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.overshort, "overshort", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.status, "status", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.timereading, "timereading", False, GetType(Date), -1, "", Nothing, Nothing, -2147483648, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.payments, "payments", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.readtime, "readtime", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.pickup, "pickup", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.addcash, "addcash", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totalrefs, "totalrefs", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totalsales2, "totalsales2", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cnttotalsales, "cnttotalsales", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cnttotalrefunds, "cnttotalrefunds", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cnttotaldiscounts, "cnttotaldiscounts", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cnttotaldep, "cnttotaldep", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cntsenior, "cntsenior", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cntdiscreg, "cntdiscreg", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cntvoids, "cntvoids", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cntreceipt, "cntreceipt", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.begreceipt, "begreceipt", False, GetType(String), 20, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.endreceipt, "endreceipt", False, GetType(String), 20, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.prevtotal, "prevtotal", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.terminal, "terminal", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totvat, "totvat", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totnonvat, "totnonvat", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.totzerorated, "totzerorated", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.sumvat, "sumvat", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.cntcredits, "cntcredits", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.accutotsale, "accutotsale", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.readingno, "readingno", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.ETwo, "E Two", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.EOneHundred, "E One Hundred", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.EFifty, "E Fifty", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.ETwenty, "E Twenty", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.ETen, "E Ten", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.EFive, "E Five", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.Eone, "Eone", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.Ecents, "Ecents", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblreadingValidator.ColumnNames.TotRemit, "Tot Remit", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.cashreadid = 0
    Entity.cashier = String.Empty
    Entity.datereading = DateTime.Now
    Entity.totalsales = 0
    Entity.totalcredit = 0
    Entity.totaldiscount = 0
    Entity.begincash = 0
    Entity.totalcheque = 0
    Entity.changeprice = 0
    Entity.transfer = 0
    Entity.thousndp = 0
    Entity.fiehundredp = 0
    Entity.twohundredp = 0
    Entity.onehundredp = 0
    Entity.fiftyp = 0
    Entity.twentyp = 0
    Entity.tenp = 0
    Entity.fivep = 0
    Entity.onep = 0
    Entity.twentyfive = 0
    Entity.overshort = 0
    Entity.status = False
    Entity.timereading = DateTime.Now
    Entity.payments = 0
    Entity.readtime = DateTime.Now
    Entity.pickup = 0
    Entity.addcash = 0
    Entity.totalrefs = 0
    Entity.totalsales2 = 0
    Entity.cnttotalsales = 0
    Entity.cnttotalrefunds = 0
    Entity.cnttotaldiscounts = 0
    Entity.cnttotaldep = 0
    Entity.cntsenior = 0
    Entity.cntdiscreg = 0
    Entity.cntvoids = 0
    Entity.cntreceipt = 0
    Entity.begreceipt = String.Empty
    Entity.endreceipt = String.Empty
    Entity.prevtotal = 0
    Entity.terminal = 0
    Entity.totvat = 0
    Entity.totnonvat = 0
    Entity.totzerorated = 0
    Entity.sumvat = 0
    Entity.cntcredits = 0
    Entity.accutotsale = 0
    Entity.readingno = 0
    Entity.ETwo = 0
    Entity.EOneHundred = 0
    Entity.EFifty = 0
    Entity.ETwenty = 0
    Entity.ETen = 0
    Entity.EFive = 0
    Entity.Eone = 0
    Entity.Ecents = 0
    Entity.TotRemit = 0

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

    If Properties.GetByName(tblreadingValidator.ColumnNames.cashreadid).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cashreadid).Value = Entity.cashreadid
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cashier).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cashier).Value = Entity.cashier
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.datereading).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.datereading).Value = Entity.datereading
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalsales).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totalsales).Value = Entity.totalsales
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalcredit).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totalcredit).Value = Entity.totalcredit
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totaldiscount).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totaldiscount).Value = Entity.totaldiscount
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.begincash).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.begincash).Value = Entity.begincash
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalcheque).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totalcheque).Value = Entity.totalcheque
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.changeprice).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.changeprice).Value = Entity.changeprice
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.transfer).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.transfer).Value = Entity.transfer
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.thousndp).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.thousndp).Value = Entity.thousndp
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.fiehundredp).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.fiehundredp).Value = Entity.fiehundredp
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.twohundredp).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.twohundredp).Value = Entity.twohundredp
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.onehundredp).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.onehundredp).Value = Entity.onehundredp
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.fiftyp).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.fiftyp).Value = Entity.fiftyp
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.twentyp).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.twentyp).Value = Entity.twentyp
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.tenp).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.tenp).Value = Entity.tenp
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.fivep).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.fivep).Value = Entity.fivep
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.onep).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.onep).Value = Entity.onep
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.twentyfive).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.twentyfive).Value = Entity.twentyfive
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.overshort).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.overshort).Value = Entity.overshort
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.status).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.status).Value = Entity.status
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.timereading).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.timereading).Value = Entity.timereading
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.payments).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.payments).Value = Entity.payments
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.readtime).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.readtime).Value = Entity.readtime
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.pickup).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.pickup).Value = Entity.pickup
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.addcash).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.addcash).Value = Entity.addcash
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalrefs).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totalrefs).Value = Entity.totalrefs
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalsales2).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totalsales2).Value = Entity.totalsales2
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cnttotalsales).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cnttotalsales).Value = Entity.cnttotalsales
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cnttotalrefunds).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cnttotalrefunds).Value = Entity.cnttotalrefunds
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cnttotaldiscounts).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cnttotaldiscounts).Value = Entity.cnttotaldiscounts
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cnttotaldep).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cnttotaldep).Value = Entity.cnttotaldep
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntsenior).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cntsenior).Value = Entity.cntsenior
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntdiscreg).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cntdiscreg).Value = Entity.cntdiscreg
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntvoids).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cntvoids).Value = Entity.cntvoids
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntreceipt).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cntreceipt).Value = Entity.cntreceipt
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.begreceipt).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.begreceipt).Value = Entity.begreceipt
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.endreceipt).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.endreceipt).Value = Entity.endreceipt
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.prevtotal).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.prevtotal).Value = Entity.prevtotal
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.terminal).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.terminal).Value = Entity.terminal
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totvat).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totvat).Value = Entity.totvat
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totnonvat).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totnonvat).Value = Entity.totnonvat
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totzerorated).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.totzerorated).Value = Entity.totzerorated
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.sumvat).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.sumvat).Value = Entity.sumvat
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntcredits).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.cntcredits).Value = Entity.cntcredits
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.accutotsale).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.accutotsale).Value = Entity.accutotsale
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.readingno).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.readingno).Value = Entity.readingno
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.ETwo).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.ETwo).Value = Entity.ETwo
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.EOneHundred).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.EOneHundred).Value = Entity.EOneHundred
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.EFifty).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.EFifty).Value = Entity.EFifty
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.ETwenty).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.ETwenty).Value = Entity.ETwenty
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.ETen).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.ETen).Value = Entity.ETen
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.EFive).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.EFive).Value = Entity.EFive
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.Eone).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.Eone).Value = Entity.Eone
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.Ecents).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.Ecents).Value = Entity.Ecents
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.TotRemit).SetAsNull = False Then
      Properties.GetByName(tblreadingValidator.ColumnNames.TotRemit).Value = Entity.TotRemit
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

    If Properties.GetByName(tblreadingValidator.ColumnNames.cashreadid).IsNull = False Then
      Entity.cashreadid = Properties.GetByName(tblreadingValidator.ColumnNames.cashreadid).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cashier).IsNull = False Then
      Entity.cashier = Properties.GetByName(tblreadingValidator.ColumnNames.cashier).GetAsString()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.datereading).IsNull = False Then
      Entity.datereading = Properties.GetByName(tblreadingValidator.ColumnNames.datereading).GetAsDate()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalsales).IsNull = False Then
      Entity.totalsales = Properties.GetByName(tblreadingValidator.ColumnNames.totalsales).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalcredit).IsNull = False Then
      Entity.totalcredit = Properties.GetByName(tblreadingValidator.ColumnNames.totalcredit).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totaldiscount).IsNull = False Then
      Entity.totaldiscount = Properties.GetByName(tblreadingValidator.ColumnNames.totaldiscount).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.begincash).IsNull = False Then
      Entity.begincash = Properties.GetByName(tblreadingValidator.ColumnNames.begincash).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalcheque).IsNull = False Then
      Entity.totalcheque = Properties.GetByName(tblreadingValidator.ColumnNames.totalcheque).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.changeprice).IsNull = False Then
      Entity.changeprice = Properties.GetByName(tblreadingValidator.ColumnNames.changeprice).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.transfer).IsNull = False Then
      Entity.transfer = Properties.GetByName(tblreadingValidator.ColumnNames.transfer).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.thousndp).IsNull = False Then
      Entity.thousndp = Properties.GetByName(tblreadingValidator.ColumnNames.thousndp).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.fiehundredp).IsNull = False Then
      Entity.fiehundredp = Properties.GetByName(tblreadingValidator.ColumnNames.fiehundredp).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.twohundredp).IsNull = False Then
      Entity.twohundredp = Properties.GetByName(tblreadingValidator.ColumnNames.twohundredp).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.onehundredp).IsNull = False Then
      Entity.onehundredp = Properties.GetByName(tblreadingValidator.ColumnNames.onehundredp).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.fiftyp).IsNull = False Then
      Entity.fiftyp = Properties.GetByName(tblreadingValidator.ColumnNames.fiftyp).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.twentyp).IsNull = False Then
      Entity.twentyp = Properties.GetByName(tblreadingValidator.ColumnNames.twentyp).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.tenp).IsNull = False Then
      Entity.tenp = Properties.GetByName(tblreadingValidator.ColumnNames.tenp).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.fivep).IsNull = False Then
      Entity.fivep = Properties.GetByName(tblreadingValidator.ColumnNames.fivep).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.onep).IsNull = False Then
      Entity.onep = Properties.GetByName(tblreadingValidator.ColumnNames.onep).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.twentyfive).IsNull = False Then
      Entity.twentyfive = Properties.GetByName(tblreadingValidator.ColumnNames.twentyfive).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.overshort).IsNull = False Then
      Entity.overshort = Properties.GetByName(tblreadingValidator.ColumnNames.overshort).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.status).IsNull = False Then
      Entity.status = Properties.GetByName(tblreadingValidator.ColumnNames.status).GetValueAsBoolean()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.timereading).IsNull = False Then
      Entity.timereading = Properties.GetByName(tblreadingValidator.ColumnNames.timereading).GetAsDate()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.payments).IsNull = False Then
      Entity.payments = Properties.GetByName(tblreadingValidator.ColumnNames.payments).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.readtime).IsNull = False Then
      Entity.readtime = Properties.GetByName(tblreadingValidator.ColumnNames.readtime).GetAsDate()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.pickup).IsNull = False Then
      Entity.pickup = Properties.GetByName(tblreadingValidator.ColumnNames.pickup).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.addcash).IsNull = False Then
      Entity.addcash = Properties.GetByName(tblreadingValidator.ColumnNames.addcash).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalrefs).IsNull = False Then
      Entity.totalrefs = Properties.GetByName(tblreadingValidator.ColumnNames.totalrefs).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totalsales2).IsNull = False Then
      Entity.totalsales2 = Properties.GetByName(tblreadingValidator.ColumnNames.totalsales2).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cnttotalsales).IsNull = False Then
      Entity.cnttotalsales = Properties.GetByName(tblreadingValidator.ColumnNames.cnttotalsales).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cnttotalrefunds).IsNull = False Then
      Entity.cnttotalrefunds = Properties.GetByName(tblreadingValidator.ColumnNames.cnttotalrefunds).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cnttotaldiscounts).IsNull = False Then
      Entity.cnttotaldiscounts = Properties.GetByName(tblreadingValidator.ColumnNames.cnttotaldiscounts).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cnttotaldep).IsNull = False Then
      Entity.cnttotaldep = Properties.GetByName(tblreadingValidator.ColumnNames.cnttotaldep).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntsenior).IsNull = False Then
      Entity.cntsenior = Properties.GetByName(tblreadingValidator.ColumnNames.cntsenior).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntdiscreg).IsNull = False Then
      Entity.cntdiscreg = Properties.GetByName(tblreadingValidator.ColumnNames.cntdiscreg).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntvoids).IsNull = False Then
      Entity.cntvoids = Properties.GetByName(tblreadingValidator.ColumnNames.cntvoids).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntreceipt).IsNull = False Then
      Entity.cntreceipt = Properties.GetByName(tblreadingValidator.ColumnNames.cntreceipt).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.begreceipt).IsNull = False Then
      Entity.begreceipt = Properties.GetByName(tblreadingValidator.ColumnNames.begreceipt).GetAsString()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.endreceipt).IsNull = False Then
      Entity.endreceipt = Properties.GetByName(tblreadingValidator.ColumnNames.endreceipt).GetAsString()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.prevtotal).IsNull = False Then
      Entity.prevtotal = Properties.GetByName(tblreadingValidator.ColumnNames.prevtotal).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.terminal).IsNull = False Then
      Entity.terminal = Properties.GetByName(tblreadingValidator.ColumnNames.terminal).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totvat).IsNull = False Then
      Entity.totvat = Properties.GetByName(tblreadingValidator.ColumnNames.totvat).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totnonvat).IsNull = False Then
      Entity.totnonvat = Properties.GetByName(tblreadingValidator.ColumnNames.totnonvat).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.totzerorated).IsNull = False Then
      Entity.totzerorated = Properties.GetByName(tblreadingValidator.ColumnNames.totzerorated).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.sumvat).IsNull = False Then
      Entity.sumvat = Properties.GetByName(tblreadingValidator.ColumnNames.sumvat).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.cntcredits).IsNull = False Then
      Entity.cntcredits = Properties.GetByName(tblreadingValidator.ColumnNames.cntcredits).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.accutotsale).IsNull = False Then
      Entity.accutotsale = Properties.GetByName(tblreadingValidator.ColumnNames.accutotsale).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.readingno).IsNull = False Then
      Entity.readingno = Properties.GetByName(tblreadingValidator.ColumnNames.readingno).GetAsInteger()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.ETwo).IsNull = False Then
      Entity.ETwo = Properties.GetByName(tblreadingValidator.ColumnNames.ETwo).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.EOneHundred).IsNull = False Then
      Entity.EOneHundred = Properties.GetByName(tblreadingValidator.ColumnNames.EOneHundred).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.EFifty).IsNull = False Then
      Entity.EFifty = Properties.GetByName(tblreadingValidator.ColumnNames.EFifty).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.ETwenty).IsNull = False Then
      Entity.ETwenty = Properties.GetByName(tblreadingValidator.ColumnNames.ETwenty).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.ETen).IsNull = False Then
      Entity.ETen = Properties.GetByName(tblreadingValidator.ColumnNames.ETen).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.EFive).IsNull = False Then
      Entity.EFive = Properties.GetByName(tblreadingValidator.ColumnNames.EFive).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.Eone).IsNull = False Then
      Entity.Eone = Properties.GetByName(tblreadingValidator.ColumnNames.Eone).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.Ecents).IsNull = False Then
      Entity.Ecents = Properties.GetByName(tblreadingValidator.ColumnNames.Ecents).GetAsDecimal()
    End If
    If Properties.GetByName(tblreadingValidator.ColumnNames.TotRemit).IsNull = False Then
      Entity.TotRemit = Properties.GetByName(tblreadingValidator.ColumnNames.TotRemit).GetAsDecimal()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the tblreading class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'cashreadid'
    ''' </summary>
    Public Shared ReadOnly Property cashreadid() As String
      Get
        Return "cashreadid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cashier'
    ''' </summary>
    Public Shared ReadOnly Property cashier() As String
      Get
        Return "cashier"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'datereading'
    ''' </summary>
    Public Shared ReadOnly Property datereading() As String
      Get
        Return "datereading"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totalsales'
    ''' </summary>
    Public Shared ReadOnly Property totalsales() As String
      Get
        Return "totalsales"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totalcredit'
    ''' </summary>
    Public Shared ReadOnly Property totalcredit() As String
      Get
        Return "totalcredit"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totaldiscount'
    ''' </summary>
    Public Shared ReadOnly Property totaldiscount() As String
      Get
        Return "totaldiscount"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'begincash'
    ''' </summary>
    Public Shared ReadOnly Property begincash() As String
      Get
        Return "begincash"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totalcheque'
    ''' </summary>
    Public Shared ReadOnly Property totalcheque() As String
      Get
        Return "totalcheque"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'changeprice'
    ''' </summary>
    Public Shared ReadOnly Property changeprice() As String
      Get
        Return "changeprice"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'transfer'
    ''' </summary>
    Public Shared ReadOnly Property transfer() As String
      Get
        Return "transfer"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'thousndp'
    ''' </summary>
    Public Shared ReadOnly Property thousndp() As String
      Get
        Return "thousndp"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'fiehundredp'
    ''' </summary>
    Public Shared ReadOnly Property fiehundredp() As String
      Get
        Return "fiehundredp"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'twohundredp'
    ''' </summary>
    Public Shared ReadOnly Property twohundredp() As String
      Get
        Return "twohundredp"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'onehundredp'
    ''' </summary>
    Public Shared ReadOnly Property onehundredp() As String
      Get
        Return "onehundredp"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'fiftyp'
    ''' </summary>
    Public Shared ReadOnly Property fiftyp() As String
      Get
        Return "fiftyp"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'twentyp'
    ''' </summary>
    Public Shared ReadOnly Property twentyp() As String
      Get
        Return "twentyp"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'tenp'
    ''' </summary>
    Public Shared ReadOnly Property tenp() As String
      Get
        Return "tenp"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'fivep'
    ''' </summary>
    Public Shared ReadOnly Property fivep() As String
      Get
        Return "fivep"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'onep'
    ''' </summary>
    Public Shared ReadOnly Property onep() As String
      Get
        Return "onep"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'twentyfive'
    ''' </summary>
    Public Shared ReadOnly Property twentyfive() As String
      Get
        Return "twentyfive"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'overshort'
    ''' </summary>
    Public Shared ReadOnly Property overshort() As String
      Get
        Return "overshort"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'status'
    ''' </summary>
    Public Shared ReadOnly Property status() As String
      Get
        Return "status"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'timereading'
    ''' </summary>
    Public Shared ReadOnly Property timereading() As String
      Get
        Return "timereading"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'payments'
    ''' </summary>
    Public Shared ReadOnly Property payments() As String
      Get
        Return "payments"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'readtime'
    ''' </summary>
    Public Shared ReadOnly Property readtime() As String
      Get
        Return "readtime"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pickup'
    ''' </summary>
    Public Shared ReadOnly Property pickup() As String
      Get
        Return "pickup"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'addcash'
    ''' </summary>
    Public Shared ReadOnly Property addcash() As String
      Get
        Return "addcash"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totalrefs'
    ''' </summary>
    Public Shared ReadOnly Property totalrefs() As String
      Get
        Return "totalrefs"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totalsales2'
    ''' </summary>
    Public Shared ReadOnly Property totalsales2() As String
      Get
        Return "totalsales2"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cnttotalsales'
    ''' </summary>
    Public Shared ReadOnly Property cnttotalsales() As String
      Get
        Return "cnttotalsales"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cnttotalrefunds'
    ''' </summary>
    Public Shared ReadOnly Property cnttotalrefunds() As String
      Get
        Return "cnttotalrefunds"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cnttotaldiscounts'
    ''' </summary>
    Public Shared ReadOnly Property cnttotaldiscounts() As String
      Get
        Return "cnttotaldiscounts"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cnttotaldep'
    ''' </summary>
    Public Shared ReadOnly Property cnttotaldep() As String
      Get
        Return "cnttotaldep"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cntsenior'
    ''' </summary>
    Public Shared ReadOnly Property cntsenior() As String
      Get
        Return "cntsenior"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cntdiscreg'
    ''' </summary>
    Public Shared ReadOnly Property cntdiscreg() As String
      Get
        Return "cntdiscreg"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cntvoids'
    ''' </summary>
    Public Shared ReadOnly Property cntvoids() As String
      Get
        Return "cntvoids"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cntreceipt'
    ''' </summary>
    Public Shared ReadOnly Property cntreceipt() As String
      Get
        Return "cntreceipt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'begreceipt'
    ''' </summary>
    Public Shared ReadOnly Property begreceipt() As String
      Get
        Return "begreceipt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'endreceipt'
    ''' </summary>
    Public Shared ReadOnly Property endreceipt() As String
      Get
        Return "endreceipt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'prevtotal'
    ''' </summary>
    Public Shared ReadOnly Property prevtotal() As String
      Get
        Return "prevtotal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'terminal'
    ''' </summary>
    Public Shared ReadOnly Property terminal() As String
      Get
        Return "terminal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totvat'
    ''' </summary>
    Public Shared ReadOnly Property totvat() As String
      Get
        Return "totvat"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totnonvat'
    ''' </summary>
    Public Shared ReadOnly Property totnonvat() As String
      Get
        Return "totnonvat"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totzerorated'
    ''' </summary>
    Public Shared ReadOnly Property totzerorated() As String
      Get
        Return "totzerorated"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sumvat'
    ''' </summary>
    Public Shared ReadOnly Property sumvat() As String
      Get
        Return "sumvat"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cntcredits'
    ''' </summary>
    Public Shared ReadOnly Property cntcredits() As String
      Get
        Return "cntcredits"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'accutotsale'
    ''' </summary>
    Public Shared ReadOnly Property accutotsale() As String
      Get
        Return "accutotsale"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'readingno'
    ''' </summary>
    Public Shared ReadOnly Property readingno() As String
      Get
        Return "readingno"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ETwo'
    ''' </summary>
    Public Shared ReadOnly Property ETwo() As String
      Get
        Return "ETwo"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'EOneHundred'
    ''' </summary>
    Public Shared ReadOnly Property EOneHundred() As String
      Get
        Return "EOneHundred"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'EFifty'
    ''' </summary>
    Public Shared ReadOnly Property EFifty() As String
      Get
        Return "EFifty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ETwenty'
    ''' </summary>
    Public Shared ReadOnly Property ETwenty() As String
      Get
        Return "ETwenty"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'ETen'
    ''' </summary>
    Public Shared ReadOnly Property ETen() As String
      Get
        Return "ETen"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'EFive'
    ''' </summary>
    Public Shared ReadOnly Property EFive() As String
      Get
        Return "EFive"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Eone'
    ''' </summary>
    Public Shared ReadOnly Property Eone() As String
      Get
        Return "Eone"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Ecents'
    ''' </summary>
    Public Shared ReadOnly Property Ecents() As String
      Get
        Return "Ecents"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'TotRemit'
    ''' </summary>
    Public Shared ReadOnly Property TotRemit() As String
      Get
        Return "TotRemit"
      End Get
    End Property
  End Class
#End Region
End Class
