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
    public partial class FormCadastroBrindes : Form
    {
        public FormCadastroBrindes()
        {
            InitializeComponent();
        }

        private void brindeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brindeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSorteioDataSet);

        }

        private void FormCadastroBrindes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSorteioDataSet.Brinde'. Você pode movê-la ou removê-la conforme necessário.
            this.brindeTableAdapter.Fill(this.bDSorteioDataSet.Brinde);
            // TODO: esta linha de código carrega dados na tabela 'bDSorteioDataSet.Brinde'. Você pode movê-la ou removê-la conforme necessário.
            this.brindeTableAdapter.Fill(this.bDSorteioDataSet.Brinde);

        }

        private void brindeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.brindeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSorteioDataSet);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.brindeBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brindeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSorteioDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.brindeBindingSource.RemoveCurrent();
        }
    }
}
