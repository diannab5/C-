using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form2 : Form
    {
        const string ConnectionString
               = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\Biblioteca\Biblioteca\things\bazadate.accdb";


        const string ProviderName = @"System.Data.OleDb";
        public Form2()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.View = View.Details;
            //adaugare coloane in listview
            listView1.Columns.Add("Id", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Titlu", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Autor", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Editura", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("AnAparitie", 130, HorizontalAlignment.Center);

            PreluareDinBd(); //functie care preia cartile din baza de date
        }
        private void PreluareDinBd()
        {
            List<Carti> carti = new List<Carti>();
            DbProviderFactory factory = DbProviderFactories.GetFactory(ProviderName);
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();

                DbCommand cmdSelect = connection.CreateCommand();
                cmdSelect.CommandText = "SELECT * FROM Carti";
                using (DbDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Carti c = new Carti(reader.GetInt32(0), //carte id
                            reader.GetString(1),//titlu carte
                            reader.GetString(2),//autor carte
                            reader.GetString(3), //editura
                            reader.GetInt32(4)); //an aparitie
                          
                            
                        carti.Add(c);
                    }
                }
            }
            foreach(Carti c in carti)
            {
                ListViewItem rand = new ListViewItem();
                rand.Text = c.CarteId.ToString();//carte id
                rand.SubItems.Add(c.Titlu); //titlu carte
                rand.SubItems.Add(c.Autor); //autor carte
                rand.SubItems.Add(c.Editura);//editura
                rand.SubItems.Add(c.AnAparitie.ToString());
                listView1.Items.Add(rand);
            }
        }

        private void adaugaCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
            listView1.Items.Clear();
            PreluareDinBd();
        }

        private void salveazaInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string numefisier = "";
            SaveFileDialog savefiledialog = new SaveFileDialog();

            savefiledialog.Title = "Salvare lista carti";
            savefiledialog.Filter = "Text File (.txt) | *.txt";
              if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                numefisier = savefiledialog.FileName.ToString();
                if (numefisier != "")
                {
                    using (StreamWriter sw = new StreamWriter(numefisier))
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            sw.WriteLine("id {0} , titlu {1}, {2} autor, editura {3}, anul aparitiei {4}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text);
                        }
                    }
                }
            }
        }
    }
}
