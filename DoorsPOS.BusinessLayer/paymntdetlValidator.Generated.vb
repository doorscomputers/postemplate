Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the paymntdetl class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class paymntdetlValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the paymntdetlValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a paymntdetl</param>
  Public Sub New(ByVal entity As paymntdetl)
    MyBase.New()

    _Entity = entity
    ClassName = "paymntdetlValidator"

    ' Create Properties for each field in the paymntdetl entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As paymntdetl
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As paymntdetl
    Get
      Return _Entity
    End Get
    Set(ByVal value As paymntdetl)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current paymntdetl
  ''' </summary>
  ''' <returns>A cloned paymntdetl object</returns>
  Public Function CloneEntity() As paymntdetl
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in paymntdetl
  ''' </summary>
  ''' <returns>A cloned paymntdetl object</returns>
  Public Function CloneEntity(ByVal entityToClone As paymntdetl) As paymntdetl
    Dim newEntity As New paymntdetl()

    newEntity.pmntdetid = entityToClone.pmntdetid
    newEntity.payid = entityToClone.payid
    newEntity.drinv = entityToClone.drinv
    newEntity.drid = entityToClone.drid
    newEntity.amnt = entityToClone.amnt
    newEntity.remarks = entityToClone.remarks

    Return newEntity
  End Function
#End Region

#Region "CreateProperties Method"
  ''' <summary>
  ''' Creates the collection of PDSAProperty objects. These are used to control validation and null handling.
  ''' </summary>
  Public Overrides Function CreateProperties() As PDSAProperties
    Dim props As New PDSAProperties()

    props.Add(PDSAProperty.Create(paymntdetlValidator.ColumnNames.pmntdetid, "pmntdetid", False, GetType(Integer), 10, "pmntdetid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymntdetlValidator.ColumnNames.payid, "payid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymntdetlValidator.ColumnNames.drinv, "drinv", False, GetType(String), 15, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(paymntdetlValidator.ColumnNames.drid, "drid", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymntdetlValidator.ColumnNames.amnt, "amnt", True, GetType(Decimal), 19, "amnt must be filled in", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(paymntdetlValidator.ColumnNames.remarks, "remarks", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.pmntdetid = 0
    Entity.payid = 0
    Entity.drinv = String.Empty
    Entity.drid = 0
    Entity.amnt = 0
    Entity.remarks = String.Empty

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

    If Properties.GetByName(paymntdetlValidator.ColumnNames.pmntdetid).SetAsNull = False Then
      Properties.GetByName(paymntdetlValidator.ColumnNames.pmntdetid).Value = Entity.pmntdetid
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.payid).SetAsNull = False Then
      Properties.GetByName(paymntdetlValidator.ColumnNames.payid).Value = Entity.payid
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.drinv).SetAsNull = False Then
      Properties.GetByName(paymntdetlValidator.ColumnNames.drinv).Value = Entity.drinv
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.drid).SetAsNull = False Then
      Properties.GetByName(paymntdetlValidator.ColumnNames.drid).Value = Entity.drid
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.amnt).SetAsNull = False Then
      Properties.GetByName(paymntdetlValidator.ColumnNames.amnt).Value = Entity.amnt
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.remarks).SetAsNull = False Then
      Properties.GetByName(paymntdetlValidator.ColumnNames.remarks).Value = Entity.remarks
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

    If Properties.GetByName(paymntdetlValidator.ColumnNames.pmntdetid).IsNull = False Then
      Entity.pmntdetid = Properties.GetByName(paymntdetlValidator.ColumnNames.pmntdetid).GetAsInteger()
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.payid).IsNull = False Then
      Entity.payid = Properties.GetByName(paymntdetlValidator.ColumnNames.payid).GetAsInteger()
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.drinv).IsNull = False Then
      Entity.drinv = Properties.GetByName(paymntdetlValidator.ColumnNames.drinv).GetAsString()
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.drid).IsNull = False Then
      Entity.drid = Properties.GetByName(paymntdetlValidator.ColumnNames.drid).GetAsInteger()
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.amnt).IsNull = False Then
      Entity.amnt = Properties.GetByName(paymntdetlValidator.ColumnNames.amnt).GetAsDecimal()
    End If
    If Properties.GetByName(paymntdetlValidator.ColumnNames.remarks).IsNull = False Then
      Entity.remarks = Properties.GetByName(paymntdetlValidator.ColumnNames.remarks).GetAsString()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the paymntdetl class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'pmntdetid'
    ''' </summary>
    Public Shared ReadOnly Property pmntdetid() As String
      Get
        Return "pmntdetid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'payid'
    ''' </summary>
    Public Shared ReadOnly Property payid() As String
      Get
        Return "payid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drinv'
    ''' </summary>
    Public Shared ReadOnly Property drinv() As String
      Get
        Return "drinv"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drid'
    ''' </summary>
    Public Shared ReadOnly Property drid() As String
      Get
        Return "drid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'amnt'
    ''' </summary>
    Public Shared ReadOnly Property amnt() As String
      Get
        Return "amnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'remarks'
    ''' </summary>
    Public Shared ReadOnly Property remarks() As String
      Get
        Return "remarks"
      End Get
    End Property
  End Class
#End Region
End Class
