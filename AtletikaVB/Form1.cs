using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AtletikaVB
{
    public partial class AtletikaVB : Form
    {
        public AtletikaVB()
        {
            InitializeComponent();
        }
        private void AtleikaVB_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT nemzetek.Nemzet,versenyekszamok.Versenyszam,versenyekszamok.VersenyzoNev,versenyekszamok.Helyezes,versenyekszamok.Eredmeny,versenyekszamok.Nem\r\nfrom nemzetek join versenyekszamok ON nemzetek.NemzetId=versenyekszamok.NemzetKod";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        versenyadatok orszag = new versenyadatok(dr.GetInt32("nemzetek.Nemzet"), dr.GetInt32("versenyekszamok.Versenyszam"), dr.GetString("versenyekszamok.VersenyzoNev"), dr.GetDouble("versenyekszamok.Eredmeny"), dr.GetString("versenyekszamok.Nem"));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Hide();
        }
    }
}
