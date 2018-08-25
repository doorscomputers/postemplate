Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data.Filtering
Public Class frmReplacementGrid
    Private Sub frmReplacementGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsvwReplacements.vwReplacement' table. You can move, or remove it, as needed.
        Me.VwReplacementTableAdapter.Fill(Me.DsvwReplacements.vwReplacement)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.VwReplacementTableAdapter.FillBy(Me.DsvwReplacements.vwReplacement)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class