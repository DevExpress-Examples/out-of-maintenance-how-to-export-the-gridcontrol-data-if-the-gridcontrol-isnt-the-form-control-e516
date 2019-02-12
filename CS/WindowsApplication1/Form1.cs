using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable GetData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Col1", typeof(string));
            dt.Columns.Add("Col2", typeof(DateTime));
            dt.Columns.Add("Col3", typeof(Int32));
            for (int i = 0; i <= 10; i++)
                dt.Rows.Add(new object[] { i, DateTime.Today, i });
            return dt;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GridControl grid = new GridControl();
            grid.BindingContext = new BindingContext();
            GridView gridview = new GridView();
            grid.MainView = gridview;
            gridview.GridControl = grid;

            grid.DataSource = GetData();

            grid.ForceInitialize();
            gridview.PopulateColumns();

            grid.ExportToXls("1.xls");
            Process.Start("1.xls");
        }
    }
}
