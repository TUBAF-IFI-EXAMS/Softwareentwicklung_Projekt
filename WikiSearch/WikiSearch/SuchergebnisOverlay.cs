using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WikiSearch
{
    public partial class SuchergebnisOverlay : Form
    {
        
        
        public SuchergebnisOverlay()
        {
            InitializeComponent();

        }

        public DataTable table = new DataTable();

        public DataSet dataSet = new DataSet();

        public DataRow dr;

        public void Suchergebnis_Load(object sender, EventArgs e)
        {
            
        }
         private void btn_delete_Click(object sender, EventArgs e)          //onclick Zeile löschen
        {
            int rowIndex = dgv.CurrentCell.RowIndex;
            dgv.Rows.RemoveAt(rowIndex);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }
    }
}
