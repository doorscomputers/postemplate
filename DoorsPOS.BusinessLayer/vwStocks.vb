Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the vwStocks Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class vwStocks

End Class

''' <summary>
''' This class is used when you wish to create a collection of vwStocks classes.
''' You may add additional methods to this class.
''' </summary>
Public Class vwStocksCollection
  Inherits List(Of vwStocks)

  
  ''' <summary>
  ''' Get all vwStocks objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of vwStocks Objects</returns>
  Public Function GetChanged() As List(Of vwStocks)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
