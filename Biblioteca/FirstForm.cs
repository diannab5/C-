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
    public partial class FirstForm : Form
    {
        const string ConnectionString
            = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\Biblioteca\Biblioteca\things\bazadate.accdb";


        const string ProviderName = @"System.Data.OleDb";

        public int ok = 0;
        public FirstForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //conexiune la baza de date
        private void button1_Click(object sender, EventArgs e)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(ProviderName);
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();

                DbCommand cmdLogin = connection.CreateCommand();
                cmdLogin.CommandText = "SELECT * FROM useri";
                using (DbDataReader reader = cmdLogin.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string numeUser = reader.GetString(0);
                        string Password = reader.GetString(1);
                        if (textBox1.Text == numeUser && textBox2.Text == Password)
                        {
                            MessageBox.Show("Conectarea s-a efectuat cu succes!");
                            this.Close();
                            ok = 1;
                        }
                        else
                        {
                            MessageBox.Show("Username-ul si parola gresite!");
                        }
                    }
                }
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this,new EventArgs());
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBox2.Focus();
            }
        }
    }
}
