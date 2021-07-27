using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikiDotNet;
using System.Threading;

namespace WikiSearch
{
    public partial class Suchoverlay : Form
    {
        public static Suchoverlay instance;
        public int maxSearch = 5;                                           // zusätzliche Variablen Festlegen
        public string Sprache = "de";
        public int verschiebung = 0;
        SuchergebnisOverlay Suchergebnis = new SuchergebnisOverlay();       
        DataTable table = new DataTable();
       

        public Suchoverlay()                                                // Suchoverlay Initialisieren
        {
            InitializeComponent();
            lbl_searching.Text = "";
            lbl_cancelled.Text = "";
            lbl_searchnote.Text = "Geben Sie Ihren Suchbegriff in die Suchzeile ein.";
            lbl_resultesfound.Text = "";
            lbl_clearsuch.Text = "";
            instance = this;

        }
       
       

        public void btn_search_Click(object sender, EventArgs e)       // onclick suchen
        {
            lbl_cancelled.Text = "";
            lbl_cancelled.BackColor = Color.Transparent;
            lbl_searching.Text = "searching...";
            lbl_searching.BackColor = Color.LightGreen;
            lbl_clearsuch.Text = "";

            string searchString = txtbx_searchquery.Text;

            if (txtbx_searchquery.Text != "")                           // prüfen ob Eingabefeld ist leer
            {
                WikiSearchSettings searchSettings = new WikiSearchSettings          
                { RequestId = "Request ID", ResultLimit = maxSearch, ResultOffset = verschiebung, Language = Sprache };

                WikiSearchResponse response = WikiSearcher.Search(searchString, searchSettings);

                lbl_resultesfound.Text = ("Es wurden " + searchSettings.ResultLimit + " Ergebnisse für " + searchString + " gefunden.");
                lbl_searching.Text = "";
                

                foreach (WikiSearchResult result in response.Query.SearchResults)           // Tabelle füllen
                {
                    Suchergebnis.dgv.Rows.Add(result.Title, result.WordCount , result.Size, result.Preview,($"\t{result.Url(searchSettings.Language)}"), result.LastEdited);
                }
                if (Suchergebnis.Visible == false) { Suchergebnis.ShowDialog(); }
                
                
            }
            else                                                                            //  wenn Eingabefeld leer Fehlermedldung ausgeben
            {
                lbl_searching.Text = "";
                lbl_resultesfound.Text = "Es wurde ein Fehler bei der Eingebe gemacht";
            }
            
            



        }

        private void btn_cancel_Click(object sender, EventArgs e)       //onclick Abbruch
        {
            lbl_searching.Text = "";
            lbl_searching.BackColor = Color.Transparent;
            lbl_cancelled.Text = "Suche abgebrochen";
            lbl_cancelled.BackColor = Color.Red;                        
            txtbx_searchquery.Text = "";
            lbl_resultesfound.Text = "";
            lbl_clearsuch.Text = "Ergebnisse gelöscht";
            lbl_clearsuch.BackColor = Color.LightGreen;
            Suchergebnis.dgv.Rows.Clear();



        }

        private void btn_close_Click(object sender, EventArgs e)            //onclick beenden
        {
           if(MessageBox.Show("wollen Sie das Programm wirklich beenden?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)       //onclick Suchergebnisse 1
        {
            maxSearch = 1;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)       //onclick Suchergebnisse 2
        {
            maxSearch = 2;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)       //onclick Suchergebnisse 5
        {
            maxSearch = 5;
        }

        private void Suchoverlay_Load(object sender, EventArgs e)       //onclick Suchergebnisse 10
        {
            maxSearch = 10;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)       //onclick Suchergebnisse 50
        {
            maxSearch = 50;
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)      //onclick Sprache Deutsch
        {
            Sprache = "de";
        }

        private void englischToolStripMenuItem_Click(object sender, EventArgs e)        //onclick Srache Englisch
        {
            Sprache = "en";
        }
    }
    public class suchanfrage
    {
        public uint AnfrageID { get; set; }
        public byte Ergebnisanz { get; set; }
        public ushort Seite { get; set; }
        public string Sprache { get; set; }
    }

    public class suchausgabe
    {
        public string Titel { get; set; }
        public uint Wortanzahl { get; set; }
        public uint Groesse { get; set; }
        public string Vorschau { get; set; }
        public string URL { get; set; }
        public DateTime letzteAenderung { get; set; }
    }
}
