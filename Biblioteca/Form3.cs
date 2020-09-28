using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form3 : Form
    {
        const string ConnectionString
                 = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\Biblioteca\Biblioteca\things\bazadate.accdb";


        const string ProviderName = @"System.Data.OleDb";
        public Form3()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.View = View.Details;
            listView1.Columns.Add("Id", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Nume", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Adresa", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Telefon", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("CNP", 140, HorizontalAlignment.Center);

            PreluareDinBd();
        }
            private void PreluareDinBd()
            {
                List<Cititori> cititori = new List<Cititori>();
                DbProviderFactory factory = DbProviderFactories.GetFactory(ProviderName);
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = ConnectionString;
                    connection.Open();

                    DbCommand cmdSelect = connection.CreateCommand();
                    cmdSelect.CommandText = "SELECT * FROM Cititori";
                    using (DbDataReader reader = cmdSelect.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cititori c = new Cititori(reader.GetInt32(0), //id cititor
                                reader.GetString(1),//nume ctitior
                                reader.GetString(2),//cnp
                                reader.GetString(3), //adresa
                                reader.GetString(4)); //telefon


                            cititori.Add(c);
                        }
                    }
                }
                foreach (Cititori c in cititori)
                {
                    ListViewItem rand = new ListViewItem();
                    rand.Text = c.CititorId.ToString();//cititor id
                    rand.SubItems.Add(c.Nume); //nume 
                    rand.SubItems.Add(c.Telefon); //telefon
                    rand.SubItems.Add(c.Adresa);//adresa
                rand.SubItems.Add(c.Cnp);
                    listView1.Items.Add(rand);
                }
            }
        //modificare culoare buton 
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                    button1.BackColor = cd.Color;
            }
        }
    }
    }

