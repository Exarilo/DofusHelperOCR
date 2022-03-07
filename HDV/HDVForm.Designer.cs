
namespace HDV
{
    partial class HDVForm
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
            this.cbConfig = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btGetRectangleParam = new System.Windows.Forms.Button();
            this.btCursorPosition = new System.Windows.Forms.Button();
            this.btToCSV = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridHDV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbConfig);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 8;
            // 
            // cbConfig
            // 
            this.cbConfig.FormattingEnabled = true;
            this.cbConfig.Items.AddRange(new object[] {
            "HDV Resources",
            "HDV Runes",
            "Test",
            "Programmer"});
            this.cbConfig.Location = new System.Drawing.Point(111, 22);
            this.cbConfig.Name = "cbConfig";
            this.cbConfig.Size = new System.Drawing.Size(229, 21);
            this.cbConfig.TabIndex = 9;
            this.cbConfig.SelectedIndexChanged += new System.EventHandler(this.cbConfig_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Config :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbResult);
            this.panel2.Controls.Add(this.btGetRectangleParam);
            this.panel2.Controls.Add(this.btCursorPosition);
            this.panel2.Controls.Add(this.btToCSV);
            this.panel2.Controls.Add(this.btStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 59);
            this.panel2.TabIndex = 9;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(543, 6);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(190, 29);
            this.tbResult.TabIndex = 11;
            // 
            // btGetRectangleParam
            // 
            this.btGetRectangleParam.Location = new System.Drawing.Point(424, 12);
            this.btGetRectangleParam.Name = "btGetRectangleParam";
            this.btGetRectangleParam.Size = new System.Drawing.Size(113, 23);
            this.btGetRectangleParam.TabIndex = 10;
            this.btGetRectangleParam.Text = "RectangleParam";
            this.btGetRectangleParam.UseVisualStyleBackColor = true;
            this.btGetRectangleParam.Click += new System.EventHandler(this.btGetRectangleParam_Click);
            // 
            // btCursorPosition
            // 
            this.btCursorPosition.Location = new System.Drawing.Point(313, 13);
            this.btCursorPosition.Name = "btCursorPosition";
            this.btCursorPosition.Size = new System.Drawing.Size(105, 23);
            this.btCursorPosition.TabIndex = 9;
            this.btCursorPosition.Text = "CursorPosition";
            this.btCursorPosition.UseVisualStyleBackColor = true;
            this.btCursorPosition.Click += new System.EventHandler(this.btCursorPosition_Click);
            // 
            // btToCSV
            // 
            this.btToCSV.Location = new System.Drawing.Point(198, 13);
            this.btToCSV.Name = "btToCSV";
            this.btToCSV.Size = new System.Drawing.Size(109, 23);
            this.btToCSV.TabIndex = 8;
            this.btToCSV.Text = "Result to Csv";
            this.btToCSV.UseVisualStyleBackColor = true;
            this.btToCSV.Click += new System.EventHandler(this.btToCSV_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(79, 13);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(113, 23);
            this.btStart.TabIndex = 7;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 265);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(733, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(67, 265);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridHDV);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(67, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(666, 265);
            this.panel5.TabIndex = 15;
            // 
            // gridHDV
            // 
            this.gridHDV.AllowUserToOrderColumns = true;
            this.gridHDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHDV.Location = new System.Drawing.Point(0, 0);
            this.gridHDV.Name = "gridHDV";
            this.gridHDV.Size = new System.Drawing.Size(666, 265);
            this.gridHDV.TabIndex = 6;
            // 
            // HDVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HDVForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btGetRectangleParam;
        private System.Windows.Forms.Button btCursorPosition;
        private System.Windows.Forms.Button btToCSV;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gridHDV;
    }
}