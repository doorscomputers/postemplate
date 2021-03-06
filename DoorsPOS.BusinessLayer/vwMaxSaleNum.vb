Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the vwMaxSaleNum Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class vwMaxSaleNum

End Class

''' <summary>
''' This class is used when you wish to create a collection of vwMaxSaleNum classes.
''' You may add additional methods to this class.
''' </summary>
Public Class vwMaxSaleNumCollection
  Inherits List(Of vwMaxSaleNum)

  
  ''' <summary>
  ''' Get all vwMaxSaleNum objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of vwMaxSaleNum Objects</returns>
  Public Function GetChanged() As List(Of vwMaxSaleNum)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
