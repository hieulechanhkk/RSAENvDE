
namespace EnandDe
{
    partial class ManualMode
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.tb_q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_e = new System.Windows.Forms.TextBox();
            this.btn_autoE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_plaintextPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_choosePlaintext = new System.Windows.Forms.Button();
            this.tb_encrypted = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.tb_plaintext = new System.Windows.Forms.TextBox();
            this.tv_phiN = new System.Windows.Forms.Label();
            this.Ciphertext = new System.Windows.Forms.TextBox();
            this.Descrypted = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.choose_ciphertext = new System.Windows.Forms.Button();
            this.ciphertextPath = new System.Windows.Forms.TextBox();
            this.choose_privatekey = new System.Windows.Forms.Button();
            this.privateKeyPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_N = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_EE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Automatic Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_p
            // 
            this.tb_p.Location = new System.Drawing.Point(66, 63);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(228, 23);
            this.tb_p.TabIndex = 1;
            // 
            // tb_q
            // 
            this.tb_q.Location = new System.Drawing.Point(300, 63);
            this.tb_q.Name = "tb_q";
            this.tb_q.Size = new System.Drawing.Size(241, 23);
            this.tb_q.TabIndex = 2;
            this.tb_q.TextChanged += new System.EventHandler(this.tb_q_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type P";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type Q";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_e
            // 
            this.tb_e.Location = new System.Drawing.Point(66, 104);
            this.tb_e.Name = "tb_e";
            this.tb_e.Size = new System.Drawing.Size(228, 23);
            this.tb_e.TabIndex = 5;
            // 
            // btn_autoE
            // 
            this.btn_autoE.Location = new System.Drawing.Point(300, 105);
            this.btn_autoE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_autoE.Name = "btn_autoE";
            this.btn_autoE.Size = new System.Drawing.Size(62, 22);
            this.btn_autoE.TabIndex = 6;
            this.btn_autoE.Text = "Random";
            this.btn_autoE.UseVisualStyleBackColor = true;
            this.btn_autoE.Click += new System.EventHandler(this.btn_autoE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type E";
            // 
            // tb_plaintextPath
            // 
            this.tb_plaintextPath.Location = new System.Drawing.Point(66, 132);
            this.tb_plaintextPath.Name = "tb_plaintextPath";
            this.tb_plaintextPath.Size = new System.Drawing.Size(228, 23);
            this.tb_plaintextPath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type Plaintext Path";
            // 
            // btn_choosePlaintext
            // 
            this.btn_choosePlaintext.Location = new System.Drawing.Point(300, 133);
            this.btn_choosePlaintext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_choosePlaintext.Name = "btn_choosePlaintext";
            this.btn_choosePlaintext.Size = new System.Drawing.Size(62, 22);
            this.btn_choosePlaintext.TabIndex = 10;
            this.btn_choosePlaintext.Text = "Choose";
            this.btn_choosePlaintext.UseVisualStyleBackColor = true;
            this.btn_choosePlaintext.Click += new System.EventHandler(this.btn_choosePlaintext_Click);
            // 
            // tb_encrypted
            // 
            this.tb_encrypted.Location = new System.Drawing.Point(66, 354);
            this.tb_encrypted.Multiline = true;
            this.tb_encrypted.Name = "tb_encrypted";
            this.tb_encrypted.Size = new System.Drawing.Size(311, 156);
            this.tb_encrypted.TabIndex = 11;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(383, 354);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(62, 22);
            this.btn_Encrypt.TabIndex = 12;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // tb_plaintext
            // 
            this.tb_plaintext.Location = new System.Drawing.Point(66, 181);
            this.tb_plaintext.Multiline = true;
            this.tb_plaintext.Name = "tb_plaintext";
            this.tb_plaintext.Size = new System.Drawing.Size(311, 139);
            this.tb_plaintext.TabIndex = 13;
            this.tb_plaintext.TextChanged += new System.EventHandler(this.tb_plaintext_TextChanged);
            // 
            // tv_phiN
            // 
            this.tv_phiN.AutoSize = true;
            this.tv_phiN.Location = new System.Drawing.Point(213, 86);
            this.tv_phiN.Name = "tv_phiN";
            this.tv_phiN.Size = new System.Drawing.Size(81, 15);
            this.tv_phiN.TabIndex = 14;
            this.tv_phiN.Text = "1 < E < Phi(N)";
            this.tv_phiN.Click += new System.EventHandler(this.label5_Click);
            // 
            // Ciphertext
            // 
            this.Ciphertext.Location = new System.Drawing.Point(667, 181);
            this.Ciphertext.Multiline = true;
            this.Ciphertext.Name = "Ciphertext";
            this.Ciphertext.Size = new System.Drawing.Size(311, 139);
            this.Ciphertext.TabIndex = 15;
            // 
            // Descrypted
            // 
            this.Descrypted.Location = new System.Drawing.Point(667, 354);
            this.Descrypted.Multiline = true;
            this.Descrypted.Name = "Descrypted";
            this.Descrypted.Size = new System.Drawing.Size(311, 156);
            this.Descrypted.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(984, 354);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 22);
            this.button2.TabIndex = 17;
            this.button2.Text = "Decypt";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 380);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 22);
            this.button3.TabIndex = 18;
            this.button3.Text = "Export File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // choose_ciphertext
            // 
            this.choose_ciphertext.Location = new System.Drawing.Point(898, 41);
            this.choose_ciphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choose_ciphertext.Name = "choose_ciphertext";
            this.choose_ciphertext.Size = new System.Drawing.Size(62, 22);
            this.choose_ciphertext.TabIndex = 20;
            this.choose_ciphertext.Text = "Choose";
            this.choose_ciphertext.UseVisualStyleBackColor = true;
            this.choose_ciphertext.Click += new System.EventHandler(this.button4_Click);
            // 
            // ciphertextPath
            // 
            this.ciphertextPath.Location = new System.Drawing.Point(667, 40);
            this.ciphertextPath.Name = "ciphertextPath";
            this.ciphertextPath.Size = new System.Drawing.Size(225, 23);
            this.ciphertextPath.TabIndex = 19;
            // 
            // choose_privatekey
            // 
            this.choose_privatekey.Location = new System.Drawing.Point(898, 69);
            this.choose_privatekey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choose_privatekey.Name = "choose_privatekey";
            this.choose_privatekey.Size = new System.Drawing.Size(62, 22);
            this.choose_privatekey.TabIndex = 22;
            this.choose_privatekey.Text = "Choose";
            this.choose_privatekey.UseVisualStyleBackColor = true;
            this.choose_privatekey.Click += new System.EventHandler(this.choose_privatekey_Click);
            // 
            // privateKeyPath
            // 
            this.privateKeyPath.Location = new System.Drawing.Point(667, 68);
            this.privateKeyPath.Name = "privateKeyPath";
            this.privateKeyPath.Size = new System.Drawing.Size(225, 23);
            this.privateKeyPath.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ciphertext Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Private Key";
            // 
            // tb_N
            // 
            this.tb_N.Location = new System.Drawing.Point(667, 104);
            this.tb_N.Name = "tb_N";
            this.tb_N.Size = new System.Drawing.Size(228, 23);
            this.tb_N.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "N";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "D";
            // 
            // tb_EE
            // 
            this.tb_EE.Location = new System.Drawing.Point(667, 133);
            this.tb_EE.Name = "tb_EE";
            this.tb_EE.Size = new System.Drawing.Size(228, 23);
            this.tb_EE.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ciphertext";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Plaintext";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 406);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 22);
            this.button4.TabIndex = 31;
            this.button4.Text = "Export Key";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // ManualMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 560);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_EE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_N);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.choose_privatekey);
            this.Controls.Add(this.privateKeyPath);
            this.Controls.Add(this.choose_ciphertext);
            this.Controls.Add(this.ciphertextPath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Descrypted);
            this.Controls.Add(this.Ciphertext);
            this.Controls.Add(this.tv_phiN);
            this.Controls.Add(this.tb_plaintext);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.tb_encrypted);
            this.Controls.Add(this.btn_choosePlaintext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_plaintextPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_autoE);
            this.Controls.Add(this.tb_e);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_q);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManualMode";
            this.Text = "ManualMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.TextBox tb_q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_e;
        private System.Windows.Forms.Button btn_autoE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_plaintextPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_choosePlaintext;
        private System.Windows.Forms.TextBox tb_encrypted;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox tb_plaintext;
        private System.Windows.Forms.Label tv_phiN;
        private System.Windows.Forms.TextBox Ciphertext;
        private System.Windows.Forms.TextBox Descrypted;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button choose_ciphertext;
        private System.Windows.Forms.TextBox ciphertextPath;
        private System.Windows.Forms.Button choose_privatekey;
        private System.Windows.Forms.TextBox privateKeyPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_N;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_EE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
    }
}