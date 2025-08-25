using KuryeSistem.Codes.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuryeSistem
{
    public partial class PaketEkle : Form
    {
        Arayuz _arayuz;
        public PaketEkle(Arayuz arayuz)
        {
            InitializeComponent();
            _arayuz = arayuz;
        }

        private void paketadd()
        {
            string[] kurye = kuryesecbox.SelectedValue.ToString().Split(' ');

            try
            {
                if (Const.baglanti.State == ConnectionState.Closed)
                    Const.baglanti.Open();

                SqlCommand sqlkomut = new SqlCommand("INSERT INTO dbo.Paket " +
                "(KuryeId, PaketTutar, PaketAdresi, KayitTarihi, Aktifmi) VALUES (@P1 ,@P2, @P3, @P4, @P5)", Const.baglanti);
                sqlkomut.Parameters.AddWithValue("@P1", kurye[0]);
                sqlkomut.Parameters.AddWithValue("@P2", packcost.Text);
                sqlkomut.Parameters.AddWithValue("@P3", packadress.Text);
                sqlkomut.Parameters.AddWithValue("@P4", pakettarihi.Value);
                sqlkomut.Parameters.AddWithValue("@P5", "True");


                sqlkomut.ExecuteNonQuery();
                Utils.LogEkle("Paket Eklendi!", kurye[0] + " " + packcost.Text + " " + packadress.Text + " " + pakettarihi.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Paket Eklenirken Hata Oluştu! " + ex.Message);
                MessageBox.Show("Paket Eklenirken Hata Oluştu!" + ex.Message);
            }
            finally
            {
                Const.baglanti.Close();
            }


        }

        private void PaketEkle_Load(object sender, EventArgs e)
        {
            if (Utils.kuryeListesi == null)
                return;

            DataRowCollection rows = Utils.kuryeListesi.Rows;
            List<string> listViews = new List<string>();

            for (int i = 0; i < rows.Count; i++)
            {
                if (Convert.ToBoolean(rows[i].ItemArray[7]) == true)
                    listViews.Add(rows[i].ItemArray[0].ToString() + " " + rows[i].ItemArray[1].ToString());
            }

            kuryesecbox.DataSource = listViews;
        }

        private void packadd_Click(object sender, EventArgs e)
        {

            if (packadress.Text.Length == 0 || packcost.Text.Length == 0)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz");
                return;
            }
            else if (kuryesecbox.SelectedIndex != -1)
            {
                paketadd();
            }
            else
            {
                MessageBox.Show("Lütfen Kurye Seçiniz...");
                return;

            }



             _arayuz.Arayuz_Load(null, null);
        }


    }
}
