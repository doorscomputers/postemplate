Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the vwSuspendDlvry Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class vwSuspendDlvry

End Class

''' <summary>
''' This class is used when you wish to create a collection of vwSuspendDlvry classes.
''' You may add additional methods to this class.
''' </summary>
Public Class vwSuspendDlvryCollection
  Inherits List(Of vwSuspendDlvry)

  
  ''' <summary>
  ''' Get all vwSuspendDlvry objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of vwSuspendDlvry Objects</returns>
  Public Function GetChanged() As List(Of vwSuspendDlvry)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
