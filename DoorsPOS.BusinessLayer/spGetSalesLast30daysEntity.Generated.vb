Imports System
Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value returned, or parameter to be input/output from the spGetSalesLast30days stored procedure.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
''' </summary>

Partial Public Class spGetSalesLast30days
    Inherits PDSAEntityBase

#Region "Constructor"
    Public Sub New()
        ClassName = "spGetSalesLast30days"
    End Sub
#End Region

#Region "Private Variables"
    Private _Itemdescription As String = String.Empty
    Private _RETURNVALUE As Integer = 0
#End Region

#Region "Public Properties"
    ''' <summary>
    ''' Get/Set the Itemdescription value
    ''' </summary>
   _
    Public Property Itemdescription() As String
        Get
            Return _Itemdescription
        End Get
        Set(ByVal Value As String)
            If HasValueChanged(_Itemdescription, Value, "@Itemdescription") Then
                _Itemdescription = Value
                RaisePropertyChanged("Itemdescription")
            End If
        End Set
    End Property
    ''' <summary>
    ''' Get/Set the RETURNVALUE value
    ''' </summary>
   _
    Public Property RETURNVALUE() As Integer
        Get
            Return _RETURNVALUE
        End Get
        Set(ByVal Value As Integer)
            If HasValueChanged(_RETURNVALUE, Value, "@RETURN_VALUE") Then
                _RETURNVALUE = Value
                RaisePropertyChanged("RETURNVALUE")
            End If
        End Set
    End Property
#End Region
End Class
