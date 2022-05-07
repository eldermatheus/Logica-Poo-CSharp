using System.Data;

namespace AppTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            unidades.Columns.Add("Registro", typeof(string));
            unidades.Columns.Add("Codigo", typeof(string));
            unidades.Columns.Add("Descricao", typeof(string));

            participantes.Columns.Add("Registro", typeof(string));
            participantes.Columns.Add("Codigo", typeof(string));
            participantes.Columns.Add("Nome", typeof(string));
            participantes.Columns.Add("Cod_pais", typeof(string));
            participantes.Columns.Add("Cnpj", typeof(string));
            participantes.Columns.Add("Cpf", typeof(string));
            participantes.Columns.Add("Ie", typeof(string));
            participantes.Columns.Add("Cod_municipio", typeof(string));
            participantes.Columns.Add("Suframa", typeof(string));
            participantes.Columns.Add("Endereco", typeof(string));
            participantes.Columns.Add("Numero", typeof(string));
            participantes.Columns.Add("Complemento", typeof(string));
            participantes.Columns.Add("Bairro", typeof(string));

            produtos.Columns.Add("Registro", typeof(string));
            produtos.Columns.Add("Codigo", typeof(string));
            produtos.Columns.Add("Descricao", typeof(string));
            produtos.Columns.Add("Codean", typeof(string));
            produtos.Columns.Add("Cod_anterior", typeof(string));
            produtos.Columns.Add("Unidade", typeof(string));
            produtos.Columns.Add("Tipo_item", typeof(string));
            produtos.Columns.Add("Ncm", typeof(string));
            produtos.Columns.Add("Ex_ipi", typeof(string));
            produtos.Columns.Add("Genero", typeof(string));
            produtos.Columns.Add("Cod_list", typeof(string));
            produtos.Columns.Add("Aliq_icms", typeof(string));
            produtos.Columns.Add("Cest", typeof(string));


            operacoes.Columns.Add("Registro", typeof(string));
            operacoes.Columns.Add("Codigo", typeof(string));
            operacoes.Columns.Add("Descricao", typeof(string));

            registroC100.Columns.Add("Registro", typeof(string));
            registroC100.Columns.Add("Ind_oper", typeof(string));
            registroC100.Columns.Add("Ind_emit", typeof(string));
            registroC100.Columns.Add("Codigo", typeof(string));
            registroC100.Columns.Add("Cod_mod", typeof(string));
            registroC100.Columns.Add("Cod_sit", typeof(string));
            registroC100.Columns.Add("Serie", typeof(string));
            registroC100.Columns.Add("Numero_doc", typeof(string));
            registroC100.Columns.Add("Chave", typeof(string));
            registroC100.Columns.Add("Data_emissao", typeof(string));
            registroC100.Columns.Add("Data_entrada_saida", typeof(string));
            registroC100.Columns.Add("Vl_doc", typeof(string));
            registroC100.Columns.Add("Cod_pagto", typeof(string));
            registroC100.Columns.Add("Vl_desconto", typeof(string));
            registroC100.Columns.Add("Vl_nao_tributado", typeof(string));
            registroC100.Columns.Add("Vl_mercadoria", typeof(string));
            registroC100.Columns.Add("Ind_frete", typeof(string));
            registroC100.Columns.Add("Vl_frete", typeof(string));
            registroC100.Columns.Add("Vl_seguro", typeof(string));
            registroC100.Columns.Add("Vl_outras_despesas", typeof(string));
            registroC100.Columns.Add("Vl_base_icms", typeof(string));
            registroC100.Columns.Add("Vl_icms", typeof(string));
            registroC100.Columns.Add("Vl_base_icms_st", typeof(string));
            registroC100.Columns.Add("Vl_icms_st", typeof(string));
            registroC100.Columns.Add("Vl_ipi", typeof(string));
            registroC100.Columns.Add("Vl_pis", typeof(string));
            registroC100.Columns.Add("Vl_cofins", typeof(string));
            registroC100.Columns.Add("Vl_pis_st", typeof(string));
            registroC100.Columns.Add("Vl_cofins_st", typeof(string));

            registroC190.Columns.Add("Registro", typeof(string));
            registroC190.Columns.Add("Cst_icms", typeof(string));
            registroC190.Columns.Add("Cfop", typeof(string));
            registroC190.Columns.Add("Aliq_icms", typeof(string));
            registroC190.Columns.Add("Vl_opr", typeof(string));
            registroC190.Columns.Add("Vl_bc_icms", typeof(string));
            registroC190.Columns.Add("Vl_icms", typeof(string));
            registroC190.Columns.Add("Vl_bc_icms_St", typeof(string));
            registroC190.Columns.Add("Vl_icms_st", typeof(string));
            registroC190.Columns.Add("Vl_red_bc", typeof(string));
            registroC190.Columns.Add("Vl_ipi", typeof(string));
            registroC190.Columns.Add("Cod_obs", typeof(string));
        }

        DataTable unidades = new DataTable();
        DataTable produtos = new DataTable();
        DataTable participantes = new DataTable();
        DataTable operacoes = new DataTable();
        DataTable registroC100 = new DataTable();
        DataTable registroC190 = new DataTable();
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirAquivo = new OpenFileDialog();

            if (abrirAquivo.ShowDialog() == DialogResult.OK)
            {
                string FileName = abrirAquivo.FileName;
                string SafeFileName = abrirAquivo.SafeFileName;
                string[] rows = File.ReadAllLines(FileName);

                foreach (string item in rows)
                {
                    string[] columns = item.Split('|');

                    switch (columns[1])
                    {
                        case "0150":
                            DataRow resultReg0150 = LerCampos.Registro(columns, participantes);
                            participantes.Rows.Add(resultReg0150);
                        break;

                        case "0190":
                            DataRow resultReg0190 = LerCampos.Registro(columns, unidades);
                            unidades.Rows.Add(resultReg0190);                            
                            break;

                        case "0200":
                            DataRow resultReg0200 = LerCampos.Registro(columns, produtos);
                            produtos.Rows.Add(resultReg0200);
                            break;

                        case "0400":
                            DataRow resultReg0400 = LerCampos.Registro(columns, operacoes);
                            operacoes.Rows.Add(resultReg0400);
                            break;

                        case "C100":
                            DataRow resultRegC100 = LerCampos.Registro(columns, registroC100);
                            registroC100.Rows.Add(resultRegC100);
                            break;                        

                        case "C190":
                            DataRow resultRegC190 = LerCampos.Registro(columns, registroC190);
                            registroC190.Rows.Add(resultRegC190);
                            break;
                    }
                }
            }

            /*dataGridView1.DataSource = unidades;
            dataGridView2.DataSource = participantes;
            dataGridView3.DataSource = produtos;
            dataGridView4.DataSource = operacoes;*/
            dataGridView1.DataSource = registroC100;
            

        }

    }
}
