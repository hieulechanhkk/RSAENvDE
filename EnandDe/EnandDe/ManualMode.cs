using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace EnandDe
{
    public partial class ManualMode : Form
    {
        string p;
        string q;
        string E;
        string M = "";
        String[] listStringASCII;
        string phiNstring="";
        string en = "";
        string privatekey = "";
        string d = "";
        string nDe = "";
        string nTemp = "";
        public ManualMode()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        static BigInteger Pow(BigInteger a, BigInteger b)
        {
            BigInteger total = 1;
            while (b > int.MaxValue)
            {
                b -= int.MaxValue;
                total = total * BigInteger.Pow(a, int.MaxValue);
            }
            total = total * BigInteger.Pow(a, (int)b);
            return total;
        }
        public static bool IsPrime(BigInteger number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (BigInteger)Math.Floor(Math.Sqrt((double)number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        public bool IsInteger(double d)
        {
            if (d == (int)d) return true;
            else return false;
        }
        public static BigInteger modinv(BigInteger inE, BigInteger phin)
        {
            BigInteger D = BigInteger.Pow(inE, 1);
            Double db = 1 / (double)D;
            db = db % (Double)phin;
            D = (BigInteger)db;
            return D;
        }
        
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            tb_encrypted.Clear();
            p = tb_p.Text;
            q = tb_q.Text;
            if (IsPrime(BigInteger.Parse(p)) == false || IsPrime(BigInteger.Parse(q)) == false)
            {
                DialogResult rs = MessageBox.Show("P và Q phải là số nguyên tố lớn khác nhau!", "Notification", MessageBoxButtons.OK);
                return;
            }
            E = tb_e.Text;
            String n;
            BigInteger input_P = BigInteger.Parse(p);
            BigInteger input_Q = BigInteger.Parse(q);
            BigInteger input_E = BigInteger.Parse(E);
            BigInteger phiN = ((input_P - 1) * (input_Q - 1));
            tv_phiN.Text = "1 < E < " + phiN.ToString();
            if(input_E <= 1 || input_E >= phiN)
            {
                DialogResult rs = MessageBox.Show("E phải nằm trong khoảng 1 < E < "+phiN.ToString()+" !", "Notification", MessageBoxButtons.OK);
                return;
            }
            BigInteger N = input_P * input_Q;
            Boolean flag = true;
            foreach (char c in M)
            {
                BigInteger unicode = c;
                BigInteger C = Pow(unicode, input_E);
                BigInteger Encrypted = C % N;
                if (flag)
                {
                    tb_encrypted.Text += Encrypted.ToString();
                    flag = false;
                }
                else
                    tb_encrypted.Text += "," + Encrypted.ToString();
            }
            d = modinv(input_E,phiN).ToString();
            en = tb_encrypted.Text;
            nTemp = N.ToString();
        }

        private void btn_choosePlaintext_Click(object sender, EventArgs e)
        {
            M = "";
            string filepath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filepath = ofd.FileName;
            if (filepath != string.Empty)
            {
                tb_plaintextPath.Text = filepath;
                M = System.IO.File.ReadAllText(filepath);
                tb_plaintext.Text = M;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tb_q_TextChanged(object sender, EventArgs e)
        {
            try {
                p = tb_p.Text;
                q = tb_q.Text;
                BigInteger input_P = BigInteger.Parse(p);
                BigInteger input_Q = BigInteger.Parse(q);
                BigInteger phiN = ((input_P - 1) * (input_Q - 1));
                tv_phiN.Text = "1 < E < " + phiN.ToString();
            }catch(Exception ex)
            { tv_phiN.Text = "1 < E < Phi(N)"; }
        }
        public BigInteger RandomBigInteger(BigInteger min, BigInteger max)
        {
            Random rnd = new Random();
            string numeratorString, denominatorString;
            double fraction = rnd.NextDouble();
            BigInteger inRange;
            numeratorString = fraction.ToString("G17").Remove(0, 2);
            denominatorString = string.Format("1E{0}", numeratorString.Length);

            inRange = (max - min) * BigInteger.Parse(numeratorString) /
               BigInteger.Parse(denominatorString,
               System.Globalization.NumberStyles.AllowExponent)
               + min;
            return inRange;
        }
        BigInteger __gcd(BigInteger a, BigInteger b)
        {
            if (a == 0 || b == 0)
                return 0;
            if (a == b)
                return a;
            if (a > b)
                return __gcd(a - b, b);

            return __gcd(a, b - a);
        }

        BigInteger random_prime(BigInteger n)
        {
            Random rnd = new Random();
            BigInteger number;
            while(true)
            {
                number = RandomBigInteger(2, n);
                if(__gcd(number,n)==1)
                {
                    break;
                }

            }
            return number;
        }
        private void btn_autoE_Click(object sender, EventArgs e)
        {
            p = tb_p.Text;
            q = tb_q.Text;
            BigInteger input_P = BigInteger.Parse(p);
            BigInteger input_Q = BigInteger.Parse(q);
            BigInteger phiN = ((input_P - 1) * (input_Q - 1));
            tb_e.Text = random_prime(phiN).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.ShowDialog();
            System.IO.File.WriteAllText(sv.FileName, en);
        }

        private void tb_plaintext_TextChanged(object sender, EventArgs e)
        {
            M = tb_plaintext.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filepath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filepath = ofd.FileName;
            if (filepath != string.Empty)
            {
                ciphertextPath.Text = filepath;
                Ciphertext.Text = System.IO.File.ReadAllText(filepath);
                
            }
        }

        private void choose_privatekey_Click(object sender, EventArgs e)
        {
            string filepath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filepath = ofd.FileName;
            if (filepath != string.Empty)
            {
                privateKeyPath.Text = filepath;
                privatekey = System.IO.File.ReadAllText(filepath);
                string[] data = privatekey.Split(",");
                d = data[0];
                nDe = data[1];
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Save Public key", "Notification", MessageBoxButtons.OK);
            SaveFileDialog sv = new SaveFileDialog();
            sv.ShowDialog();
            System.IO.File.WriteAllText(sv.FileName, tb_e.Text+","+nTemp);
            DialogResult rss = MessageBox.Show("Save Private key", "Notification", MessageBoxButtons.OK);
            SaveFileDialog svv = new SaveFileDialog();
            svv.ShowDialog();
            System.IO.File.WriteAllText(svv.FileName, d + "," + nTemp);
        }
    }
}
