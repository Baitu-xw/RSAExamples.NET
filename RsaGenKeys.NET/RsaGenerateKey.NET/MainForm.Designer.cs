namespace RsaGenerateKey.NET
{
    partial class MainForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblKeySize = new System.Windows.Forms.Label();
            this.txtKeySize = new System.Windows.Forms.TextBox();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkXmlFormat = new System.Windows.Forms.CheckBox();
            this.chkPemFormat = new System.Windows.Forms.CheckBox();
            this.chkDerFormat = new System.Windows.Forms.CheckBox();
            this.chkCerFormat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(392, 176);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 39);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // lblKeySize
            // 
            this.lblKeySize.AutoSize = true;
            this.lblKeySize.Location = new System.Drawing.Point(59, 46);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(70, 20);
            this.lblKeySize.TabIndex = 1;
            this.lblKeySize.Text = "Key Size";
            // 
            // txtKeySize
            // 
            this.txtKeySize.Location = new System.Drawing.Point(151, 43);
            this.txtKeySize.Name = "txtKeySize";
            this.txtKeySize.Size = new System.Drawing.Size(337, 26);
            this.txtKeySize.TabIndex = 2;
            this.txtKeySize.Text = "1024";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(59, 90);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(82, 20);
            this.lblSavePath.TabIndex = 1;
            this.lblSavePath.Text = "Save Path";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(151, 87);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(337, 26);
            this.txtSavePath.TabIndex = 2;
            this.txtSavePath.Text = "c:\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // chkXmlFormat
            // 
            this.chkXmlFormat.AutoSize = true;
            this.chkXmlFormat.Location = new System.Drawing.Point(151, 129);
            this.chkXmlFormat.Name = "chkXmlFormat";
            this.chkXmlFormat.Size = new System.Drawing.Size(68, 24);
            this.chkXmlFormat.TabIndex = 3;
            this.chkXmlFormat.Text = "XML";
            this.chkXmlFormat.UseVisualStyleBackColor = true;
            // 
            // chkPemFormat
            // 
            this.chkPemFormat.AutoSize = true;
            this.chkPemFormat.Location = new System.Drawing.Point(241, 129);
            this.chkPemFormat.Name = "chkPemFormat";
            this.chkPemFormat.Size = new System.Drawing.Size(69, 24);
            this.chkPemFormat.TabIndex = 3;
            this.chkPemFormat.Text = "PEM";
            this.chkPemFormat.UseVisualStyleBackColor = true;
            // 
            // chkDerFormat
            // 
            this.chkDerFormat.AutoSize = true;
            this.chkDerFormat.Location = new System.Drawing.Point(314, 129);
            this.chkDerFormat.Name = "chkDerFormat";
            this.chkDerFormat.Size = new System.Drawing.Size(70, 24);
            this.chkDerFormat.TabIndex = 3;
            this.chkDerFormat.Text = "DER";
            this.chkDerFormat.UseVisualStyleBackColor = true;
            // 
            // chkCerFormat
            // 
            this.chkCerFormat.AutoSize = true;
            this.chkCerFormat.Location = new System.Drawing.Point(405, 129);
            this.chkCerFormat.Name = "chkCerFormat";
            this.chkCerFormat.Size = new System.Drawing.Size(69, 24);
            this.chkCerFormat.TabIndex = 3;
            this.chkCerFormat.Text = "CER";
            this.chkCerFormat.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 221);
            this.Controls.Add(this.chkCerFormat);
            this.Controls.Add(this.chkDerFormat);
            this.Controls.Add(this.chkPemFormat);
            this.Controls.Add(this.chkXmlFormat);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.txtKeySize);
            this.Controls.Add(this.lblKeySize);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Keys Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblKeySize;
        private System.Windows.Forms.TextBox txtKeySize;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkXmlFormat;
        private System.Windows.Forms.CheckBox chkPemFormat;
        private System.Windows.Forms.CheckBox chkDerFormat;
        private System.Windows.Forms.CheckBox chkCerFormat;
    }
}

