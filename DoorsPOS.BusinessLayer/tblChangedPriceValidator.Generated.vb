Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the tblChangedPrice class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class tblChangedPriceValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the tblChangedPriceValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a tblChangedPrice</param>
  Public Sub New(ByVal entity As tblChangedPrice)
    MyBase.New()

    _Entity = entity
    ClassName = "tblChangedPriceValidator"

    ' Create Properties for each field in the tblChangedPrice entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As tblChangedPrice
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As tblChangedPrice
    Get
      Return _Entity
    End Get
    Set(ByVal value As tblChangedPrice)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current tblChangedPrice
  ''' </summary>
  ''' <returns>A cloned tblChangedPrice object</returns>
  Public Function CloneEntity() As tblChangedPrice
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in tblChangedPrice
  ''' </summary>
  ''' <returns>A cloned tblChangedPrice object</returns>
  Public Function CloneEntity(ByVal entityToClone As tblChangedPrice) As tblChangedPrice
    Dim newEntity As New tblChangedPrice()

    newEntity.cpid = entityToClone.cpid
    newEntity.cpdate = entityToClone.cpdate
    newEntity.stckid = entityToClone.stckid
    newEntity.oldprice = entityToClone.oldprice
    newEntity.newprice = entityToClone.newprice
    newEntity.sInsertid = entityToClone.sInsertid

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(tblChangedPriceValidator.ColumnNames.cpid, "cpid", False, GetType(Integer), 10, "cpid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblChangedPriceValidator.ColumnNames.cpdate, "cpdate", False, GetType(Date), -1, "", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(tblChangedPriceValidator.ColumnNames.stckid, "stckid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblChangedPriceValidator.ColumnNames.oldprice, "oldprice", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblChangedPriceValidator.ColumnNames.newprice, "newprice", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblChangedPriceValidator.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.cpid = 0
    Entity.cpdate = DateTime.Now
    Entity.stckid = 0
    Entity.oldprice = 0
    Entity.newprice = 0
    Entity.sInsertid = String.Empty

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

    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.cpid).SetAsNull = False Then
      Properties.GetByName(tblChangedPriceValidator.ColumnNames.cpid).Value = Entity.cpid
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.cpdate).SetAsNull = False Then
      Properties.GetByName(tblChangedPriceValidator.ColumnNames.cpdate).Value = Entity.cpdate
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(tblChangedPriceValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.oldprice).SetAsNull = False Then
      Properties.GetByName(tblChangedPriceValidator.ColumnNames.oldprice).Value = Entity.oldprice
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.newprice).SetAsNull = False Then
      Properties.GetByName(tblChangedPriceValidator.ColumnNames.newprice).Value = Entity.newprice
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(tblChangedPriceValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
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

    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.cpid).IsNull = False Then
      Entity.cpid = Properties.GetByName(tblChangedPriceValidator.ColumnNames.cpid).GetAsInteger()
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.cpdate).IsNull = False Then
      Entity.cpdate = Properties.GetByName(tblChangedPriceValidator.ColumnNames.cpdate).GetAsDate()
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(tblChangedPriceValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.oldprice).IsNull = False Then
      Entity.oldprice = Properties.GetByName(tblChangedPriceValidator.ColumnNames.oldprice).GetAsDecimal()
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.newprice).IsNull = False Then
      Entity.newprice = Properties.GetByName(tblChangedPriceValidator.ColumnNames.newprice).GetAsDecimal()
    End If
    If Properties.GetByName(tblChangedPriceValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(tblChangedPriceValidator.ColumnNames.sInsertid).GetAsString()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the tblChangedPrice class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'cpid'
    ''' </summary>
    Public Shared ReadOnly Property cpid() As String
      Get
        Return "cpid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'cpdate'
    ''' </summary>
    Public Shared ReadOnly Property cpdate() As String
      Get
        Return "cpdate"
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
    ''' Returns 'oldprice'
    ''' </summary>
    Public Shared ReadOnly Property oldprice() As String
      Get
        Return "oldprice"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'newprice'
    ''' </summary>
    Public Shared ReadOnly Property newprice() As String
      Get
        Return "newprice"
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
  End Class
#End Region
End Class
