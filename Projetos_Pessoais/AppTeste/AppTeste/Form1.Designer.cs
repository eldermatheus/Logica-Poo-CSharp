namespace AppTeste
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ind_oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ind_emit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_sit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_entrada_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_pagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_nao_tributado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_mercadoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ind_frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_outras_despesas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_base_icms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_icms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_base_icms_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_icms_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_ipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_pis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_cofins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_pis_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_cofins_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.Ind_oper,
            this.Ind_emit,
            this.Codigo,
            this.Cod_mod,
            this.Cod_sit,
            this.Serie,
            this.Numero_doc,
            this.Chave,
            this.Data_emissao,
            this.Data_entrada_saida,
            this.Vl_doc,
            this.Cod_pagto,
            this.Vl_desconto,
            this.Vl_nao_tributado,
            this.Vl_mercadoria,
            this.Ind_frete,
            this.Vl_frete,
            this.Vl_seguro,
            this.Vl_outras_despesas,
            this.Vl_base_icms,
            this.Vl_icms,
            this.Vl_base_icms_st,
            this.Vl_icms_st,
            this.Vl_ipi,
            this.Vl_pis,
            this.Vl_cofins,
            this.Vl_pis_st,
            this.Vl_cofins_st});
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 531);
            this.dataGridView1.TabIndex = 1;
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "Registro";
            this.Registro.HeaderText = "Registro";
            this.Registro.Name = "Registro";
            // 
            // Ind_oper
            // 
            this.Ind_oper.DataPropertyName = "Ind_oper";
            this.Ind_oper.HeaderText = "Ind_oper";
            this.Ind_oper.Name = "Ind_oper";
            // 
            // Ind_emit
            // 
            this.Ind_emit.DataPropertyName = "Ind_emit";
            this.Ind_emit.HeaderText = "Ind_emit";
            this.Ind_emit.Name = "Ind_emit";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Cod_mod
            // 
            this.Cod_mod.DataPropertyName = "Cod_mod";
            this.Cod_mod.HeaderText = "Cod_mod";
            this.Cod_mod.Name = "Cod_mod";
            // 
            // Cod_sit
            // 
            this.Cod_sit.DataPropertyName = "Cod_sit";
            this.Cod_sit.HeaderText = "Cod_sit";
            this.Cod_sit.Name = "Cod_sit";
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "Serie";
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            // 
            // Numero_doc
            // 
            this.Numero_doc.DataPropertyName = "Numero_doc";
            this.Numero_doc.HeaderText = "Numero_doc";
            this.Numero_doc.Name = "Numero_doc";
            // 
            // Chave
            // 
            this.Chave.DataPropertyName = "Chave";
            this.Chave.HeaderText = "Chave";
            this.Chave.Name = "Chave";
            // 
            // Data_emissao
            // 
            this.Data_emissao.DataPropertyName = "Data_emissao";
            this.Data_emissao.HeaderText = "Data_emissao";
            this.Data_emissao.Name = "Data_emissao";
            // 
            // Data_entrada_saida
            // 
            this.Data_entrada_saida.DataPropertyName = "Data_entrada_saida";
            this.Data_entrada_saida.HeaderText = "Data_entrada_saida";
            this.Data_entrada_saida.Name = "Data_entrada_saida";
            // 
            // Vl_doc
            // 
            this.Vl_doc.DataPropertyName = "Vl_doc";
            this.Vl_doc.HeaderText = "Vl_doc";
            this.Vl_doc.Name = "Vl_doc";
            // 
            // Cod_pagto
            // 
            this.Cod_pagto.DataPropertyName = "Cod_pagto";
            this.Cod_pagto.HeaderText = "Cod_pagto";
            this.Cod_pagto.Name = "Cod_pagto";
            // 
            // Vl_desconto
            // 
            this.Vl_desconto.DataPropertyName = "Vl_desconto";
            this.Vl_desconto.HeaderText = "Vl_desconto";
            this.Vl_desconto.Name = "Vl_desconto";
            // 
            // Vl_nao_tributado
            // 
            this.Vl_nao_tributado.DataPropertyName = "Vl_nao_tributado";
            this.Vl_nao_tributado.HeaderText = "Vl_nao_tributado";
            this.Vl_nao_tributado.Name = "Vl_nao_tributado";
            // 
            // Vl_mercadoria
            // 
            this.Vl_mercadoria.DataPropertyName = "Vl_mercadoria";
            this.Vl_mercadoria.HeaderText = "Vl_mercadoria";
            this.Vl_mercadoria.Name = "Vl_mercadoria";
            // 
            // Ind_frete
            // 
            this.Ind_frete.DataPropertyName = "Ind_frete";
            this.Ind_frete.HeaderText = "Ind_frete";
            this.Ind_frete.Name = "Ind_frete";
            // 
            // Vl_frete
            // 
            this.Vl_frete.DataPropertyName = "Vl_frete";
            this.Vl_frete.HeaderText = "Vl_frete";
            this.Vl_frete.Name = "Vl_frete";
            // 
            // Vl_seguro
            // 
            this.Vl_seguro.DataPropertyName = "Vl_seguro";
            this.Vl_seguro.HeaderText = "Vl_seguro";
            this.Vl_seguro.Name = "Vl_seguro";
            // 
            // Vl_outras_despesas
            // 
            this.Vl_outras_despesas.DataPropertyName = "Vl_outras_despesas";
            this.Vl_outras_despesas.HeaderText = "Vl_outras_despesas";
            this.Vl_outras_despesas.Name = "Vl_outras_despesas";
            // 
            // Vl_base_icms
            // 
            this.Vl_base_icms.DataPropertyName = "Vl_base_icms";
            this.Vl_base_icms.HeaderText = "Vl_base_icms";
            this.Vl_base_icms.Name = "Vl_base_icms";
            // 
            // Vl_icms
            // 
            this.Vl_icms.DataPropertyName = "Vl_icms";
            this.Vl_icms.HeaderText = "Vl_icms";
            this.Vl_icms.Name = "Vl_icms";
            // 
            // Vl_base_icms_st
            // 
            this.Vl_base_icms_st.DataPropertyName = "Vl_base_icms_st";
            this.Vl_base_icms_st.HeaderText = "Vl_base_icms_st";
            this.Vl_base_icms_st.Name = "Vl_base_icms_st";
            // 
            // Vl_icms_st
            // 
            this.Vl_icms_st.DataPropertyName = "Vl_icms_st";
            this.Vl_icms_st.HeaderText = "Vl_icms_st";
            this.Vl_icms_st.Name = "Vl_icms_st";
            // 
            // Vl_ipi
            // 
            this.Vl_ipi.DataPropertyName = "Vl_ipi";
            this.Vl_ipi.HeaderText = "Vl_ipi";
            this.Vl_ipi.Name = "Vl_ipi";
            // 
            // Vl_pis
            // 
            this.Vl_pis.DataPropertyName = "Vl_pis";
            this.Vl_pis.HeaderText = "Vl_pis";
            this.Vl_pis.Name = "Vl_pis";
            // 
            // Vl_cofins
            // 
            this.Vl_cofins.DataPropertyName = "Vl_cofins";
            this.Vl_cofins.HeaderText = "Vl_cofins";
            this.Vl_cofins.Name = "Vl_cofins";
            // 
            // Vl_pis_st
            // 
            this.Vl_pis_st.DataPropertyName = "Vl_pis_st";
            this.Vl_pis_st.HeaderText = "Vl_pis_st";
            this.Vl_pis_st.Name = "Vl_pis_st";
            // 
            // Vl_cofins_st
            // 
            this.Vl_cofins_st.DataPropertyName = "Vl_cofins_st";
            this.Vl_cofins_st.HeaderText = "Vl_cofins_st";
            this.Vl_cofins_st.Name = "Vl_cofins_st";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Importador-NFe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Numero_docf;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Registro;
        private DataGridViewTextBoxColumn Ind_oper;
        private DataGridViewTextBoxColumn Ind_emit;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Cod_mod;
        private DataGridViewTextBoxColumn Cod_sit;
        private DataGridViewTextBoxColumn Serie;
        private DataGridViewTextBoxColumn Numero_doc;
        private DataGridViewTextBoxColumn Chave;
        private DataGridViewTextBoxColumn Data_emissao;
        private DataGridViewTextBoxColumn Data_entrada_saida;
        private DataGridViewTextBoxColumn Vl_doc;
        private DataGridViewTextBoxColumn Cod_pagto;
        private DataGridViewTextBoxColumn Vl_desconto;
        private DataGridViewTextBoxColumn Vl_nao_tributado;
        private DataGridViewTextBoxColumn Vl_mercadoria;
        private DataGridViewTextBoxColumn Ind_frete;
        private DataGridViewTextBoxColumn Vl_frete;
        private DataGridViewTextBoxColumn Vl_seguro;
        private DataGridViewTextBoxColumn Vl_outras_despesas;
        private DataGridViewTextBoxColumn Vl_base_icms;
        private DataGridViewTextBoxColumn Vl_icms;
        private DataGridViewTextBoxColumn Vl_base_icms_st;
        private DataGridViewTextBoxColumn Vl_icms_st;
        private DataGridViewTextBoxColumn Vl_ipi;
        private DataGridViewTextBoxColumn Vl_pis;
        private DataGridViewTextBoxColumn Vl_cofins;
        private DataGridViewTextBoxColumn Vl_pis_st;
        private DataGridViewTextBoxColumn Vl_cofins_st;
    }
}