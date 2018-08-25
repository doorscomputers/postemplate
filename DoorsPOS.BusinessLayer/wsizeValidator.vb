Imports System
Imports PDSA.Validation

'Imports DoorsPOS.WinApp

Partial Public Class wsizeValidator
#Region "CreateNewEntity Method"
	''' <summary>
	''' This method is called when a new instance of the Validator class is created. It calls the InitializeEntity method first. You can then modify this method to set your own default values.
	''' </summary>
	Public Function CreateNewEntity() As wsize
    ' Create new Entity Object
    Entity = New wsize()
    ' Initialize new Entity
    InitializeEntity()
    ' Reset all SetAsNull properties
    ResetAllSetAsNullProperties(false)

		' Set any custom default values here
		' For Example:
		'  Entity.CurrentDate = DateTime.Now;

		Return Entity
	End Function
#End Region

#Region "ValidateCore Method"
  ''' <summary>
  ''' Used to validate any custom business rules on your wsize class.
  ''' You can add any additional business rules to this method that you want.
  ''' This method is called by the Insert() and Update() methods and will throw an exception if you add any Busin
  ''' </summary>
  Protected Overrides Sub ValidateCore()
    ' Write Custom Business Rules Here


    ' Sample:
    ' If Entity.Price < Entity.Cost Then
    '   Properties.BusinessRuleMessages.Add(New PDSAValidationRule("Cost", "Cost must be less than price"))
    ' End If 
    '
    ' If Entity.Cost = 20 Then
    '   Properties.BusinessRuleMessages.Add(New PDSAValidationRule("Cost", "Cost can not be equal to 20"))
    ' End If 
  End Sub
#End Region

#Region "AddBusinessRulesToProperties"
  ''' <summary>
  ''' If you wish to change any of the standard validation properties of any of the columns, retrieve the columns from this method, then change the appropriate properties.
  ''' </summary>
  Protected Overrides Sub AddBusinessRulesToProperties()
    ' Add any standard rules here.
    'Dim prop As PDSAProperty

    'prop = Properties.GetByName(wsizeValidator.ColumnNames.ColumnNameHere)
    'prop.MinLength = 6

    'prop = Properties.GetByName(wsizeValidator.ColumnNames.DateColumnNameHere)
    'prop.MinValue = Convert.ToDateTime("1/1/2000")
    'prop.MaxValue = DateTime.Now
  End Sub
#End Region
End Class

