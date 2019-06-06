namespace Sorteio
{
    partial class FormCadastroNumero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label numeroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroNumero));
            this.grpIntervalo = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.bDSorteioDataSet = new Sorteio.BDSorteioDataSet();
            this.numeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroTableAdapter = new Sorteio.BDSorteioDataSetTableAdapters.NumeroTableAdapter();
            this.tableAdapterManager = new Sorteio.BDSorteioDataSetTableAdapters.TableAdapterManager();
            this.numeroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.numeroDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.sorteadoCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            this.grpIntervalo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDSorteioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroBindingNavigator)).BeginInit();
            this.numeroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(116, 44);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 10;
            numeroLabel.Text = "Numero:";
            // 
            // grpIntervalo
            // 
            this.grpIntervalo.Controls.Add(this.btnAdicionar);
            this.grpIntervalo.Controls.Add(this.label1);
            this.grpIntervalo.Controls.Add(this.lblDe);
            this.grpIntervalo.Controls.Add(this.txtMax);
            this.grpIntervalo.Controls.Add(this.txtMin);
            this.grpIntervalo.Location = new System.Drawing.Point(17, 67);
            this.grpIntervalo.Name = "grpIntervalo";
            this.grpIntervalo.Size = new System.Drawing.Size(420, 72);
            this.grpIntervalo.TabIndex = 7;
            this.grpIntervalo.TabStop = false;
            this.grpIntervalo.Text = "Adicionar Intervalo";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(297, 27);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Até:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(14, 32);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 13);
            this.lblDe.TabIndex = 3;
            this.lblDe.Text = "De:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(185, 29);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 1;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(44, 29);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 0;
            // 
            // bDSorteioDataSet
            // 
            this.bDSorteioDataSet.DataSetName = "BDSorteioDataSet";
            this.bDSorteioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numeroBindingSource
            // 
            this.numeroBindingSource.DataMember = "Numero";
            this.numeroBindingSource.DataSource = this.bDSorteioDataSet;
            // 
            // numeroTableAdapter
            // 
            this.numeroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrindeTableAdapter = null;
            this.tableAdapterManager.NumeroTableAdapter = this.numeroTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sorteio.BDSorteioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numeroBindingNavigator
            // 
            this.numeroBindingNavigator.AddNewItem = null;
            this.numeroBindingNavigator.BindingSource = this.numeroBindingSource;
            this.numeroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.numeroBindingNavigator.DeleteItem = null;
            this.numeroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.numeroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.numeroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.numeroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.numeroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.numeroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.numeroBindingNavigator.Name = "numeroBindingNavigator";
            this.numeroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.numeroBindingNavigator.Size = new System.Drawing.Size(449, 25);
            this.numeroBindingNavigator.TabIndex = 8;
            this.numeroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // numeroDataGridView
            // 
            this.numeroDataGridView.AutoGenerateColumns = false;
            this.numeroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numeroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.numeroDataGridView.DataSource = this.numeroBindingSource;
            this.numeroDataGridView.Location = new System.Drawing.Point(17, 145);
            this.numeroDataGridView.Name = "numeroDataGridView";
            this.numeroDataGridView.Size = new System.Drawing.Size(253, 364);
            this.numeroDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Sorteado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Sorteado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numeroBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(48, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(55, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numeroBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(175, 41);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(138, 20);
            this.numeroTextBox.TabIndex = 11;
            // 
            // sorteadoCheckBox
            // 
            this.sorteadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.numeroBindingSource, "Sorteado", true));
            this.sorteadoCheckBox.Location = new System.Drawing.Point(333, 39);
            this.sorteadoCheckBox.Name = "sorteadoCheckBox";
            this.sorteadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.sorteadoCheckBox.TabIndex = 13;
            this.sorteadoCheckBox.Text = "Sorteado?";
            this.sorteadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(362, 145);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 60);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastroNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(449, 521);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.sorteadoCheckBox);
            this.Controls.Add(this.numeroDataGridView);
            this.Controls.Add(this.numeroBindingNavigator);
            this.Controls.Add(this.grpIntervalo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 560);
            this.MinimumSize = new System.Drawing.Size(465, 560);
            this.Name = "FormCadastroNumero";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCadastroNumero";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCadastroNumero_Load);
            this.grpIntervalo.ResumeLayout(false);
            this.grpIntervalo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDSorteioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroBindingNavigator)).EndInit();
            this.numeroBindingNavigator.ResumeLayout(false);
            this.numeroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpIntervalo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private BDSorteioDataSet bDSorteioDataSet;
        private System.Windows.Forms.BindingSource numeroBindingSource;
        private BDSorteioDataSetTableAdapters.NumeroTableAdapter numeroTableAdapter;
        private BDSorteioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator numeroBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView numeroDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.CheckBox sorteadoCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnSalvar;
    }
}