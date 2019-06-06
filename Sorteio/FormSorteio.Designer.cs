namespace Sorteio
{
    partial class FormSorteio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSorteio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstSorteados = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCadastroNumeros = new System.Windows.Forms.Button();
            this.btnCadastroBrindes = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSortear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstSorteados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 462);
            this.panel1.TabIndex = 5;
            // 
            // lstSorteados
            // 
            this.lstSorteados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSorteados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSorteados.FullRowSelect = true;
            this.lstSorteados.GridLines = true;
            this.lstSorteados.Location = new System.Drawing.Point(0, 0);
            this.lstSorteados.Name = "lstSorteados";
            this.lstSorteados.ShowGroups = false;
            this.lstSorteados.Size = new System.Drawing.Size(1289, 462);
            this.lstSorteados.TabIndex = 3;
            this.lstSorteados.UseCompatibleStateImageBehavior = false;
            this.lstSorteados.View = System.Windows.Forms.View.List;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblResult);
            this.panel3.Controls.Add(this.btnCadastroNumeros);
            this.panel3.Controls.Add(this.btnCadastroBrindes);
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.btnSortear);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1289, 114);
            this.panel3.TabIndex = 7;
            // 
            // btnCadastroNumeros
            // 
            this.btnCadastroNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastroNumeros.Location = new System.Drawing.Point(93, 45);
            this.btnCadastroNumeros.Name = "btnCadastroNumeros";
            this.btnCadastroNumeros.Size = new System.Drawing.Size(75, 51);
            this.btnCadastroNumeros.TabIndex = 8;
            this.btnCadastroNumeros.Text = "Cadastrar Numeros";
            this.btnCadastroNumeros.UseVisualStyleBackColor = true;
            this.btnCadastroNumeros.Click += new System.EventHandler(this.btnCadastroNumeros_Click);
            // 
            // btnCadastroBrindes
            // 
            this.btnCadastroBrindes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastroBrindes.Location = new System.Drawing.Point(12, 44);
            this.btnCadastroBrindes.Name = "btnCadastroBrindes";
            this.btnCadastroBrindes.Size = new System.Drawing.Size(75, 51);
            this.btnCadastroBrindes.TabIndex = 7;
            this.btnCadastroBrindes.Text = "Cadastrar Brindes";
            this.btnCadastroBrindes.UseVisualStyleBackColor = true;
            this.btnCadastroBrindes.Click += new System.EventHandler(this.btnCadastroBrindes_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(1186, 44);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 52);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSortear
            // 
            this.btnSortear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSortear.Location = new System.Drawing.Point(575, 43);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(160, 52);
            this.btnSortear.TabIndex = 5;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(527, 3);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(250, 37);
            this.lblResult.TabIndex = 9;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSorteio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstSorteados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCadastroNumeros;
        private System.Windows.Forms.Button btnCadastroBrindes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Label lblResult;
    }
}

