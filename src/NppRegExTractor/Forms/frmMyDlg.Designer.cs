namespace NppRegExTractorPlugin
{
    partial class frmMyDlg
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
            this.textBoxLogDir = new System.Windows.Forms.TextBox();
            this.cbRecursive = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialogLogDir = new System.Windows.Forms.FolderBrowserDialog();
            this.bntSeachLogDir = new System.Windows.Forms.Button();
            this.textBoxSearchTermsFile = new System.Windows.Forms.TextBox();
            this.openFileDialogSearchFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectSearchFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbOutputFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectOutputFile = new System.Windows.Forms.Button();
            this.saveFileDialogOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBoxLogDir
            // 
            this.textBoxLogDir.Location = new System.Drawing.Point(13, 39);
            this.textBoxLogDir.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogDir.Name = "textBoxLogDir";
            this.textBoxLogDir.Size = new System.Drawing.Size(271, 22);
            this.textBoxLogDir.TabIndex = 0;
            // 
            // cbRecursive
            // 
            this.cbRecursive.AutoSize = true;
            this.cbRecursive.Location = new System.Drawing.Point(13, 68);
            this.cbRecursive.Name = "cbRecursive";
            this.cbRecursive.Size = new System.Drawing.Size(217, 21);
            this.cbRecursive.TabIndex = 1;
            this.cbRecursive.Text = "Search this directory recusive";
            this.cbRecursive.UseVisualStyleBackColor = true;
            // 
            // bntSeachLogDir
            // 
            this.bntSeachLogDir.Location = new System.Drawing.Point(291, 39);
            this.bntSeachLogDir.Name = "bntSeachLogDir";
            this.bntSeachLogDir.Size = new System.Drawing.Size(26, 22);
            this.bntSeachLogDir.TabIndex = 2;
            this.bntSeachLogDir.Text = "...";
            this.bntSeachLogDir.UseVisualStyleBackColor = true;
            this.bntSeachLogDir.Click += new System.EventHandler(this.bntSeachLogDir_Click);
            // 
            // textBoxSearchTermsFile
            // 
            this.textBoxSearchTermsFile.Location = new System.Drawing.Point(13, 205);
            this.textBoxSearchTermsFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchTermsFile.Name = "textBoxSearchTermsFile";
            this.textBoxSearchTermsFile.Size = new System.Drawing.Size(271, 22);
            this.textBoxSearchTermsFile.TabIndex = 3;
            // 
            // openFileDialogSearchFile
            // 
            this.openFileDialogSearchFile.FileName = "openFileDialog1";
            // 
            // btnSelectSearchFile
            // 
            this.btnSelectSearchFile.Location = new System.Drawing.Point(291, 205);
            this.btnSelectSearchFile.Name = "btnSelectSearchFile";
            this.btnSelectSearchFile.Size = new System.Drawing.Size(26, 22);
            this.btnSelectSearchFile.TabIndex = 2;
            this.btnSelectSearchFile.Text = "...";
            this.btnSelectSearchFile.UseVisualStyleBackColor = true;
            this.btnSelectSearchFile.Click += new System.EventHandler(this.btnSelectSearchFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select log file dir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select SearchTermFile";
            // 
            // textBoxFileFilter
            // 
            this.textBoxFileFilter.Location = new System.Drawing.Point(13, 114);
            this.textBoxFileFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileFilter.Name = "textBoxFileFilter";
            this.textBoxFileFilter.Size = new System.Drawing.Size(271, 22);
            this.textBoxFileFilter.TabIndex = 6;
            this.textBoxFileFilter.Text = "*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filter Files";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(13, 234);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbOutputFile
            // 
            this.tbOutputFile.Location = new System.Drawing.Point(13, 159);
            this.tbOutputFile.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutputFile.Name = "tbOutputFile";
            this.tbOutputFile.Size = new System.Drawing.Size(271, 22);
            this.tbOutputFile.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output File";
            // 
            // btnSelectOutputFile
            // 
            this.btnSelectOutputFile.Location = new System.Drawing.Point(291, 159);
            this.btnSelectOutputFile.Name = "btnSelectOutputFile";
            this.btnSelectOutputFile.Size = new System.Drawing.Size(26, 22);
            this.btnSelectOutputFile.TabIndex = 11;
            this.btnSelectOutputFile.Text = "...";
            this.btnSelectOutputFile.UseVisualStyleBackColor = true;
            this.btnSelectOutputFile.Click += new System.EventHandler(this.btnSelectOutputFile_Click);
            // 
            // frmMyDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.btnSelectOutputFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOutputFile);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFileFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchTermsFile);
            this.Controls.Add(this.btnSelectSearchFile);
            this.Controls.Add(this.bntSeachLogDir);
            this.Controls.Add(this.cbRecursive);
            this.Controls.Add(this.textBoxLogDir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMyDlg";
            this.Text = "frmMyDlg";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogDir;
        private System.Windows.Forms.CheckBox cbRecursive;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLogDir;
        private System.Windows.Forms.Button bntSeachLogDir;
        private System.Windows.Forms.TextBox textBoxSearchTermsFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogSearchFile;
        private System.Windows.Forms.Button btnSelectSearchFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbOutputFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectOutputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputFile;
    }
}