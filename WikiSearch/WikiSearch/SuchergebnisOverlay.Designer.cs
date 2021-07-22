
namespace WikiSearch
{
    partial class SuchergebnisOverlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachTitelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabetischAzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabetischZaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachÄnderungsdatumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neusteZuerstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ältesteZuerstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_sortingon = new System.Windows.Forms.Label();
            this.lbl_sortingtype = new System.Windows.Forms.Label();
            this.btn_resetsorting = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.19672F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.80328F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reihe 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-366, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reihe 2";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv.Location = new System.Drawing.Point(35, 94);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1598, 552);
            this.dgv.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Titel";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Wortanzahl";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Größe (Bytes)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Text Vorschau";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 128;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "URL";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 64;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "Letze Änderung";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 142;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(35, 652);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 29);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Zeile löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(35, 708);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(202, 29);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "alle Suchergebnisse löschen";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1645, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortierungToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // sortierungToolStripMenuItem
            // 
            this.sortierungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachTitelToolStripMenuItem,
            this.nachÄnderungsdatumToolStripMenuItem});
            this.sortierungToolStripMenuItem.Name = "sortierungToolStripMenuItem";
            this.sortierungToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.sortierungToolStripMenuItem.Text = "Sortierung";
            // 
            // nachTitelToolStripMenuItem
            // 
            this.nachTitelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alphabetischAzToolStripMenuItem,
            this.alphabetischZaToolStripMenuItem});
            this.nachTitelToolStripMenuItem.Name = "nachTitelToolStripMenuItem";
            this.nachTitelToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.nachTitelToolStripMenuItem.Text = "nach Titel";
            // 
            // alphabetischAzToolStripMenuItem
            // 
            this.alphabetischAzToolStripMenuItem.Name = "alphabetischAzToolStripMenuItem";
            this.alphabetischAzToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.alphabetischAzToolStripMenuItem.Text = "alphabetisch a-z";
            this.alphabetischAzToolStripMenuItem.Click += new System.EventHandler(this.alphabetischAzToolStripMenuItem_Click);
            // 
            // alphabetischZaToolStripMenuItem
            // 
            this.alphabetischZaToolStripMenuItem.Name = "alphabetischZaToolStripMenuItem";
            this.alphabetischZaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.alphabetischZaToolStripMenuItem.Text = "alphabetisch z-a";
            this.alphabetischZaToolStripMenuItem.Click += new System.EventHandler(this.alphabetischZaToolStripMenuItem_Click);
            // 
            // nachÄnderungsdatumToolStripMenuItem
            // 
            this.nachÄnderungsdatumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neusteZuerstToolStripMenuItem,
            this.ältesteZuerstToolStripMenuItem});
            this.nachÄnderungsdatumToolStripMenuItem.Name = "nachÄnderungsdatumToolStripMenuItem";
            this.nachÄnderungsdatumToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.nachÄnderungsdatumToolStripMenuItem.Text = "nach Änderungsdatum";
            // 
            // neusteZuerstToolStripMenuItem
            // 
            this.neusteZuerstToolStripMenuItem.Name = "neusteZuerstToolStripMenuItem";
            this.neusteZuerstToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.neusteZuerstToolStripMenuItem.Text = "neuste zuerst";
            this.neusteZuerstToolStripMenuItem.Click += new System.EventHandler(this.neusteZuerstToolStripMenuItem_Click);
            // 
            // ältesteZuerstToolStripMenuItem
            // 
            this.ältesteZuerstToolStripMenuItem.Name = "ältesteZuerstToolStripMenuItem";
            this.ältesteZuerstToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ältesteZuerstToolStripMenuItem.Text = "älteste zuerst";
            this.ältesteZuerstToolStripMenuItem.Click += new System.EventHandler(this.ältesteZuerstToolStripMenuItem_Click);
            // 
            // lbl_sortingon
            // 
            this.lbl_sortingon.AutoSize = true;
            this.lbl_sortingon.Location = new System.Drawing.Point(400, 32);
            this.lbl_sortingon.Name = "lbl_sortingon";
            this.lbl_sortingon.Size = new System.Drawing.Size(116, 20);
            this.lbl_sortingon.TabIndex = 7;
            this.lbl_sortingon.Text = "Sortierung aktiv:";
            // 
            // lbl_sortingtype
            // 
            this.lbl_sortingtype.AutoSize = true;
            this.lbl_sortingtype.Location = new System.Drawing.Point(522, 32);
            this.lbl_sortingtype.Name = "lbl_sortingtype";
            this.lbl_sortingtype.Size = new System.Drawing.Size(50, 20);
            this.lbl_sortingtype.TabIndex = 8;
            this.lbl_sortingtype.Text = "label4";
            // 
            // btn_resetsorting
            // 
            this.btn_resetsorting.Location = new System.Drawing.Point(400, 55);
            this.btn_resetsorting.Name = "btn_resetsorting";
            this.btn_resetsorting.Size = new System.Drawing.Size(183, 29);
            this.btn_resetsorting.TabIndex = 9;
            this.btn_resetsorting.Text = "Sortierung zurücksetzten";
            this.btn_resetsorting.UseVisualStyleBackColor = true;
            this.btn_resetsorting.Click += new System.EventHandler(this.btn_resetsorting_Click);
            // 
            // SuchergebnisOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 763);
            this.Controls.Add(this.btn_resetsorting);
            this.Controls.Add(this.lbl_sortingtype);
            this.Controls.Add(this.lbl_sortingon);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SuchergebnisOverlay";
            this.Text = "SuchergebnisOverlay";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortierungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachTitelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphabetischAzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphabetischZaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachÄnderungsdatumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neusteZuerstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ältesteZuerstToolStripMenuItem;
        private System.Windows.Forms.Label lbl_sortingon;
        private System.Windows.Forms.Label lbl_sortingtype;
        private System.Windows.Forms.Button btn_resetsorting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}