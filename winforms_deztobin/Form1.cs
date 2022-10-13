using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace winforms_deztobin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtDezAusgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHexAusgabe2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void CmdDezimal_Click(object sender, EventArgs e)
        {
            txtBinAusgabe.Text = Reverse(DezToBin(txtDezimal.Text));
            txtHexAusgabe1.Text = DezToHex(txtDezimal.Text);
        }

        private void CmdBinaer_Click(object sender, EventArgs e)
        {
            txtDezAusgabe.Text = BinToDez(txtBinaerEingabe.Text);
            txtHexAusgabe2.Text = DezToHex(txtDezAusgabe.Text);
        }

        private void txtDezimal_TextChanged(object sender, EventArgs e)
        {

        }



        //Methode wandelt eine Dezimalzahl in seinen Binärwert um
        string DezToBin(string strDez)
        {
            long x = Convert.ToInt64(strDez);
            strDez = "";
            long y = 0;
            while (x > 0)
            {
                y = x % 2;
                strDez += y.ToString();
                if (x == 1)                 // wenn x = 1, wäre (x - 1) / 2 !Exception umgangen
                {
                    return strDez;
                }
                else
                {
                    x = (x - y) / 2;
                }
                
            }
            return strDez;
        }
        //Methode wandelt eine Dezimalzahl in seinen Hexadezimalwert um
        string DezToHex(string strDez)
        {
            long x = Convert.ToInt64(strDez);
            string hex = x.ToString("X");
            return hex;
        }
        //Methode wandelt eine Binärzahl in seinen Dezimalwert um
        string BinToDez(string strBin)
        {
            strBin = Reverse(strBin);
            char[] c = strBin.ToCharArray();
            strBin = "";
            double x = 2;
            double y = 0;
            for (int i = 0; i < c.Length; i++)
            {
                switch (c[i])
                {
                    case '0':
                        break;
                    case '1':
                        y += Math.Pow(x, i);
                        break;
                }
            }
            strBin = y.ToString();
            return strBin;
        }
        //Methode spiegelt den aufgenommenen String und gibt ihn zurück
        public static string Reverse(string s)
        {
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
    }
}