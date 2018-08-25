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
''' Used to Add/Edit/Delete/Select data from the pohdrtmp table.
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class pohdrtmpData
  Inherits PDSADataClassTable

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the pohdrtmpData class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    _Entity = New pohdrtmp()
    ValidatorObject = New pohdrtmpValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the pohdrtmpData class
  ''' </summary>
  ''' <param name="entity">An instance of a pohdrtmp</param>
  Public Sub New(ByVal entity As pohdrtmp)
    MyBase.New(entity)

    _Entity = entity
    ValidatorObject = New pohdrtmpValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the pohdrtmpData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a pohdrtmp</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, ByVal entity As pohdrtmp)
    MyBase.New(dataProvider, entity)

    _Entity = entity
    ValidatorObject = New pohdrtmpValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the pohdrtmpData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a pohdrtmp</param>
  ''' <param name="validator">An instance of a pohdrtmpValidator</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As pohdrtmp, ByVal validator As pohdrtmpValidator)
    MyBase.New(dataProvider, entity, validator)

    _Entity = entity
    ValidatorObject = validator

    Init()
  End Sub
#End Region

#Region "Private Filter Properties and Enumerations"
  Private _Entity As pohdrtmp

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
    ''' 'poinv' WhereFilter
    ''' </summary>
    poinv
    ''' <summary>
    ''' 'Likepoinv' WhereFilter
    ''' </summary>
    Likepoinv
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
    ''' 'poinv' OrderByFilter
    ''' </summary>
    poinv
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
  Public Property Entity() As pohdrtmp
    Get
      Return _Entity
    End Get
    Set(ByVal value As pohdrtmp)
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
    ClassName = "pohdrtmpData"
    DBObjectName = "pohdrtmp"
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
    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp)
    prop.IsInsertable = False
    prop.IsUpdatable = False
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.podate)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlBoolean.Null
    prop.ValueForNull = Nothing

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlBoolean.Null
    prop.ValueForNull = Nothing

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlString.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlString.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid)
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
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).Value = Entity.poidtmp
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).Value = Entity.podate
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).Value = Entity.poinv
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).Value = Entity.supcode
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).Value = Entity.poamnt
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).Value = Entity.dlivered
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).Value = Entity.drpsted
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
  End Sub
#End Region

#Region "ColumnCollectionToEntityData Method"
  ''' <summary>
  ''' Moves the data from the Columns collection into the Entity class.
  ''' This is called whenever you are reading data in from a database.
  ''' </summary>
  Protected Overrides Sub ColumnCollectionToEntityData()
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).IsNull = False Then
      Entity.poidtmp = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).GetAsInteger()
    Else
      Entity.poidtmp = 0
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).IsNull = False Then
      Entity.podate = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).GetAsDate()
    Else
      Entity.podate = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).IsNull = False Then
      Entity.poinv = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).GetAsString()
    Else
      Entity.poinv = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).GetAsInteger()
    Else
      Entity.supcode = 0
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).IsNull = False Then
      Entity.poamnt = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).GetAsDecimal()
    Else
      Entity.poamnt = 0
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).IsNull = False Then
      Entity.dlivered = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).GetValueAsBoolean()
    Else
      Entity.dlivered = Nothing
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).IsNull = False Then
      Entity.drpsted = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).GetValueAsBoolean()
    Else
      Entity.drpsted = Nothing
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).GetAsString()
    Else
      Entity.sInsertid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).GetAsDate()
    Else
      Entity.dtInsertdt = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).GetAsString()
    Else
      Entity.sLastUpdateid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    Else
      Entity.dtLastUpdatedt = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).GetAsShort()
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
  ''' <returns>pohdrtmp</returns>
  Public Function CreateEntityFromDataRow(ByVal dr As DataRow) As pohdrtmp
    ' Create new Entity Object
    Entity = New pohdrtmp()

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
            sb.Append(" SELECT poidtmp, podate, poinv, supcode, poamnt, dlivered, drpsted, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id FROM dbo.pohdrtmp")

        End If
      Case SelectFilters.ListBox
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT poidtmp, poinv FROM dbo.pohdrtmp")

        End If
      Case SelectFilters.PrimaryKey
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT poidtmp, podate, poinv, supcode, poamnt, dlivered, drpsted, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id FROM dbo.pohdrtmp WHERE poidtmp = @poidtmp")

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
            sb.Append(" INSERT INTO dbo.pohdrtmp ( podate, poinv, supcode, poamnt, dlivered, drpsted, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id ) VALUES ( @podate, @poinv, @supcode, @poamnt, @dlivered, @drpsted, @sInsertid, @dtInsertdt, @sLastUpdateid, @dtLastUpdatedt, @iConcurrencyid )")

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
            sb.Append(" UPDATE dbo.pohdrtmp SET podate = @podate, poinv = @poinv, supcode = @supcode, poamnt = @poamnt, dlivered = @dlivered, drpsted = @drpsted, sInsert_id = @sInsertid, dtInsert_dt = @dtInsertdt, sLastUpdate_id = @sLastUpdateid, dtLastUpdate_dt = @dtLastUpdatedt, iConcurrency_id = @iConcurrencyid WHERE poidtmp = @poidtmp")

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
  ''' <param name="poidtmp">The value of the primary key of the row to delete</param>
  ''' <returns>int</returns>
  Public Function DeleteByPK(ByVal poidtmp As Integer) As Integer
    DeleteFilter = DeleteFilters.DeleteByPK
    Entity.poidtmp = poidtmp

    ' If using Audit Tracking, need to load the record first
    If UseAuditTracking Then
      LoadByPK(poidtmp)
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
            sb.Append(" DELETE FROM dbo.pohdrtmp")

        End If
      Case DeleteFilters.DeleteByPK
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" DELETE FROM dbo.pohdrtmp WHERE poidtmp = @poidtmp")

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
            sb.Append(" SELECT Count(*) As NumRecs FROM dbo.pohdrtmp")

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
  ''' <param name="poidtmp">The value of the primary key of the row to load</param>
  ''' <returns>Int32</returns>
  Public Function LoadByPK(ByVal poidtmp As Integer) As Integer
    SelectFilter = SelectFilters.PrimaryKey
    Entity.poidtmp = poidtmp

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
        sb.Append(" WHERE poidtmp = @poidtmp")
          
      Case WhereFilters.poinv
        sb.Append(" WHERE poinv = @poinv")
          
      Case WhereFilters.Likepoinv
        sb.Append(" WHERE poinv LIKE @poinv")
          
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
        CommandObject.Parameters.Add(DataProvider.CreateParameter("poidtmp", DbType.Int32, Entity.poidtmp))
      Case WhereFilters.poinv
        CommandObject.Parameters.Add(DataProvider.CreateParameter("poinv", DbType.String, Entity.poinv))
      Case WhereFilters.Likepoinv
        CommandObject.Parameters.Add(DataProvider.CreateParameter("poinv", DbType.String, Entity.poinv))
      
      

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

      Case OrderByFilters.poinv
          sb.Append(" ORDER BY poinv")


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
        CommandObject.Parameters.Add(DataProvider.CreateParameter("@poidtmp", DbType.Int32, Entity.poidtmp))
      
  
    End Select
  End Sub
#End Region

#Region "PrimaryKeySet Method"
  ''' <summary>
  ''' Sets the primary key field in the Entity and in the Data Columns Collection.
  ''' </summary>
  ''' <param name="poidtmp">The value of the primary key to set</param>
  Public Overrides Sub PrimaryKeySet(ByVal poidtmp As Integer)
    ' Fill in Entity Values
    Entity.poidtmp = poidtmp
    ' Fill in Columns Collection
    ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).Value = poidtmp
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@poidtmp", DbType.Int32, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).Value))
          
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@podate", DbType.Date, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@poinv", DbType.String, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@supcode", DbType.Int32, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@poamnt", DbType.Decimal, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dlivered", DbType.Boolean, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@drpsted", DbType.Boolean, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtInsertdt", DbType.DateTime, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sLastUpdateid", DbType.String, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtLastUpdatedt", DbType.DateTime, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@iConcurrencyid", DbType.Int16, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).Value))

        End Select

      Case PDSADataModificationState.Update
        Select Case UpdateFilter
          Case UpdateFilters.PrimaryKey
            CommandObject.Parameters.Clear()
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@podate", DbType.Date, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.podate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@poinv", DbType.String, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poinv).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@supcode", DbType.Int32, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.supcode).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@poamnt", DbType.Decimal, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poamnt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dlivered", DbType.Boolean, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dlivered).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@drpsted", DbType.Boolean, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.drpsted).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtInsertdt", DbType.DateTime, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtInsertdt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sLastUpdateid", DbType.String, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.sLastUpdateid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtLastUpdatedt", DbType.DateTime, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.dtLastUpdatedt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@iConcurrencyid", DbType.Int16, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.iConcurrencyid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@poidtmp", DbType.Int32, ValidatorObject.Properties.GetByName(pohdrtmpValidator.ColumnNames.poidtmp).Value))

        End Select
    End Select
  End Sub
#End Region
End Class
