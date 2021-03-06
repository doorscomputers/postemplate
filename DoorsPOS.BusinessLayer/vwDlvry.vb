Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the vwDlvry Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class vwDlvry

End Class

''' <summary>
''' This class is used when you wish to create a collection of vwDlvry classes.
''' You may add additional methods to this class.
''' </summary>
Public Class vwDlvryCollection
  Inherits List(Of vwDlvry)

  
  ''' <summary>
  ''' Get all vwDlvry objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of vwDlvry Objects</returns>
  Public Function GetChanged() As List(Of vwDlvry)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
