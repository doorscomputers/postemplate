Imports System
Imports System.Data
Imports System.Text

Imports PDSA.Common
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses

'Imports DoorsPOS.WinApp

''' <summary>
''' This class calls the stored procedure spSearchItemsData
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class spSearchItemsData
  Inherits PDSAStoredProcExecute

#Region "Constructors"
  Public Sub New()
    MyBase.New()

    _Entity = New spSearchItems()

    Init()
  End Sub

  Public Sub New(ByVal entity As spSearchItems)
    MyBase.New()

    _Entity = entity

    Init()
  End Sub

  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As spSearchItems)
    MyBase.New(dataProvider)

    _Entity = entity

    Init()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As spSearchItems
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the Entity class that will be used to get and set properties/fields for this data class.
  ''' </summary>
  Public Property Entity() As spSearchItems
    Get
      Return _Entity
    End Get
    Set(ByVal value As spSearchItems)
      _Entity = value
    End Set
  End Property
#End Region

#Region "Init Method"
  ''' <summary>
  ''' Initializes this class to a valid start state.
  ''' </summary>
  Protected Overrides Sub Init()
    ClassName = "spSearchItemsData"
    StoredProcName = "spSearchItems"
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
    param.ParameterName = spSearchItemsData.ParameterNames.itemdesc
    param.DBType = DbType.String
    param.ParamDirection = ParameterDirection.Input
    Me.AllParameters.Add(param)

    param = New PDSADataParameter()
    param.ParameterName = spSearchItemsData.ParameterNames.RETURNVALUE
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
    If AllParameters.GetByName(spSearchItemsData.ParameterNames.itemdesc).SetAsNull = False Then
      AllParameters.GetByName(spSearchItemsData.ParameterNames.itemdesc).Value = Entity.itemdesc
    Else
      AllParameters.GetByName(spSearchItemsData.ParameterNames.itemdesc).Value = System.Data.SqlTypes.SqlString.Null
    End If
  End Sub
#End Region

#Region "OutputParametersToEntityData Method"
  ''' <summary>
  ''' Moves the output parameters from the Parameters collection into the Entity class.
  ''' </summary>
  Protected Overrides Sub OutputParametersToEntityData()
    If AllParameters.GetByName(spSearchItemsData.ParameterNames.RETURNVALUE).SetAsNull = false Then
      Entity.RETURNVALUE = AllParameters.GetByName(spSearchItemsData.ParameterNames.RETURNVALUE).GetAsInteger()
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
  ''' Contains static string properties that represent the name of each property in the spSearchItems class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ParameterNames
    ''' <summary>
    ''' Returns '@item_desc'
    ''' </summary>
    Public Shared ReadOnly Property itemdesc() As String
      Get
        Return "@item_desc"
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

