
namespace WikiSearch
{
    partial class Suchoverlay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_searching = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_cancelled = new System.Windows.Forms.Label();
            this.lbl_searchnote = new System.Windows.Forms.Label();
            this.txtbx_searchquery = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_resultesfound = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suchergebniseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.spracheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_clearsuch = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(72, 181);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 29);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "suchen";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_searching
            // 
            this.lbl_searching.AutoSize = true;
            this.lbl_searching.Location = new System.Drawing.Point(208, 185);
            this.lbl_searching.Name = "lbl_searching";
            this.lbl_searching.Size = new System.Drawing.Size(111, 20);
            this.lbl_searching.TabIndex = 1;
            this.lbl_searching.Text = "label_searching";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(72, 289);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 29);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Zurücksetzen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_cancelled
            // 
            this.lbl_cancelled.AutoSize = true;
            this.lbl_cancelled.Location = new System.Drawing.Point(208, 293);
            this.lbl_cancelled.Name = "lbl_cancelled";
            this.lbl_cancelled.Size = new System.Drawing.Size(111, 20);
            this.lbl_cancelled.TabIndex = 3;
            this.lbl_cancelled.Text = "label_cancelled";
            // 
            // lbl_searchnote
            // 
            this.lbl_searchnote.AutoSize = true;
            this.lbl_searchnote.Location = new System.Drawing.Point(72, 53);
            this.lbl_searchnote.Name = "lbl_searchnote";
            this.lbl_searchnote.Size = new System.Drawing.Size(120, 20);
            this.lbl_searchnote.TabIndex = 4;
            this.lbl_searchnote.Text = "lable_searchnote";
            // 
            // txtbx_searchquery
            // 
            this.txtbx_searchquery.Location = new System.Drawing.Point(72, 76);
            this.txtbx_searchquery.Name = "txtbx_searchquery";
            this.txtbx_searchquery.Size = new System.Drawing.Size(125, 27);
            this.txtbx_searchquery.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(694, 409);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(94, 29);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "beenden";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_resultesfound
            // 
            this.lbl_resultesfound.AutoSize = true;
            this.lbl_resultesfound.Location = new System.Drawing.Point(72, 224);
            this.lbl_resultesfound.Name = "lbl_resultesfound";
            this.lbl_resultesfound.Size = new System.Drawing.Size(50, 20);
            this.lbl_resultesfound.TabIndex = 7;
            this.lbl_resultesfound.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Optionen";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suchergebniseToolStripMenuItem,
            this.spracheToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.toolStripMenuItem1.Text = "Optionen";
            // 
            // suchergebniseToolStripMenuItem
            // 
            this.suchergebniseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.suchergebniseToolStripMenuItem.Name = "suchergebniseToolStripMenuItem";
            this.suchergebniseToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.suchergebniseToolStripMenuItem.Text = "Suchergebnise";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem3.Text = "1";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem4.Text = "2";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem5.Text = "5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem6.Text = "10";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem7.Text = "50";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // spracheToolStripMenuItem
            // 
            this.spracheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem,
            this.englischToolStripMenuItem});
            this.spracheToolStripMenuItem.Name = "spracheToolStripMenuItem";
            this.spracheToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.spracheToolStripMenuItem.Text = "Sprache der Ergebnisse";
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.deutschToolStripMenuItem.Text = "Deutsch";
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click);
            // 
            // englischToolStripMenuItem
            // 
            this.englischToolStripMenuItem.Name = "englischToolStripMenuItem";
            this.englischToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.englischToolStripMenuItem.Text = "Englisch";
            this.englischToolStripMenuItem.Click += new System.EventHandler(this.englischToolStripMenuItem_Click);
            // 
            // lbl_clearsuch
            // 
            this.lbl_clearsuch.AutoSize = true;
            this.lbl_clearsuch.Location = new System.Drawing.Point(208, 327);
            this.lbl_clearsuch.Name = "lbl_clearsuch";
            this.lbl_clearsuch.Size = new System.Drawing.Size(97, 20);
            this.lbl_clearsuch.TabIndex = 9;
            this.lbl_clearsuch.Text = "label_cleared";
            // 
            // Suchoverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_clearsuch);
            this.Controls.Add(this.lbl_resultesfound);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txtbx_searchquery);
            this.Controls.Add(this.lbl_searchnote);
            this.Controls.Add(this.lbl_cancelled);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_searching);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Suchoverlay";
            this.Text = "Suchoverlay";
            this.Load += new System.EventHandler(this.Suchoverlay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_searching;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_cancelled;
        private System.Windows.Forms.Label lbl_searchnote;
        private System.Windows.Forms.TextBox txtbx_searchquery;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_resultesfound;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suchergebniseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem spracheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem;
        private System.Windows.Forms.Label lbl_clearsuch;
    }
}

