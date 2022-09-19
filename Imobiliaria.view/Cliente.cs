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
    public partial class Cliente : Form
    {
        private ControleCliente _Control = new ControleCliente();
        private bool Alterar = false;
        private Cliente oClienteAlterado = null;
        public Cliente()
        {
            InitializeComponent();
            DesabilitaCampos();
        }
        public void CarregaCombo()
        {
            Dgv_Cliente.DataSource = _Control.SelecionarTodos();
        }
        public void DesabilitaCampos()
        {
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            Dgv_Cliente.Visible = false;
        }
        public void HabilitaCampos()
        {
            btnAlterar.Enabled = true;
            btnRemover.Enabled = true;
            Dgv_Cliente.Visible = true;
        }
        public void limpaCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            n_Telefone.Clear();
            n_CPF.Clear();
            dt_Nascimento.Clear();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Email.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (n_Telefone.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Telefone.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                n_Telefone.Focus();
            }
            else if (n_CPF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                n_CPF.Focus();
            }
            else if (dt_Nascimento.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Data de Nascimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_Nascimento.Focus();
            }
            else
            {
                if (btnSalvar.Text != "Modificar")
                {
                    model.Cliente oCliente = new model.Cliente();
                    oCliente.NmCliente = txtNome.Text;
                    oCliente.Email = txtEmail.Text;
                    oCliente.Telefone = n_Telefone.Text;
                    oCliente.Cpf = n_CPF.Text;
                    oCliente.DataNascimento = dt_Nascimento.Text;

                    _Control.Incluir(oCliente);
                    MessageBox.Show("Dados salvos com sucesso!", "Salvamento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    model.Cliente oClienteAlterado = new model.Cliente();

                    oClienteAlterado.NmCliente = txtNome.Text;
                    oClienteAlterado.Email = txtEmail.Text;
                    oClienteAlterado.Telefone = n_Telefone.Text;
                    oClienteAlterado.Cpf = n_CPF.Text;
                    oClienteAlterado.DataNascimento = dt_Nascimento.Text;
                    oClienteAlterado.CdCliente = Convert.ToInt32(lblid.Text);

                    
                    _Control.Alterar(oClienteAlterado);

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int ind = Dgv_Cliente.CurrentCell.RowIndex;
            string id = Convert.ToString(Dgv_Cliente.Rows[ind].Cells[0].Value);
            string Nome = Convert.ToString(Dgv_Cliente.Rows[ind].Cells[1].Value).TrimEnd();
            string Email = Convert.ToString(Dgv_Cliente.Rows[ind].Cells[2].Value).TrimEnd();
            string Telefone = Convert.ToString(Dgv_Cliente.Rows[ind].Cells[3].Value).TrimEnd();
            string CPF = Convert.ToString(Dgv_Cliente.Rows[ind].Cells[4].Value).TrimEnd();
            string DataNascimento = Convert.ToString(Dgv_Cliente.Rows[ind].Cells[5].Value).TrimEnd();

            lblid.Text = id;
            btnSalvar.Text = "Modificar";
            txtNome.Text = Nome;
            txtEmail.Text = Email;
            n_Telefone.Text = Telefone;
            n_CPF.Text = CPF;
            dt_Nascimento.Text = DataNascimento;

        }                  

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover esse registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exclusao == DialogResult.Yes)
            {
                int ind = Dgv_Cliente.CurrentCell.RowIndex;
                string cd = Convert.ToString(Dgv_Cliente.Rows[ind].Cells[0].Value);
                int cdCliente = int.Parse(cd);
                _Control.Remover(cdCliente);
                CarregaCombo();
                MessageBox.Show("Exclusão realizada com sucesso!!", "Exclusão de Registro Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DesabilitaCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            DesabilitaCampos();
            btnSalvar.Text = "Salvar";
        }
    }
}

