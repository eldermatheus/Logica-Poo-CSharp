
namespace Importador
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnServidor = new System.Windows.Forms.TextBox();
            this.btnPorta = new System.Windows.Forms.TextBox();
            this.btnBase = new System.Windows.Forms.TextBox();
            this.btnDataInicial = new System.Windows.Forms.TextBox();
            this.btnDataFinal = new System.Windows.Forms.TextBox();
            this.btnSerie = new System.Windows.Forms.TextBox();
            this.btnModelo = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnImportaTxt = new System.Windows.Forms.Button();
            this.btnChecaCodigo = new System.Windows.Forms.RadioButton();
            this.btnChecaCodean = new System.Windows.Forms.RadioButton();
            this.btnChecaCodAnt = new System.Windows.Forms.RadioButton();
            this.btnChecaDescricao = new System.Windows.Forms.RadioButton();
            this.btnChecaAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdvProdutos = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnClientes = new Importador.SplitButtont();
            this.btnProdutos = new Importador.SplitButtont();
            this.btnOperacoes = new Importador.SplitButtont();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMovEntradas = new System.Windows.Forms.RadioButton();
            this.btnMovSaidas = new System.Windows.Forms.RadioButton();
            this.btnMovAll = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServidor
            // 
            this.btnServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnServidor.Location = new System.Drawing.Point(13, 54);
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.Size = new System.Drawing.Size(100, 23);
            this.btnServidor.TabIndex = 0;
            this.btnServidor.Text = "127.0.0.1";
            // 
            // btnPorta
            // 
            this.btnPorta.Location = new System.Drawing.Point(240, 53);
            this.btnPorta.Name = "btnPorta";
            this.btnPorta.Size = new System.Drawing.Size(52, 23);
            this.btnPorta.TabIndex = 2;
            this.btnPorta.Text = "5432";
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(124, 53);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(104, 23);
            this.btnBase.TabIndex = 1;
            this.btnBase.Text = "base_v5";
            // 
            // btnDataInicial
            // 
            this.btnDataInicial.Enabled = false;
            this.btnDataInicial.Location = new System.Drawing.Point(12, 120);
            this.btnDataInicial.Name = "btnDataInicial";
            this.btnDataInicial.Size = new System.Drawing.Size(96, 23);
            this.btnDataInicial.TabIndex = 6;
            // 
            // btnDataFinal
            // 
            this.btnDataFinal.Enabled = false;
            this.btnDataFinal.Location = new System.Drawing.Point(123, 120);
            this.btnDataFinal.Name = "btnDataFinal";
            this.btnDataFinal.Size = new System.Drawing.Size(100, 23);
            this.btnDataFinal.TabIndex = 7;
            // 
            // btnSerie
            // 
            this.btnSerie.Enabled = false;
            this.btnSerie.Location = new System.Drawing.Point(238, 120);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(49, 23);
            this.btnSerie.TabIndex = 8;
            // 
            // btnModelo
            // 
            this.btnModelo.Enabled = false;
            this.btnModelo.Location = new System.Drawing.Point(305, 120);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(52, 23);
            this.btnModelo.TabIndex = 9;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConectar.Location = new System.Drawing.Point(339, 25);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(142, 51);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImportaTxt
            // 
            this.btnImportaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImportaTxt.Location = new System.Drawing.Point(872, 28);
            this.btnImportaTxt.Name = "btnImportaTxt";
            this.btnImportaTxt.Size = new System.Drawing.Size(135, 49);
            this.btnImportaTxt.TabIndex = 5;
            this.btnImportaTxt.Text = "Carregar TXT";
            this.btnImportaTxt.UseVisualStyleBackColor = false;
            this.btnImportaTxt.Click += new System.EventHandler(this.btnImportaTxt_Click);
            // 
            // btnChecaCodigo
            // 
            this.btnChecaCodigo.AutoSize = true;
            this.btnChecaCodigo.Enabled = false;
            this.btnChecaCodigo.Location = new System.Drawing.Point(6, 22);
            this.btnChecaCodigo.Name = "btnChecaCodigo";
            this.btnChecaCodigo.Size = new System.Drawing.Size(64, 19);
            this.btnChecaCodigo.TabIndex = 10;
            this.btnChecaCodigo.TabStop = true;
            this.btnChecaCodigo.Text = "Código";
            this.btnChecaCodigo.UseVisualStyleBackColor = true;
            // 
            // btnChecaCodean
            // 
            this.btnChecaCodean.AutoSize = true;
            this.btnChecaCodean.Enabled = false;
            this.btnChecaCodean.Location = new System.Drawing.Point(76, 22);
            this.btnChecaCodean.Name = "btnChecaCodean";
            this.btnChecaCodean.Size = new System.Drawing.Size(66, 19);
            this.btnChecaCodean.TabIndex = 11;
            this.btnChecaCodean.TabStop = true;
            this.btnChecaCodean.Text = "Codean";
            this.btnChecaCodean.UseVisualStyleBackColor = true;
            // 
            // btnChecaCodAnt
            // 
            this.btnChecaCodAnt.AutoSize = true;
            this.btnChecaCodAnt.Enabled = false;
            this.btnChecaCodAnt.Location = new System.Drawing.Point(148, 22);
            this.btnChecaCodAnt.Name = "btnChecaCodAnt";
            this.btnChecaCodAnt.Size = new System.Drawing.Size(69, 19);
            this.btnChecaCodAnt.TabIndex = 12;
            this.btnChecaCodAnt.TabStop = true;
            this.btnChecaCodAnt.Text = "Cód.Ant";
            this.btnChecaCodAnt.UseVisualStyleBackColor = true;
            // 
            // btnChecaDescricao
            // 
            this.btnChecaDescricao.AutoSize = true;
            this.btnChecaDescricao.Enabled = false;
            this.btnChecaDescricao.Location = new System.Drawing.Point(223, 22);
            this.btnChecaDescricao.Name = "btnChecaDescricao";
            this.btnChecaDescricao.Size = new System.Drawing.Size(76, 19);
            this.btnChecaDescricao.TabIndex = 13;
            this.btnChecaDescricao.TabStop = true;
            this.btnChecaDescricao.Text = "Descrição";
            this.btnChecaDescricao.UseVisualStyleBackColor = true;
            // 
            // btnChecaAll
            // 
            this.btnChecaAll.AutoSize = true;
            this.btnChecaAll.Enabled = false;
            this.btnChecaAll.Location = new System.Drawing.Point(305, 22);
            this.btnChecaAll.Name = "btnChecaAll";
            this.btnChecaAll.Size = new System.Drawing.Size(56, 19);
            this.btnChecaAll.TabIndex = 14;
            this.btnChecaAll.TabStop = true;
            this.btnChecaAll.Text = "Todos";
            this.btnChecaAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Porta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Base de Dados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Data Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data Final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Serie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Modelo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChecaAll);
            this.groupBox1.Controls.Add(this.btnChecaCodigo);
            this.groupBox1.Controls.Add(this.btnChecaCodean);
            this.groupBox1.Controls.Add(this.btnChecaCodAnt);
            this.groupBox1.Controls.Add(this.btnChecaDescricao);
            this.groupBox1.Location = new System.Drawing.Point(411, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 52);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checagem de Produtos";
            // 
            // gdvProdutos
            // 
            this.gdvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.gdvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProdutos.Location = new System.Drawing.Point(13, 163);
            this.gdvProdutos.Name = "gdvProdutos";
            this.gdvProdutos.RowTemplate.Height = 25;
            this.gdvProdutos.Size = new System.Drawing.Size(1000, 410);
            this.gdvProdutos.TabIndex = 24;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.Location = new System.Drawing.Point(877, 587);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(136, 45);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Enabled = false;
            this.btnPagamentos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPagamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagamentos.Location = new System.Drawing.Point(278, 587);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(127, 45);
            this.btnPagamentos.TabIndex = 31;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPagamentos.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Enabled = false;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.Location = new System.Drawing.Point(544, 587);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(127, 45);
            this.btnImportar.TabIndex = 32;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.ColecaoItens = new string[] {
        "Inserir Clientes"};
            this.btnClientes.Enabled = false;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.Location = new System.Drawing.Point(12, 587);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(127, 45);
            this.btnClientes.TabIndex = 34;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.ColecaoItens = new string[] {
        "Checar Produtos",
        "Checar Unidades",
        "Inserir Produtos"};
            this.btnProdutos.Enabled = false;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProdutos.Location = new System.Drawing.Point(145, 587);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(127, 45);
            this.btnProdutos.TabIndex = 35;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnOperacoes
            // 
            this.btnOperacoes.ColecaoItens = new string[] {
        "Checar NFs",
        "Checar Operações"};
            this.btnOperacoes.Enabled = false;
            this.btnOperacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnOperacoes.Image")));
            this.btnOperacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOperacoes.Location = new System.Drawing.Point(411, 587);
            this.btnOperacoes.Name = "btnOperacoes";
            this.btnOperacoes.Size = new System.Drawing.Size(127, 45);
            this.btnOperacoes.TabIndex = 36;
            this.btnOperacoes.Text = "Operações";
            this.btnOperacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOperacoes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMovEntradas);
            this.groupBox2.Controls.Add(this.btnMovSaidas);
            this.groupBox2.Controls.Add(this.btnMovAll);
            this.groupBox2.Location = new System.Drawing.Point(804, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 52);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentações";
            // 
            // btnMovEntradas
            // 
            this.btnMovEntradas.AutoSize = true;
            this.btnMovEntradas.Enabled = false;
            this.btnMovEntradas.Location = new System.Drawing.Point(6, 22);
            this.btnMovEntradas.Name = "btnMovEntradas";
            this.btnMovEntradas.Size = new System.Drawing.Size(70, 19);
            this.btnMovEntradas.TabIndex = 10;
            this.btnMovEntradas.TabStop = true;
            this.btnMovEntradas.Text = "Entradas";
            this.btnMovEntradas.UseVisualStyleBackColor = true;
            // 
            // btnMovSaidas
            // 
            this.btnMovSaidas.AutoSize = true;
            this.btnMovSaidas.Enabled = false;
            this.btnMovSaidas.Location = new System.Drawing.Point(82, 22);
            this.btnMovSaidas.Name = "btnMovSaidas";
            this.btnMovSaidas.Size = new System.Drawing.Size(58, 19);
            this.btnMovSaidas.TabIndex = 11;
            this.btnMovSaidas.TabStop = true;
            this.btnMovSaidas.Text = "Saídas";
            this.btnMovSaidas.UseVisualStyleBackColor = true;
            // 
            // btnMovAll
            // 
            this.btnMovAll.AutoSize = true;
            this.btnMovAll.Enabled = false;
            this.btnMovAll.Location = new System.Drawing.Point(148, 22);
            this.btnMovAll.Name = "btnMovAll";
            this.btnMovAll.Size = new System.Drawing.Size(55, 19);
            this.btnMovAll.TabIndex = 12;
            this.btnMovAll.TabStop = true;
            this.btnMovAll.Text = "Todas";
            this.btnMovAll.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOperacoes);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gdvProdutos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportaTxt);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnModelo);
            this.Controls.Add(this.btnSerie);
            this.Controls.Add(this.btnDataFinal);
            this.Controls.Add(this.btnDataInicial);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.btnPorta);
            this.Controls.Add(this.btnServidor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Importador Sped";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImportaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdvProdutos;
        public System.Windows.Forms.TextBox btnServidor;
        public System.Windows.Forms.TextBox btnPorta;
        public System.Windows.Forms.TextBox btnBase;
        public System.Windows.Forms.Button btnConectar;
        public System.Windows.Forms.TextBox btnDataInicial;
        public System.Windows.Forms.TextBox btnDataFinal;
        public System.Windows.Forms.TextBox btnSerie;
        public System.Windows.Forms.TextBox btnModelo;
        public System.Windows.Forms.RadioButton btnChecaCodigo;
        public System.Windows.Forms.RadioButton btnChecaCodean;
        public System.Windows.Forms.RadioButton btnChecaCodAnt;
        public System.Windows.Forms.RadioButton btnChecaDescricao;
        public System.Windows.Forms.RadioButton btnChecaAll;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Button btnImportar;
        private SplitButtont btnClientes;
        private SplitButtont btnProdutos;
        private SplitButtont btnOperacoes;
        private GroupBox groupBox2;
        public RadioButton btnMovEntradas;
        public RadioButton btnMovSaidas;
        public RadioButton btnMovAll;
    }
}

