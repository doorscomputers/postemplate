Imports System
Imports System.Data
Imports System.Text

Imports PDSA.Common
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

''' <summary>
''' This class calls the view vwDlvry
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class vwDlvryData
  Inherits PDSADataClassReadOnly

#Region "Constructors"
  Public Sub New()
    MyBase.New()

    _Entity = New vwDlvry()

    Init()
  End Sub
  
  Public Sub New(ByVal dataProvider As PDSADataProvider, ByVal entity As vwDlvry)
    MyBase.New(dataProvider)

    _Entity = entity

    Init()
  End Sub
#End Region

#Region "Private Variables"
  Private _Entity As vwDlvry

  Private _WhereFilter As WhereFilters
  Private _OrderByFilter As OrderByFilters
  Private _SelectFilter As SelectFilters
  Private _RowCountFilter As RowCountFilters
#End Region

#Region "Filter Enumerations"
  ''' <summary>
  ''' Enumeration for selecting a SELECT statement when calling the Load, GetDataSet or GetDataReader method.
  ''' </summary>
  Public Enum SelectFilters
    ''' <summary>
    ''' 'All' SelectFilter
    ''' </summary>
    All
    ''' <summary>
    ''' A Custom SelectFilter
    ''' </summary>
    Custom
  End Enum

  ''' <summary>
  ''' Enumeration for selecting a WHERE statement when calling the Load, GetDataSet or GetDataReader method.
  ''' </summary>
  Public Enum WhereFilters
    ''' <summary>
    ''' No WhereFilter Selected
    ''' </summary>
    None
    ''' <summary>
    ''' A Custom WhereFilter
    ''' </summary>
    Custom
    ''' <summary>
    ''' 'drinv' WhereFilter
    ''' </summary>
    drinv
    ''' <summary>
    ''' 'Likedrinv' WhereFilter
    ''' </summary>
    Likedrinv
  End Enum

  ''' <summary>
  ''' Enumeration for selecting an ORDER BY statement when calling the Load, GetDataSet or GetDataReader method.
  ''' </summary>
  Public Enum OrderByFilters
    ''' <summary>
    ''' No OrderByFilter Selected
    ''' </summary>
    None
    ''' <summary>
    ''' A Custom OrderByFilter
    ''' </summary>
    Custom
    ''' <summary>
    ''' 'drinv' OrderByFilter
    ''' </summary>
    drinv
  End Enum
  ''' <summary>
  ''' Enumeration for selecting a Row Count statement or Row Count stored procedure to execute when calling the RowCount() method.
  ''' </summary>
  Public Enum RowCountFilters
    ''' <summary>
    ''' 'All' RowCountFilter
    ''' </summary>
    All
    Custom
  End Enum
#End Region

#Region "Public Properties"
  ''' <summary>
  ''' Get/Set the Entity class that will be used to get and set properties/fields for this data class.
  ''' </summary>
  Public Property Entity() As vwDlvry
    Get
      Return _Entity
    End Get
    Set(ByVal value As vwDlvry)
      _Entity = value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set a Dynamic SQL or Stored Procedure to execute to return data.
  ''' </summary>
  Public Property SelectFilter() As SelectFilters
    Get
      Return _SelectFilter
    End Get
    Set(ByVal Value As SelectFilters)
      _SelectFilter = Value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set a WHERE clause to be used with a SELECT statement when using Dynamic SQL.
  ''' </summary>
  Public Property WhereFilter() As WhereFilters
    Get
      Return _WhereFilter
    End Get
    Set(ByVal Value As WhereFilters)
      _WhereFilter = Value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set a ORDER BY clause to be used with a SELECT statement when using Dynamic SQL.
  ''' </summary>
  Public Property OrderByFilter() As OrderByFilters
    Get
      Return _OrderByFilter
    End Get
    Set(ByVal Value As OrderByFilters)
      _OrderByFilter = Value
    End Set
  End Property
  
  ''' <summary>
  ''' Get/Set a Row Count statement to execute when calling the RowCount() method. You might need to set a WhereFilter as well.
  ''' </summary>
  Public Property RowCountFilter() As RowCountFilters
    Get
      Return _RowCountFilter
    End Get
    Set(ByVal Value As RowCountFilters)
      _RowCountFilter = Value
    End Set
  End Property
#End Region

#Region "Init Method"
  ''' <summary>
  ''' Initializes this class to a valid start state.
  ''' </summary>
  Protected Overrides Sub Init()
    ClassName = "vwDlvryData"
    DBObjectName = "vwDlvry"
    SchemaName = "dbo"

    ' Create Data Columns
    InitDataColumns()
  End Sub
#End Region

#Region "InitDataColumns Method"
  ''' <summary>
  ''' Initializes all of the Data Columns with valid data for each field in the view.
  ''' </summary>
  Protected Overrides Sub InitDataColumns()
    Dim dc As PDSADataColumn

    ' Create each data column
    dc = PDSADataColumn.CreateDataColumn(vwDlvryData.ColumnNames.drinv, "drinv", False, GetType(String), DbType.String)
    AllColumns.Add(dc)
    dc = PDSADataColumn.CreateDataColumn(vwDlvryData.ColumnNames.drdate, "drdate", False, GetType(Date), DbType.Date)
    AllColumns.Add(dc)
    dc = PDSADataColumn.CreateDataColumn(vwDlvryData.ColumnNames.supcode, "supcode", False, GetType(Integer), DbType.Int32)
    AllColumns.Add(dc)
    dc = PDSADataColumn.CreateDataColumn(vwDlvryData.ColumnNames.supplier, "supplier", False, GetType(String), DbType.String)
    AllColumns.Add(dc)
    dc = PDSADataColumn.CreateDataColumn(vwDlvryData.ColumnNames.paid, "paid", False, GetType(Boolean?), DbType.Boolean)
    AllColumns.Add(dc)
    dc = PDSADataColumn.CreateDataColumn(vwDlvryData.ColumnNames.drbal, "drbal", False, GetType(Decimal), DbType.Decimal)
    AllColumns.Add(dc)
    dc = PDSADataColumn.CreateDataColumn(vwDlvryData.ColumnNames.sInsertid, "s Insert  id", False, GetType(String), DbType.String)
    AllColumns.Add(dc)
    dc = PDSADataColumn.CreateDataColumn(vwDlvryData.ColumnNames.drid, "drid", False, GetType(Integer), DbType.Int32)
    AllColumns.Add(dc)
  End Sub
#End Region

#Region "EntityDataToColumnCollection Method"
  ''' <summary>
  ''' Moves the data from the Entity class into the Columns collection
  ''' </summary>
  Protected Overrides Sub EntityDataToColumnCollection()
    If AllColumns.GetByName(vwDlvryData.ColumnNames.drinv).SetAsNull = False Then
      AllColumns.GetByName(vwDlvryData.ColumnNames.drinv).Value = Entity.drinv
    Else
      AllColumns.GetByName(vwDlvryData.ColumnNames.drinv).Value = String.Empty
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.drdate).SetAsNull = False Then
      AllColumns.GetByName(vwDlvryData.ColumnNames.drdate).Value = Entity.drdate
    Else
      AllColumns.GetByName(vwDlvryData.ColumnNames.drdate).Value = DateTime.Now
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.supcode).SetAsNull = False Then
      AllColumns.GetByName(vwDlvryData.ColumnNames.supcode).Value = Entity.supcode
    Else
      AllColumns.GetByName(vwDlvryData.ColumnNames.supcode).Value = 0
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.supplier).SetAsNull = False Then
      AllColumns.GetByName(vwDlvryData.ColumnNames.supplier).Value = Entity.supplier
    Else
      AllColumns.GetByName(vwDlvryData.ColumnNames.supplier).Value = String.Empty
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.paid).SetAsNull = False Then
      AllColumns.GetByName(vwDlvryData.ColumnNames.paid).Value = Entity.paid
    Else
      AllColumns.GetByName(vwDlvryData.ColumnNames.paid).Value = False
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.drbal).SetAsNull = False Then
      AllColumns.GetByName(vwDlvryData.ColumnNames.drbal).Value = Entity.drbal
    Else
      AllColumns.GetByName(vwDlvryData.ColumnNames.drbal).Value = 0
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.sInsertid).SetAsNull = False Then
      AllColumns.GetByName(vwDlvryData.ColumnNames.sInsertid).Value = Entity.sInsertid
    Else
      AllColumns.GetByName(vwDlvryData.ColumnNames.sInsertid).Value = String.Empty
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.drid).SetAsNull = False Then
      AllColumns.GetByName(vwDlvryData.ColumnNames.drid).Value = Entity.drid
    Else
      AllColumns.GetByName(vwDlvryData.ColumnNames.drid).Value = 0
    End If
    
  End Sub
#End Region

#Region "ColumnCollectionToEntityData Method"
  ''' <summary>
  ''' Moves the data from the Columns collection into the Entity class.
  ''' </summary>
  Protected Overrides Sub ColumnCollectionToEntityData()
    If AllColumns.GetByName(vwDlvryData.ColumnNames.drinv).IsNull = False Then
      Entity.drinv = AllColumns.GetByName(vwDlvryData.ColumnNames.drinv).GetAsString()
    Else
      Entity.drinv = String.Empty
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.drdate).IsNull = False Then
      Entity.drdate = AllColumns.GetByName(vwDlvryData.ColumnNames.drdate).GetAsDate()
    Else
      Entity.drdate = DateTime.Now
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = AllColumns.GetByName(vwDlvryData.ColumnNames.supcode).GetAsInteger()
    Else
      Entity.supcode = 0
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.supplier).IsNull = False Then
      Entity.supplier = AllColumns.GetByName(vwDlvryData.ColumnNames.supplier).GetAsString()
    Else
      Entity.supplier = String.Empty
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.paid).IsNull = False Then
      Entity.paid = AllColumns.GetByName(vwDlvryData.ColumnNames.paid).GetValueAsBoolean()
    Else
      Entity.paid = False
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.drbal).IsNull = False Then
      Entity.drbal = AllColumns.GetByName(vwDlvryData.ColumnNames.drbal).GetAsDecimal()
    Else
      Entity.drbal = 0
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = AllColumns.GetByName(vwDlvryData.ColumnNames.sInsertid).GetAsString()
    Else
      Entity.sInsertid = String.Empty
    End If
    
    If AllColumns.GetByName(vwDlvryData.ColumnNames.drid).IsNull = False Then
      Entity.drid = AllColumns.GetByName(vwDlvryData.ColumnNames.drid).GetAsInteger()
    Else
      Entity.drid = 0
    End If
    
  End Sub
#End Region

#Region "CreateEntityFromDataRow Method"
  ''' <summary>
  ''' Creates an Entity object from a DataRow object.
  ''' </summary>
  ''' <param name="dr">DataRow object with all fields from the view in it.</param>
  ''' <returns>vwDlvry</returns>
  Public Function CreateEntityFromDataRow(ByVal dr As DataRow) As vwDlvry
    Dim entity As New vwDlvry()

    If dr.Table.Columns.Contains(vwDlvryData.ColumnNames.drinv) Then
      If dr(vwDlvryData.ColumnNames.drinv).Equals(DBNull.Value) = False Then
        entity.drinv = PDSAString.ConvertToStringTrim(dr(vwDlvryData.ColumnNames.drinv))
      End If
    End If
    If dr.Table.Columns.Contains(vwDlvryData.ColumnNames.drdate) Then
      If dr(vwDlvryData.ColumnNames.drdate).Equals(DBNull.Value) = False Then
        entity.drdate = Convert.ToDateTime(dr(vwDlvryData.ColumnNames.drdate))
      End If
    End If
    If dr.Table.Columns.Contains(vwDlvryData.ColumnNames.supcode) Then
      If dr(vwDlvryData.ColumnNames.supcode).Equals(DBNull.Value) = False Then
        entity.supcode = Convert.ToInt32(dr(vwDlvryData.ColumnNames.supcode))
      End If
    End If
    If dr.Table.Columns.Contains(vwDlvryData.ColumnNames.supplier) Then
      If dr(vwDlvryData.ColumnNames.supplier).Equals(DBNull.Value) = False Then
        entity.supplier = PDSAString.ConvertToStringTrim(dr(vwDlvryData.ColumnNames.supplier))
      End If
    End If
    If dr.Table.Columns.Contains(vwDlvryData.ColumnNames.paid) Then
      If dr(vwDlvryData.ColumnNames.paid).Equals(DBNull.Value) = False Then
        entity.paid = Convert.ToBoolean(dr(vwDlvryData.ColumnNames.paid))
      End If
    End If
    If dr.Table.Columns.Contains(vwDlvryData.ColumnNames.drbal) Then
      If dr(vwDlvryData.ColumnNames.drbal).Equals(DBNull.Value) = False Then
        entity.drbal = Convert.ToDecimal(dr(vwDlvryData.ColumnNames.drbal))
      End If
    End If
    If dr.Table.Columns.Contains(vwDlvryData.ColumnNames.sInsertid) Then
      If dr(vwDlvryData.ColumnNames.sInsertid).Equals(DBNull.Value) = False Then
        entity.sInsertid = PDSAString.ConvertToStringTrim(dr(vwDlvryData.ColumnNames.sInsertid))
      End If
    End If
    If dr.Table.Columns.Contains(vwDlvryData.ColumnNames.drid) Then
      If dr(vwDlvryData.ColumnNames.drid).Equals(DBNull.Value) = False Then
        entity.drid = Convert.ToInt32(dr(vwDlvryData.ColumnNames.drid))
      End If
    End If
    entity.IsDirty = False

    Return entity
  End Function
#End Region

#Region "SelectSQL Method"
  ''' <summary>
  ''' Builds the SQL for the SELECT statement based on the SelectFilter property.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function SelectSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case SelectFilter
      Case SelectFilters.All
        sb.Append(" SELECT drinv, drdate, supcode, supplier, paid, drbal, sInsert_id, drid FROM dbo.vwDlvry")


      Case SelectFilters.Custom
        sb.Append(SelectCustom)

    End Select

    SQL = sb.ToString()

    Return SQL
  End Function
#End Region

#Region "RowCountSQL Method"
  ''' <summary>
  ''' Builds the SELECT Count(*) SQL that will count the number of rows.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function RowCountSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case RowCountFilter
      Case RowCountFilters.All
        sb.Append(" SELECT Count(*) As NumRecs FROM dbo.vwDlvry")


      Case RowCountFilters.Custom
        sb.Append(RowCountCustom)

    End Select

    sb.Append(WhereClauseSQL())

    SQL = sb.ToString()

    Return SQL
  End Function
#End Region

#Region "WhereClauseSQL Method"
  ''' <summary>
  ''' Builds the WHERE clause to be used in combination with a SELECT statement.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function WhereClauseSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case WhereFilter
      Case WhereFilters.Custom
        sb.Append(WhereCustom)

      Case WhereFilters.None
        ' Do nothing

      Case WhereFilters.drinv
        sb.Append(" WHERE drinv = @drinv")

        
      Case WhereFilters.Likedrinv
        sb.Append(" WHERE drinv LIKE @drinv")

        
    End Select

    Return sb.ToString()
  End Function
#End Region

#Region "WhereClauseFillInParameters Method"
  ''' <summary>
  ''' Builds the CommandObject.Parameters collection for any WHERE clause parameters.
  ''' </summary>
  Protected Overrides Sub WhereClauseFillInParameters()
    Select Case WhereFilter
      Case WhereFilters.drinv
        CommandObject.Parameters.Add(DataProvider.CreateParameter("drinv", DbType.String, Entity.drinv))
      Case WhereFilters.Likedrinv
        CommandObject.Parameters.Add(DataProvider.CreateParameter("drinv", DbType.String, Entity.drinv))

    End Select
  End Sub
#End Region

#Region "OrderByClauseSQL Method"
  ''' <summary>
  ''' Builds the ORDER BY clause to be used in combination with a SELECT statement.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function OrderByClauseSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case OrderByFilter
      Case OrderByFilters.None
        '  Do Nothing

      Case OrderByFilters.Custom
        sb.Append(OrderByCustom)

      Case OrderByFilters.drinv
          sb.Append(" ORDER BY drinv")


    End Select

    Return sb.ToString()
  End Function
#End Region

#Region "ColumnNames Class"
  ''' <summary>
  ''' Contains static string properties that represent the name of each property in the Product class.
  ''' This class is generated by the Haystack Code Generator for .NET.
  ''' Do not modify this class or add methods as it is intended to be able to be re-generated at any ti
  ''' </summary>
  Public Class ColumnNames
    ''' <summary>
    ''' Returns 'drinv'
    ''' </summary>
    Public Shared ReadOnly Property drinv() As String
      Get
        Return "drinv"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drdate'
    ''' </summary>
    Public Shared ReadOnly Property drdate() As String
      Get
        Return "drdate"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'supcode'
    ''' </summary>
    Public Shared ReadOnly Property supcode() As String
      Get
        Return "supcode"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'supplier'
    ''' </summary>
    Public Shared ReadOnly Property supplier() As String
      Get
        Return "supplier"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'paid'
    ''' </summary>
    Public Shared ReadOnly Property paid() As String
      Get
        Return "paid"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drbal'
    ''' </summary>
    Public Shared ReadOnly Property drbal() As String
      Get
        Return "drbal"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'sInsert_id'
    ''' </summary>
    Public Shared ReadOnly Property sInsertid() As String
      Get
        Return "sInsert_id"
      End Get
    End Property
    ''' <summary>
    ''' Returns 'drid'
    ''' </summary>
    Public Shared ReadOnly Property drid() As String
      Get
        Return "drid"
      End Get
    End Property
  End Class
#End Region
End Class