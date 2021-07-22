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
        
        
        public SuchergebnisOverlay()        // Suchergebnis Overlay Initialisieren
        {
            InitializeComponent();
            lbl_sortingon.Visible = false;
            lbl_sortingtype.Visible = false;
            btn_resetsorting.Visible = false;

        }

        public DataTable table = new DataTable();       // Tabelle einem Arry zuordnen

        public DataSet dataSet = new DataSet();

        public DataRow dr;

        public void Suchergebnis_Load(object sender, EventArgs e)       // Tabelle laden
        {
            
        }
         public void btn_delete_Click(object sender, EventArgs e)          //onclick Zeile löschen
        {
            dgv.RefreshEdit();
            dgv.Refresh();
            if (dgv.CurrentCell != null && dgv.CurrentCell.Value != null)
            {
                int rowIndex = dgv.CurrentCell.RowIndex;
                dgv.Rows.RemoveAt(rowIndex);
            } 
            
        }

        private void btn_clear_Click(object sender, EventArgs e)        //onclick Tabelle leeren
        {
            dgv.Rows.Clear();
        }

        private void alphabetischAzToolStripMenuItem_Click(object sender, EventArgs e)      //onclick nach Titel a-z sotrieren
        {
            lbl_sortingon.Visible = true;
            lbl_sortingtype.Visible = true;
            lbl_sortingtype.Text = "alphabetisch a-z";
            dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
            btn_resetsorting.Visible = true;
        }

        private void alphabetischZaToolStripMenuItem_Click(object sender, EventArgs e)      //onclick nach Titel z-a sotrieren
        {
            lbl_sortingon.Visible = true;
            lbl_sortingtype.Visible = true;
            lbl_sortingtype.Text = "alphabetisch z-a";
            dgv.Sort(dgv.Columns[0], ListSortDirection.Descending);
            btn_resetsorting.Visible = true;
        }

        private void neusteZuerstToolStripMenuItem_Click(object sender, EventArgs e)        //onclick nach letzer Änderung sotrieren (neuste zuerst)
        {
            lbl_sortingon.Visible = true;
            lbl_sortingtype.Visible = true;
            lbl_sortingtype.Text = "neuste zuerst";
            dgv.Sort(dgv.Columns[5], ListSortDirection.Descending);
            btn_resetsorting.Visible = true;
        }

        private void ältesteZuerstToolStripMenuItem_Click(object sender, EventArgs e)        //onclick nach letzer Änderung sortieren (älteste zuerst)
        {
            lbl_sortingon.Visible = true;
            lbl_sortingtype.Visible = true;
            lbl_sortingtype.Text = "älteste zuerst";
            dgv.Sort(dgv.Columns[5], ListSortDirection.Ascending);
            btn_resetsorting.Visible = true;
        }

        private void btn_resetsorting_Click(object sender, EventArgs e)     //onclick Sortierung zurücksetzten
        {
            lbl_sortingon.Visible = false;
            lbl_sortingtype.Visible = false;
            btn_resetsorting.Visible = false;
            table.DefaultView.Sort = string.Empty;//todo
        }

    }
}
