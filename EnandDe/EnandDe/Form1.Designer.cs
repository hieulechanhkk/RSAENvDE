
namespace EnandDe
{
    partial class Form1
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
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.tb_plaintext = new System.Windows.Forms.TextBox();
            this.tb_Ciphertext = new System.Windows.Forms.TextBox();
            this.btn_PublicKey = new System.Windows.Forms.Button();
            this.btn_fileplaintext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_publickey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Cipher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_privatekey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Ciphertext = new System.Windows.Forms.Button();
            this.btn_Privatekey = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.export_ciphertext = new System.Windows.Forms.Button();
            this.export_result = new System.Windows.Forms.Button();
            this.btn_generatekey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(413, 345);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(122, 22);
            this.btn_Encrypt.TabIndex = 0;
            this.btn_Encrypt.Text = "Encrypt Message";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_plaintext
            // 
            this.tb_plaintext.Location = new System.Drawing.Point(30, 107);
            this.tb_plaintext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_plaintext.Multiline = true;
            this.tb_plaintext.Name = "tb_plaintext";
            this.tb_plaintext.Size = new System.Drawing.Size(376, 168);
            this.tb_plaintext.TabIndex = 1;
            this.tb_plaintext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_Ciphertext
            // 
            this.tb_Ciphertext.Location = new System.Drawing.Point(30, 345);
            this.tb_Ciphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Ciphertext.Multiline = true;
            this.tb_Ciphertext.Name = "tb_Ciphertext";
            this.tb_Ciphertext.Size = new System.Drawing.Size(376, 188);
            this.tb_Ciphertext.TabIndex = 2;
            // 
            // btn_PublicKey
            // 
            this.btn_PublicKey.Location = new System.Drawing.Point(413, 297);
            this.btn_PublicKey.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PublicKey.Name = "btn_PublicKey";
            this.btn_PublicKey.Size = new System.Drawing.Size(78, 20);
            this.btn_PublicKey.TabIndex = 3;
            this.btn_PublicKey.Text = "Public Key";
            this.btn_PublicKey.UseVisualStyleBackColor = true;
            this.btn_PublicKey.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_fileplaintext
            // 
            this.btn_fileplaintext.Location = new System.Drawing.Point(411, 107);
            this.btn_fileplaintext.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fileplaintext.Name = "btn_fileplaintext";
            this.btn_fileplaintext.Size = new System.Drawing.Size(122, 20);
            this.btn_fileplaintext.TabIndex = 4;
            this.btn_fileplaintext.Text = "File Plaintext";
            this.btn_fileplaintext.UseVisualStyleBackColor = true;
            this.btn_fileplaintext.Click += new System.EventHandler(this.btn_Choose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plaintext";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ciphertext";
            // 
            // tb_publickey
            // 
            this.tb_publickey.Location = new System.Drawing.Point(30, 294);
            this.tb_publickey.Name = "tb_publickey";
            this.tb_publickey.Size = new System.Drawing.Size(376, 23);
            this.tb_publickey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Public Key Path";
            // 
            // tb_Cipher
            // 
            this.tb_Cipher.Location = new System.Drawing.Point(577, 107);
            this.tb_Cipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Cipher.Multiline = true;
            this.tb_Cipher.Name = "tb_Cipher";
            this.tb_Cipher.Size = new System.Drawing.Size(376, 168);
            this.tb_Cipher.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ciphertext";
            // 
            // tb_privatekey
            // 
            this.tb_privatekey.Location = new System.Drawing.Point(577, 294);
            this.tb_privatekey.Name = "tb_privatekey";
            this.tb_privatekey.Size = new System.Drawing.Size(376, 23);
            this.tb_privatekey.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Private Key Path";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(577, 345);
            this.tb_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(376, 188);
            this.tb_result.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Result";
            // 
            // btn_Ciphertext
            // 
            this.btn_Ciphertext.Location = new System.Drawing.Point(958, 107);
            this.btn_Ciphertext.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ciphertext.Name = "btn_Ciphertext";
            this.btn_Ciphertext.Size = new System.Drawing.Size(122, 20);
            this.btn_Ciphertext.TabIndex = 15;
            this.btn_Ciphertext.Text = "File Ciphertext";
            this.btn_Ciphertext.UseVisualStyleBackColor = true;
            this.btn_Ciphertext.Click += new System.EventHandler(this.btn_Ciphertext_Click);
            // 
            // btn_Privatekey
            // 
            this.btn_Privatekey.Location = new System.Drawing.Point(958, 297);
            this.btn_Privatekey.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Privatekey.Name = "btn_Privatekey";
            this.btn_Privatekey.Size = new System.Drawing.Size(78, 20);
            this.btn_Privatekey.TabIndex = 16;
            this.btn_Privatekey.Text = "Private Key";
            this.btn_Privatekey.UseVisualStyleBackColor = true;
            this.btn_Privatekey.Click += new System.EventHandler(this.btn_Privatekey_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(958, 345);
            this.btn_Decrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(122, 22);
            this.btn_Decrypt.TabIndex = 17;
            this.btn_Decrypt.Text = "Decrypt Message";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // export_ciphertext
            // 
            this.export_ciphertext.Location = new System.Drawing.Point(411, 381);
            this.export_ciphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.export_ciphertext.Name = "export_ciphertext";
            this.export_ciphertext.Size = new System.Drawing.Size(122, 22);
            this.export_ciphertext.TabIndex = 18;
            this.export_ciphertext.Text = "Export File";
            this.export_ciphertext.UseVisualStyleBackColor = true;
            this.export_ciphertext.Click += new System.EventHandler(this.export_ciphertext_Click);
            // 
            // export_result
            // 
            this.export_result.Location = new System.Drawing.Point(958, 381);
            this.export_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.export_result.Name = "export_result";
            this.export_result.Size = new System.Drawing.Size(122, 22);
            this.export_result.TabIndex = 19;
            this.export_result.Text = "Export File";
            this.export_result.UseVisualStyleBackColor = true;
            this.export_result.Click += new System.EventHandler(this.export_result_Click);
            // 
            // btn_generatekey
            // 
            this.btn_generatekey.Location = new System.Drawing.Point(30, 22);
            this.btn_generatekey.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generatekey.Name = "btn_generatekey";
            this.btn_generatekey.Size = new System.Drawing.Size(129, 24);
            this.btn_generatekey.TabIndex = 20;
            this.btn_generatekey.Text = "Generate Key";
            this.btn_generatekey.UseVisualStyleBackColor = true;
            this.btn_generatekey.Click += new System.EventHandler(this.btn_generatekey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 537);
            this.Controls.Add(this.btn_generatekey);
            this.Controls.Add(this.export_result);
            this.Controls.Add(this.export_ciphertext);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Privatekey);
            this.Controls.Add(this.btn_Ciphertext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_privatekey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Cipher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_publickey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fileplaintext);
            this.Controls.Add(this.btn_PublicKey);
            this.Controls.Add(this.tb_Ciphertext);
            this.Controls.Add(this.tb_plaintext);
            this.Controls.Add(this.btn_Encrypt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox tb_plaintext;
        private System.Windows.Forms.TextBox tb_Ciphertext;
        private System.Windows.Forms.Button btn_PublicKey;
        private System.Windows.Forms.Button btn_fileplaintext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_publickey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Cipher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_privatekey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Ciphertext;
        private System.Windows.Forms.Button btn_Privatekey;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button export_ciphertext;
        private System.Windows.Forms.Button export_result;
        private System.Windows.Forms.Button btn_generatekey;
    }
}

