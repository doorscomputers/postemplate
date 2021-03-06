Imports System
Imports System.Data
Imports System.Text

Imports PDSA.Common
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses

'Imports DoorsPOS.WinApp

''' <summary>
''' This class calls the stored procedure usp_pos_hdrtmpInsertData
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class usp_pos_hdrtmpInsertData
  Inherits PDSAStoredProcExecute

#Region "Constructors"
  Public Sub New()
    MyBase.New()

    _Entity = New usp_pos_hdrtmpInsert()

    Init()
  End Sub

  Public Sub New(ByVal entity As usp_pos_hdrtmpInsert)
    MyBase.New()

    _Entity = entity

    Init()
  End Sub

  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As usp_pos_hdrtmpInsert)
    MyBase.New(dataProvider)

    _Entity = entity

    Init()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As usp_pos_hdrtmpInsert
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the Entity class that will be used to get and set properties/fields for this data class.
  ''' </summary>
  Public Property Entity() As usp_pos_hdrtmpInsert
    Get
      Return _Entity
    End Get
    Set(ByVal value As usp_pos_hdrtmpInsert)
      _Entity = value
    End Set
  End Property
#End Region

#Region "Init Method"
  ''' <summary>
  ''' Initializes this class to a valid start state.
  ''' </summary>
  Protected Overrides Sub Init()
    ClassName = "usp_pos_hdrtmpInsertData"
    StoredProcName = "usp_pos_hdrtmpInsert"
    SchemaName = "dbo"

    ' Create Parameters
    InitParameters()
  End Sub
#End Region

#Region "InitParameters Method"
  ''' <summary>
  ''' Creates all the parameters for the stored procedure.
  ''' </summary>
  Protected Overrides Sub InitParameters()
    Dim param As PDSADataParameter
 
    ' Clear all parameters each time
    Me.AllParameters.Clear()

    ' Create each parameter object and add to Parameters Collection
    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.posdate
    param.DBType = DbType.Date
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.custid
    param.DBType = DbType.Int32
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.disc
    param.DBType = DbType.Double
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.discamnt
    param.DBType = DbType.Decimal
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.tendered
    param.DBType = DbType.Decimal
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.Cheyns
    param.DBType = DbType.Decimal
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.sInsertid
    param.DBType = DbType.String
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.mowd
    param.DBType = DbType.String
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.status
    param.DBType = DbType.Boolean
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.totsales
    param.DBType = DbType.Decimal
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.tid
    param.DBType = DbType.AnsiStringFixedLength
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.wtid
    param.DBType = DbType.Int32
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.RefNo
    param.DBType = DbType.Int32
    param.ParamDirection = ParameterDirection.InputOutput
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = usp_pos_hdrtmpInsertData.ParameterNames.RETURNVALUE
    param.DBType = DbType.Int32
    param.ParamDirection = ParameterDirection.ReturnValue
    Me.AllParameters.Add(param)


    AddReturnValueParameterToCollection()
  End Sub
#End Region

#Region "EntityDataToParameterCollection Method"
  ''' <summary>
  ''' Moves the data from the Entity class into the Parameters collection
  ''' </summary>
  Protected Overrides Sub EntityDataToParameterCollection()
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.posdate).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.posdate).Value = Entity.posdate
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.posdate).Value = System.Data.SqlTypes.SqlDateTime.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.custid).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.custid).Value = Entity.custid
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.custid).Value = System.Data.SqlTypes.SqlInt32.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.disc).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.disc).Value = Entity.disc
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.disc).Value = System.Data.SqlTypes.SqlDouble.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.discamnt).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.discamnt).Value = Entity.discamnt
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.discamnt).Value = System.Data.SqlTypes.SqlMoney.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.tendered).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.tendered).Value = Entity.tendered
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.tendered).Value = System.Data.SqlTypes.SqlMoney.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.Cheyns).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.Cheyns).Value = Entity.Cheyns
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.Cheyns).Value = System.Data.SqlTypes.SqlMoney.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.sInsertid).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.sInsertid).Value = Entity.sInsertid
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.sInsertid).Value = System.Data.SqlTypes.SqlString.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.mowd).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.mowd).Value = Entity.mowd
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.mowd).Value = System.Data.SqlTypes.SqlString.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.status).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.status).Value = Entity.status
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.status).Value = System.Data.SqlTypes.SqlBoolean.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.totsales).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.totsales).Value = Entity.totsales
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.totsales).Value = System.Data.SqlTypes.SqlMoney.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.tid).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.tid).Value = Entity.tid
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.tid).Value = System.Data.SqlTypes.SqlString.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.wtid).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.wtid).Value = Entity.wtid
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.wtid).Value = System.Data.SqlTypes.SqlInt32.Null
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.RefNo).SetAsNull = False Then
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.RefNo).Value = Entity.RefNo
    Else
      AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.RefNo).Value = System.Data.SqlTypes.SqlInt32.Null
    End If
  End Sub
#End Region

#Region "OutputParametersToEntityData Method"
  ''' <summary>
  ''' Moves the output parameters from the Parameters collection into the Entity class.
  ''' </summary>
  Protected Overrides Sub OutputParametersToEntityData()
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.RETURNVALUE).SetAsNull = false Then
      Entity.RETURNVALUE = AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.RETURNVALUE).GetAsInteger()
    End If
    If AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.RefNo).SetAsNull = false Then
      Entity.RefNo = AllParameters.GetByName(usp_pos_hdrtmpInsertData.ParameterNames.RefNo).GetAsInteger()
    End If
  End Sub
#End Region


#Region "SetDirtyFlag Methods" 
  ''' <summary> 
  ''' This is called with a 'false' value after each successful Insert/Update method call. 
  ''' </summary> 
  ''' <param name="isDirty">Called with 'false' by default</param> 
  Protected Overloads Overrides Sub SetDirtyFlag(ByVal isDirty As Boolean) 
    Entity.IsDirty = isDirty 
  End Sub 
#End Region 

#Region "ParameterNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the usp_pos_hdrtmpInsert class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ParameterNames
    ''' <summary>
    ''' Returns '@pos_date'
    ''' </summary>
    Public Shared ReadOnly Property posdate() As String
      Get
        Return "@pos_date"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@custid'
    ''' </summary>
    Public Shared ReadOnly Property custid() As String
      Get
        Return "@custid"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@disc'
    ''' </summary>
    Public Shared ReadOnly Property disc() As String
      Get
        Return "@disc"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@disc_amnt'
    ''' </summary>
    Public Shared ReadOnly Property discamnt() As String
      Get
        Return "@disc_amnt"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@tendered'
    ''' </summary>
    Public Shared ReadOnly Property tendered() As String
      Get
        Return "@tendered"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@Cheyns'
    ''' </summary>
    Public Shared ReadOnly Property Cheyns() As String
      Get
        Return "@Cheyns"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@sInsert_id'
    ''' </summary>
    Public Shared ReadOnly Property sInsertid() As String
      Get
        Return "@sInsert_id"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@mowd'
    ''' </summary>
    Public Shared ReadOnly Property mowd() As String
      Get
        Return "@mowd"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@status'
    ''' </summary>
    Public Shared ReadOnly Property status() As String
      Get
        Return "@status"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@totsales'
    ''' </summary>
    Public Shared ReadOnly Property totsales() As String
      Get
        Return "@totsales"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@tid'
    ''' </summary>
    Public Shared ReadOnly Property tid() As String
      Get
        Return "@tid"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@wtid'
    ''' </summary>
    Public Shared ReadOnly Property wtid() As String
      Get
        Return "@wtid"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@RefNo'
    ''' </summary>
    Public Shared ReadOnly Property RefNo() As String
      Get
        Return "@RefNo"
      End Get
    End Property
    ''' <summary>
    ''' Returns '@RETURN_VALUE'
    ''' </summary>
    Public Shared ReadOnly Property RETURNVALUE() As String
      Get
        Return "@RETURN_VALUE"
      End Get
    End Property
  End Class
#End Region
End Class

