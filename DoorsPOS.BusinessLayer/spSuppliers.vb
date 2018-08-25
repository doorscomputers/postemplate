Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the spSuppliers Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class spSuppliers

End Class

''' <summary>
''' This class is used when you wish to create a collection of spSuppliers classes.
''' You may add additional methods to this class.
''' </summary>
Public Class spSuppliersCollection
  Inherits List(Of spSuppliers)

  
  ''' <summary>
  ''' Get all spSuppliers objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of spSuppliers Objects</returns>
  Public Function GetChanged() As List(Of spSuppliers)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
