Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the vwPOSuspended Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class vwPOSuspended

End Class

''' <summary>
''' This class is used when you wish to create a collection of vwPOSuspended classes.
''' You may add additional methods to this class.
''' </summary>
Public Class vwPOSuspendedCollection
  Inherits List(Of vwPOSuspended)

  
  ''' <summary>
  ''' Get all vwPOSuspended objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of vwPOSuspended Objects</returns>
  Public Function GetChanged() As List(Of vwPOSuspended)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
