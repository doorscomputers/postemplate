Imports System
Imports System.Collections.Generic
Imports System.Linq

' This class is an extension of the dlvryhdrtmp Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.
Partial Public Class dlvryhdrtmp

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
''' This class is used when you wish to create a collection of dlvryhdrtmp classes.
''' You may add additional methods to this class.
''' </summary>
Public Class dlvryhdrtmpCollection
  Inherits List(Of dlvryhdrtmp)

  Public Function Getdlvryhdrtmp(ByVal dridtmp As Integer) As dlvryhdrtmp
#If SILVERLIGHT Then
    Return First(Function(x) x.dridtmp = dridtmp)
#Else
    Return Find(Function(x) x.dridtmp = dridtmp)
#End If
    
  End Function
  
  ''' <summary>
  ''' Get all dlvryhdrtmp objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of dlvryhdrtmp Objects</returns>
  Public Function GetChanged() As List(Of dlvryhdrtmp)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class