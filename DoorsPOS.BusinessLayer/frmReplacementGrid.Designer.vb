<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReplacementGrid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.VwReplacementBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsvwReplacements = New DoorsPOS.BusinessLayer.dsvwReplacements()
        Me.VwReplacementTableAdapter = New DoorsPOS.BusinessLayer.dsvwReplacementsTableAdapters.vwReplacementTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.VwReplacementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwReplacements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VwReplacementBindingSource
        '
        Me.VwReplacementBindingSource.DataMember = "vwReplacement"
        Me.VwReplacementBindingSource.DataSource = Me.DsvwReplacements
        '
        'DsvwReplacements
        '
        Me.DsvwReplacements.DataSetName = "dsvwReplacements"
        Me.DsvwReplacements.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwReplacementTableAdapter
        '
        Me.VwReplacementTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwReplacementBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(990, 530)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrdate, Me.colitem_desc, Me.colqty, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colrdate
        '
        Me.colrdate.Caption = "Date Received"
        Me.colrdate.FieldName = "rdate"
        Me.colrdate.Name = "colrdate"
        Me.colrdate.Visible = True
        Me.colrdate.VisibleIndex = 0
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 1
        '
        'colqty
        '
        Me.colqty.Caption = "Qty Received"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 2
        '
        'colsInsert_id
        '
        Me.colsInsert_id.Caption = "Encoder"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 3
        '
        'frmReplacementGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 530)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmReplacementGrid"
        Me.Text = "Replacements"
        CType(Me.VwReplacementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwReplacements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsvwReplacements As dsvwReplacements
    Friend WithEvents VwReplacementBindingSource As Windows.Forms.BindingSource
    Friend WithEvents VwReplacementTableAdapter As dsvwReplacementsTableAdapters.vwReplacementTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colrdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
