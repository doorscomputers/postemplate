Imports System

Imports PDSA.Validation

''' <summary>
''' This class contains properties for each data value that makes up a spBanks.
''' This class is generated by the Haystack Code Generator for .NET.
''' Do not modify this class or add methods as it is intended to be able to be re-generated at any time.
''' </summary>
Partial Public Class spBanks
    Inherits PDSAEntityBase

#Region "Constructor"
    Public Sub New()
        ClassName = "spBanks"
    End Sub
#End Region

#Region "Private Variables"
    Private _bankid As Integer = 0
    Private _bank As String = String.Empty
    Private _accountno As String = String.Empty
    Private _RETURNVALUE As Integer = 0
#End Region

#Region "Public Properties"
    ''' <summary>
    ''' Get/Set the bankid value
    ''' </summary>
   _
    Public Property bankid() As Integer
        Get
            Return _bankid
        End Get
        Set(ByVal Value As Integer)
            _bankid = Value
        End Set
    End Property
    ''' <summary>
    ''' Get/Set the bank value
    ''' </summary>
   _
    Public Property bank() As String
        Get
            Return _bank
        End Get
        Set(ByVal Value As String)
            _bank = Value
        End Set
    End Property
    ''' <summary>
    ''' Get/Set the accountno value
    ''' </summary>
   _
    Public Property accountno() As String
        Get
            Return _accountno
        End Get
        Set(ByVal Value As String)
            _accountno = Value
        End Set
    End Property
    ''' <summary>
    ''' Get/Set the return value value
    ''' </summary>
   _
    Public Property RETURNVALUE() As Integer
        Get
            Return _RETURNVALUE
        End Get
        Set(ByVal Value As Integer)
            _RETURNVALUE = Value
        End Set
    End Property
#End Region
End Class