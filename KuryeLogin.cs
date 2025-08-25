using KuryeSistem.Codes;
using KuryeSistem.Codes.Utils;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KuryeSistem
{
    public partial class KuryeLogin : Form
    {
        public KuryeLogin()
        {
            InitializeComponent();
        }
        Arayuz Arayuz;
        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usertxt.Text.Length == 0)
            {

                MessageBox.Show("L�tfen kullan�c� ad�n� giriniz..");
                usertxt.Focus();
                return;
            }
            if (psswordtxt.Text.Length == 0)
            {
                MessageBox.Show("L�tfen �ifrenizi giriniz..");
                usertxt.Focus();
                return;
            }

            DataTable password = Sp.SQLCalistir("SELECT YoneticiSifre from dbo.Yonetici WHERE YoneticiKullanici='" + usertxt.Text + "' and YoneticiSifre = '" + psswordtxt.Text + "'").Tables[0];
            if (password.Rows.Count == 0)
            {
                MessageBox.Show("�ifre Ba�ar�s�z");
                return;

            }
            if (password.Rows[0][0].ToString() == psswordtxt.Text)
            {
                this.Hide();
                Arayuz = new Arayuz();
                Arayuz.Show();

                Utils.LogEkle("Y�netici Giri� Yapt�", usertxt.Text);
            }
            else MessageBox.Show("�ifre Ba�ar�s�z");
            return;

        }
    }


}
