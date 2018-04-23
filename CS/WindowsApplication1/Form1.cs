using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

using DevExpress.XtraGrid.Views.Grid.Customization;

using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Scrolling;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        public void InitData() {
            for (int i = 0; i <= 10; i++) {
                dataSet11.DataTable1.Rows.Add(new object[] {  i,DateTime.Today, i });
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
          }

        private void simpleButton1_Click(object sender, EventArgs e) {
            GridControl grid = new GridControl();
            grid.BindingContext = new BindingContext();
            GridView gridview = new GridView();
            grid.MainView = gridview;
            gridview.GridControl = grid;
            //grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            //gridview});

            grid.DataSource = dataSet11.DataTable1;

            grid.ForceInitialize();
            gridview.PopulateColumns();

            grid.ExportToXls("1.xls");
    
        }


    }
}
