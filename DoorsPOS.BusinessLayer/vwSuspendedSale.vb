Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the vwSuspendedSale Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class vwSuspendedSale

End Class

''' <summary>
''' This class is used when you wish to create a collection of vwSuspendedSale classes.
''' You may add additional methods to this class.
''' </summary>
Public Class vwSuspendedSaleCollection
  Inherits List(Of vwSuspendedSale)

  
  ''' <summary>
  ''' Get all vwSuspendedSale objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of vwSuspendedSale Objects</returns>
  Public Function GetChanged() As List(Of vwSuspendedSale)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
