using ClosedXML.Excel;
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
using ClosedXML.Excel;
using Excelll = ClosedXML.Excel;

namespace KuryeSistem
{
    public partial class LogPanel : Form
    {
        Arayuz _arayuz;
        public LogPanel(Arayuz arayuz)
        {
            InitializeComponent();
            _arayuz = arayuz;
        }

        private void LogPanel_Load(object sender, EventArgs e)
        {
            logPanelGridView.DataSource = Utils.VerileriGoster(Const.logKaydi);
        }

        private void excelbtn_Click(object sender, EventArgs e)
        {
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
                    foreach (DataGridViewColumn column in logPanelGridView.Columns)
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
                    Utils.LogEkle("Excel", "Excel Log Kaydı oluşturuldu!");
                    logPanelGridView.DataSource = Utils.VerileriGoster(Const.logKaydi);

                    int ff = logPanelGridView.Rows.Count;
                    foreach (DataGridViewRow row in logPanelGridView.Rows)
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


                Utils.LogEkle("Excel", "Excel Log Kaydı oluşturuldu!");

                
            }
        }
    }
}

