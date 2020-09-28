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
    public partial class Form6 : Form
    {
        const string ConnectionString
                  = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\Biblioteca\Biblioteca\things\bazadate.accdb";


        const string ProviderName = @"System.Data.OleDb";

        private int nrLife;
        private int nrPolirom;
        private int nrRao;
        private int nrHumanitas;
        private int nrCorint;
        private int nrLitera;
        private int nrTrei;
        private int Total=18;

        public Form6()
        {
            InitializeComponent();

            getDateEdituri(); //functie care sa preia datele din bd
            //calculez ponderile
            float pLife = (nrLife * 100) / Total;
            float pPolirom = (nrPolirom * 100) / Total;
            float pRao = (nrRao * 100) / Total;
            float pHm = (nrHumanitas * 100) / Total;
            float pCrt = (nrCorint * 100) / Total;
            float pLit = (nrLitera * 100) / Total;
            float pTrei = (nrTrei * 100) / Total;

            chart1.Series["Series1"].Points.AddXY("LifeStyle", pLife);
            chart1.Series["Series1"].Points[0].Color = Color.FromArgb(113, 238, 184);
            chart1.Series["Series1"].Points.AddXY("Polirom", pPolirom);
            chart1.Series["Series1"].Points[1].Color = Color.FromArgb(112, 225, 147);
            chart1.Series["Series1"].Points.AddXY("Rao", pRao);
            chart1.Series["Series1"].Points[2].Color = Color.FromArgb(32, 178, 170);
            chart1.Series["Series1"].Points.AddXY("Humanitas", pHm);
            chart1.Series["Series1"].Points[3].Color = Color.FromArgb(112, 225, 218);
            chart1.Series["Series1"].Points.AddXY("Corint", pCrt);
            chart1.Series["Series1"].Points[4].Color = Color.FromArgb(129, 199, 202);
            chart1.Series["Series1"].Points.AddXY("Litera", pLit);
            chart1.Series["Series1"].Points[5].Color = Color.FromArgb(164, 251, 202);
            chart1.Series["Series1"].Points.AddXY("Trei", pTrei);
            chart1.Series["Series1"].Points[6].Color = Color.FromArgb(116, 189, 195);
        }

        private void getDateEdituri()
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(ProviderName);
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();

                DbCommand cmdSelectLifeP = connection.CreateCommand();
                cmdSelectLifeP.CommandText = "SELECT COUNT(carteId) FROM Carti WHERE editura = 'Lifestyle Publishing'";
                nrLife = Convert.ToInt32(cmdSelectLifeP.ExecuteScalar());

                DbCommand cmdSelectPoli = connection.CreateCommand();
                cmdSelectPoli.CommandText = "SELECT COUNT(carteId) FROM Carti WHERE editura= 'Polirom'";
                nrPolirom = Convert.ToInt32(cmdSelectPoli.ExecuteScalar());

                DbCommand cmdSelectRao = connection.CreateCommand();
                cmdSelectRao.CommandText = "SELECT COUNT(carteId) FROM Carti WHERE editura = 'Rao'";
                nrRao = Convert.ToInt32(cmdSelectRao.ExecuteScalar());

                DbCommand cmdSelectHm = connection.CreateCommand();
                cmdSelectHm.CommandText = "SELECT COUNT(carteId) FROM Carti WHERE editura = 'Humanitas Multimedia'";
                nrHumanitas = Convert.ToInt32(cmdSelectHm.ExecuteScalar());
                DbCommand cmdSelectCrt = connection.CreateCommand();
                cmdSelectCrt.CommandText = "SELECT COUNT(carteId) FROM Carti WHERE editura= 'Corint'";
                nrCorint = Convert.ToInt32(cmdSelectCrt.ExecuteScalar());

                DbCommand cmdSelectLit = connection.CreateCommand();
                cmdSelectLit.CommandText = "SELECT COUNT(carteId) FROM Carti WHERE editura= 'Litera'";
                nrLitera = Convert.ToInt32(cmdSelectLit.ExecuteScalar());

                DbCommand cmdSelectTrei = connection.CreateCommand();
                cmdSelectTrei.CommandText = "SELECT COUNT(carteId) FROM Carti WHERE editura= 'Trei'";
                nrTrei = Convert.ToInt32(cmdSelectTrei.ExecuteScalar());

            }
        }
    }

}
