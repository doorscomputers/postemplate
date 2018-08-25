Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the tblBarcodes class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class tblBarcodesValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the tblBarcodesValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a tblBarcodes</param>
  Public Sub New(ByVal entity As tblBarcodes)
    MyBase.New()

    _Entity = entity
    ClassName = "tblBarcodesValidator"

    ' Create Properties for each field in the tblBarcodes entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As tblBarcodes
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As tblBarcodes
    Get
      Return _Entity
    End Get
    Set(ByVal value As tblBarcodes)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current tblBarcodes
  ''' </summary>
  ''' <returns>A cloned tblBarcodes object</returns>
  Public Function CloneEntity() As tblBarcodes
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in tblBarcodes
  ''' </summary>
  ''' <returns>A cloned tblBarcodes object</returns>
  Public Function CloneEntity(ByVal entityToClone As tblBarcodes) As tblBarcodes
    Dim newEntity As New tblBarcodes()

    newEntity.bcodeid = entityToClone.bcodeid
    newEntity.barcode = entityToClone.barcode
    newEntity.stckid = entityToClone.stckid
    newEntity.dateadded = entityToClone.dateadded

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(tblBarcodesValidator.ColumnNames.bcodeid, "bcodeid", False, GetType(Integer), 10, "bcodeid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblBarcodesValidator.ColumnNames.barcode, "barcode", True, GetType(String), 22, "barcode must be filled in", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(tblBarcodesValidator.ColumnNames.stckid, "stckid", True, GetType(Integer), 10, "stckid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(tblBarcodesValidator.ColumnNames.dateadded, "dateadded", False, GetType(Date), -1, "", Convert.ToDateTime("1/1/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.bcodeid = 0
    Entity.barcode = String.Empty
    Entity.stckid = 0
    Entity.dateadded = DateTime.Now

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

    If Properties.GetByName(tblBarcodesValidator.ColumnNames.bcodeid).SetAsNull = False Then
      Properties.GetByName(tblBarcodesValidator.ColumnNames.bcodeid).Value = Entity.bcodeid
    End If
    If Properties.GetByName(tblBarcodesValidator.ColumnNames.barcode).SetAsNull = False Then
      Properties.GetByName(tblBarcodesValidator.ColumnNames.barcode).Value = Entity.barcode
    End If
    If Properties.GetByName(tblBarcodesValidator.ColumnNames.stckid).SetAsNull = False Then
      Properties.GetByName(tblBarcodesValidator.ColumnNames.stckid).Value = Entity.stckid
    End If
    If Properties.GetByName(tblBarcodesValidator.ColumnNames.dateadded).SetAsNull = False Then
      Properties.GetByName(tblBarcodesValidator.ColumnNames.dateadded).Value = Entity.dateadded
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

    If Properties.GetByName(tblBarcodesValidator.ColumnNames.bcodeid).IsNull = False Then
      Entity.bcodeid = Properties.GetByName(tblBarcodesValidator.ColumnNames.bcodeid).GetAsInteger()
    End If
    If Properties.GetByName(tblBarcodesValidator.ColumnNames.barcode).IsNull = False Then
      Entity.barcode = Properties.GetByName(tblBarcodesValidator.ColumnNames.barcode).GetAsString()
    End If
    If Properties.GetByName(tblBarcodesValidator.ColumnNames.stckid).IsNull = False Then
      Entity.stckid = Properties.GetByName(tblBarcodesValidator.ColumnNames.stckid).GetAsInteger()
    End If
    If Properties.GetByName(tblBarcodesValidator.ColumnNames.dateadded).IsNull = False Then
      Entity.dateadded = Properties.GetByName(tblBarcodesValidator.ColumnNames.dateadded).GetAsDate()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the tblBarcodes class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'bcodeid'
    ''' </summary>
    Public Shared ReadOnly Property bcodeid() As String
      Get
        Return "bcodeid"
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
    ''' Returns 'stckid'
    ''' </summary>
    Public Shared ReadOnly Property stckid() As String
      Get
        Return "stckid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'dateadded'
    ''' </summary>
    Public Shared ReadOnly Property dateadded() As String
      Get
        Return "dateadded"
      End Get
    End Property
  End Class
#End Region
End Class
