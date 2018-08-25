Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the vwHiStocks Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class vwHiStocks

End Class

''' <summary>
''' This class is used when you wish to create a collection of vwHiStocks classes.
''' You may add additional methods to this class.
''' </summary>
Public Class vwHiStocksCollection
  Inherits List(Of vwHiStocks)

  
  ''' <summary>
  ''' Get all vwHiStocks objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of vwHiStocks Objects</returns>
  Public Function GetChanged() As List(Of vwHiStocks)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
