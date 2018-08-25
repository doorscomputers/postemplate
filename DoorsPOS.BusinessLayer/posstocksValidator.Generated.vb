Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the posstocks class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class posstocksValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the posstocksValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a posstocks</param>
  Public Sub New(ByVal entity As posstocks)
    MyBase.New()

    _Entity = entity
    ClassName = "posstocksValidator"

    ' Create Properties for each field in the posstocks entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As posstocks
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As posstocks
    Get
      Return _Entity
    End Get
    Set(ByVal value As posstocks)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current posstocks
  ''' </summary>
  ''' <returns>A cloned posstocks object</returns>
  Public Function CloneEntity() As posstocks
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in posstocks
  ''' </summary>
  ''' <returns>A cloned posstocks object</returns>
  Public Function CloneEntity(ByVal entityToClone As posstocks) As posstocks
    Dim newEntity As New posstocks()

    newEntity.stckid = entityToClone.stckid
    newEntity.itemdesc = entityToClone.itemdesc
    newEntity.available = entityToClone.available
    newEntity.retail = entityToClone.retail
    newEntity.retail2 = entityToClone.retail2
    newEntity.sInsertid = entityToClone.sInsertid
    newEntity.packaging = entityToClone.packaging
    newEntity.barcode = entityToClone.barcode

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(posstocksValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posstocksValidator.ColumnNames.itemdesc, "item desc", True, GetType(String), 1073741823, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(posstocksValidator.ColumnNames.available, "available", True, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), -2147483648, 0, "", ""))
    props.Add(PDSAProperty.Create(posstocksValidator.ColumnNames.retail, "retail", True, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posstocksValidator.ColumnNames.retail2, "retail2", True, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(posstocksValidator.ColumnNames.sInsertid, "s Insertid", True, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(posstocksValidator.ColumnNames.packaging, "packaging", True, GetType(Double), 53, "", Convert.ToDouble("-79228162514264337593543950335"), Convert.ToDouble("79228162514264337593543950335"), -2147483648, 0, "", ""))
    props.Add(PDSAProperty.Create(posstocksValidator.ColumnNames.barcode, "barcode", True, GetType(String), 22, "", Nothing, Nothing, 0, String.Empty, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.stckid = 0
    Entity.itemdesc = String.Empty
    Entity.available = 0
    Entity.retail = 0
    Entity.retail2 = 0
    Entity.sInsertid = String.Empty
    Entity.packaging = 0
    Entity.barcode = String.Empty

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

    If Properties.GetByName(posstocksValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(posstocksValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.itemdesc).SetAsNull = False Then
      Properties.GetByName(posstocksValidator.ColumnNames.itemdesc).Value = Entity.itemdesc
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.available).SetAsNull = False Then
      Properties.GetByName(posstocksValidator.ColumnNames.available).Value = Entity.available
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.retail).SetAsNull = False Then
      Properties.GetByName(posstocksValidator.ColumnNames.retail).Value = Entity.retail
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.retail2).SetAsNull = False Then
      Properties.GetByName(posstocksValidator.ColumnNames.retail2).Value = Entity.retail2
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.sInsertid).SetAsNull = False Then
      Properties.GetByName(posstocksValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.packaging).SetAsNull = False Then
      Properties.GetByName(posstocksValidator.ColumnNames.packaging).Value = Entity.packaging
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.barcode).SetAsNull = False Then
      Properties.GetByName(posstocksValidator.ColumnNames.barcode).Value = Entity.barcode
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

    If Properties.GetByName(posstocksValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(posstocksValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.itemdesc).IsNull = False Then
      Entity.itemdesc = Properties.GetByName(posstocksValidator.ColumnNames.itemdesc).GetAsString()
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.available).IsNull = False Then
      Entity.available = Properties.GetByName(posstocksValidator.ColumnNames.available).GetAsDouble()
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.retail).IsNull = False Then
      Entity.retail = Properties.GetByName(posstocksValidator.ColumnNames.retail).GetAsDecimal()
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.retail2).IsNull = False Then
      Entity.retail2 = Properties.GetByName(posstocksValidator.ColumnNames.retail2).GetAsDecimal()
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = Properties.GetByName(posstocksValidator.ColumnNames.sInsertid).GetAsString()
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.packaging).IsNull = False Then
      Entity.packaging = Properties.GetByName(posstocksValidator.ColumnNames.packaging).GetAsDouble()
    End If
    If Properties.GetByName(posstocksValidator.ColumnNames.barcode).IsNull = False Then
      Entity.barcode = Properties.GetByName(posstocksValidator.ColumnNames.barcode).GetAsString()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the posstocks class.
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
    ''' Returns 'retail'
    ''' </summary>
    Public Shared ReadOnly Property retail() As String
      Get
        Return "retail"
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
    ''' Returns 'sInsertid'
    ''' </summary>
    Public Shared ReadOnly Property sInsertid() As String
      Get
        Return "sInsertid"
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
    ''' Returns 'barcode'
    ''' </summary>
    Public Shared ReadOnly Property barcode() As String
      Get
        Return "barcode"
      End Get
    End Property
  End Class
#End Region
End Class
