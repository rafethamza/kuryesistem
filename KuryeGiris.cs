using KuryeSistem.Codes.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuryeSistem
{
    public partial class KuryeGiris : Form
    {
        Arayuz _arayuz;
        public KuryeGiris(Arayuz arayuz)
        {
            InitializeComponent();
            _arayuz = arayuz;
        }


        private void kuryeAdd()
        {
            try
            {
                if (Const.baglanti.State == ConnectionState.Closed)
                    Const.baglanti.Open();

                SqlCommand sqlkomut = new SqlCommand("INSERT INTO dbo.KuryeBilgi " +
                "(KuryeIsim, KuryeNumara, KuryeAdres, KuryeBaslangicTarihi, KuryeTc, KayitTarihi, Aktifmi) VALUES (@P1, @P2, @P3, @P4, @P5, @P6, @P7)", Const.baglanti);
                sqlkomut.Parameters.AddWithValue("@P1", kuryeisimtxt.Text);
                sqlkomut.Parameters.AddWithValue("@P2", kuryenotxt.Text);
                sqlkomut.Parameters.AddWithValue("@P3", kuryeadrestxt.Text);
                sqlkomut.Parameters.AddWithValue("@P4", dateTimePicker1.Value);
                sqlkomut.Parameters.AddWithValue("@P5", kuryetcnotxt.Text);
                sqlkomut.Parameters.AddWithValue("@P6", DateTime.Now);
                sqlkomut.Parameters.AddWithValue("@P7", "True");


                sqlkomut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kurye Eklenirken Hata Oluştu! s " + ex.Message);
            }
            finally
            {
                Const.baglanti.Close();
            }

            Utils.LogEkle("Kurye Eklendi", kuryeisimtxt.Text + " " + kuryenotxt.Text + " "
                    + kuryetcnotxt.Text + " " + kuryeadrestxt.Text + " " + dateTimePicker1.Value);
        }
        private bool numerickontrol(string data)
        {
            return data.All(char.IsNumber);
        }
        private void kuryeEkleBtn_Click(object sender, EventArgs e)
        {


            if (kuryeisimtxt.Text.Length == 0 || kuryenotxt.Text.Length == 0 || kuryeadrestxt.Text.Length == 0 || kuryetcnotxt.Text.Length == 0)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz");
                return;
            }
            if (kuryetcnotxt.Text.Length != 11 || kuryenotxt.Text.Length != 11)
            {
                MessageBox.Show("Lütfen 11 Haneyi Doldurunuz...");
                return;
            }
            else if (numerickontrol(kuryetcnotxt.Text) || numerickontrol(kuryenotxt.Text))
            {
                kuryeAdd();
            }
            else
            {
                MessageBox.Show("Lütfen Sayı Giriniz...");
                return;

            }

            Utils.VerileriGuncelle();

            dtGridViewLog.DataSource = Utils.kuryeListesi;
        }

        private void KuryeGiris_Load(object sender, EventArgs e)
        {
            if (Utils.kuryeListesi.Rows.Count == 0)
                Utils.VerileriGuncelle();

            dtGridViewLog.DataSource = Utils.kuryeListesi;
        }

        private void dtGridViewLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Emin misin?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string msg = "";
                try
                {
                    Const.baglanti.Open();
                    int selectedId = Convert.ToInt32(dtGridViewLog.Rows[e.RowIndex].Cells["Id"].Value);
                    msg = selectedId.ToString() + " " + dtGridViewLog.Rows[e.RowIndex].Cells["KuryeIsim"].Value + " " + dtGridViewLog.Rows[e.RowIndex].Cells["KuryeNumara"].Value + " " +
                    dtGridViewLog.Rows[e.RowIndex].Cells["KuryeNumara"].Value + " " + dtGridViewLog.Rows[e.RowIndex].Cells["KuryeTc"].Value + " " + dtGridViewLog.Rows[e.RowIndex].Cells["KayitTarihi"].Value;
                    SqlCommand sqlCommand = new SqlCommand("delete dbo.KuryeBilgi where Id='" + selectedId + "' ", Const.baglanti);

                    sqlCommand.ExecuteNonQuery();

                    Utils.LogEkle("Kurye Silindi", msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silinirken Hata Oluştu... " + ex.Message);

                    Utils.LogEkle("Kurye Silinemedi", ex.Message);
                }
                finally
                {
                    Const.baglanti.Close();
                }

            }

            Utils.VerileriGuncelle();

            dtGridViewLog.DataSource = Utils.kuryeListesi;

        }

        private void KuryeGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            _arayuz.Arayuz_Load(null, null);


        }


    }

}
