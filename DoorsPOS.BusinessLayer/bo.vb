Imports System
Imports System.Collections.Generic
Imports System.Linq

' This class is an extension of the bo Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.
Partial Public Class bo

#Region "RETURNVALUE Property"
  'Private mRETURNVALUE As Integer
  '
  'Public Property RETURNVALUE() As Integer
  '  Get
  '    Return mRETURNVALUE
  '  End Get
  '  Set(ByVal Value As Integer)
  '    If mRETURNVALUE <> Value Then
  '      mRETURNVALUE = Value
  '      RaisePropertyChanged("RETURNVALUE")
  '    End If
  '  End Set
  'End Property
#End Region
End Class

''' <summary>
''' This class is used when you wish to create a collection of bo classes.
''' You may add additional methods to this class.
''' </summary>
Public Class boCollection
  Inherits List(Of bo)

  Public Function Getbo(ByVal boid As Integer) As bo
#If SILVERLIGHT Then
    Return First(Function(x) x.boid = boid)
#Else
    Return Find(Function(x) x.boid = boid)
#End If
    
  End Function
  
  ''' <summary>
  ''' Get all bo objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of bo Objects</returns>
  Public Function GetChanged() As List(Of bo)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class