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
''' Used to Add/Edit/Delete/Select data from the paymnthdr table.
''' This class is generated by the Haystack Code Generator for .NET.
''' You should NOT modify this class as it is intended to be re-generated.
''' </summary>
Public Class paymnthdrData
  Inherits PDSADataClassTable

#Region "Constructors"
  ''' <summary>
  ''' Constructor for the paymnthdrData class
  ''' </summary>
  Public Sub New()
    MyBase.New()

    _Entity = New paymnthdr()
    ValidatorObject = New paymnthdrValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the paymnthdrData class
  ''' </summary>
  ''' <param name="entity">An instance of a paymnthdr</param>
  Public Sub New(ByVal entity As paymnthdr)
    MyBase.New(entity)

    _Entity = entity
    ValidatorObject = New paymnthdrValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the paymnthdrData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a paymnthdr</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, ByVal entity As paymnthdr)
    MyBase.New(dataProvider, entity)

    _Entity = entity
    ValidatorObject = New paymnthdrValidator(_Entity)

    Init()
  End Sub

  ''' <summary>
  ''' Constructor for the paymnthdrData class
  ''' </summary>
  ''' <param name="dataProvider">An instance of a PDSADataProvider</param>
  ''' <param name="entity">An instance of a paymnthdr</param>
  ''' <param name="validator">An instance of a paymnthdrValidator</param>
  Public Sub New(ByVal dataProvider As PDSADataProvider, _
    ByVal entity As paymnthdr, ByVal validator As paymnthdrValidator)
    MyBase.New(dataProvider, entity, validator)

    _Entity = entity
    ValidatorObject = validator

    Init()
  End Sub
#End Region

#Region "Private Filter Properties and Enumerations"
  Private _Entity As paymnthdr

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
    ''' 'chqno' WhereFilter
    ''' </summary>
    chqno
    ''' <summary>
    ''' 'Likechqno' WhereFilter
    ''' </summary>
    Likechqno
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
    ''' 'chqno' OrderByFilter
    ''' </summary>
    chqno
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
  Public Property Entity() As paymnthdr
    Get
      Return _Entity
    End Get
    Set(ByVal value As paymnthdr)
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
    ClassName = "paymnthdrData"
    DBObjectName = "paymnthdr"
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
    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.payid)
    prop.IsInsertable = False
    prop.IsUpdatable = False
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paydate)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.supcode)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.discount)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlMoney.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqno)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.bankid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlInt32.Null
    prop.ValueForNull = 0

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.remarks)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlChars.Null
    prop.ValueForNull = String.Empty

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt)
    prop.IsInsertable = True
    prop.IsUpdatable = True
    prop.IncludeInAuditTracking = True
    prop.DBValueForNull = System.Data.SqlTypes.SqlDateTime.Null
    prop.ValueForNull = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)

    prop = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid)
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
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.payid).Value = Entity.payid
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).Value = Entity.paydate
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).Value = Entity.supcode
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).Value = Entity.paytypeid
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).Value = Entity.amntpaid
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).Value = Entity.amntwords
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.discount).Value = Entity.discount
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).Value = Entity.chqno
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).Value = Entity.bankid
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).Value = Entity.chqdate
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).Value = Entity.remarks
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).Value = Entity.sInsertid
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).Value = Entity.dtInsertdt
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).Value = Entity.sLastUpdateid
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).Value = Entity.dtLastUpdatedt
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).Value = Entity.iConcurrencyid
  End Sub
#End Region

#Region "ColumnCollectionToEntityData Method"
  ''' <summary>
  ''' Moves the data from the Columns collection into the Entity class.
  ''' This is called whenever you are reading data in from a database.
  ''' </summary>
  Protected Overrides Sub ColumnCollectionToEntityData()
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.payid).IsNull = False Then
      Entity.payid = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.payid).GetAsInteger()
    Else
      Entity.payid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).IsNull = False Then
      Entity.paydate = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).GetAsDate()
    Else
      Entity.paydate = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).IsNull = False Then
      Entity.supcode = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).GetAsInteger()
    Else
      Entity.supcode = 0
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).IsNull = False Then
      Entity.paytypeid = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).GetAsInteger()
    Else
      Entity.paytypeid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).IsNull = False Then
      Entity.amntpaid = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).GetAsDecimal()
    Else
      Entity.amntpaid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).IsNull = False Then
      Entity.amntwords = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).GetAsString()
    Else
      Entity.amntwords = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.discount).IsNull = False Then
      Entity.discount = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.discount).GetAsDecimal()
    Else
      Entity.discount = 0
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).IsNull = False Then
      Entity.chqno = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).GetAsString()
    Else
      Entity.chqno = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).IsNull = False Then
      Entity.bankid = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).GetAsInteger()
    Else
      Entity.bankid = 0
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).IsNull = False Then
      Entity.chqdate = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).GetAsDate()
    Else
      Entity.chqdate = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).IsNull = False Then
      Entity.remarks = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).GetAsString()
    Else
      Entity.remarks = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).IsNull = False Then
      Entity.sInsertid = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).GetAsString()
    Else
      Entity.sInsertid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).IsNull = False Then
      Entity.dtInsertdt = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).GetAsDate()
    Else
      Entity.dtInsertdt = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).IsNull = False Then
      Entity.sLastUpdateid = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).GetAsString()
    Else
      Entity.sLastUpdateid = String.Empty
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).IsNull = False Then
      Entity.dtLastUpdatedt = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).GetAsDate()
    Else
      Entity.dtLastUpdatedt = Convert.ToDateTime("1/1/1753", System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat)
    End If
    
    If ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).IsNull = False Then
      Entity.iConcurrencyid = ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).GetAsShort()
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
  ''' <returns>paymnthdr</returns>
  Public Function CreateEntityFromDataRow(ByVal dr As DataRow) As paymnthdr
    ' Create new Entity Object
    Entity = New paymnthdr()

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
            sb.Append(" SELECT payid, paydate, supcode, paytypeid, amntpaid, amntwords, discount, chqno, bankid, chqdate, remarks, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id FROM dbo.paymnthdr")

        End If
      Case SelectFilters.ListBox
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT payid, chqno FROM dbo.paymnthdr")

        End If
      Case SelectFilters.PrimaryKey
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" SELECT payid, paydate, supcode, paytypeid, amntpaid, chqno, bankid, chqdate, remarks, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id FROM dbo.paymnthdr")

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
            sb.Append(" INSERT INTO dbo.paymnthdr ( paydate, supcode, paytypeid, amntpaid, amntwords, discount, chqno, bankid, chqdate, remarks, sInsert_id, dtInsert_dt, sLastUpdate_id, dtLastUpdate_dt, iConcurrency_id ) VALUES ( @paydate, @supcode, @paytypeid, @amntpaid, @amntwords, @discount, @chqno, @bankid, @chqdate, @remarks, @sInsertid, @dtInsertdt, @sLastUpdateid, @dtLastUpdatedt, @iConcurrencyid )")

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
            sb.Append(" UPDATE dbo.paymnthdr SET paydate = @paydate, supcode = @supcode, paytypeid = @paytypeid, amntpaid = @amntpaid, amntwords = @amntwords, discount = @discount, chqno = @chqno, bankid = @bankid, chqdate = @chqdate, remarks = @remarks, sInsert_id = @sInsertid, dtInsert_dt = @dtInsertdt, sLastUpdate_id = @sLastUpdateid, dtLastUpdate_dt = @dtLastUpdatedt, iConcurrency_id = @iConcurrencyid WHERE payid = @payid")

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
  ''' <param name="payid">The value of the primary key of the row to delete</param>
  ''' <returns>int</returns>
  Public Function DeleteByPK(ByVal payid As Integer) As Integer
    DeleteFilter = DeleteFilters.DeleteByPK
    Entity.payid = payid

    ' If using Audit Tracking, need to load the record first
    If UseAuditTracking Then
      LoadByPK(payid)
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
            sb.Append(" DELETE FROM dbo.paymnthdr")

        End If
      Case DeleteFilters.DeleteByPK
        If UseStoredProcs Then
          sb.Append("")
        Else
            sb.Append(" DELETE FROM dbo.paymnthdr WHERE payid = @payid")

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
            sb.Append(" SELECT Count(*) As NumRecs FROM dbo.paymnthdr")

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
  ''' <param name="payid">The value of the primary key of the row to load</param>
  ''' <returns>Int32</returns>
  Public Function LoadByPK(ByVal payid As Integer) As Integer
    SelectFilter = SelectFilters.PrimaryKey
    Entity.payid = payid

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

      Case WhereFilters.chqno
        sb.Append(" WHERE chqno = @chqno")
          
      Case WhereFilters.Likechqno
        sb.Append(" WHERE chqno LIKE @chqno")
          
      Case WhereFilters.PrimaryKey
        sb.Append(" WHERE payid = @payid")
          
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
      Case WhereFilters.chqno
        CommandObject.Parameters.Add(DataProvider.CreateParameter("chqno", DbType.String, Entity.chqno))
      Case WhereFilters.Likechqno
        CommandObject.Parameters.Add(DataProvider.CreateParameter("chqno", DbType.String, Entity.chqno))
      Case WhereFilters.PrimaryKey
        CommandObject.Parameters.Add(DataProvider.CreateParameter("payid", DbType.Int32, Entity.payid))
      
      

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

      Case OrderByFilters.chqno
          sb.Append(" ORDER BY chqno")


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
  ''' <param name="payid">The value of the primary key to set</param>
  Public Overrides Sub PrimaryKeySet(ByVal payid As Integer)
    ' Fill in Entity Values
    Entity.payid = payid
    ' Fill in Columns Collection
    ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.payid).Value = payid
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@payid", DbType.Int32, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.payid).Value))
          
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
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@paydate", DbType.Date, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@supcode", DbType.Int32, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@paytypeid", DbType.Int32, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@amntpaid", DbType.Decimal, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@amntwords", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@discount", DbType.Decimal, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.discount).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@chqno", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@bankid", DbType.Int32, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@chqdate", DbType.Date, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@remarks", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtInsertdt", DbType.Date, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sLastUpdateid", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtLastUpdatedt", DbType.Date, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@iConcurrencyid", DbType.Int16, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).Value))

        End Select

      Case PDSADataModificationState.Update
        Select Case UpdateFilter
          Case UpdateFilters.PrimaryKey
            CommandObject.Parameters.Clear()
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@paydate", DbType.Date, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paydate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@supcode", DbType.Int32, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.supcode).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@paytypeid", DbType.Int32, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.paytypeid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@amntpaid", DbType.Decimal, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntpaid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@amntwords", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.amntwords).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@discount", DbType.Decimal, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.discount).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@chqno", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqno).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@bankid", DbType.Int32, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.bankid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@chqdate", DbType.Date, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.chqdate).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@remarks", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.remarks).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sInsertid", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sInsertid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtInsertdt", DbType.Date, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtInsertdt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@sLastUpdateid", DbType.String, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.sLastUpdateid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@dtLastUpdatedt", DbType.Date, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.dtLastUpdatedt).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@iConcurrencyid", DbType.Int16, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.iConcurrencyid).Value))
            CommandObject.Parameters.Add(DataProvider.CreateParameter("@payid", DbType.Int32, ValidatorObject.Properties.GetByName(paymnthdrValidator.ColumnNames.payid).Value))

        End Select
    End Select
  End Sub
#End Region
End Class