using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikiDotNet;

namespace WikiSearch
{
    public partial class Suchoverlay : Form
    {
        public int maxSearch = 5;
        public string Sprache = "de";
        SuchergebnisOverlay Suchergebnis = new SuchergebnisOverlay();

        public Suchoverlay()
        {
            InitializeComponent();
            lbl_searching.Text = "";
            lbl_cancelled.Text = "";
            lbl_searchnote.Text = "Geben Sie Ihren Suchbegriff in die Suchzeile ein.";
            lbl_resultesfound.Text = "";


        }

        private void btn_search_Click(object sender, EventArgs e)       //onclick suchen
        {
            lbl_cancelled.Text = "";
            lbl_cancelled.BackColor = Color.Transparent;
            lbl_searching.Text = "searching...";
            lbl_searching.BackColor = Color.LightGreen;

            string searchString = txtbx_searchquery.Text;

            if (txtbx_searchquery.Text != "")
            {
                WikiSearchSettings searchSettings = new WikiSearchSettings
                { RequestId = "Request ID", ResultLimit = maxSearch, ResultOffset = 2, Language = Sprache };

                WikiSearchResponse response = WikiSearcher.Search(searchString, searchSettings);

                lbl_resultesfound.Text = ("Es wurden " + searchSettings.ResultLimit + " Ergebnisse für " + searchString + " gefunden.");
                lbl_searching.Text = "";
                foreach (WikiSearchResult result in response.Query.SearchResults)
                {
                    Suchergebnis.ShowDialog();
                    Suchergebnis.lbl_row1.Text = ($"\t{result.Title}");
                    Suchergebnis.lbl_row2.Text = ($"\t({result.WordCount} words, {result.Size} bytes, id {result.PageId})");
                    Suchergebnis.lbl_row3.Text = ($"\t{result.Preview}");
                    Suchergebnis.lbl_row4.Text = ($"\t{result.Url(searchSettings.Language)}");
                    Suchergebnis.lbl_row5.Text = ($"\tLast edited at {result.LastEdited}");

                }
            }
            else
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
            lbl_cancelled.BackColor = Color.Red;  //in Light Rot ändern
            txtbx_searchquery.Text = "";
            lbl_resultesfound.Text = "";


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

        private void toolStripMenuItem7_Click(object sender, EventArgs e)       //onclick Suchergebnisse 100
        {
            maxSearch = 100;
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
}
