using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class FormCadastroNumero : Form
    {
        public FormCadastroNumero()
        {
            InitializeComponent();
        }

        private void numeroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.numeroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSorteioDataSet);

        }

        private void FormCadastroNumero_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSorteioDataSet.Numero'. Você pode movê-la ou removê-la conforme necessário.
            this.numeroTableAdapter.Fill(this.bDSorteioDataSet.Numero);
            // TODO: esta linha de código carrega dados na tabela 'bDSorteioDataSet.Numero'. Você pode movê-la ou removê-la conforme necessário.
            this.numeroTableAdapter.Fill(this.bDSorteioDataSet.Numero);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            int vMin = 0;
            int vMax = 300;

            vMin = Convert.ToInt32(txtMin.Text);
            vMax = Convert.ToInt32(txtMax.Text);


            for (int i=vMin; i<vMax; i++)
            {



                this.numeroBindingSource.AddNew();
                numeroTextBox.Text = i.ToString();
            }

            this.Validate();
            this.numeroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSorteioDataSet);


        }

        private void numeroBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.numeroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSorteioDataSet);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.numeroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSorteioDataSet);
        }
    }
}
