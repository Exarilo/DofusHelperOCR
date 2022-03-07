
namespace HDV
{
    partial class ScriptForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btMoveCursor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConfigName = new System.Windows.Forms.TextBox();
            this.btSaveConfig = new System.Windows.Forms.Button();
            this.btMouseClick = new System.Windows.Forms.Button();
            this.btWait = new System.Windows.Forms.Button();
            this.btConvertImgInt = new System.Windows.Forms.Button();
            this.btConvertImgString = new System.Windows.Forms.Button();
            this.btCaptureScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(20, 37);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(298, 575);
            this.tbCode.TabIndex = 1;
            // 
            // btMoveCursor
            // 
            this.btMoveCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMoveCursor.Location = new System.Drawing.Point(337, 37);
            this.btMoveCursor.Name = "btMoveCursor";
            this.btMoveCursor.Size = new System.Drawing.Size(171, 23);
            this.btMoveCursor.TabIndex = 2;
            this.btMoveCursor.Text = "Move Cursor";
            this.btMoveCursor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMoveCursor.UseVisualStyleBackColor = true;
            this.btMoveCursor.Click += new System.EventHandler(this.btMoveCursor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Config name :";
            // 
            // tbConfigName
            // 
            this.tbConfigName.Location = new System.Drawing.Point(331, 273);
            this.tbConfigName.Name = "tbConfigName";
            this.tbConfigName.Size = new System.Drawing.Size(177, 20);
            this.tbConfigName.TabIndex = 9;
            // 
            // btSaveConfig
            // 
            this.btSaveConfig.Location = new System.Drawing.Point(331, 299);
            this.btSaveConfig.Name = "btSaveConfig";
            this.btSaveConfig.Size = new System.Drawing.Size(177, 23);
            this.btSaveConfig.TabIndex = 10;
            this.btSaveConfig.Text = "Save";
            this.btSaveConfig.UseVisualStyleBackColor = true;
            this.btSaveConfig.Click += new System.EventHandler(this.btSaveConfig_Click_1);
            // 
            // btMouseClick
            // 
            this.btMouseClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMouseClick.Location = new System.Drawing.Point(337, 70);
            this.btMouseClick.Name = "btMouseClick";
            this.btMouseClick.Size = new System.Drawing.Size(171, 23);
            this.btMouseClick.TabIndex = 11;
            this.btMouseClick.Text = "Mouse Click";
            this.btMouseClick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMouseClick.UseVisualStyleBackColor = true;
            this.btMouseClick.Click += new System.EventHandler(this.btMouseClick_Click);
            // 
            // btWait
            // 
            this.btWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWait.Location = new System.Drawing.Point(337, 186);
            this.btWait.Name = "btWait";
            this.btWait.Size = new System.Drawing.Size(171, 23);
            this.btWait.TabIndex = 12;
            this.btWait.Text = "Wait";
            this.btWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btWait.UseVisualStyleBackColor = true;
            this.btWait.Click += new System.EventHandler(this.btWait_Click);
            // 
            // btConvertImgInt
            // 
            this.btConvertImgInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConvertImgInt.Location = new System.Drawing.Point(337, 157);
            this.btConvertImgInt.Name = "btConvertImgInt";
            this.btConvertImgInt.Size = new System.Drawing.Size(171, 23);
            this.btConvertImgInt.TabIndex = 13;
            this.btConvertImgInt.Text = "Convert ImgInt to String";
            this.btConvertImgInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConvertImgInt.UseVisualStyleBackColor = true;
            this.btConvertImgInt.Click += new System.EventHandler(this.btConvertImgInt_Click);
            // 
            // btConvertImgString
            // 
            this.btConvertImgString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConvertImgString.Location = new System.Drawing.Point(337, 128);
            this.btConvertImgString.Name = "btConvertImgString";
            this.btConvertImgString.Size = new System.Drawing.Size(171, 23);
            this.btConvertImgString.TabIndex = 14;
            this.btConvertImgString.Text = "Convert ImgString to String";
            this.btConvertImgString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConvertImgString.UseVisualStyleBackColor = true;
            this.btConvertImgString.Click += new System.EventHandler(this.btConvertImgString_Click);
            // 
            // btCaptureScreen
            // 
            this.btCaptureScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCaptureScreen.Location = new System.Drawing.Point(337, 99);
            this.btCaptureScreen.Name = "btCaptureScreen";
            this.btCaptureScreen.Size = new System.Drawing.Size(171, 23);
            this.btCaptureScreen.TabIndex = 15;
            this.btCaptureScreen.Text = "Capture Screen";
            this.btCaptureScreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCaptureScreen.UseVisualStyleBackColor = true;
            this.btCaptureScreen.Click += new System.EventHandler(this.btCaptureScreen_Click);
            // 
            // ScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 636);
            this.Controls.Add(this.btCaptureScreen);
            this.Controls.Add(this.btConvertImgString);
            this.Controls.Add(this.btConvertImgInt);
            this.Controls.Add(this.btWait);
            this.Controls.Add(this.btMouseClick);
            this.Controls.Add(this.btSaveConfig);
            this.Controls.Add(this.tbConfigName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMoveCursor);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label1);
            this.Name = "ScriptForm";
            this.Text = "ScriptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btMoveCursor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfigName;
        private System.Windows.Forms.Button btSaveConfig;
        private System.Windows.Forms.Button btMouseClick;
        private System.Windows.Forms.Button btWait;
        private System.Windows.Forms.Button btConvertImgInt;
        private System.Windows.Forms.Button btConvertImgString;
        private System.Windows.Forms.Button btCaptureScreen;
    }
}