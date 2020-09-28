using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form5 : Form
    {
        const string ConnectionString
               = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\Biblioteca\Biblioteca\things\bazadate.accdb";


        const string ProviderName = @"System.Data.OleDb";
        public Form5()
        {
            InitializeComponent();
        }

        private void ValidareDate()
        {
            if(string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                errorProvider1.SetError(textBoxId, "Sa se introduca id-ul");
            }
            else if(string.IsNullOrWhiteSpace(textBoxTitlu.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxTitlu, "Sa se introduca titlul");

            }
            else if (string.IsNullOrWhiteSpace(textBoxAutor.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxAutor, "Sa se introduca autorul");
            }
            else if (string.IsNullOrWhiteSpace(textBoxEditura.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxEditura, "Sa se introduca editura");
            }
            else if (string.IsNullOrWhiteSpace(textBoxAnAp.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxAnAp, "Sa se introduca anul aparitiei");
            }
            else
            {
                errorProvider1.Clear();
                //insert into table
                DbProviderFactory factory = DbProviderFactories.GetFactory(ProviderName);
                using (DbConnection connection = factory.CreateConnection())
                {
                    connection.ConnectionString = ConnectionString;
                    connection.Open();

                    DbCommand select = connection.CreateCommand();
                    select.CommandText = "SELECT MAX(carteId) FROM Carti";
                    int idMax = Convert.ToInt32(select.ExecuteScalar());

                    DbCommand cmdInsert = connection.CreateCommand();
                    cmdInsert.CommandText = "INSERT INTO Carti(carteId,titlu,autor,editura,anAparitie) VALUES (@id,@titlu ,@autor, @editura, @anaparitie)";

                    //parametru pentru id
                    DbParameter pId = cmdInsert.CreateParameter();
                    pId.DbType = System.Data.DbType.Int32;
                    cmdInsert.Parameters.Add(pId);
                    //parametru pentru titlu
                    DbParameter pTitlu = cmdInsert.CreateParameter();
                    pTitlu.DbType = System.Data.DbType.String;
                    cmdInsert.Parameters.Add(pTitlu);
                    //parametru pentru autor
                    DbParameter pAutor = cmdInsert.CreateParameter();
                    pAutor.DbType = System.Data.DbType.String;
                    cmdInsert.Parameters.Add(pAutor);
                    //parametru pentru editura
                    DbParameter pEditura = cmdInsert.CreateParameter();
                    pEditura.DbType = System.Data.DbType.String;
                    cmdInsert.Parameters.Add(pEditura);
                    //parametru pentru an aparitie
                    DbParameter pAn = cmdInsert.CreateParameter();
                    pAn.DbType = System.Data.DbType.Int32;
                    cmdInsert.Parameters.Add(pAn);

                   
                    //valori
                    pId.Value = idMax + 1;
                    pTitlu.Value = textBoxTitlu.Text;
                    pAutor.Value = textBoxAutor.Text;
                    pEditura.Value = textBoxEditura.Text;
       
                    pAn.Value = Int32.Parse(textBoxAnAp.Text);
                   
               

                    cmdInsert.ExecuteNonQuery();
                }
                MessageBox.Show("O noua carte a fost adaugata!");

            }
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            ValidareDate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBoxTitlu.Focus();
            }
        }

        private void textBoxTitlu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxAutor.Focus();
            }
        }

        private void textBoxAutor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxEditura.Focus();
            }
        }

        private void textBoxEditura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxAnAp.Focus();
            }
        }
    }
}
