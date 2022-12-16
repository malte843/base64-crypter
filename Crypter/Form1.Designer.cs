namespace Crypter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEncryptOut = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptOut = new System.Windows.Forms.TextBox();
            this.txtEncryptIn = new System.Windows.Forms.TextBox();
            this.txtDecryptIn = new System.Windows.Forms.TextBox();
            this.btnCopyE = new System.Windows.Forms.Button();
            this.btnCopyD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEncryptOut
            // 
            this.txtEncryptOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptOut.Location = new System.Drawing.Point(12, 141);
            this.txtEncryptOut.Multiline = true;
            this.txtEncryptOut.Name = "txtEncryptOut";
            this.txtEncryptOut.ReadOnly = true;
            this.txtEncryptOut.Size = new System.Drawing.Size(322, 110);
            this.txtEncryptOut.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(340, 225);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(83, 26);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encrypt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Decrypt";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(340, 492);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(83, 26);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecryptOut
            // 
            this.txtDecryptOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptOut.Location = new System.Drawing.Point(12, 408);
            this.txtDecryptOut.Multiline = true;
            this.txtDecryptOut.Name = "txtDecryptOut";
            this.txtDecryptOut.ReadOnly = true;
            this.txtDecryptOut.Size = new System.Drawing.Size(322, 110);
            this.txtDecryptOut.TabIndex = 9;
            // 
            // txtEncryptIn
            // 
            this.txtEncryptIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptIn.Location = new System.Drawing.Point(12, 25);
            this.txtEncryptIn.Multiline = true;
            this.txtEncryptIn.Name = "txtEncryptIn";
            this.txtEncryptIn.Size = new System.Drawing.Size(322, 110);
            this.txtEncryptIn.TabIndex = 10;
            // 
            // txtDecryptIn
            // 
            this.txtDecryptIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptIn.Location = new System.Drawing.Point(12, 292);
            this.txtDecryptIn.Multiline = true;
            this.txtDecryptIn.Name = "txtDecryptIn";
            this.txtDecryptIn.Size = new System.Drawing.Size(322, 110);
            this.txtDecryptIn.TabIndex = 11;
            // 
            // btnCopyE
            // 
            this.btnCopyE.Location = new System.Drawing.Point(340, 193);
            this.btnCopyE.Name = "btnCopyE";
            this.btnCopyE.Size = new System.Drawing.Size(83, 26);
            this.btnCopyE.TabIndex = 12;
            this.btnCopyE.Text = "Copy";
            this.btnCopyE.UseVisualStyleBackColor = true;
            this.btnCopyE.Click += new System.EventHandler(this.btnCopyE_Click);
            // 
            // btnCopyD
            // 
            this.btnCopyD.Location = new System.Drawing.Point(340, 460);
            this.btnCopyD.Name = "btnCopyD";
            this.btnCopyD.Size = new System.Drawing.Size(83, 26);
            this.btnCopyD.TabIndex = 13;
            this.btnCopyD.Text = "Copy";
            this.btnCopyD.UseVisualStyleBackColor = true;
            this.btnCopyD.Click += new System.EventHandler(this.btnCopyD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 532);
            this.Controls.Add(this.btnCopyD);
            this.Controls.Add(this.btnCopyE);
            this.Controls.Add(this.txtDecryptIn);
            this.Controls.Add(this.txtEncryptIn);
            this.Controls.Add(this.txtDecryptOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncryptOut);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Crypter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEncryptOut;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecryptOut;
        private System.Windows.Forms.TextBox txtEncryptIn;
        private System.Windows.Forms.TextBox txtDecryptIn;
        private System.Windows.Forms.Button btnCopyE;
        private System.Windows.Forms.Button btnCopyD;
    }
}

