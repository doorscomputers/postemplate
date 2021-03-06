Imports System
Imports System.Data
Imports System.Text

Imports PDSA.Common
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses

'Imports DoorsPOS.WinApp

''' <summary>
''' This class calls the stored procedure spGetTransferNoData
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class spGetTransferNoData
  Inherits PDSAStoredProcExecute

#Region "Constructors"
  Public Sub New()
    MyBase.New()

    _Entity = New spGetTransferNo()

    Init()
  End Sub

  Public Sub New(ByVal entity As spGetTransferNo)
    MyBase.New()

    _Entity = entity

    Init()
  End Sub

  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As spGetTransferNo)
    MyBase.New(dataProvider)

    _Entity = entity

    Init()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As spGetTransferNo
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the Entity class that will be used to get and set properties/fields for this data class.
  ''' </summary>
  Public Property Entity() As spGetTransferNo
    Get
      Return _Entity
    End Get
    Set(ByVal value As spGetTransferNo)
      _Entity = value
    End Set
  End Property
#End Region

#Region "Init Method"
  ''' <summary>
  ''' Initializes this class to a valid start state.
  ''' </summary>
  Protected Overrides Sub Init()
    ClassName = "spGetTransferNoData"
    StoredProcName = "spGetTransferNo"
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
    param.ParameterName = spGetTransferNoData.ParameterNames.TransferNo
    param.DBType = DbType.Int32
    param.ParamDirection = ParameterDirection.InputOutput
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = spGetTransferNoData.ParameterNames.RETURNVALUE
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
    If AllParameters.GetByName(spGetTransferNoData.ParameterNames.TransferNo).SetAsNull = False Then
      AllParameters.GetByName(spGetTransferNoData.ParameterNames.TransferNo).Value = Entity.TransferNo
    Else
      AllParameters.GetByName(spGetTransferNoData.ParameterNames.TransferNo).Value = System.Data.SqlTypes.SqlInt32.Null
    End If
  End Sub
#End Region

#Region "OutputParametersToEntityData Method"
  ''' <summary>
  ''' Moves the output parameters from the Parameters collection into the Entity class.
  ''' </summary>
  Protected Overrides Sub OutputParametersToEntityData()
    If AllParameters.GetByName(spGetTransferNoData.ParameterNames.RETURNVALUE).SetAsNull = false Then
      Entity.RETURNVALUE = AllParameters.GetByName(spGetTransferNoData.ParameterNames.RETURNVALUE).GetAsInteger()
    End If
    If AllParameters.GetByName(spGetTransferNoData.ParameterNames.TransferNo).SetAsNull = false Then
      Entity.TransferNo = AllParameters.GetByName(spGetTransferNoData.ParameterNames.TransferNo).GetAsInteger()
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
  ''' Contains static string properties that represent the name of each property in the spGetTransferNo class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ParameterNames
    ''' <summary>
    ''' Returns '@TransferNo'
    ''' </summary>
    Public Shared ReadOnly Property TransferNo() As String
      Get
        Return "@TransferNo"
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

