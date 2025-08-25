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

                MessageBox.Show("Lütfen kullanýcý adýný giriniz..");
                usertxt.Focus();
                return;
            }
            if (psswordtxt.Text.Length == 0)
            {
                MessageBox.Show("Lütfen þifrenizi giriniz..");
                usertxt.Focus();
                return;
            }

            DataTable password = Sp.SQLCalistir("SELECT YoneticiSifre from dbo.Yonetici WHERE YoneticiKullanici='" + usertxt.Text + "' and YoneticiSifre = '" + psswordtxt.Text + "'").Tables[0];
            if (password.Rows.Count == 0)
            {
                MessageBox.Show("Þifre Baþarýsýz");
                return;

            }
            if (password.Rows[0][0].ToString() == psswordtxt.Text)
            {
                this.Hide();
                Arayuz = new Arayuz();
                Arayuz.Show();

                Utils.LogEkle("Yönetici Giriþ Yaptý", usertxt.Text);
            }
            else MessageBox.Show("Þifre Baþarýsýz");
            return;

        }
    }


}
