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
    public partial class Corretor : Form
    {
        private ControleCorretor _Control = new ControleCorretor();
        private bool Alterar = false;
        private Corretor oCorretorAlterado = null;
        public Corretor()
        {
            InitializeComponent();
            DesabilitaCampos();
        }
        public void CarregaCombo()
        {
            Dgv_Corretor.DataSource = _Control.SelecionarTodos();
        }
        public void DesabilitaCampos()
        {
            btnAlterarCorretor.Enabled = false;
            btnRemoverCorretor.Enabled = false;
            Dgv_Corretor.Visible = false;
        }
        public void HabilitaCampos()
        {
            btnAlterarCorretor.Enabled = true;
            btnRemoverCorretor.Enabled = true;
            Dgv_Corretor.Visible = true;
        }
        public void limpaCampos()
        {
            txtNomeCorretor.Clear();
            txtEmailCorretor.Clear();
            n_TelefoneCorretor.Clear();
            n_CPFCorretor.Clear();
            dt_NascimentoCorretor.Clear();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCorretor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeCorretor.Focus();
            }
            else if (txtEmailCorretor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Email.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailCorretor.Focus();
            }
            else if (n_TelefoneCorretor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Telefone.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                n_TelefoneCorretor.Focus();
            }
            else if (n_CPFCorretor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                n_CPFCorretor.Focus();
            }
            else if (dt_NascimentoCorretor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Data de Nascimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt_NascimentoCorretor.Focus();
            }
            else
            {
                if (btnSalvarCorretor.Text != "Modificar")
                {
                    model.Corretor oCorretor = new model.Corretor();
                    oCorretor.NmCorretor = txtNomeCorretor.Text;
                    oCorretor.Email = txtEmailCorretor.Text;
                    oCorretor.Telefone = n_TelefoneCorretor.Text;
                    oCorretor.Cpf = n_CPFCorretor.Text;
                    oCorretor.DataNascimento = dt_NascimentoCorretor.Text;

                    _Control.Incluir(oCorretor);
                    MessageBox.Show("Dados salvos com sucesso!", "Salvamento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    model.Corretor oCorretorAlterado = new model.Corretor();

                    oCorretorAlterado.NmCorretor = txtNomeCorretor.Text;
                    oCorretorAlterado.Email = txtEmailCorretor.Text;
                    oCorretorAlterado.Telefone = n_TelefoneCorretor.Text;
                    oCorretorAlterado.Cpf = n_CPFCorretor.Text;
                    oCorretorAlterado.DataNascimento = dt_NascimentoCorretor.Text;
                    oCorretorAlterado.CdCorretor = Convert.ToInt32(lblid.Text);


                    _Control.Alterar(oCorretorAlterado);

                    btnSalvarCorretor.Text = "Salvar";

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
                int ind = Dgv_Corretor.CurrentCell.RowIndex;
                string cd = Convert.ToString(Dgv_Corretor.Rows[ind].Cells[0].Value);
                int cdCorretor = int.Parse(cd);
                _Control.Remover(cdCorretor);
                CarregaCombo();
                MessageBox.Show("Exclusão realizada com sucesso!!", "Exclusão de Registro Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DesabilitaCampos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int ind = Dgv_Corretor.CurrentCell.RowIndex;
            string id = Convert.ToString(Dgv_Corretor.Rows[ind].Cells[0].Value);
            string Nome = Convert.ToString(Dgv_Corretor.Rows[ind].Cells[1].Value).TrimEnd();
            string Email = Convert.ToString(Dgv_Corretor.Rows[ind].Cells[2].Value).TrimEnd();
            string Telefone = Convert.ToString(Dgv_Corretor.Rows[ind].Cells[3].Value).TrimEnd();
            string CPF = Convert.ToString(Dgv_Corretor.Rows[ind].Cells[4].Value).TrimEnd();
            string DataNascimento = Convert.ToString(Dgv_Corretor.Rows[ind].Cells[5].Value).TrimEnd();

            lblid.Text = id;
            btnSalvarCorretor.Text = "Modificar";
            txtNomeCorretor.Text = Nome;
            txtEmailCorretor.Text = Email;
            n_TelefoneCorretor.Text = Telefone;
            n_CPFCorretor.Text = CPF;
            dt_NascimentoCorretor.Text = DataNascimento;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            DesabilitaCampos();
            btnSalvarCorretor.Text = "Salvar";
        }
    }
}
