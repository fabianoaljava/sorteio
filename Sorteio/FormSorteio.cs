using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Sorteio;

namespace Sorteio
{
    public partial class FormSorteio : Form
    {
        public FormSorteio()
        {
            InitializeComponent();
        }

        private void btnCadastroBrindes_Click(object sender, EventArgs e)
        {
            FormCadastroBrindes formCadastroBrindes = new FormCadastroBrindes();
            formCadastroBrindes.Show();
        }

        private void btnCadastroNumeros_Click(object sender, EventArgs e)
        {
            FormCadastroNumero formCadastroNumero = new FormCadastroNumero();
            formCadastroNumero.Show();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {



            Sorteados sorteio = new Sorteados();

            var vConnectionString = ConfigurationManager.ConnectionStrings["Sorteio.Properties.Settings.BDSorteioConnectionString"].ToString();

            int vCont = 0;


            SqlDataReader vBrinde = null;
            SqlDataReader vNumero = null;


            string vQueryBrinde = "SELECT * FROM Brinde WHERE NumeroSorteado IS NULL ";

            string vQueryNumeroAleatorio = "SELECT top(1) Id, Numero  FROM Numero WHERE Sorteado IS NULL order by newid()";

            using (SqlConnection vConexao = new SqlConnection(vConnectionString))
            {


                SqlCommand vBrindeCmd = new SqlCommand(vQueryBrinde, vConexao);

                vConexao.Open();

                vBrinde = vBrindeCmd.ExecuteReader();

                using (vBrinde)
                {

                    while(vBrinde.Read())
                    {
                        sorteio.BrindeId = Convert.ToInt32(vBrinde["Id"].ToString());
                        sorteio.BrindeNome = vBrinde["Nome"].ToString();

                       
                        SqlCommand vNumeroCmd = new SqlCommand(vQueryNumeroAleatorio, vConexao);

                        vNumero = vNumeroCmd.ExecuteReader();
                        using (vNumero)
                        {
                            while (vNumero.Read())
                            {
                                sorteio.NumeroSorteado = Convert.ToInt32(vNumero["Numero"].ToString());
                            }
                        }

  

                        string vUpdateBrinde = "UPDATE Brinde SET NumeroSorteado = @fNumero WHERE Id = @fBrindeId";
                        SqlCommand vUpdateBrindCmd = new SqlCommand(vUpdateBrinde, vConexao);



                        vUpdateBrindCmd.Parameters.AddWithValue("@fNumero", sorteio.NumeroSorteado);
                        vUpdateBrindCmd.Parameters.AddWithValue("@fBrindeId", sorteio.BrindeId);
                        vUpdateBrindCmd.ExecuteNonQuery();

                        Console.WriteLine(vUpdateBrindCmd.CommandText);

                        vUpdateBrindCmd.Dispose();

                        string vUpdateNumero = "UPDATE Numero SET Sorteado = 1 WHERE Numero = @fNumero";
                        SqlCommand vUpdadeNumeroCmd = new SqlCommand(vUpdateNumero, vConexao);

                        vUpdadeNumeroCmd.Parameters.AddWithValue("@fNumero", sorteio.NumeroSorteado);
                        vUpdadeNumeroCmd.ExecuteNonQuery();

                        Console.WriteLine(vUpdadeNumeroCmd.CommandText);
                        vUpdadeNumeroCmd.Dispose();

                        ListViewItem ItemSorteado = new ListViewItem();

                        ItemSorteado.Text = sorteio.NumeroSorteado + " - " + sorteio.BrindeNome;

                        lstSorteados.Items.Add(ItemSorteado);

                        lstSorteados.Refresh();

                        vCont++;

                        Console.WriteLine("Sorteado: " + sorteio.NumeroSorteado + " - " + sorteio.BrindeNome);

                        


                    }

                }


                lblResult.Text = vCont.ToString() + " brinde(s) sorteado(s).";


            }




        }
    }
}
