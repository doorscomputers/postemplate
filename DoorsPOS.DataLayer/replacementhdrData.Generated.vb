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
''' Used to Add/Edit/Delete/Select data from the replacementhdr table.
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class replacementhdrData
  Inherits PDSADataClassTable

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the replacementhdrData class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    _Entity = New replacementhdr()
    ValidatorObject = New replacementhdrValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the replacementhdrData class
  ''' </summary>
  ''' <param name="entity">An instance of a replacementhdr</param>
  Public Sub New(ByVal entity As replacementhdr)
    MyBase.New(entity)

    _Entity = entity
    ValidatorObject = New replacementhdrValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the replacementhdrData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a replacementhdr</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, ByVal entity As replacementhdr)
    MyBase.New(dataProvider, entity)

    _Entity = entity
    ValidatorObject = New replacementhdrValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the replacementhdrData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a replacementhdr</param>
  ''' <param name="validator">An instance of a replacementhdrValidator</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As replacementhdr, ByVal validator As replacementhdrValidator)
    MyBase.New(dataProvider, entity, validator)

    _Entity = entity
    ValidatorObject = validator

    Init()
  End Sub
#End Region

#Region "Private Filter Properties and Enumerations"
  Private _Entity As replacementhdr

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
    ''' 'LikesInsert_id' WhereFilter
    ''' </summary>
    LikesInsert_id
    ''' <summary>
    ''' 'PrimaryKey' WhereFilter
    ''' </summary>
    PrimaryKey
    ''' <summary>
    ''' 'sInsert_id' WhereFilter
    ''' </summary>
    sInsert_id
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
    ''' 'sInsert_id' OrderByFilter
    ''' </summary>
    sInsert_id
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
  Public Property Entity() As replacementhdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As replacementhdr)
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
    ClassName = "replacementhdrData"
    DBObjectName = "replacementhdr"
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
    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.repid)
    prop.IsInsertable = False
    prop.IsUpdatable = False
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.rdate)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt16.Null
    prop.ValueForNull = 0

  End Sub
#End Region

#Region "EntityDataToColumnCollection Method"
  ''' <summary>
  ''' Moves the data from the Entity class into the Columns collection
  ''' This is called prior to performing a Business Rule Check, an INSERT, UPDATE or DELETE
  ''' </summary>
  Protected Overrides Sub EntityDataToColumnCollection()
    ' Move all Entity Values into Properties Collection
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.repid).Value = Entity.repid
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).Value = Entity.ReplacementNo
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).Value = Entity.rdate
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).Value = Entity.ramnt
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
  End Sub
#End Region

#Region "ColumnCollectionToEntityData Method"
  ''' <summary>
  ''' Moves the data from the Columns collection into the Entity class.
  ''' This is called whenever you are reading data in from a database.
  ''' </summary>
  Protected Overrides Sub ColumnCollectionToEntityData()
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.repid).IsNull = False Then
      Entity.repid = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.repid).GetAsInteger()
    Else
      Entity.repid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).IsNull = False Then
      Entity.ReplacementNo = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).GetAsInteger()
    Else
      Entity.ReplacementNo = 0
    End If
    
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).IsNull = False Then
      Entity.rdate = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).GetAsDate()
    Else
      Entity.rdate = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).IsNull = False Then
      Entity.ramnt = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).GetAsDecimal()
    Else
      Entity.ramnt = 0
    End If
    
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).GetAsString()
    Else
      Entity.sInsertid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).GetAsDate()
    Else
      Entity.dtInsertdt = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).GetAsString()
    Else
      Entity.sLastUpdateid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    Else
      Entity.dtLastUpdatedt = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).GetAsShort()
    Else
      Entity.iConcurrencyid = 0
    End If
    
  End Sub
#End Region

#Region "CreateEntityFromDataRow Method"
  ''' <summary>
  ''' Creates an Entity object from a DataRow object.
  ''' </summary>
  ''' <param name="dr">DataRow object with all fields from the table in it.</param>
  ''' <returns>replacementhdr</returns>
  Public Function CreateEntityFromDataRow(ByVal dr As DataRow) As replacementhdr
    ' Create new Entity Object
    Entity = New replacementhdr()

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
            sb.Append(" SELECT repid, ReplacementNo, rdate, ramnt, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id FROM dbo.replacementhdr")

        End If
      Case SelectFilters.ListBox
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT repid, sInsert_id FROM dbo.replacementhdr")

        End If
      Case SelectFilters.PrimaryKey
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT repid, ReplacementNo, rdate, ramnt, locid, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id FROM dbo.replacementhdr WHERE repid = @repid")

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
            sb.Append(" INSERT INTO dbo.replacementhdr ( ReplacementNo, rdate, ramnt, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id ) VALUES ( @ReplacementNo, @rdate, @ramnt, @sInsertid, @dtInsertdt, @sLastUpdateid, @dtLastUpdatedt, @iConcurrencyid )")

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
            sb.Append(" UPDATE dbo.replacementhdr SET ReplacementNo = @ReplacementNo, rdate = @rdate, ramnt = @ramnt, sInsert_id = @sInsertid, dtInsert_dt = @dtInsertdt, sLastUpdate_id = @sLastUpdateid, dtLastUpdate_dt = @dtLastUpdatedt, iConcurrency_id = @iConcurrencyid WHERE repid = @repid")

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
  ''' <param name="repid">The value of the primary key of the row to delete</param>
  ''' <returns>int</returns>
  Public Function DeleteByPK(ByVal repid As Integer) As Integer
    DeleteFilter = DeleteFilters.DeleteByPK
    Entity.repid = repid

    ' If using Audit Tracking, need to load the record first
    If UseAuditTracking Then
      LoadByPK(repid)
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
            sb.Append(" DELETE FROM dbo.replacementhdr")

        End If
      Case DeleteFilters.DeleteByPK
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" DELETE FROM dbo.replacementhdr WHERE repid = @repid")

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
            sb.Append(" SELECT Count(*) As NumRecs FROM dbo.replacementhdr")

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
  ''' <param name="repid">The value of the primary key of the row to load</param>
  ''' <returns>Int32</returns>
  Public Function LoadByPK(ByVal repid As Integer) As Integer
    SelectFilter = SelectFilters.PrimaryKey
    Entity.repid = repid

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

      Case WhereFilters.LikesInsert_id
        sb.Append(" WHERE sInsert_id LIKE @sInsertid")
          
      Case WhereFilters.PrimaryKey
        sb.Append(" WHERE repid = @repid")
          
      Case WhereFilters.sInsert_id
        sb.Append(" WHERE sInsert_id = @sInsertid")
          
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
      Case WhereFilters.LikesInsert_id
        CommandObject.Parameters.Add(DataProvider.CreateParameter("sInsertid", DbType.String, Entity.sInsertid))
      Case WhereFilters.PrimaryKey
        CommandObject.Parameters.Add(DataProvider.CreateParameter("repid", DbType.Int32, Entity.repid))
      Case WhereFilters.sInsert_id
        CommandObject.Parameters.Add(DataProvider.CreateParameter("sInsertid", DbType.String, Entity.sInsertid))
      
      

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

      Case OrderByFilters.sInsert_id
          sb.Append(" ORDER BY sInsert_id")


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
        CommandObject.Parameters.Add(DataProvider.CreateParameter("@repid", DbType.Int32, Entity.repid))
      
  
    End Select
  End Sub
#End Region

#Region "PrimaryKeySet Method"
  ''' <summary>
  ''' Sets the primary key field in the Entity and in the Data Columns Collection.
  ''' </summary>
  ''' <param name="repid">The value of the primary key to set</param>
  Public Overrides Sub PrimaryKeySet(ByVal repid As Integer)
    ' Fill in Entity Values
    Entity.repid = repid
    ' Fill in Columns Collection
    ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.repid).Value = repid
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@repid", DbType.Int32, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.repid).Value))
          
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@ReplacementNo", DbType.Int32, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@rdate", DbType.Date, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@ramnt", DbType.Decimal, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtInsertdt", DbType.Date, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sLastUpdateid", DbType.String, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtLastUpdatedt", DbType.Date, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@iConcurrencyid", DbType.Int16, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).Value))

        End Select

      Case PDSADataModificationState.Update
        Select Case UpdateFilter
          Case UpdateFilters.PrimaryKey
            CommandObject.Parameters.Clear()
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@ReplacementNo", DbType.Int32, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ReplacementNo).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@rdate", DbType.Date, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.rdate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@ramnt", DbType.Decimal, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.ramnt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtInsertdt", DbType.Date, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtInsertdt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sLastUpdateid", DbType.String, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.sLastUpdateid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtLastUpdatedt", DbType.Date, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.dtLastUpdatedt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@iConcurrencyid", DbType.Int16, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.iConcurrencyid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@repid", DbType.Int32, ValidatorObject.Properties.GetByName(replacementhdrValidator.ColumnNames.repid).Value))

        End Select
    End Select
  End Sub
#End Region
End Class
