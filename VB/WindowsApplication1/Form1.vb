Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Imports DevExpress.XtraGrid.Views.Grid.Customization

Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports System.Reflection
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Scrolling

Namespace WindowsApplication1
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

		End Sub

		Public Sub InitData()
			For i As Integer = 0 To 10
				dataSet11.DataTable1.Rows.Add(New Object() { i,DateTime.Today, i })
			Next i
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitData()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim grid As GridControl = New GridControl()
			grid.BindingContext = New BindingContext()
			Dim gridview As GridView = New GridView()
			grid.MainView = gridview
			gridview.GridControl = grid
			'grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
			'gridview});

			grid.DataSource = dataSet11.DataTable1

			grid.ForceInitialize()
			gridview.PopulateColumns()

			grid.ExportToXls("1.xls")

		End Sub


	End Class
End Namespace
