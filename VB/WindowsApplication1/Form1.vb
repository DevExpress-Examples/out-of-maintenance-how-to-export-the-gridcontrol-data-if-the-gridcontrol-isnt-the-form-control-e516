Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Data
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Function GetData() As DataTable
			Dim dt = New DataTable()
			dt.Columns.Add("Col1", GetType(String))
			dt.Columns.Add("Col2", GetType(DateTime))
			dt.Columns.Add("Col3", GetType(Int32))
			For i As Integer = 0 To 10
				dt.Rows.Add(New Object() { i, DateTime.Today, i })
			Next i
			Return dt
		End Function
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim grid As New GridControl()
			grid.BindingContext = New BindingContext()
			Dim gridview As New GridView()
			grid.MainView = gridview
			gridview.GridControl = grid

			grid.DataSource = GetData()

			grid.ForceInitialize()
			gridview.PopulateColumns()

			grid.ExportToXls("1.xls")
			Process.Start("1.xls")
		End Sub
	End Class
End Namespace
