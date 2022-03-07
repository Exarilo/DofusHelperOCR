
namespace HDV
{
    partial class DirectionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentPositionY = new System.Windows.Forms.NumericUpDown();
            this.currentPositionX = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.destinationPositionY = new System.Windows.Forms.NumericUpDown();
            this.destinationPositionX = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPositionX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPositionX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentPositionY);
            this.groupBox1.Controls.Add(this.currentPositionX);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current position :";
            // 
            // currentPositionY
            // 
            this.currentPositionY.Location = new System.Drawing.Point(70, 30);
            this.currentPositionY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.currentPositionY.Name = "currentPositionY";
            this.currentPositionY.Size = new System.Drawing.Size(42, 20);
            this.currentPositionY.TabIndex = 1;
            this.currentPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentPositionX
            // 
            this.currentPositionX.Location = new System.Drawing.Point(6, 30);
            this.currentPositionX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.currentPositionX.Name = "currentPositionX";
            this.currentPositionX.Size = new System.Drawing.Size(42, 20);
            this.currentPositionX.TabIndex = 0;
            this.currentPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.destinationPositionY);
            this.groupBox2.Controls.Add(this.destinationPositionX);
            this.groupBox2.Location = new System.Drawing.Point(21, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination position :";
            // 
            // destinationPositionY
            // 
            this.destinationPositionY.Location = new System.Drawing.Point(70, 19);
            this.destinationPositionY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.destinationPositionY.Name = "destinationPositionY";
            this.destinationPositionY.Size = new System.Drawing.Size(42, 20);
            this.destinationPositionY.TabIndex = 2;
            this.destinationPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // destinationPositionX
            // 
            this.destinationPositionX.Location = new System.Drawing.Point(6, 19);
            this.destinationPositionX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.destinationPositionX.Name = "destinationPositionX";
            this.destinationPositionX.Size = new System.Drawing.Size(42, 20);
            this.destinationPositionX.TabIndex = 1;
            this.destinationPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(39, 164);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // DirectionForm
            // 
            this.AcceptButton = this.btStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 203);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectionForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPositionX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinationPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPositionX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown currentPositionY;
        private System.Windows.Forms.NumericUpDown currentPositionX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown destinationPositionY;
        private System.Windows.Forms.NumericUpDown destinationPositionX;
        private System.Windows.Forms.Button btStart;
    }
}