Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the pos_hdr class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class pos_hdrValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the pos_hdrValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a pos_hdr</param>
  Public Sub New(ByVal entity As pos_hdr)
    MyBase.New()

    _Entity = entity
    ClassName = "pos_hdrValidator"

    ' Create Properties for each field in the pos_hdr entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As pos_hdr
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As pos_hdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As pos_hdr)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current pos_hdr
  ''' </summary>
  ''' <returns>A cloned pos_hdr object</returns>
  Public Function CloneEntity() As pos_hdr
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in pos_hdr
  ''' </summary>
  ''' <returns>A cloned pos_hdr object</returns>
  Public Function CloneEntity(ByVal entityToClone As pos_hdr) As pos_hdr
    Dim newEntity As New pos_hdr()

    newEntity.postmphdrid = entityToClone.postmphdrid
    newEntity.posdate = entityToClone.posdate
    newEntity.custid = entityToClone.custid
    newEntity.disc = entityToClone.disc
    newEntity.posamnt = entityToClone.posamnt
    newEntity.discamnt = entityToClone.discamnt
    newEntity.tendered = entityToClone.tendered
    newEntity.Cheyns = entityToClone.Cheyns
    newEntity.subtot = entityToClone.subtot
    newEntity.posted = entityToClone.posted
    newEntity.postme = entityToClone.postme
    newEntity.costamnt = entityToClone.costamnt
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.dtInsertdt = entityToClone.dtInsertdt
    newEntity.sLastUpdateid = entityToClone.sLastUpdateid
    newEntity.dtLastUpdatedt = entityToClone.dtLastUpdatedt
    newEntity.iConcurrencyid = entityToClone.iConcurrencyid
    newEntity.cheque = entityToClone.cheque
    newEntity.mowd = entityToClone.mowd
    newEntity.paidamnt = entityToClone.paidamnt
    newEntity.status = entityToClone.status
    newEntity.bal = entityToClone.bal
    newEntity.Custnum = entityToClone.Custnum
    newEntity.Sc = entityToClone.Sc
    newEntity.totsales = entityToClone.totsales
    newEntity.lessvat = entityToClone.lessvat
    newEntity.nov = entityToClone.nov
    newEntity.lesssc = entityToClone.lesssc
    newEntity.vatable = entityToClone.vatable
    newEntity.exempt = entityToClone.exempt
    newEntity.vatamnt = entityToClone.vatamnt
    newEntity.tid = entityToClone.tid
    newEntity.wtid = entityToClone.wtid
    newEntity.trminal = entityToClone.trminal

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.postmphdrid, "postmp hdrid", True, GetType(Integer), 10, "postmp hdrid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.posdate, "pos date", True, GetType(Date), -1, "pos date must be filled in", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.custid, "custid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.disc, "disc", False, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.posamnt, "pos amnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.discamnt, "disc amnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.tendered, "tendered", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.Cheyns, "Cheyns", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.subtot, "subtot", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.posted, "posted", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.postme, "pos tme", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.costamnt, "cost amnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.dtInsertdt, "dt Insert  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.sLastUpdateid, "s Last Update  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.dtLastUpdatedt, "dt Last Update  dt", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.iConcurrencyid, "i Concurrency  id", False, GetType(Short), 5, "", Convert.ToInt16("-32768"), Convert.ToInt16("32767"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.cheque, "cheque", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.mowd, "mowd", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.paidamnt, "paidamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.status, "status", False, GetType(Boolean?), -1, "", Nothing, Nothing, 0, False, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.bal, "bal", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.Custnum, "Custnum", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.Sc, "Sc", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.totsales, "totsales", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.lessvat, "less vat", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.nov, "nov", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.lesssc, "less sc", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.vatable, "vatable", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.exempt, "exempt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.vatamnt, "vatamnt", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.tid, "tid", False, GetType(String), 10, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.wtid, "wtid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(pos_hdrValidator.ColumnNames.trminal, "trminal", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.postmphdrid = 0
    Entity.posdate = DateTime.Now
    Entity.custid = 0
    Entity.disc = 0
    Entity.posamnt = 0
    Entity.discamnt = 0
    Entity.tendered = 0
    Entity.Cheyns = 0
    Entity.subtot = 0
    Entity.posted = False
    Entity.postme = DateTime.Now
    Entity.costamnt = 0
    Entity.sInsertid = String.Empty
    Entity.dtInsertdt = DateTime.Now
    Entity.sLastUpdateid = String.Empty
    Entity.dtLastUpdatedt = DateTime.Now
    Entity.iConcurrencyid = 0
    Entity.cheque = String.Empty
    Entity.mowd = String.Empty
    Entity.paidamnt = 0
    Entity.status = False
    Entity.bal = 0
    Entity.Custnum = 0
    Entity.Sc = 0
    Entity.totsales = 0
    Entity.lessvat = 0
    Entity.nov = 0
    Entity.lesssc = 0
    Entity.vatable = 0
    Entity.exempt = 0
    Entity.vatamnt = 0
    Entity.tid = String.Empty
    Entity.wtid = 0
    Entity.trminal = 0

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

    If Properties.GetByName(pos_hdrValidator.ColumnNames.postmphdrid).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.postmphdrid).Value = Entity.postmphdrid
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.posdate).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.posdate).Value = Entity.posdate
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.custid).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.custid).Value = Entity.custid
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.disc).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.disc).Value = Entity.disc
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.posamnt).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.posamnt).Value = Entity.posamnt
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.discamnt).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.discamnt).Value = Entity.discamnt
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.tendered).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.tendered).Value = Entity.tendered
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.Cheyns).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.Cheyns).Value = Entity.Cheyns
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.subtot).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.subtot).Value = Entity.subtot
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.posted).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.posted).Value = Entity.posted
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.postme).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.postme).Value = Entity.postme
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.costamnt).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.costamnt).Value = Entity.costamnt
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.dtInsertdt).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.sLastUpdateid).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.dtLastUpdatedt).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.iConcurrencyid).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.cheque).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.cheque).Value = Entity.cheque
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.mowd).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.mowd).Value = Entity.mowd
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.paidamnt).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.paidamnt).Value = Entity.paidamnt
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.status).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.status).Value = Entity.status
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.bal).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.bal).Value = Entity.bal
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.Custnum).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.Custnum).Value = Entity.Custnum
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.Sc).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.Sc).Value = Entity.Sc
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.totsales).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.totsales).Value = Entity.totsales
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.lessvat).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.lessvat).Value = Entity.lessvat
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.nov).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.nov).Value = Entity.nov
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.lesssc).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.lesssc).Value = Entity.lesssc
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.vatable).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.vatable).Value = Entity.vatable
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.exempt).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.exempt).Value = Entity.exempt
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.vatamnt).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.vatamnt).Value = Entity.vatamnt
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.tid).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.tid).Value = Entity.tid
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.wtid).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.wtid).Value = Entity.wtid
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.trminal).SetAsNull = False Then
      Properties.GetByName(pos_hdrValidator.ColumnNames.trminal).Value = Entity.trminal
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

    If Properties.GetByName(pos_hdrValidator.ColumnNames.postmphdrid).IsNull = False Then
      Entity.postmphdrid = Properties.GetByName(pos_hdrValidator.ColumnNames.postmphdrid).GetAsInteger()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.posdate).IsNull = False Then
      Entity.posdate = Properties.GetByName(pos_hdrValidator.ColumnNames.posdate).GetAsDate()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.custid).IsNull = False Then
      Entity.custid = Properties.GetByName(pos_hdrValidator.ColumnNames.custid).GetAsInteger()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.disc).IsNull = False Then
      Entity.disc = Properties.GetByName(pos_hdrValidator.ColumnNames.disc).GetAsDouble()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.posamnt).IsNull = False Then
      Entity.posamnt = Properties.GetByName(pos_hdrValidator.ColumnNames.posamnt).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.discamnt).IsNull = False Then
      Entity.discamnt = Properties.GetByName(pos_hdrValidator.ColumnNames.discamnt).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.tendered).IsNull = False Then
      Entity.tendered = Properties.GetByName(pos_hdrValidator.ColumnNames.tendered).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.Cheyns).IsNull = False Then
      Entity.Cheyns = Properties.GetByName(pos_hdrValidator.ColumnNames.Cheyns).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.subtot).IsNull = False Then
      Entity.subtot = Properties.GetByName(pos_hdrValidator.ColumnNames.subtot).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.posted).IsNull = False Then
      Entity.posted = Properties.GetByName(pos_hdrValidator.ColumnNames.posted).GetValueAsBoolean()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.postme).IsNull = False Then
      Entity.postme = Properties.GetByName(pos_hdrValidator.ColumnNames.postme).GetAsDate()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.costamnt).IsNull = False Then
      Entity.costamnt = Properties.GetByName(pos_hdrValidator.ColumnNames.costamnt).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(pos_hdrValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = Properties.GetByName(pos_hdrValidator.ColumnNames.dtInsertdt).GetAsDate()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = Properties.GetByName(pos_hdrValidator.ColumnNames.sLastUpdateid).GetAsString()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = Properties.GetByName(pos_hdrValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = Properties.GetByName(pos_hdrValidator.ColumnNames.iConcurrencyid).GetAsShort()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.cheque).IsNull = False Then
      Entity.cheque = Properties.GetByName(pos_hdrValidator.ColumnNames.cheque).GetAsString()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.mowd).IsNull = False Then
      Entity.mowd = Properties.GetByName(pos_hdrValidator.ColumnNames.mowd).GetAsString()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.paidamnt).IsNull = False Then
      Entity.paidamnt = Properties.GetByName(pos_hdrValidator.ColumnNames.paidamnt).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.status).IsNull = False Then
      Entity.status = Properties.GetByName(pos_hdrValidator.ColumnNames.status).GetValueAsBoolean()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.bal).IsNull = False Then
      Entity.bal = Properties.GetByName(pos_hdrValidator.ColumnNames.bal).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.Custnum).IsNull = False Then
      Entity.Custnum = Properties.GetByName(pos_hdrValidator.ColumnNames.Custnum).GetAsInteger()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.Sc).IsNull = False Then
      Entity.Sc = Properties.GetByName(pos_hdrValidator.ColumnNames.Sc).GetAsInteger()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.totsales).IsNull = False Then
      Entity.totsales = Properties.GetByName(pos_hdrValidator.ColumnNames.totsales).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.lessvat).IsNull = False Then
      Entity.lessvat = Properties.GetByName(pos_hdrValidator.ColumnNames.lessvat).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.nov).IsNull = False Then
      Entity.nov = Properties.GetByName(pos_hdrValidator.ColumnNames.nov).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.lesssc).IsNull = False Then
      Entity.lesssc = Properties.GetByName(pos_hdrValidator.ColumnNames.lesssc).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.vatable).IsNull = False Then
      Entity.vatable = Properties.GetByName(pos_hdrValidator.ColumnNames.vatable).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.exempt).IsNull = False Then
      Entity.exempt = Properties.GetByName(pos_hdrValidator.ColumnNames.exempt).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.vatamnt).IsNull = False Then
      Entity.vatamnt = Properties.GetByName(pos_hdrValidator.ColumnNames.vatamnt).GetAsDecimal()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.tid).IsNull = False Then
      Entity.tid = Properties.GetByName(pos_hdrValidator.ColumnNames.tid).GetAsString()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.wtid).IsNull = False Then
      Entity.wtid = Properties.GetByName(pos_hdrValidator.ColumnNames.wtid).GetAsInteger()
    End If
    If Properties.GetByName(pos_hdrValidator.ColumnNames.trminal).IsNull = False Then
      Entity.trminal = Properties.GetByName(pos_hdrValidator.ColumnNames.trminal).GetAsInteger()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the pos_hdr class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'postmp_hdrid'
    ''' </summary>
    Public Shared ReadOnly Property postmphdrid() As String
      Get
        Return "postmp_hdrid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pos_date'
    ''' </summary>
    Public Shared ReadOnly Property posdate() As String
      Get
        Return "pos_date"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'custid'
    ''' </summary>
    Public Shared ReadOnly Property custid() As String
      Get
        Return "custid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'disc'
    ''' </summary>
    Public Shared ReadOnly Property disc() As String
      Get
        Return "disc"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pos_amnt'
    ''' </summary>
    Public Shared ReadOnly Property posamnt() As String
      Get
        Return "pos_amnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'disc_amnt'
    ''' </summary>
    Public Shared ReadOnly Property discamnt() As String
      Get
        Return "disc_amnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'tendered'
    ''' </summary>
    Public Shared ReadOnly Property tendered() As String
      Get
        Return "tendered"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Cheyns'
    ''' </summary>
    Public Shared ReadOnly Property Cheyns() As String
      Get
        Return "Cheyns"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'subtot'
    ''' </summary>
    Public Shared ReadOnly Property subtot() As String
      Get
        Return "subtot"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'posted'
    ''' </summary>
    Public Shared ReadOnly Property posted() As String
      Get
        Return "posted"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'pos_tme'
    ''' </summary>
    Public Shared ReadOnly Property postme() As String
      Get
        Return "pos_tme"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cost_amnt'
    ''' </summary>
    Public Shared ReadOnly Property costamnt() As String
      Get
        Return "cost_amnt"
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
    ''' Returns 'cheque'
    ''' </summary>
    Public Shared ReadOnly Property cheque() As String
      Get
        Return "cheque"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'mowd'
    ''' </summary>
    Public Shared ReadOnly Property mowd() As String
      Get
        Return "mowd"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'paidamnt'
    ''' </summary>
    Public Shared ReadOnly Property paidamnt() As String
      Get
        Return "paidamnt"
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
    ''' Returns 'bal'
    ''' </summary>
    Public Shared ReadOnly Property bal() As String
      Get
        Return "bal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Custnum'
    ''' </summary>
    Public Shared ReadOnly Property Custnum() As String
      Get
        Return "Custnum"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'Sc'
    ''' </summary>
    Public Shared ReadOnly Property Sc() As String
      Get
        Return "Sc"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'totsales'
    ''' </summary>
    Public Shared ReadOnly Property totsales() As String
      Get
        Return "totsales"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'less_vat'
    ''' </summary>
    Public Shared ReadOnly Property lessvat() As String
      Get
        Return "less_vat"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'nov'
    ''' </summary>
    Public Shared ReadOnly Property nov() As String
      Get
        Return "nov"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'less_sc'
    ''' </summary>
    Public Shared ReadOnly Property lesssc() As String
      Get
        Return "less_sc"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'vatable'
    ''' </summary>
    Public Shared ReadOnly Property vatable() As String
      Get
        Return "vatable"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'exempt'
    ''' </summary>
    Public Shared ReadOnly Property exempt() As String
      Get
        Return "exempt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'vatamnt'
    ''' </summary>
    Public Shared ReadOnly Property vatamnt() As String
      Get
        Return "vatamnt"
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
    ''' Returns 'wtid'
    ''' </summary>
    Public Shared ReadOnly Property wtid() As String
      Get
        Return "wtid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'trminal'
    ''' </summary>
    Public Shared ReadOnly Property trminal() As String
      Get
        Return "trminal"
      End Get
    End Property
  End Class
#End Region
End Class
