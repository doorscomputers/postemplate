Imports System
Imports System.Linq

Imports PDSA.Validation

' This class is an extension of the vwInvPayments Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.  
Partial Public Class vwInvPayments

End Class

''' <summary>
''' This class is used when you wish to create a collection of vwInvPayments classes.
''' You may add additional methods to this class.
''' </summary>
Public Class vwInvPaymentsCollection
  Inherits List(Of vwInvPayments)

  
  ''' <summary>
  ''' Get all vwInvPayments objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of vwInvPayments Objects</returns>
  Public Function GetChanged() As List(Of vwInvPayments)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class