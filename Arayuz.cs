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

    public partial class Arayuz : Form

    {
        public Arayuz()
        {
            InitializeComponent();
        }

        LogPanel logPanel;
        PaketEkle paketEkle;
        KuryeGiris kuryeGiris;
        gunlukrapor gunlukrapor;
        private void Arayuz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void kuryebtn_Click(object sender, EventArgs e)
        {
            kuryeGiris = new KuryeGiris(this);
            kuryeGiris.Show();
        }

        public void Arayuz_Load(object sender, EventArgs e)
        {
            Utils.kuryeListesi = Utils.VerileriGoster(Const.queryKuryeListesi);

            if (Utils.kuryeListesi == null)
                return;

            DataRowCollection rows = Utils.kuryeListesi.Rows;
            List<string> listViews = new List<string>();

            for (int i = 0; i < rows.Count; i++)
            {
                if (Convert.ToBoolean(rows[i].ItemArray[7]) == true)
                    listViews.Add(rows[i].ItemArray[1].ToString() + "-" + rows[i].ItemArray[2].ToString());
            }

            aktifkuryelist.DataSource = listViews;

            guncelpaketdtgridview.DataSource = Utils.VerileriGoster(Const.queryGuncelPaketListesi);
        }

        private void paketadd_Click(object sender, EventArgs e)
        {
            paketEkle = new PaketEkle(this);
            paketEkle.Show();
        }



        private void guncelpaketdtgridview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Emin misin?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int ind = guncelpaketdtgridview.SelectedRows[0].Index;
                    Const.baglanti.Open();
                    int selectedId = Convert.ToInt32(guncelpaketdtgridview.Rows[ind].Cells["Id"].Value);
                    SqlCommand sqlCommand = new SqlCommand("delete dbo.Paket where Id='" + selectedId + "' ", Const.baglanti);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silinirken Hata Oluştu... " + ex.Message);
                }
                finally
                {
                    Const.baglanti.Close();
                }

            }


            Utils.VerileriGuncelle();

            guncelpaketdtgridview.DataSource = Utils.guncelPaketListesi;
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            logPanel = new LogPanel(this);
            logPanel.Show();
        }

        private void gunlukraporbtn_Click(object sender, EventArgs e)
        {
            gunlukrapor = new gunlukrapor(this);
            gunlukrapor.Show();
        }
    }
}
