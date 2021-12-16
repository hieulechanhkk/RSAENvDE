using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpressEncription;
using System.Security.Cryptography;
namespace EnandDe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //RSA Encryption;
            //1. Generate a key
            tb_publickey.Enabled = false;
            tb_Ciphertext.ReadOnly = true;
            tb_privatekey.Enabled = false;
            tb_result.ReadOnly = true;
            export_ciphertext.Enabled = false;
            
            export_result.Enabled = false;
            
        }
        string filepath = string.Empty;
        string publickeyfile = string.Empty;
        string plaintext = string.Empty;
        string ciphertext = string.Empty;
        string cipherfilepath = string.Empty;
        string privatekey = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (tb_plaintext.Text!=string.Empty && tb_publickey.Text != string.Empty)
            {
                var ciphertext = ExpressEncription.RSAEncription.EncryptString(tb_plaintext.Text, tb_publickey.Text);
                // var result = ExpressEncription.RSAEncription.DecryptString(ciphertext, @"D:\Demo\private.key");
                tb_Ciphertext.Text = ciphertext.ToString();
            }
            else
            {
                DialogResult rs = MessageBox.Show("You need to have PUBLIC KEY and PLAINTEXT to ENCRYPT","Notification",MessageBoxButtons.OK);
            }
            if(tb_Ciphertext.Text!=string.Empty)
            {
                export_ciphertext.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filepath = ofd.FileName;
            if (filepath != string.Empty)
            {
                plaintext = System.IO.File.ReadAllText(filepath);
                tb_plaintext.Text = plaintext;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tb_publickey.Text = ofd.FileName;
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ciphertext_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            cipherfilepath = ofd.FileName;
            if(cipherfilepath!=string.Empty)
            {
                tb_Cipher.Text = System.IO.File.ReadAllText(cipherfilepath);
                
            }
        }

        private void btn_Privatekey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tb_privatekey.Text = ofd.FileName;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            if (tb_Cipher.Text != string.Empty && tb_privatekey.Text!=string.Empty) {
                var result = ExpressEncription.RSAEncription.DecryptString(tb_Cipher.Text, tb_privatekey.Text);
                tb_result.Text = result;
                if (tb_result.Text == string.Empty)
                    export_result.Enabled = false;
                        
            }
            else
            {
                DialogResult rs = MessageBox.Show("You need to have PRIVATE KEY and CIPHERTEXT to DECRYPT", "Notification", MessageBoxButtons.OK);
            }
            if(tb_result.Text!=string.Empty)
            {
                export_result.Enabled = true;
            }
        }

        private void export_ciphertext_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.ShowDialog();
            System.IO.File.WriteAllText(sv.FileName,tb_Ciphertext.Text);
        }

        private void export_result_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.ShowDialog();
            System.IO.File.WriteAllText(sv.FileName, tb_result.Text);
        }

        private void btn_generatekey_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Save PUBLIC KEY FILE", "Notification", MessageBoxButtons.OK);
            SaveFileDialog svpublic = new SaveFileDialog();
            svpublic.ShowDialog();
            DialogResult rs2 = MessageBox.Show("Save PRIVATE KEY FILE", "Notification", MessageBoxButtons.OK);
            SaveFileDialog svprivate = new SaveFileDialog();
            svprivate.ShowDialog();
            if(svpublic.FileName!=string.Empty && svprivate.FileName!=string.Empty)
            {
                ExpressEncription.RSAEncription.MakeKey(svpublic.FileName,svprivate.FileName);
            }
            else
            {
                DialogResult rs3 = MessageBox.Show("Create your file to write!!!!", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
