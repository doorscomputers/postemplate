Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

''' <summary>
''' Used to validate all properties of the banktrans class.
''' This class is generated using the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Partial Public Class banktransValidator
  Inherits PDSAValidatorBase

#Region "Constructor"
  ''' <summary>
  ''' Constructor for the banktransValidator class
  ''' </summary>
  ''' <param name="entity">An instance of a banktrans</param>
  Public Sub New(ByVal entity As banktrans)
    MyBase.New()

    _Entity = entity
    ClassName = "banktransValidator"

    ' Create Properties for each field in the banktrans entity class
    InitProperties()
    
    ' Add any additional business rules to the Properties.
    AddBusinessRulesToProperties()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As banktrans
#End Region

#Region "Public Entity Property"
  Public Overloads Property Entity() As banktrans
    Get
      Return _Entity
    End Get
    Set(ByVal value As banktrans)
      _Entity = value
      MyBase.Entity = value
    End Set
  End Property
#End Region

#Region "CloneEntity Method"
  ''' <summary>
  ''' Clones the current banktrans
  ''' </summary>
  ''' <returns>A cloned banktrans object</returns>
  Public Function CloneEntity() As banktrans
     Return CloneEntity(Me.Entity)
  End Function
  
  ''' <summary>
  ''' Clones the passed in banktrans
  ''' </summary>
  ''' <returns>A cloned banktrans object</returns>
  Public Function CloneEntity(ByVal entityToClone As banktrans) As banktrans
    Dim newEntity As New banktrans()

    newEntity.banktransid = entityToClone.banktransid
    newEntity.bankid = entityToClone.bankid
    newEntity.transdate = entityToClone.transdate
    newEntity.oldbal = entityToClone.oldbal
    newEntity.newbal = entityToClone.newbal
    newEntity.transrefno = entityToClone.transrefno
    newEntity.transtype = entityToClone.transtype
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

    props.Add(PDSAProperty.Create(banktransValidator.ColumnNames.banktransid, "banktransid", False, GetType(Integer), 10, "banktransid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(banktransValidator.ColumnNames.bankid, "bankid", True, GetType(Integer), 10, "bankid must be filled in", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(banktransValidator.ColumnNames.transdate, "transdate", True, GetType(Date), -1, "transdate must be filled in", Convert.ToDateTime("01/01/1753 12:00:00 AM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), Convert.ToDateTime("12/31/9999 11:59:59 PM", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat), 0, DateTime.Now, "", ""))
    props.Add(PDSAProperty.Create(banktransValidator.ColumnNames.oldbal, "oldbal", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(banktransValidator.ColumnNames.newbal, "newbal", False, GetType(Decimal), 19, "", Convert.ToDecimal("-79228162514264337593543950335"), Convert.ToDecimal("79228162514264337593543950335"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(banktransValidator.ColumnNames.transrefno, "transrefno", False, GetType(Integer), 10, "", Convert.ToInt32("-2147483648"), Convert.ToInt32("2147483647"), 0, 0, "", ""))
    props.Add(PDSAProperty.Create(banktransValidator.ColumnNames.transtype, "transtype", False, GetType(String), 10, "", Nothing, Nothing, 0, String.Empty, "", ""))
    props.Add(PDSAProperty.Create(banktransValidator.ColumnNames.remarks, "remarks", False, GetType(String), 50, "", Nothing, Nothing, 0, String.Empty, "", ""))
    
    Return props
  End Function
#End Region

#Region "Initialize Entity"
  ''' <summary>
  ''' This method is called from the CreateNewEntity Method. All the properties for the Entity are set to default values here by the code generator.
  ''' </summary>
  Protected Overrides Sub InitializeEntity()    
    Entity.banktransid = 0
    Entity.bankid = 0
    Entity.transdate = DateTime.Now
    Entity.oldbal = 0
    Entity.newbal = 0
    Entity.transrefno = 0
    Entity.transtype = String.Empty
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

    If Properties.GetByName(banktransValidator.ColumnNames.banktransid).SetAsNull = False Then
      Properties.GetByName(banktransValidator.ColumnNames.banktransid).Value = Entity.banktransid
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.bankid).SetAsNull = False Then
      Properties.GetByName(banktransValidator.ColumnNames.bankid).Value = Entity.bankid
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.transdate).SetAsNull = False Then
      Properties.GetByName(banktransValidator.ColumnNames.transdate).Value = Entity.transdate
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.oldbal).SetAsNull = False Then
      Properties.GetByName(banktransValidator.ColumnNames.oldbal).Value = Entity.oldbal
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.newbal).SetAsNull = False Then
      Properties.GetByName(banktransValidator.ColumnNames.newbal).Value = Entity.newbal
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.transrefno).SetAsNull = False Then
      Properties.GetByName(banktransValidator.ColumnNames.transrefno).Value = Entity.transrefno
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.transtype).SetAsNull = False Then
      Properties.GetByName(banktransValidator.ColumnNames.transtype).Value = Entity.transtype
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.remarks).SetAsNull = False Then
      Properties.GetByName(banktransValidator.ColumnNames.remarks).Value = Entity.remarks
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

    If Properties.GetByName(banktransValidator.ColumnNames.banktransid).IsNull = False Then
      Entity.banktransid = Properties.GetByName(banktransValidator.ColumnNames.banktransid).GetAsInteger()
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.bankid).IsNull = False Then
      Entity.bankid = Properties.GetByName(banktransValidator.ColumnNames.bankid).GetAsInteger()
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.transdate).IsNull = False Then
      Entity.transdate = Properties.GetByName(banktransValidator.ColumnNames.transdate).GetAsDate()
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.oldbal).IsNull = False Then
      Entity.oldbal = Properties.GetByName(banktransValidator.ColumnNames.oldbal).GetAsDecimal()
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.newbal).IsNull = False Then
      Entity.newbal = Properties.GetByName(banktransValidator.ColumnNames.newbal).GetAsDecimal()
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.transrefno).IsNull = False Then
      Entity.transrefno = Properties.GetByName(banktransValidator.ColumnNames.transrefno).GetAsInteger()
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.transtype).IsNull = False Then
      Entity.transtype = Properties.GetByName(banktransValidator.ColumnNames.transtype).GetAsString()
    End If
    If Properties.GetByName(banktransValidator.ColumnNames.remarks).IsNull = False Then
      Entity.remarks = Properties.GetByName(banktransValidator.ColumnNames.remarks).GetAsString()
    End If
  End Sub
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the banktrans class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'banktransid'
    ''' </summary>
    Public Shared ReadOnly Property banktransid() As String
      Get
        Return "banktransid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'bankid'
    ''' </summary>
    Public Shared ReadOnly Property bankid() As String
      Get
        Return "bankid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'transdate'
    ''' </summary>
    Public Shared ReadOnly Property transdate() As String
      Get
        Return "transdate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'oldbal'
    ''' </summary>
    Public Shared ReadOnly Property oldbal() As String
      Get
        Return "oldbal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'newbal'
    ''' </summary>
    Public Shared ReadOnly Property newbal() As String
      Get
        Return "newbal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'transrefno'
    ''' </summary>
    Public Shared ReadOnly Property transrefno() As String
      Get
        Return "transrefno"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'transtype'
    ''' </summary>
    Public Shared ReadOnly Property transtype() As String
      Get
        Return "transtype"
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
