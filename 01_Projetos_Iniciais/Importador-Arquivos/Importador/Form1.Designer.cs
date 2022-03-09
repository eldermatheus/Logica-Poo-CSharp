
namespace Importador
{
    partial class ZImportador
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
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer3 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            this.splitButton1 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton2 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.splitButton4 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.btnServidor = new System.Windows.Forms.TextBox();
            this.btnPorta = new System.Windows.Forms.TextBox();
            this.btnBase = new System.Windows.Forms.TextBox();
            this.btnDataInicial = new System.Windows.Forms.TextBox();
            this.btnDataFinal = new System.Windows.Forms.TextBox();
            this.btnSerie = new System.Windows.Forms.TextBox();
            this.btnModelo = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnImportaTxt = new System.Windows.Forms.Button();
            this.btnChecaProd = new System.Windows.Forms.RadioButton();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitButton1
            // 
            this.splitButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitButton1.BeforeTouchSize = new System.Drawing.Size(118, 41);
            this.splitButton1.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton1.ForeColor = System.Drawing.Color.Black;
            this.splitButton1.Location = new System.Drawing.Point(13, 587);
            this.splitButton1.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton1.Name = "splitButton1";
            splitButtonRenderer1.SplitButton = this.splitButton1;
            this.splitButton1.Renderer = splitButtonRenderer1;
            this.splitButton1.ShowDropDownOnButtonClick = false;
            this.splitButton1.Size = new System.Drawing.Size(118, 41);
            this.splitButton1.TabIndex = 25;
            this.splitButton1.Text = "Clientes";
            this.splitButton1.Click += new System.EventHandler(this.splitButton1_Click);
            // 
            // splitButton2
            // 
            this.splitButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitButton2.BeforeTouchSize = new System.Drawing.Size(118, 41);
            this.splitButton2.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton2.ForeColor = System.Drawing.Color.Black;
            this.splitButton2.Location = new System.Drawing.Point(137, 587);
            this.splitButton2.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton2.Name = "splitButton2";
            splitButtonRenderer2.SplitButton = this.splitButton2;
            this.splitButton2.Renderer = splitButtonRenderer2;
            this.splitButton2.ShowDropDownOnButtonClick = false;
            this.splitButton2.Size = new System.Drawing.Size(118, 41);
            this.splitButton2.TabIndex = 26;
            this.splitButton2.Text = "Produtos";
            // 
            // splitButton4
            // 
            this.splitButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitButton4.BeforeTouchSize = new System.Drawing.Size(118, 41);
            this.splitButton4.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton4.ForeColor = System.Drawing.Color.Black;
            this.splitButton4.Location = new System.Drawing.Point(380, 587);
            this.splitButton4.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton4.Name = "splitButton4";
            splitButtonRenderer3.SplitButton = this.splitButton4;
            this.splitButton4.Renderer = splitButtonRenderer3;
            this.splitButton4.ShowDropDownOnButtonClick = false;
            this.splitButton4.Size = new System.Drawing.Size(118, 41);
            this.splitButton4.TabIndex = 28;
            this.splitButton4.Text = "Checar Produtos";
            // 
            // btnServidor
            // 
            this.btnServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnServidor.Location = new System.Drawing.Point(13, 34);
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.Size = new System.Drawing.Size(100, 23);
            this.btnServidor.TabIndex = 0;
            this.btnServidor.TextChanged += new System.EventHandler(this.btnServidor_TextChanged);
            // 
            // btnPorta
            // 
            this.btnPorta.Location = new System.Drawing.Point(240, 33);
            this.btnPorta.Name = "btnPorta";
            this.btnPorta.Size = new System.Drawing.Size(52, 23);
            this.btnPorta.TabIndex = 2;
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(124, 33);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(104, 23);
            this.btnBase.TabIndex = 1;
            // 
            // btnDataInicial
            // 
            this.btnDataInicial.Location = new System.Drawing.Point(12, 120);
            this.btnDataInicial.Name = "btnDataInicial";
            this.btnDataInicial.Size = new System.Drawing.Size(96, 23);
            this.btnDataInicial.TabIndex = 6;
            // 
            // btnDataFinal
            // 
            this.btnDataFinal.Location = new System.Drawing.Point(123, 120);
            this.btnDataFinal.Name = "btnDataFinal";
            this.btnDataFinal.Size = new System.Drawing.Size(100, 23);
            this.btnDataFinal.TabIndex = 7;
            // 
            // btnSerie
            // 
            this.btnSerie.Location = new System.Drawing.Point(238, 120);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(49, 23);
            this.btnSerie.TabIndex = 8;
            // 
            // btnModelo
            // 
            this.btnModelo.Location = new System.Drawing.Point(305, 120);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(52, 23);
            this.btnModelo.TabIndex = 9;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConectar.Location = new System.Drawing.Point(309, 5);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(142, 51);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.button1_Click);
            this.btnConectar.MouseCaptureChanged += new System.EventHandler(this.button1_Click_2);
            // 
            // btnImportaTxt
            // 
            this.btnImportaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImportaTxt.Location = new System.Drawing.Point(766, 5);
            this.btnImportaTxt.Name = "btnImportaTxt";
            this.btnImportaTxt.Size = new System.Drawing.Size(135, 49);
            this.btnImportaTxt.TabIndex = 5;
            this.btnImportaTxt.Text = "Carregar TXT";
            this.btnImportaTxt.UseVisualStyleBackColor = false;
            this.btnImportaTxt.Click += new System.EventHandler(this.btnImportaTxt_Click);
            // 
            // btnChecaProd
            // 
            this.btnChecaProd.AutoSize = true;
            this.btnChecaProd.Location = new System.Drawing.Point(6, 22);
            this.btnChecaProd.Name = "btnChecaProd";
            this.btnChecaProd.Size = new System.Drawing.Size(64, 19);
            this.btnChecaProd.TabIndex = 10;
            this.btnChecaProd.TabStop = true;
            this.btnChecaProd.Text = "Código";
            this.btnChecaProd.UseVisualStyleBackColor = true;
            this.btnChecaProd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnChecaCodean
            // 
            this.btnChecaCodean.AutoSize = true;
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
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Porta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 16);
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
            this.groupBox1.Controls.Add(this.btnChecaProd);
            this.groupBox1.Controls.Add(this.btnChecaCodean);
            this.groupBox1.Controls.Add(this.btnChecaCodAnt);
            this.groupBox1.Controls.Add(this.btnChecaDescricao);
            this.groupBox1.Location = new System.Drawing.Point(431, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 52);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checagem de Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 410);
            this.dataGridView1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(877, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 30;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(261, 587);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 41);
            this.button2.TabIndex = 31;
            this.button2.Text = "Pagamentos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 587);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 41);
            this.button3.TabIndex = 32;
            this.button3.Text = "Importar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(641, 599);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 23);
            this.progressBar1.TabIndex = 33;
            // 
            // ZImportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 640);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitButton4);
            this.Controls.Add(this.splitButton2);
            this.Controls.Add(this.splitButton1);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "ZImportador";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox btnServidor;
        public System.Windows.Forms.TextBox btnPorta;
        public System.Windows.Forms.TextBox btnBase;
        public System.Windows.Forms.Button btnConectar;
        public System.Windows.Forms.TextBox btnDataInicial;
        public System.Windows.Forms.TextBox btnDataFinal;
        public System.Windows.Forms.TextBox btnSerie;
        public System.Windows.Forms.TextBox btnModelo;
        public System.Windows.Forms.RadioButton btnChecaProd;
        public System.Windows.Forms.RadioButton btnChecaCodean;
        public System.Windows.Forms.RadioButton btnChecaCodAnt;
        public System.Windows.Forms.RadioButton btnChecaDescricao;
        public System.Windows.Forms.RadioButton btnChecaAll;
        private Syncfusion.Windows.Forms.Tools.SplitButton splitButton1;
        private Syncfusion.Windows.Forms.Tools.SplitButton splitButton2;
        private Syncfusion.Windows.Forms.Tools.SplitButton splitButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

