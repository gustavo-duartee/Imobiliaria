using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imobiliaria.model;
using Imobiliaria.model.Repositories;
using Imobiliaria.view.Control;

namespace Imobiliaria.view
{
    public partial class Imovel : Form
    {
        public Imovel()
        {
            InitializeComponent();
            DesabilitaCampos();
        }
        private ControleImoveis _Control = new ControleImoveis();
        private bool Alterar = false;
        private Imovel oClienteAlterado = null;
       
        public void CarregaCombo()
        {
            Dgv_Imoveis.DataSource = _Control.SelecionarTodos();
        }
        public void DesabilitaCampos()
        {
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            Dgv_Imoveis.Visible = false;
        }
        public void HabilitaCampos()
        {
            btnAlterar.Enabled = true;
            btnRemover.Enabled = true;
            Dgv_Imoveis.Visible = true;
        }
        
        public void limpaCampos()
        {
            txtEndereço.Clear();
            cmbQuartos.SelectedIndex = -1;
            cmbBanheiros.SelectedIndex = -1;
            cmbGaragem.SelectedIndex = -1;
            cmbAndares.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbLavanderia.SelectedIndex = -1;
            txtTamanho.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            n_CEP.Clear();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtEndereço.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Endereço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereço.Focus();
            }

            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }
            else if (cmbQuartos.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Quartos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbQuartos.Focus();
            }
            else if (cmbBanheiros.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Banheiros.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBanheiros.Focus();
            }
            else if (cmbGaragem.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Garagem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGaragem.Focus();
            }
            else if (cmbAndares.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Andares.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAndares.Focus();
            }
            else if (txtTamanho.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Tamanho.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTamanho.Focus();
            }
            else if (cmbTipo.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Tipo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTipo.Focus();
            }
            else
            {
                if (btnSalvar.Text != "Modificar")
                {
                    model.Imoveis oImoveis = new model.Imoveis();
                    oImoveis.Endereço = txtEndereço.Text;
                    oImoveis.Cidade = txtCidade.Text;
                    oImoveis.Quartos = cmbQuartos.Text;
                    oImoveis.Banheiros = cmbBanheiros.Text;
                    oImoveis.Garagem = cmbGaragem.Text;
                    oImoveis.Andares = cmbAndares.Text;
                    oImoveis.Tamanho = txtTamanho.Text;
                    oImoveis.Tipo = cmbTipo.Text;
                    oImoveis.Bairro = txtBairro.Text;
                    oImoveis.Cep = n_CEP.Text;
                    oImoveis.Lavanderia = cmbLavanderia.Text;

                    _Control.Incluir(oImoveis);
                    MessageBox.Show("Dados salvos com sucesso!", "Salvamento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    model.Imoveis oImoveisAlterado = new model.Imoveis();

                    oImoveisAlterado.Endereço = txtEndereço.Text;
                    oImoveisAlterado.Cidade = txtCidade.Text;
                    oImoveisAlterado.Quartos = cmbQuartos.Text;
                    oImoveisAlterado.Banheiros = cmbBanheiros.Text;
                    oImoveisAlterado.Garagem = cmbGaragem.Text;
                    oImoveisAlterado.Andares = cmbAndares.Text;
                    oImoveisAlterado.Tamanho = txtTamanho.Text;
                    oImoveisAlterado.Tipo = cmbTipo.Text;
                    oImoveisAlterado.Bairro = txtBairro.Text;
                    oImoveisAlterado.Cep = n_CEP.Text;
                    oImoveisAlterado.Lavanderia = cmbLavanderia.Text;

                    oImoveisAlterado.CdImovel = Convert.ToInt32(lblid.Text);


                    _Control.Alterar(oImoveisAlterado);

                    btnSalvar.Text = "Salvar";
                    MessageBox.Show("Dados alterados com sucesso!", "Alteração concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                HabilitaCampos();
                CarregaCombo();
                limpaCampos();
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregaCombo();
            HabilitaCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover esse registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exclusao == DialogResult.Yes)
            {
                int ind = Dgv_Imoveis.CurrentCell.RowIndex;
                string cd = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[0].Value);
                int cdCorretor = int.Parse(cd);
                _Control.Remover(cdCorretor);
                CarregaCombo();
                MessageBox.Show("Exclusão realizada com sucesso!!", "Exclusão de Registro Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DesabilitaCampos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int ind = Dgv_Imoveis.CurrentCell.RowIndex;

            string id = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[0].Value);
            string Endereço = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[1].Value).TrimEnd();
            string Cidade = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[2].Value).TrimEnd();
            string Bairro = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[3].Value).TrimEnd();
            string Cep = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[4].Value).TrimEnd();
            string Quartos = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[5].Value).TrimEnd();
            string Banheiros = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[6].Value).TrimEnd();
            string Garagem = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[7].Value).TrimEnd();
            string Andares = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[8].Value).TrimEnd();
            string Tamanho = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[9].Value).TrimEnd();
            string Tipo = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[10].Value).TrimEnd();
            string Lavanderia = Convert.ToString(Dgv_Imoveis.Rows[ind].Cells[11].Value).TrimEnd();

            lblid.Text = id;
            btnSalvar.Text = "Modificar";
            txtEndereço.Text = Endereço;
            txtCidade.Text = Cidade;
            cmbQuartos.Text = Quartos;
            cmbBanheiros.Text = Banheiros;
            cmbGaragem.Text = Garagem;
            cmbAndares.Text = Andares;
            txtTamanho.Text = Tamanho;
            cmbTipo.Text = Tipo;
            txtBairro.Text = Bairro;
            n_CEP.Text = Cep;
            cmbLavanderia.Text = Lavanderia;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            DesabilitaCampos();
            btnSalvar.Text = "Salvar";
        }
    }
}




/*
cmbQuartos.Enabled = true;
cmbBanheiros.Enabled = true;
cmbGaragem.Enabled = true;
cmbAndares.Enabled = true;
cmbTipo.Enabled = true;
cmbLavanderia.Enabled = true;*/