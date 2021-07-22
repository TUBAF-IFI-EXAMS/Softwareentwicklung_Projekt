
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
            this.lbl_result = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_row1 = new System.Windows.Forms.Label();
            this.lbl_row2 = new System.Windows.Forms.Label();
            this.lbl_row3 = new System.Windows.Forms.Label();
            this.lbl_row4 = new System.Windows.Forms.Label();
            this.lbl_row5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(35, 25);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(136, 20);
            this.lbl_result.TabIndex = 0;
            this.lbl_result.Text = "label_Suchergebnis";
            this.lbl_result.Click += new System.EventHandler(this.lbl_searchresult_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.19672F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.80328F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_row1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_row2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_row3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_row4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_row5, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1577, 154);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_row1
            // 
            this.lbl_row1.AutoSize = true;
            this.lbl_row1.Location = new System.Drawing.Point(3, 0);
            this.lbl_row1.Name = "lbl_row1";
            this.lbl_row1.Size = new System.Drawing.Size(58, 20);
            this.lbl_row1.TabIndex = 0;
            this.lbl_row1.Text = "Reihe 1";
            // 
            // lbl_row2
            // 
            this.lbl_row2.AutoSize = true;
            this.lbl_row2.Location = new System.Drawing.Point(297, 0);
            this.lbl_row2.Name = "lbl_row2";
            this.lbl_row2.Size = new System.Drawing.Size(58, 20);
            this.lbl_row2.TabIndex = 2;
            this.lbl_row2.Text = "Reihe 2";
            // 
            // lbl_row3
            // 
            this.lbl_row3.AutoSize = true;
            this.lbl_row3.Location = new System.Drawing.Point(613, 0);
            this.lbl_row3.Name = "lbl_row3";
            this.lbl_row3.Size = new System.Drawing.Size(58, 20);
            this.lbl_row3.TabIndex = 3;
            this.lbl_row3.Text = "Reihe 3";
            // 
            // lbl_row4
            // 
            this.lbl_row4.AutoSize = true;
            this.lbl_row4.Location = new System.Drawing.Point(966, 0);
            this.lbl_row4.Name = "lbl_row4";
            this.lbl_row4.Size = new System.Drawing.Size(58, 20);
            this.lbl_row4.TabIndex = 4;
            this.lbl_row4.Text = "Reihe 4";
            // 
            // lbl_row5
            // 
            this.lbl_row5.AutoSize = true;
            this.lbl_row5.Location = new System.Drawing.Point(1262, 0);
            this.lbl_row5.Name = "lbl_row5";
            this.lbl_row5.Size = new System.Drawing.Size(58, 20);
            this.lbl_row5.TabIndex = 5;
            this.lbl_row5.Text = "Reihe 5";
            // 
            // SuchergebnisOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_result);
            this.Name = "SuchergebnisOverlay";
            this.Text = "SuchergebnisOverlay";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_result;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lbl_row1;
        public System.Windows.Forms.Label lbl_row2;
        public System.Windows.Forms.Label lbl_row3;
        public System.Windows.Forms.Label lbl_row4;
        public System.Windows.Forms.Label lbl_row5;
    }
}