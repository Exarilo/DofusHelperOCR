
namespace HDV
{
    partial class FMForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.gridStatistics = new System.Windows.Forms.DataGridView();
            this.tbCategorie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.webBrowserItems = new System.Windows.Forms.WebBrowser();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbNiveau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbItemSearch = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStatistics)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 787);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(387, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 787);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(11, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(11, 765);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 22);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btStart);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.tbItemName);
            this.panel5.Controls.Add(this.gridStatistics);
            this.panel5.Controls.Add(this.tbCategorie);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.tbDescription);
            this.panel5.Controls.Add(this.tbNiveau);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.tbItemSearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(11, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 755);
            this.panel5.TabIndex = 4;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(124, 719);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 14;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recherche :";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(66, 57);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(286, 20);
            this.tbItemName.TabIndex = 11;
            this.tbItemName.MouseEnter += new System.EventHandler(this.tbItemName_MouseEnter);
            this.tbItemName.MouseLeave += new System.EventHandler(this.tbItemName_MouseLeave);
            // 
            // gridStatistics
            // 
            this.gridStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStatistics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStatistics.Location = new System.Drawing.Point(19, 408);
            this.gridStatistics.Name = "gridStatistics";
            this.gridStatistics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridStatistics.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridStatistics.Size = new System.Drawing.Size(334, 305);
            this.gridStatistics.TabIndex = 10;
            // 
            // tbCategorie
            // 
            this.tbCategorie.Location = new System.Drawing.Point(165, 83);
            this.tbCategorie.Name = "tbCategorie";
            this.tbCategorie.Size = new System.Drawing.Size(187, 20);
            this.tbCategorie.TabIndex = 7;
            this.tbCategorie.MouseEnter += new System.EventHandler(this.tbCategorie_MouseEnter);
            this.tbCategorie.MouseLeave += new System.EventHandler(this.tbCategorie_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cathégorie";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.webBrowserItems);
            this.panel6.Location = new System.Drawing.Point(66, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 212);
            this.panel6.TabIndex = 5;
            // 
            // webBrowserItems
            // 
            this.webBrowserItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserItems.Location = new System.Drawing.Point(0, 0);
            this.webBrowserItems.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserItems.Name = "webBrowserItems";
            this.webBrowserItems.ScrollBarsEnabled = false;
            this.webBrowserItems.Size = new System.Drawing.Size(246, 210);
            this.webBrowserItems.TabIndex = 4;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(19, 339);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(334, 63);
            this.tbDescription.TabIndex = 4;
            // 
            // tbNiveau
            // 
            this.tbNiveau.Location = new System.Drawing.Point(66, 83);
            this.tbNiveau.Name = "tbNiveau";
            this.tbNiveau.Size = new System.Drawing.Size(29, 20);
            this.tbNiveau.TabIndex = 2;
            this.tbNiveau.MouseEnter += new System.EventHandler(this.tbNiveau_MouseEnter);
            this.tbNiveau.MouseLeave += new System.EventHandler(this.tbNiveau_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niveau ";
            // 
            // tbItemSearch
            // 
            this.tbItemSearch.Location = new System.Drawing.Point(86, 30);
            this.tbItemSearch.Name = "tbItemSearch";
            this.tbItemSearch.Size = new System.Drawing.Size(266, 20);
            this.tbItemSearch.TabIndex = 0;
            this.tbItemSearch.TextChanged += new System.EventHandler(this.tbItemName_TextChanged);
            // 
            // FMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 787);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FMForm";
            this.Text = "FMForm";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStatistics)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbItemSearch;
        private System.Windows.Forms.TextBox tbNiveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbCategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.WebBrowser webBrowserItems;
        private System.Windows.Forms.DataGridView gridStatistics;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btStart;
    }
}
