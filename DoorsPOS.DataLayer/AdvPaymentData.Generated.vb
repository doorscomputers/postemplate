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
''' Used to Add/Edit/Delete/Select data from the AdvPayment table.
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class AdvPaymentData
  Inherits PDSADataClassTable

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the AdvPaymentData class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    _Entity = New AdvPayment()
    ValidatorObject = New AdvPaymentValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the AdvPaymentData class
  ''' </summary>
  ''' <param name="entity">An instance of a AdvPayment</param>
  Public Sub New(ByVal entity As AdvPayment)
    MyBase.New(entity)

    _Entity = entity
    ValidatorObject = New AdvPaymentValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the AdvPaymentData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a AdvPayment</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, ByVal entity As AdvPayment)
    MyBase.New(dataProvider, entity)

    _Entity = entity
    ValidatorObject = New AdvPaymentValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the AdvPaymentData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a AdvPayment</param>
  ''' <param name="validator">An instance of a AdvPaymentValidator</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As AdvPayment, ByVal validator As AdvPaymentValidator)
    MyBase.New(dataProvider, entity, validator)

    _Entity = entity
    ValidatorObject = validator

    Init()
  End Sub
#End Region

#Region "Private Filter Properties and Enumerations"
  Private _Entity As AdvPayment

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
    ''' 'AmntPaid' SelectFilter
    ''' </summary>
    AmntPaid
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
    ''' 'Remarks' WhereFilter
    ''' </summary>
    Remarks
    ''' <summary>
    ''' 'LikeRemarks' WhereFilter
    ''' </summary>
    LikeRemarks
    ''' <summary>
    ''' 'custclaimed' WhereFilter
    ''' </summary>
    custclaimed
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
    ''' 'Remarks' OrderByFilter
    ''' </summary>
    Remarks
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
  Public Property Entity() As AdvPayment
    Get
      Return _Entity
    End Get
    Set(ByVal value As AdvPayment)
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
    ClassName = "AdvPaymentData"
    DBObjectName = "AdvPayment"
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
    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.advid)
    prop.IsInsertable = False
    prop.IsUpdatable = False
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.custid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlBoolean.Null
    prop.ValueForNull = Nothing

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlString.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlString.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlString.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid)
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
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).Value = Entity.advid
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).Value = Entity.datepaid
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).Value = Entity.custid
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).Value = Entity.amountpaid
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).Value = Entity.claimed
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).Value = Entity.Remarks
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
  End Sub
#End Region

#Region "ColumnCollectionToEntityData Method"
  ''' <summary>
  ''' Moves the data from the Columns collection into the Entity class.
  ''' This is called whenever you are reading data in from a database.
  ''' </summary>
  Protected Overrides Sub ColumnCollectionToEntityData()
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).IsNull = False Then
      Entity.advid = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).GetAsInteger()
    Else
      Entity.advid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).IsNull = False Then
      Entity.datepaid = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).GetAsDate()
    Else
      Entity.datepaid = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).IsNull = False Then
      Entity.custid = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).GetAsInteger()
    Else
      Entity.custid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).IsNull = False Then
      Entity.amountpaid = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).GetAsDecimal()
    Else
      Entity.amountpaid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).IsNull = False Then
      Entity.claimed = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).GetValueAsBoolean()
    Else
      Entity.claimed = Nothing
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).IsNull = False Then
      Entity.Remarks = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).GetAsString()
    Else
      Entity.Remarks = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).GetAsString()
    Else
      Entity.sInsertid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).GetAsDate()
    Else
      Entity.dtInsertdt = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).GetAsString()
    Else
      Entity.sLastUpdateid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    Else
      Entity.dtLastUpdatedt = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).GetAsShort()
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
  ''' <returns>AdvPayment</returns>
  Public Function CreateEntityFromDataRow(ByVal dr As DataRow) As AdvPayment
    ' Create new Entity Object
    Entity = New AdvPayment()

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
            sb.Append(" SELECT advid, datepaid, custid, amountpaid, claimed, Remarks, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id FROM dbo.AdvPayment")

        End If
      Case SelectFilters.ListBox
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT advid, Remarks FROM dbo.AdvPayment")

        End If
      Case SelectFilters.PrimaryKey
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT advid, datepaid, custid, amountpaid, claimed, Remarks, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id FROM dbo.AdvPayment WHERE advid = @advid")

        End If
      Case SelectFilters.AmntPaid
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT ")
sb.Append(" amountpaid, custid ")
sb.Append(" FROM dbo.AdvPayment")

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
            sb.Append(" INSERT INTO dbo.AdvPayment ( datepaid, custid, amountpaid, claimed, Remarks, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id ) VALUES ( @datepaid, @custid, @amountpaid, @claimed, @Remarks, @sInsertid, @dtInsertdt, @sLastUpdateid, @dtLastUpdatedt, @iConcurrencyid )")

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
            sb.Append(" UPDATE dbo.AdvPayment SET datepaid = @datepaid, custid = @custid, amountpaid = @amountpaid, claimed = @claimed, Remarks = @Remarks, sInsert_id = @sInsertid, dtInsert_dt = @dtInsertdt, sLastUpdate_id = @sLastUpdateid, dtLastUpdate_dt = @dtLastUpdatedt, iConcurrency_id = @iConcurrencyid WHERE advid = @advid")

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
  ''' <param name="advid">The value of the primary key of the row to delete</param>
  ''' <returns>int</returns>
  Public Function DeleteByPK(ByVal advid As Integer) As Integer
    DeleteFilter = DeleteFilters.DeleteByPK
    Entity.advid = advid

    ' If using Audit Tracking, need to load the record first
    If UseAuditTracking Then
      LoadByPK(advid)
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
            sb.Append(" DELETE FROM dbo.AdvPayment")

        End If
      Case DeleteFilters.DeleteByPK
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" DELETE FROM dbo.AdvPayment WHERE advid = @advid")

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
            sb.Append(" SELECT Count(*) As NumRecs FROM dbo.AdvPayment")

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
  ''' <param name="advid">The value of the primary key of the row to load</param>
  ''' <returns>Int32</returns>
  Public Function LoadByPK(ByVal advid As Integer) As Integer
    SelectFilter = SelectFilters.PrimaryKey
    Entity.advid = advid

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
        sb.Append(" WHERE advid = @advid")
          
      Case WhereFilters.Remarks
        sb.Append(" WHERE Remarks = @Remarks")
          
      Case WhereFilters.LikeRemarks
        sb.Append(" WHERE Remarks LIKE @Remarks")
          
      Case WhereFilters.custclaimed
        sb.Append(" WHERE custid  =  @custid AND claimed  =  0")
          
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
        CommandObject.Parameters.Add(DataProvider.CreateParameter("advid", DbType.Int32, Entity.advid))
      Case WhereFilters.Remarks
        CommandObject.Parameters.Add(DataProvider.CreateParameter("Remarks", DbType.String, Entity.Remarks))
      Case WhereFilters.LikeRemarks
        CommandObject.Parameters.Add(DataProvider.CreateParameter("Remarks", DbType.String, Entity.Remarks))
      Case WhereFilters.custclaimed
        CommandObject.Parameters.Add(DataProvider.CreateParameter("custid", DbType.Int32, Entity.custid))
        CommandObject.Parameters.Add(DataProvider.CreateParameter("claimed", DbType.Boolean, Entity.claimed))
      
      

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

      Case OrderByFilters.Remarks
          sb.Append(" ORDER BY Remarks")


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
        CommandObject.Parameters.Add(DataProvider.CreateParameter("@advid", DbType.Int32, Entity.advid))
      
      Case SelectFilters.AmntPaid
      
  
    End Select
  End Sub
#End Region

#Region "PrimaryKeySet Method"
  ''' <summary>
  ''' Sets the primary key field in the Entity and in the Data Columns Collection.
  ''' </summary>
  ''' <param name="advid">The value of the primary key to set</param>
  Public Overrides Sub PrimaryKeySet(ByVal advid As Integer)
    ' Fill in Entity Values
    Entity.advid = advid
    ' Fill in Columns Collection
    ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).Value = advid
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@advid", DbType.Int32, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).Value))
          
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@datepaid", DbType.Date, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@custid", DbType.Int32, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@amountpaid", DbType.Decimal, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@claimed", DbType.Boolean, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@Remarks", DbType.String, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtInsertdt", DbType.DateTime, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sLastUpdateid", DbType.String, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtLastUpdatedt", DbType.DateTime, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@iConcurrencyid", DbType.Int16, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).Value))

        End Select

      Case PDSADataModificationState.Update
        Select Case UpdateFilter
          Case UpdateFilters.PrimaryKey
            CommandObject.Parameters.Clear()
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@datepaid", DbType.Date, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.datepaid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@custid", DbType.Int32, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.custid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@amountpaid", DbType.Decimal, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.amountpaid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@claimed", DbType.Boolean, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.claimed).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@Remarks", DbType.String, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.Remarks).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtInsertdt", DbType.DateTime, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtInsertdt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sLastUpdateid", DbType.String, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.sLastUpdateid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtLastUpdatedt", DbType.DateTime, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.dtLastUpdatedt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@iConcurrencyid", DbType.Int16, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.iConcurrencyid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@advid", DbType.Int32, ValidatorObject.Properties.GetByName(AdvPaymentValidator.ColumnNames.advid).Value))

        End Select
    End Select
  End Sub
#End Region
End Class
