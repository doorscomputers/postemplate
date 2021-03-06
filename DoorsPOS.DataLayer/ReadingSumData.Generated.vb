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
''' Used to Add/Edit/Delete/Select data from the ReadingSum table.
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class ReadingSumData
  Inherits PDSADataClassTable

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the ReadingSumData class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    _Entity = New ReadingSum()
    ValidatorObject = New ReadingSumValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the ReadingSumData class
  ''' </summary>
  ''' <param name="entity">An instance of a ReadingSum</param>
  Public Sub New(ByVal entity As ReadingSum)
    MyBase.New(entity)

    _Entity = entity
    ValidatorObject = New ReadingSumValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the ReadingSumData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a ReadingSum</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, ByVal entity As ReadingSum)
    MyBase.New(dataProvider, entity)

    _Entity = entity
    ValidatorObject = New ReadingSumValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the ReadingSumData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a ReadingSum</param>
  ''' <param name="validator">An instance of a ReadingSumValidator</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As ReadingSum, ByVal validator As ReadingSumValidator)
    MyBase.New(dataProvider, entity, validator)

    _Entity = entity
    ValidatorObject = validator

    Init()
  End Sub
#End Region

#Region "Private Filter Properties and Enumerations"
  Private _Entity As ReadingSum

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
    ''' 'LikeLocation' WhereFilter
    ''' </summary>
    LikeLocation
    ''' <summary>
    ''' 'Location' WhereFilter
    ''' </summary>
    Location
    ''' <summary>
    ''' 'PrimaryKey' WhereFilter
    ''' </summary>
    PrimaryKey
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
    ''' 'Location' OrderByFilter
    ''' </summary>
    Location
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
  Public Property Entity() As ReadingSum
    Get
      Return _Entity
    End Get
    Set(ByVal value As ReadingSum)
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
    ClassName = "ReadingSumData"
    DBObjectName = "ReadingSum"
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
    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId)
    prop.IsInsertable = False
    prop.IsUpdatable = False
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Location)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.xShort)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
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
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).Value = Entity.ReadingId
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).Value = Entity.ReadingDate
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Location).Value = Entity.Location
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).Value = Entity.Cashier
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).Value = Entity.TotalSales
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).Value = Entity.BegCash
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).Value = Entity.CashEnd
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).Value = Entity.xShort
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).Value = Entity.OverAmount
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).Value = Entity.Remittance
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).Value = Entity.AddFund
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).Value = Entity.PettyCash
  End Sub
#End Region

#Region "ColumnCollectionToEntityData Method"
  ''' <summary>
  ''' Moves the data from the Columns collection into the Entity class.
  ''' This is called whenever you are reading data in from a database.
  ''' </summary>
  Protected Overrides Sub ColumnCollectionToEntityData()
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).IsNull = False Then
      Entity.ReadingId = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).GetAsInteger()
    Else
      Entity.ReadingId = 0
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).IsNull = False Then
      Entity.ReadingDate = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).GetAsDate()
    Else
      Entity.ReadingDate = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Location).IsNull = False Then
      Entity.Location = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Location).GetAsString()
    Else
      Entity.Location = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).IsNull = False Then
      Entity.Cashier = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).GetAsString()
    Else
      Entity.Cashier = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).IsNull = False Then
      Entity.TotalSales = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).GetAsDecimal()
    Else
      Entity.TotalSales = 0
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).IsNull = False Then
      Entity.BegCash = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).GetAsDecimal()
    Else
      Entity.BegCash = 0
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).IsNull = False Then
      Entity.CashEnd = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).GetAsDecimal()
    Else
      Entity.CashEnd = 0
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).IsNull = False Then
      Entity.xShort = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).GetAsDecimal()
    Else
      Entity.xShort = 0
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).IsNull = False Then
      Entity.OverAmount = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).GetAsDecimal()
    Else
      Entity.OverAmount = 0
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).IsNull = False Then
      Entity.Remittance = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).GetAsDecimal()
    Else
      Entity.Remittance = 0
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).IsNull = False Then
      Entity.AddFund = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).GetAsDecimal()
    Else
      Entity.AddFund = 0
    End If
    
    If ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).IsNull = False Then
      Entity.PettyCash = ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).GetAsDecimal()
    Else
      Entity.PettyCash = 0
    End If
    
  End Sub
#End Region

#Region "CreateEntityFromDataRow Method"
  ''' <summary>
  ''' Creates an Entity object from a DataRow object.
  ''' </summary>
  ''' <param name="dr">DataRow object with all fields from the table in it.</param>
  ''' <returns>ReadingSum</returns>
  Public Function CreateEntityFromDataRow(ByVal dr As DataRow) As ReadingSum
    ' Create new Entity Object
    Entity = New ReadingSum()

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
            sb.Append(" SELECT ReadingId, ReadingDate, Location, Cashier, TotalSales, BegCash, CashEnd, Short, OverAmount, Remittance, AddFund, PettyCash FROM dbo.ReadingSum")

        End If
      Case SelectFilters.ListBox
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT ReadingId, Location FROM dbo.ReadingSum")

        End If
      Case SelectFilters.PrimaryKey
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT ReadingId, ReadingDate, Location, Cashier, TotalSales, BegCash, CashEnd, Short, OverAmount, Remittance, AddFund, PettyCash FROM dbo.ReadingSum")

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
            sb.Append(" INSERT INTO dbo.ReadingSum ( ReadingDate, Location, Cashier, TotalSales, BegCash, CashEnd, Short, OverAmount, Remittance, AddFund, PettyCash ) VALUES ( @ReadingDate, @Location, @Cashier, @TotalSales, @BegCash, @CashEnd, @xShort, @OverAmount, @Remittance, @AddFund, @PettyCash )")

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
            sb.Append(" UPDATE dbo.ReadingSum SET ReadingDate = @ReadingDate, Location = @Location, Cashier = @Cashier, TotalSales = @TotalSales, BegCash = @BegCash, CashEnd = @CashEnd, Short = @xShort, OverAmount = @OverAmount, Remittance = @Remittance, AddFund = @AddFund, PettyCash = @PettyCash WHERE ReadingId = @ReadingId")

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
  ''' <param name="ReadingId">The value of the primary key of the row to delete</param>
  ''' <returns>int</returns>
  Public Function DeleteByPK(ByVal readingId As Integer) As Integer
    DeleteFilter = DeleteFilters.DeleteByPK
    Entity.ReadingId = readingId

    ' If using Audit Tracking, need to load the record first
    If UseAuditTracking Then
      LoadByPK(readingId)
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
            sb.Append(" DELETE FROM dbo.ReadingSum")

        End If
      Case DeleteFilters.DeleteByPK
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" DELETE FROM dbo.ReadingSum WHERE ReadingId = @ReadingId")

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
            sb.Append(" SELECT Count(*) As NumRecs FROM dbo.ReadingSum")

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
  ''' <param name="ReadingId">The value of the primary key of the row to load</param>
  ''' <returns>Int32</returns>
  Public Function LoadByPK(ByVal readingId As Integer) As Integer
    SelectFilter = SelectFilters.PrimaryKey
    Entity.ReadingId = readingId

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

      Case WhereFilters.LikeLocation
        sb.Append(" WHERE Location LIKE @Location")
          
      Case WhereFilters.Location
        sb.Append(" WHERE Location = @Location")
          
      Case WhereFilters.PrimaryKey
        sb.Append(" WHERE ReadingId = @ReadingId")
          
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
      Case WhereFilters.LikeLocation
        CommandObject.Parameters.Add(DataProvider.CreateParameter("Location", DbType.String, Entity.Location))
      Case WhereFilters.Location
        CommandObject.Parameters.Add(DataProvider.CreateParameter("Location", DbType.String, Entity.Location))
      Case WhereFilters.PrimaryKey
        CommandObject.Parameters.Add(DataProvider.CreateParameter("ReadingId", DbType.Int32, Entity.ReadingId))
      
      

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

      Case OrderByFilters.Location
          sb.Append(" ORDER BY Location")


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
      
  
    End Select
  End Sub
#End Region

#Region "PrimaryKeySet Method"
  ''' <summary>
  ''' Sets the primary key field in the Entity and in the Data Columns Collection.
  ''' </summary>
  ''' <param name="ReadingId">The value of the primary key to set</param>
  Public Overrides Sub PrimaryKeySet(ByVal readingId As Integer)
    ' Fill in Entity Values
    Entity.ReadingId = readingId
    ' Fill in Columns Collection
    ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).Value = readingId
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@ReadingId", DbType.Int32, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).Value))
          
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@ReadingDate", DbType.Date, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@Location", DbType.String, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Location).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@Cashier", DbType.String, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@TotalSales", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@BegCash", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@CashEnd", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@xShort", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@OverAmount", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@Remittance", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@AddFund", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@PettyCash", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).Value))

        End Select

      Case PDSADataModificationState.Update
        Select Case UpdateFilter
          Case UpdateFilters.PrimaryKey
            CommandObject.Parameters.Clear()
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@ReadingDate", DbType.Date, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingDate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@Location", DbType.String, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Location).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@Cashier", DbType.String, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Cashier).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@TotalSales", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.TotalSales).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@BegCash", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.BegCash).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@CashEnd", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.CashEnd).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@xShort", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.xShort).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@OverAmount", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.OverAmount).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@Remittance", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.Remittance).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@AddFund", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.AddFund).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@PettyCash", DbType.Decimal, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.PettyCash).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@ReadingId", DbType.Int32, ValidatorObject.Properties.GetByName(ReadingSumValidator.ColumnNames.ReadingId).Value))

        End Select
    End Select
  End Sub
#End Region
End Class
