Imports System
Imports System.Collections.Generic
Imports System.Linq

' This class is an extension of the pos_hdrtmp Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.
Partial Public Class pos_hdrtmp

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
''' This class is used when you wish to create a collection of pos_hdrtmp classes.
''' You may add additional methods to this class.
''' </summary>
Public Class pos_hdrtmpCollection
  Inherits List(Of pos_hdrtmp)

  Public Function Getpos_hdrtmp(ByVal postmphdrid As Integer) As pos_hdrtmp
#If SILVERLIGHT Then
    Return First(Function(x) x.postmphdrid = postmphdrid)
#Else
    Return Find(Function(x) x.postmphdrid = postmphdrid)
#End If
    
  End Function
  
  ''' <summary>
  ''' Get all pos_hdrtmp objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of pos_hdrtmp Objects</returns>
  Public Function GetChanged() As List(Of pos_hdrtmp)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class