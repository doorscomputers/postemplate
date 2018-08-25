Imports System
Imports System.Data
Imports System.Text

Imports PDSA.Common
Imports PDSA.DataLayer
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

'Imports DoorsPOS.WinApp
'Imports DoorsPOS.WinApp

''' <summary>
''' Used to Add/Edit/Delete/Select data from the tblExpenseTrans table.
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class tblExpenseTransData
  Inherits PDSADataClassTable

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the tblExpenseTransData class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    _Entity = New tblExpenseTrans()
    ValidatorObject = New tblExpenseTransValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the tblExpenseTransData class
  ''' </summary>
  ''' <param name="entity">An instance of a tblExpenseTrans</param>
  Public Sub New(ByVal entity As tblExpenseTrans)
    MyBase.New(entity)

    _Entity = entity
    ValidatorObject = New tblExpenseTransValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the tblExpenseTransData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a tblExpenseTrans</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, ByVal entity As tblExpenseTrans)
    MyBase.New(dataProvider, entity)

    _Entity = entity
    ValidatorObject = New tblExpenseTransValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the tblExpenseTransData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a tblExpenseTrans</param>
  ''' <param name="validator">An instance of a tblExpenseTransValidator</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As tblExpenseTrans, ByVal validator As tblExpenseTransValidator)
    MyBase.New(dataProvider, entity, validator)

    _Entity = entity
    ValidatorObject = validator

    Init()
  End Sub
#End Region

#Region "Private Filter Properties and Enumerations"
  Private _Entity As tblExpenseTrans

  Private _WhereFilter As WhereFilters
  Private _OrderByFilter As OrderByFilters
  Private _SelectFilter As SelectFilters
  Private _InsertFilter As InsertFilters
  Private _UpdateFilter As UpdateFilters
  Private _DeleteFilter As DeleteFilters
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
    ''' 'ListBox' SelectFilter
    ''' </summary>
    ListBox
    ''' <summary>
    ''' 'PrimaryKey' SelectFilter
    ''' </summary>
    PrimaryKey
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
    ''' 'PrimaryKey' WhereFilter
    ''' </summary>
    PrimaryKey
    ''' <summary>
    ''' 'expremarks' WhereFilter
    ''' </summary>
    expremarks
    ''' <summary>
    ''' 'Likeexpremarks' WhereFilter
    ''' </summary>
    Likeexpremarks
    ''' <summary>
    ''' 'expenseid' WhereFilter
    ''' </summary>
    expenseid
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
    ''' 'expremarks' OrderByFilter
    ''' </summary>
    expremarks
  End Enum

  ''' <summary>
  ''' Enumeration for selecting an INSERT statement or INSERT stored procedure to execute when calling the Insert() method.
  ''' </summary>
  Public Enum InsertFilters
    ''' <summary>
    ''' 'All' InsertFilter
    ''' </summary>
    All
    ''' <summary>
    ''' A Custom InsertFilter
    ''' </summary>
    Custom
  End Enum

  ''' <summary>
  ''' Enumeration for selecting an UPDATE statement or UPDATE stored procedure to execute when calling the Update() method.
  ''' </summary>
  Public Enum UpdateFilters
    ''' <summary>
    ''' 'PrimaryKey' UpdateFilter
    ''' </summary>
    PrimaryKey
    ''' <summary>
    ''' A Custom UpdateFilter
    ''' </summary>
    Custom
  End Enum

  ''' <summary>
  ''' Enumeration for selecting a DELETE statement or DELETE stored procedure to execute when calling the Delete() method.
  ''' </summary>
  Public Enum DeleteFilters
    ''' <summary>
    ''' 'All' DeleteFilter
    ''' </summary>
    All
    ''' <summary>
    ''' 'DeleteByPK' DeleteFilter
    ''' </summary>
    DeleteByPK
    ''' <summary>
    ''' A Custom DeleteFilter
    ''' </summary>
    Custom
  End Enum

  ''' <summary>
  ''' Enumeration for selecting a Row Count statement or Row Count stored procedure to execute when calling the RowCount() method.
  ''' </summary>
  Public Enum RowCountFilters
    ''' <summary>
    ''' 'All' RowCountFilter
    ''' </summary>
    All
    ''' <summary>
    ''' S Custom RowCountFilter
    ''' </summary>
    Custom
  End Enum
#End Region

#Region "Public Entity Property"
  ''' <summary>
  ''' Get/Set the Entity class that will be used to get and set properties/fields for this data class.
  ''' </summary>
  Public Property Entity() As tblExpenseTrans
    Get
      Return _Entity
    End Get
    Set(ByVal value As tblExpenseTrans)
      _Entity = value
      MyBase.EntityObject = _Entity
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
  ''' Get/Set an INSERT statement or INSERT stored procedure to execute when calling the Insert() method.
  ''' </summary>
  Public Property InsertFilter() As InsertFilters
    Get
      Return _InsertFilter
    End Get
    Set(ByVal Value As InsertFilters)
      _InsertFilter = Value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set an UPDATE statement or UPDATE stored procedure to execute when calling the Update() method.
  ''' </summary>
  Public Property UpdateFilter() As UpdateFilters
    Get
      Return _UpdateFilter
    End Get
    Set(ByVal Value As UpdateFilters)
      _UpdateFilter = Value
      If _UpdateFilter = UpdateFilters.Custom Then
        PerformValidation = False
      End If
    End Set
  End Property

  ''' <summary>
  ''' Get/Set a DELETE statement or DELETE stored procedure to execute when calling the Delete() method. You might need to set a WhereFilter as well.
  ''' </summary>
  Public Property DeleteFilter() As DeleteFilters
    Get
      Return _DeleteFilter
    End Get
    Set(ByVal Value As DeleteFilters)
      _DeleteFilter = Value
    End Set
  End Property

  ''' <summary>
  ''' Get/Set a Row Count statement or RowCount stored procedure to execute when calling the RowCount() method. You might need to set a WhereFilter as well.
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
    ClassName = "tblExpenseTransData"
    DBObjectName = "tblExpenseTrans"
    SchemaName = "dbo"
    PrimaryKeyType = PDSAPrimaryKeyType.SQLIdentity
    PrimaryKeyGenerate = False
    UseAuditTracking = DataProvider.UseDBAuditTracking
    UseStoredProcs = DataProvider.UseStoredProcedures

    MyBase.EntityObject = Entity
    MyBase.ValidatorObject = ValidatorObject

    ' Set Reference to ValidatorObject Properties Collection
    AllColumns = ValidatorObject.Properties

    ' Create Data Columns
    InitDataColumns()
  End Sub
#End Region

#Region "InitDataColumns Method"
  ''' <summary>
  ''' Initializes all of the Data Columns with valid data for each field in the table.
  ''' </summary>
  Protected Overrides Sub InitDataColumns()
    Dim prop As PDSAProperty

    ' Fill in Column Properties
    prop = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid)
    prop.IsInsertable = False
    prop.IsUpdatable = False
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlString.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlString.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlString.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

  End Sub
#End Region

#Region "EntityDataToColumnCollection Method"
  ''' <summary>
  ''' Moves the data from the Entity class into the Columns collection
  ''' This is called prior to performing a Business Rule Check, an INSERT, UPDATE or DELETE
  ''' </summary>
  Protected Overrides Sub EntityDataToColumnCollection()
    ' Move all Entity Values into Properties Collection
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).Value = Entity.exptransid
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).Value = Entity.expdate
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).Value = Entity.expamount
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).Value = Entity.expremarks
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).Value = Entity.expenseid
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).Value = Entity.modifiedby
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).Value = Entity.modifiedon
  End Sub
#End Region

#Region "ColumnCollectionToEntityData Method"
  ''' <summary>
  ''' Moves the data from the Columns collection into the Entity class.
  ''' This is called whenever you are reading data in from a database.
  ''' </summary>
  Protected Overrides Sub ColumnCollectionToEntityData()
    If ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).IsNull = False Then
      Entity.exptransid = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).GetAsInteger()
    Else
      Entity.exptransid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).IsNull = False Then
      Entity.expdate = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).GetAsDate()
    Else
      Entity.expdate = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).IsNull = False Then
      Entity.expamount = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).GetAsDecimal()
    Else
      Entity.expamount = 0
    End If
    
    If ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).IsNull = False Then
      Entity.expremarks = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).GetAsString()
    Else
      Entity.expremarks = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).GetAsString()
    Else
      Entity.sInsertid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).IsNull = False Then
      Entity.expenseid = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).GetAsInteger()
    Else
      Entity.expenseid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).IsNull = False Then
      Entity.modifiedby = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).GetAsString()
    Else
      Entity.modifiedby = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).IsNull = False Then
      Entity.modifiedon = ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).GetAsDate()
    Else
      Entity.modifiedon = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
  End Sub
#End Region

#Region "CreateEntityFromDataRow Method"
  ''' <summary>
  ''' Creates an Entity object from a DataRow object.
  ''' </summary>
  ''' <param name="dr">DataRow object with all fields from the table in it.</param>
  ''' <returns>tblExpenseTrans</returns>
  Public Function CreateEntityFromDataRow(ByVal dr As DataRow) As tblExpenseTrans
    ' Create new Entity Object
    Entity = New tblExpenseTrans()

    ' Move all data into Properties collection
    ' This method calls the ColumnCollectionToEntityData method
    DataRowToProperties(dr)
    Entity.IsDirty = False

    Return Entity
  End Function
#End Region

#Region "SelectSQL Method"
  ''' <summary>
  ''' Builds the SQL for the SELECT statement, or SELECT stored procedure based on the SelectFilter property.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function SelectSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case SelectFilter
      Case SelectFilters.All
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT exptransid, expdate, expamount, expremarks, sInsert_id, expenseid, modified_by, modified_on FROM dbo.tblExpenseTrans")

        End If
      Case SelectFilters.ListBox
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT exptransid, expremarks FROM dbo.tblExpenseTrans")

        End If
      Case SelectFilters.PrimaryKey
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT exptransid, expdate, expamount, expremarks, sInsert_id, expenseid, modified_by, modified_on FROM dbo.tblExpenseTrans WHERE exptransid = @exptransid")

        End If

      Case SelectFilters.Custom
        sb.Append(SelectCustom)

    End Select

    SQL = sb.ToString()

    Return SQL
  End Function
#End Region

#Region "InsertSQL Method"
  ''' <summary>
  ''' Builds the SQL for the INSERT statement, or INSERT stored procedure based on the InsertFilter property.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function InsertSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case InsertFilter
      Case InsertFilters.All
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" INSERT INTO dbo.tblExpenseTrans ( expdate, expamount, expremarks, sInsert_id, expenseid, modified_by, modified_on ) VALUES ( @expdate, @expamount, @expremarks, @sInsertid, @expenseid, @modifiedby, @modifiedon )")

        End If

      Case InsertFilters.Custom
        sb.Append(InsertCustom)
    End Select

    SQL = sb.ToString()

    Return SQL
  End Function
#End Region

#Region "UpdateSQL Method"
  ''' <summary>
  ''' Builds the SQL for the UPDATE statement, or UPDATE stored procedure based on the UpdateFilter property.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function UpdateSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case UpdateFilter
      Case UpdateFilters.PrimaryKey
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" UPDATE dbo.tblExpenseTrans SET expdate = @expdate, expamount = @expamount, expremarks = @expremarks, sInsert_id = @sInsertid, expenseid = @expenseid, modified_by = @modifiedby, modified_on = @modifiedon WHERE exptransid = @exptransid")

        End If

      Case UpdateFilters.Custom
        sb.Append(UpdateCustom)

    End Select

    SQL = sb.ToString()

    Return SQL
  End Function
#End Region

#Region "DeleteByPK Method"
  ''' <summary>
  ''' Delete a record from the table based on the primary key value that is passed in.
  ''' </summary>
  ''' <param name="exptransid">The value of the primary key of the row to delete</param>
  ''' <returns>int</returns>
  Public Function DeleteByPK(ByVal exptransid As Integer) As Integer
    DeleteFilter = DeleteFilters.DeleteByPK
    Entity.exptransid = exptransid

    ' If using Audit Tracking, need to load the record first
    If UseAuditTracking Then
      LoadByPK(exptransid)
    End If

    ' Set WhereFilter to None, because it got set in LoadByPK
    WhereFilter = WhereFilters.None
    RowsAffected = Delete()

    Return RowsAffected
  End Function
#End Region

#Region "DeleteSQL Method"
  ''' <summary>
  ''' Builds the SQL for the DELETE statement, or DELETE stored procedure. You can set the WhereFilter property to selectively delete rows from the table.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function DeleteSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case DeleteFilter
      Case DeleteFilters.All
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" DELETE FROM dbo.tblExpenseTrans")

        End If
      Case DeleteFilters.DeleteByPK
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" DELETE FROM dbo.tblExpenseTrans WHERE exptransid = @exptransid")

        End If

      Case DeleteFilters.Custom
        sb.Append(DeleteCustom)

    End Select

    If UseStoredProcs = False Then
      sb.Append(WhereClauseSQL())
    End If

    SQL = sb.ToString()

    Return SQL
  End Function
#End Region

#Region "RowCountSQL Method"
  ''' <summary>
  ''' Builds the SELECT Count(*) SQL, or the name of the stored procedure, that will count the number of rows.
  ''' </summary>
  ''' <returns>string</returns>
  Public Overrides Function RowCountSQL() As String
    Dim sb As StringBuilder = New StringBuilder(SB_INIT_LENGTH)

    Select Case RowCountFilter
      Case RowCountFilters.All
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT Count(*) As NumRecs FROM dbo.tblExpenseTrans")

        End If

      Case RowCountFilters.Custom
        sb.Append(RowCountCustom)

    End Select

    If UseStoredProcs = False Then
      sb.Append(WhereClauseSQL())
    End If

    SQL = sb.ToString()

    Return SQL
  End Function
#End Region

#Region "LoadByPK Method"
  ''' <summary>
  ''' Load a row of data in the Entity properties
  ''' </summary>
  ''' <param name="exptransid">The value of the primary key of the row to load</param>
  ''' <returns>Int32</returns>
  Public Function LoadByPK(ByVal exptransid As Integer) As Integer
    SelectFilter = SelectFilters.PrimaryKey
    Entity.exptransid = exptransid

    ' Load data into Properties
    RowsAffected = Load()

    ' Reset all Collection Properties
    ResetCollectionProperties()

    Return RowsAffected
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

      Case WhereFilters.PrimaryKey
        sb.Append(" WHERE exptransid = @exptransid")
          
      Case WhereFilters.expremarks
        sb.Append(" WHERE expremarks = @expremarks")
          
      Case WhereFilters.Likeexpremarks
        sb.Append(" WHERE expremarks LIKE @expremarks")
          
      Case WhereFilters.expenseid
        sb.Append(" WHERE expenseid = @expenseid")
          
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
      Case WhereFilters.PrimaryKey
        CommandObject.Parameters.Add(DataProvider.CreateParameter("exptransid", DbType.Int32, Entity.exptransid))
      Case WhereFilters.expremarks
        CommandObject.Parameters.Add(DataProvider.CreateParameter("expremarks", DbType.String, Entity.expremarks))
      Case WhereFilters.Likeexpremarks
        CommandObject.Parameters.Add(DataProvider.CreateParameter("expremarks", DbType.String, Entity.expremarks))
      Case WhereFilters.expenseid
        CommandObject.Parameters.Add(DataProvider.CreateParameter("expenseid", DbType.Int32, Entity.expenseid))
      
      

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

      Case OrderByFilters.expremarks
          sb.Append(" ORDER BY expremarks")


    End Select

    Return sb.ToString()
  End Function
#End Region

#Region "SelectFillInParameters Method"
  ''' <summary>
  ''' Builds the CommandObject.Parameters collection for any SELECT statement parameters.
  ''' </summary>
  Protected Overrides Sub SelectFillInParameters()
    Select Case SelectFilter
      Case SelectFilters.All
      
      Case SelectFilters.ListBox
      
      Case SelectFilters.PrimaryKey
        CommandObject.Parameters.Add(DataProvider.CreateParameter("@exptransid", DbType.Int32, Entity.exptransid))
      
  
    End Select
  End Sub
#End Region

#Region "PrimaryKeySet Method"
  ''' <summary>
  ''' Sets the primary key field in the Entity and in the Data Columns Collection.
  ''' </summary>
  ''' <param name="exptransid">The value of the primary key to set</param>
  Public Overrides Sub PrimaryKeySet(ByVal exptransid As Integer)
    ' Fill in Entity Values
    Entity.exptransid = exptransid
    ' Fill in Columns Collection
    ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).Value = exptransid
  End Sub
#End Region

#Region "SetModificationCommandParameters Method"
  ''' <summary>
  ''' Called to build any parameters prior to submitting an INSERT, UPDATE, DELETE statement.
  ''' </summary>
  Protected Overrides Sub SetModificationCommandParameters()
    Select Case DataModificationAction
      Case PDSADataModificationState.Delete
        Select Case DeleteFilter
        
          Case DeleteFilters.All
            CommandObject.Parameters.Clear()
          Case DeleteFilters.DeleteByPK
            CommandObject.Parameters.Clear()
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@exptransid", DbType.Int32, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).Value))
          
        End Select        
        If Me.WhereFilter <> WhereFilters.None Then
          WhereClauseFillInParameters()
        End If
      
      Case PDSADataModificationState.Insert
        If PrimaryKeyType = PDSAPrimaryKeyType.PDSA Then
          If PrimaryKeyGenerate = True Then
            '  Get New Primary Key from pdsaTableIds
            PrimaryKeySet(PKGetFromPDSATableIds(PDSALoginName))
          End If
        End If

        ' Clear any Where Filter when doing an INSERT
        Me.WhereFilter = WhereFilters.None

        Select Case InsertFilter
          Case InsertFilters.All
            CommandObject.Parameters.Clear()
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@expdate", DbType.Date, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@expamount", DbType.Decimal, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@expremarks", DbType.String, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@expenseid", DbType.Int32, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@modifiedby", DbType.String, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@modifiedon", DbType.DateTime, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).Value))

        End Select

      Case PDSADataModificationState.Update
        Select Case UpdateFilter
          Case UpdateFilters.PrimaryKey
            CommandObject.Parameters.Clear()
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@expdate", DbType.Date, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expdate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@expamount", DbType.Decimal, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expamount).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@expremarks", DbType.String, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expremarks).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@expenseid", DbType.Int32, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.expenseid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@modifiedby", DbType.String, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedby).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@modifiedon", DbType.DateTime, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.modifiedon).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@exptransid", DbType.Int32, ValidatorObject.Properties.GetByName(tblExpenseTransValidator.ColumnNames.exptransid).Value))

        End Select
    End Select
  End Sub
#End Region
End Class
