
namespace HDV
{
    partial class BestiaireForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestiaireForm));
            this.tbMonsterSearch = new System.Windows.Forms.TextBox();
            this.webBrowserMonsters = new System.Windows.Forms.WebBrowser();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMonsterName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxArea = new System.Windows.Forms.ListBox();
            this.listBoxDrop = new System.Windows.Forms.ListBox();
            this.pbHp = new System.Windows.Forms.PictureBox();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.tbPA = new System.Windows.Forms.TextBox();
            this.pbPa = new System.Windows.Forms.PictureBox();
            this.tbPM = new System.Windows.Forms.TextBox();
            this.pbPM = new System.Windows.Forms.PictureBox();
            this.tbResNeutre = new System.Windows.Forms.TextBox();
            this.pbResNeutre = new System.Windows.Forms.PictureBox();
            this.tbResTerre = new System.Windows.Forms.TextBox();
            this.pbResTerre = new System.Windows.Forms.PictureBox();
            this.tbResFeu = new System.Windows.Forms.TextBox();
            this.pbResFeu = new System.Windows.Forms.PictureBox();
            this.tbResEau = new System.Windows.Forms.TextBox();
            this.pbResEau = new System.Windows.Forms.PictureBox();
            this.tbResAir = new System.Windows.Forms.TextBox();
            this.pbResAir = new System.Windows.Forms.PictureBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResNeutre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResTerre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResFeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResEau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResAir)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMonsterSearch
            // 
            this.tbMonsterSearch.Location = new System.Drawing.Point(98, 20);
            this.tbMonsterSearch.Name = "tbMonsterSearch";
            this.tbMonsterSearch.Size = new System.Drawing.Size(181, 20);
            this.tbMonsterSearch.TabIndex = 14;
            this.tbMonsterSearch.TextChanged += new System.EventHandler(this.tbMonsterSearch_TextChanged);
            // 
            // webBrowserMonsters
            // 
            this.webBrowserMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMonsters.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMonsters.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMonsters.Name = "webBrowserMonsters";
            this.webBrowserMonsters.ScrollBarsEnabled = false;
            this.webBrowserMonsters.Size = new System.Drawing.Size(302, 216);
            this.webBrowserMonsters.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tbResAir);
            this.panel6.Controls.Add(this.pbResAir);
            this.panel6.Controls.Add(this.tbResEau);
            this.panel6.Controls.Add(this.tbResFeu);
            this.panel6.Controls.Add(this.pbResEau);
            this.panel6.Controls.Add(this.pbResFeu);
            this.panel6.Controls.Add(this.tbResTerre);
            this.panel6.Controls.Add(this.tbResNeutre);
            this.panel6.Controls.Add(this.pbResTerre);
            this.panel6.Controls.Add(this.pbResNeutre);
            this.panel6.Controls.Add(this.tbPM);
            this.panel6.Controls.Add(this.pbPM);
            this.panel6.Controls.Add(this.tbPA);
            this.panel6.Controls.Add(this.pbPa);
            this.panel6.Controls.Add(this.tbHp);
            this.panel6.Controls.Add(this.pbHp);
            this.panel6.Controls.Add(this.webBrowserMonsters);
            this.panel6.Location = new System.Drawing.Point(31, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 218);
            this.panel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nom :";
            // 
            // tbMonsterName
            // 
            this.tbMonsterName.Location = new System.Drawing.Point(80, 44);
            this.tbMonsterName.Name = "tbMonsterName";
            this.tbMonsterName.Size = new System.Drawing.Size(199, 20);
            this.tbMonsterName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Recherche :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Type :";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(71, 68);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(208, 20);
            this.tbType.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Zone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Drop";
            // 
            // listBoxArea
            // 
            this.listBoxArea.FormattingEnabled = true;
            this.listBoxArea.Location = new System.Drawing.Point(32, 358);
            this.listBoxArea.Name = "listBoxArea";
            this.listBoxArea.Size = new System.Drawing.Size(142, 147);
            this.listBoxArea.TabIndex = 30;
            // 
            // listBoxDrop
            // 
            this.listBoxDrop.FormattingEnabled = true;
            this.listBoxDrop.Location = new System.Drawing.Point(182, 358);
            this.listBoxDrop.Name = "listBoxDrop";
            this.listBoxDrop.Size = new System.Drawing.Size(152, 147);
            this.listBoxDrop.TabIndex = 31;
            // 
            // pbHp
            // 
            this.pbHp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHp.BackgroundImage")));
            this.pbHp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHp.Location = new System.Drawing.Point(217, 3);
            this.pbHp.Name = "pbHp";
            this.pbHp.Size = new System.Drawing.Size(20, 20);
            this.pbHp.TabIndex = 5;
            this.pbHp.TabStop = false;
            // 
            // tbHp
            // 
            this.tbHp.Location = new System.Drawing.Point(243, 3);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(47, 20);
            this.tbHp.TabIndex = 6;
            // 
            // tbPA
            // 
            this.tbPA.Location = new System.Drawing.Point(243, 29);
            this.tbPA.Name = "tbPA";
            this.tbPA.Size = new System.Drawing.Size(47, 20);
            this.tbPA.TabIndex = 33;
            // 
            // pbPa
            // 
            this.pbPa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPa.BackgroundImage")));
            this.pbPa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPa.Location = new System.Drawing.Point(217, 29);
            this.pbPa.Name = "pbPa";
            this.pbPa.Size = new System.Drawing.Size(20, 20);
            this.pbPa.TabIndex = 32;
            this.pbPa.TabStop = false;
            // 
            // tbPM
            // 
            this.tbPM.Location = new System.Drawing.Point(243, 55);
            this.tbPM.Name = "tbPM";
            this.tbPM.Size = new System.Drawing.Size(47, 20);
            this.tbPM.TabIndex = 35;
            // 
            // pbPM
            // 
            this.pbPM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPM.BackgroundImage")));
            this.pbPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPM.Location = new System.Drawing.Point(217, 55);
            this.pbPM.Name = "pbPM";
            this.pbPM.Size = new System.Drawing.Size(20, 20);
            this.pbPM.TabIndex = 34;
            this.pbPM.TabStop = false;
            // 
            // tbResNeutre
            // 
            this.tbResNeutre.Location = new System.Drawing.Point(243, 81);
            this.tbResNeutre.Name = "tbResNeutre";
            this.tbResNeutre.Size = new System.Drawing.Size(47, 20);
            this.tbResNeutre.TabIndex = 37;
            // 
            // pbResNeutre
            // 
            this.pbResNeutre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbResNeutre.BackgroundImage")));
            this.pbResNeutre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResNeutre.Location = new System.Drawing.Point(217, 81);
            this.pbResNeutre.Name = "pbResNeutre";
            this.pbResNeutre.Size = new System.Drawing.Size(20, 20);
            this.pbResNeutre.TabIndex = 36;
            this.pbResNeutre.TabStop = false;
            // 
            // tbResTerre
            // 
            this.tbResTerre.Location = new System.Drawing.Point(243, 107);
            this.tbResTerre.Name = "tbResTerre";
            this.tbResTerre.Size = new System.Drawing.Size(47, 20);
            this.tbResTerre.TabIndex = 37;
            // 
            // pbResTerre
            // 
            this.pbResTerre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbResTerre.BackgroundImage")));
            this.pbResTerre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResTerre.Location = new System.Drawing.Point(217, 107);
            this.pbResTerre.Name = "pbResTerre";
            this.pbResTerre.Size = new System.Drawing.Size(20, 20);
            this.pbResTerre.TabIndex = 36;
            this.pbResTerre.TabStop = false;
            // 
            // tbResFeu
            // 
            this.tbResFeu.Location = new System.Drawing.Point(243, 133);
            this.tbResFeu.Name = "tbResFeu";
            this.tbResFeu.Size = new System.Drawing.Size(47, 20);
            this.tbResFeu.TabIndex = 39;
            // 
            // pbResFeu
            // 
            this.pbResFeu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbResFeu.BackgroundImage")));
            this.pbResFeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResFeu.Location = new System.Drawing.Point(217, 133);
            this.pbResFeu.Name = "pbResFeu";
            this.pbResFeu.Size = new System.Drawing.Size(20, 20);
            this.pbResFeu.TabIndex = 38;
            this.pbResFeu.TabStop = false;
            // 
            // tbResEau
            // 
            this.tbResEau.Location = new System.Drawing.Point(243, 159);
            this.tbResEau.Name = "tbResEau";
            this.tbResEau.Size = new System.Drawing.Size(47, 20);
            this.tbResEau.TabIndex = 37;
            // 
            // pbResEau
            // 
            this.pbResEau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbResEau.BackgroundImage")));
            this.pbResEau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResEau.Location = new System.Drawing.Point(217, 159);
            this.pbResEau.Name = "pbResEau";
            this.pbResEau.Size = new System.Drawing.Size(20, 20);
            this.pbResEau.TabIndex = 36;
            this.pbResEau.TabStop = false;
            // 
            // tbResAir
            // 
            this.tbResAir.Location = new System.Drawing.Point(243, 185);
            this.tbResAir.Name = "tbResAir";
            this.tbResAir.Size = new System.Drawing.Size(47, 20);
            this.tbResAir.TabIndex = 41;
            // 
            // pbResAir
            // 
            this.pbResAir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbResAir.BackgroundImage")));
            this.pbResAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResAir.Location = new System.Drawing.Point(217, 185);
            this.pbResAir.Name = "pbResAir";
            this.pbResAir.Size = new System.Drawing.Size(20, 20);
            this.pbResAir.TabIndex = 40;
            this.pbResAir.TabStop = false;
            // 
            // BestiaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 586);
            this.Controls.Add(this.listBoxDrop);
            this.Controls.Add(this.listBoxArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMonsterName);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tbMonsterSearch);
            this.Name = "BestiaireForm";
            this.Text = "BestiaireForm";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResNeutre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResTerre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResFeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResEau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResAir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMonsterSearch;
        private System.Windows.Forms.WebBrowser webBrowserMonsters;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMonsterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxArea;
        private System.Windows.Forms.ListBox listBoxDrop;
        private System.Windows.Forms.PictureBox pbHp;
        private System.Windows.Forms.TextBox tbHp;
        private System.Windows.Forms.TextBox tbResAir;
        private System.Windows.Forms.PictureBox pbResAir;
        private System.Windows.Forms.TextBox tbResEau;
        private System.Windows.Forms.TextBox tbResFeu;
        private System.Windows.Forms.PictureBox pbResEau;
        private System.Windows.Forms.PictureBox pbResFeu;
        private System.Windows.Forms.TextBox tbResTerre;
        private System.Windows.Forms.TextBox tbResNeutre;
        private System.Windows.Forms.PictureBox pbResTerre;
        private System.Windows.Forms.PictureBox pbResNeutre;
        private System.Windows.Forms.TextBox tbPM;
        private System.Windows.Forms.PictureBox pbPM;
        private System.Windows.Forms.TextBox tbPA;
        private System.Windows.Forms.PictureBox pbPa;
    }
}