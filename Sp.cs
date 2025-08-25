using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;


public class Sp
{
    public static SqlConnection cn1 = new SqlConnection();

    public static DataSet SQLCalistir(string SQL)
    {
        try
        {
            cn1.ConnectionString = "Data Source=DESKTOP-I7D4GIB\\SQLEXPRESS;Initial Catalog=kuryetakip;Integrated Security=True;Trust Server Certificate=True";
            SqlCommand Com = new SqlCommand(SQL, cn1);
            Com.CommandTimeout = 240;
            Com.CommandType = CommandType.Text;
            string str = cn1.ConnectionString;
            DataSet SQLset = new DataSet();
            SqlDataAdapter Comset = new SqlDataAdapter(Com);
            try
            {
                Comset.Fill(SQLset);
                return SQLset;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
                return null;
            }
            finally
            {

            }
        }
        catch
        {
            return null;
        }
    }
    }
    
