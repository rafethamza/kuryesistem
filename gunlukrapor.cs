using KuryeSistem.Codes.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ClosedXML.Excel;
using Excelll = ClosedXML.Excel;

namespace KuryeSistem
{
    public partial class gunlukrapor : Form
    {
        Arayuz _arayuz;
        public gunlukrapor(Arayuz arayuz)
        {
            InitializeComponent();
            _arayuz = arayuz;
        }
        private void guncelleme()
        {
            string[] kurye = kuryesecbox.SelectedValue.ToString().Split(" ");
            string tarih = tarihsec.Value.ToString("yyyy-MM-dd");

            if (kuryepktlist.Checked == true)
            {
                Utils.kuryeRaporCikar(Convert.ToInt32(kurye[0]), comboBox1.SelectedIndex, tarih);

            }
            else if (tumpktlist.Checked == true)
            {
                Utils.RaporCikar(comboBox1.SelectedIndex, tarih);
            }

            if (kuryepktlist.Checked == true)
            {
                Utils.kuryeOrtTutarRapor(Convert.ToInt32(kurye[0]), comboBox1.SelectedIndex, tarih);

                if (Utils.raporData.Rows.Count > 0)
                {
                    label1.Text = Utils.raporData.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    label1.Text = "Veri bulunamadı.";
                }

                if (Utils.raporTutar.Rows.Count > 0)
                {
                    ortuttarlbl.Text = Utils.raporTutar.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    ortuttarlbl.Text = "Veri bulunamadı.";
                }
                if (Utils.raporToplam.Rows.Count > 0)
                {
                    toplamtutarlbl.Text = Utils.raporToplam.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    toplamtutarlbl.Text = "Veri bulunamadı.";
                }

            }
            else if (tumpktlist.Checked == true)
            {
                Utils.OrtTutarRapor(comboBox1.SelectedIndex, tarih);

                if (Utils.raporData.Rows.Count > 0)
                {
                    label1.Text = Utils.raporData.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    label1.Text = "Veri bulunamadı.";
                }

                if (Utils.raporTutar.Rows.Count > 0)
                {
                    ortuttarlbl.Text = Utils.raporTutar.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    ortuttarlbl.Text = "Veri bulunamadı.";
                }

                if (Utils.raporToplam.Rows.Count > 0)
                {
                    toplamtutarlbl.Text = Utils.raporToplam.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    toplamtutarlbl.Text = "Veri bulunamadı.";
                }
            }




            paketListGridView.DataSource = Utils.paketListesi;
        }

        private void gunlukrapor_Load(object sender, EventArgs e)
        {
            paketListGridView.DataSource = Utils.VerileriGoster(Const.queryPaketListesi);

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

        private void kuryesecbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            guncelleme();
        }

        private void paketListGridView_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Emin misin?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string msg = "";
                try
                {
                    int ind = paketListGridView.SelectedRows[0].Index;
                    Const.baglanti.Open();
                    int selectedId = Convert.ToInt32(paketListGridView.Rows[ind].Cells["Id"].Value);
                    msg = selectedId.ToString() + " " + paketListGridView.Rows[ind].Cells["KuryeId"].Value + " " + paketListGridView.Rows[ind].Cells["PaketTutar"].Value + " " +
                    paketListGridView.Rows[ind].Cells["PaketAdresi"].Value + " " + paketListGridView.Rows[ind].Cells["KayitTarihi"].Value;
                    SqlCommand sqlCommand = new SqlCommand("delete dbo.Paket where Id='" + selectedId + "' ", Const.baglanti);

                    sqlCommand.ExecuteNonQuery();

                    Utils.LogEkle("Paket Silindi!", msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silinirken Hata Oluştu... " + ex.Message);
                    Utils.LogEkle("Paket Silinirken Hata Oluştu...", ex.Message);
                }
                finally
                {
                    Const.baglanti.Close();
                }

            }


            Utils.VerileriGuncelle();

            paketListGridView.DataSource = Utils.paketListesi;

            guncelleme();


            _arayuz.Arayuz_Load(null, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guncelleme();
        }

        private void tumpktlist_CheckedChanged(object sender, EventArgs e)
        {
            guncelleme();
        }

        private void kuryepktlist_CheckedChanged(object sender, EventArgs e)
        {
            guncelleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Excel Worksheets (*.xls)|*.xls|xlsx file (*.xlsx)|*.xls|ods file (*.ods)|*.ods|odt file (*.odt)|*.odt|All files (*.*)|*.*";
            //saveFileDialog.Filter = "xlsx file (*.xlsx)|*.xls|Excel Worksheets (*.xls)|*.xls|ods file (*.ods)|*.ods|odt file (*.odt)|*.odt|All files (*.*)|*.*";
            saveFileDialog.Filter = "Excel Worksheets (*.xls)|*.xls|xlsx file (*.xlsx)|*.xls|ods file (*.ods)|*.ods|odt file (*.odt)|*.odt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Excel' e Aktar";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName.Length == 0)
            {
                return;
            }

            #region
            //Creating DataTable
            System.Data.DataTable dt1 = new System.Data.DataTable();

            int sayac = 0;
            using (Excelll.XLWorkbook wb1 = new Excelll.XLWorkbook())
            {
                var ws = wb1.Worksheets.Add("RAPORLAMA");

                int dt_row = 0;

                int baslik = 0;
                foreach (DataGridViewColumn column in paketListGridView.Columns)
                {
                    baslik++;
                    //dt1.Columns.Add(column.HeaderText, column.ValueType);
                    ws.Cell(1, baslik).Style.Font.Bold = true;
                    ws.Cell(1, baslik).Value = column.HeaderText;//11.07.2023 "dt_row + 3" yerine 1 vardı

                    //ÇERÇEVE KOYMA
                    ws.Cell(1, baslik).Style
                   .Border.SetTopBorder(XLBorderStyleValues.DashDotDot)
                   .Border.SetRightBorder(XLBorderStyleValues.DashDotDot)
                   .Border.SetBottomBorder(XLBorderStyleValues.DashDotDot)
                   .Border.SetLeftBorder(XLBorderStyleValues.DashDotDot);

                }
                int ff = paketListGridView.Rows.Count;
                foreach (DataGridViewRow row in paketListGridView.Rows)
                {
                    if (ff == dt_row + 1)
                    { goto bitir; }
                    dt1.Rows.Add();//11.07.2023 kapattım                    
                    dt_row++;


                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sayac++;
                        try
                        {
                            if (sayac < 8) ws.Columns(sayac, sayac).Width = 30;
                            else ws.Columns(sayac, sayac).Width = 18;
                            if (sayac == 37) ws.Columns(sayac, sayac).Width = 100;

                            if (cell.Value is null)
                            {
                                cell.Value = "";
                            }
                            ws.Cell(dt1.Rows.Count + 1, cell.ColumnIndex + 1).Value = cell.Value.ToString();

                            //ÇERÇEVE KOYMA
                            ws.Cell(dt1.Rows.Count + 1, cell.ColumnIndex + 1).Style
                          .Border.SetTopBorder(XLBorderStyleValues.DashDotDot)
                          .Border.SetRightBorder(XLBorderStyleValues.DashDotDot)
                          .Border.SetBottomBorder(XLBorderStyleValues.DashDotDot)
                          .Border.SetLeftBorder(XLBorderStyleValues.DashDotDot);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "-HATA GELDİ. YÖNETİCİYE DANIŞ.");
                            return;
                        }
                    }
                    sayac = 0;
                }
            bitir:
                string folderPath1 = saveFileDialog.FileName;
                wb1.SaveAs(folderPath1 + ".xlsx");
                MessageBox.Show("İşlem tamamlandı..");
            }
            #endregion
            Utils.LogEkle("Excel Oluşturuldu!", "Rapor Oluşturuldu!");


        }

        private void tarihsec_ValueChanged(object sender, EventArgs e)
        {
            guncelleme();
        }
    }
}

