Imports System
Imports System.Collections.Generic
Imports System.Linq

' This class is an extension of the categories Entity class
' This class is generated by the Haystack Code Generator for .NET.
' You may add additional properties to this class.
Partial Public Class categories

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
''' This class is used when you wish to create a collection of categories classes.
''' You may add additional methods to this class.
''' </summary>
Public Class categoriesCollection
  Inherits List(Of categories)

  Public Function Getcategories(ByVal categoryid As Integer) As categories
#If SILVERLIGHT Then
    Return First(Function(x) x.categoryid = categoryid)
#Else
    Return Find(Function(x) x.categoryid = categoryid)
#End If
    
  End Function
  
  ''' <summary>
  ''' Get all categories objects where IsDirty=True
  ''' </summary>
  ''' <returns>A List of categories Objects</returns>
  Public Function GetChanged() As List(Of categories)  
	  Return (From item In Me Where item.IsDirty = True).ToList()
  End Function
End Class
