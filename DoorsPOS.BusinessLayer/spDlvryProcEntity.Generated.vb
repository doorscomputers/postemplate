Imports System
Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value returned, or parameter to be input/output from the spDlvryProc stored procedure.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
''' </summary>

Partial Public Class spDlvryProc
    Inherits PDSAEntityBase

#Region "Constructor"
    Public Sub New()
        ClassName = "spDlvryProc"
    End Sub
#End Region

#Region "Private Variables"
    Private _drdrid As Integer = 0
    Private _supcode As Integer = 0
    Private _RETURNVALUE As Integer = 0
#End Region

#Region "Public Properties"
    ''' <summary>
    ''' Get/Set the drdrid value
    ''' </summary>
   _
    Public Property drdrid() As Integer
        Get
            Return _drdrid
        End Get
        Set(ByVal Value As Integer)
            If HasValueChanged(_drdrid, Value, "@drdrid") Then
                _drdrid = Value
                RaisePropertyChanged("drdrid")
            End If
        End Set
    End Property
    ''' <summary>
    ''' Get/Set the supcode value
    ''' </summary>
   _
    Public Property supcode() As Integer
        Get
            Return _supcode
        End Get
        Set(ByVal Value As Integer)
            If HasValueChanged(_supcode, Value, "@supcode") Then
                _supcode = Value
                RaisePropertyChanged("supcode")
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
