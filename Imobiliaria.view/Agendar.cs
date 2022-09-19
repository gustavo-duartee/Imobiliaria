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
    public partial class Agendar : Form
    {

        private ControleImoveis _ControlImoveis = new ControleImoveis();
        private ControleCliente _ControlCliente = new ControleCliente();
        private ControleCorretor _ControlCorretor = new ControleCorretor();
        private ControleAgendar _ControlAgendar = new ControleAgendar();

        private bool Alterar = false;
        private Agendar oAgendarAlterado = null;

        public Agendar()
        {
            InitializeComponent();
            DesabilitaCampos();
        }
        public void CarregaComboImovel()
        {
            Dgv_Imoveis.DataSource = _ControlImoveis.SelecionarTodos();
        }
        public void CarregaComboCliente()
        {
            Dgv_Cliente.DataSource = _ControlCliente.SelecionarTodos();
        }
        public void CarregaComboCorretor()
        {
            Dgv_Corretor.DataSource = _ControlCorretor.SelecionarTodos();
        }
        public void CarregaComboAgendar()
        {
            Dgv_Agendar.DataSource = _ControlAgendar.SelecionarTodos();

            Dgv_Cliente.Visible = false;
            Dgv_Imoveis.Visible = false;
            Dgv_Agendar.Visible = true;
            Dgv_Corretor.Visible = false;

        }
        public void DesabilitaCampos()
        {
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            Dgv_Agendar.Visible = false;
            Dgv_Imoveis.Visible = false;
            Dgv_Cliente.Visible = false;
            Dgv_Corretor.Visible = false;
        }
        public void HabilitaCampos()
        {
            btnAlterar.Enabled = true;
            btnRemover.Enabled = true;
            Dgv_Agendar.Visible = true;
        }
        public void limpaCampos()
        {
            cdCliente.Clear();
            cdCorretor.Clear();
            cdImovel.Clear();
            cmbValor.Clear();
        }
        private void btnListarImovel_Click(object sender, EventArgs e)
        {
            CarregaComboImovel();
            Dgv_Cliente.Visible = false;
            Dgv_Imoveis.Visible = true;
            Dgv_Agendar.Visible = false;
            Dgv_Corretor.Visible = false;
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            CarregaComboCliente();
            Dgv_Cliente.Visible = true;
            Dgv_Imoveis.Visible = false;
            Dgv_Agendar.Visible = false;
            Dgv_Corretor.Visible = false;
        }

        private void btnListarCorretor_Click(object sender, EventArgs e)
        {
            CarregaComboCorretor();
            Dgv_Cliente.Visible = false;
            Dgv_Imoveis.Visible = false;
            Dgv_Agendar.Visible = false;
            Dgv_Corretor.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cdCliente.Text == "")
            {
                MessageBox.Show("Obrigatório informar o código do Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cdCliente.Focus();
            }
            else if (cdCorretor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o código do Corretor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cdCorretor.Focus();
            }
            else if (cdImovel.Text == "")
            {
                MessageBox.Show("Obrigatório informar o código do Imovel.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cdImovel.Focus();
            }
            else if (cmbValor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o Valor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbValor.Focus();
            }
            else
            {
                if (btnSalvar.Text != "Modificar")
                {
                    model.Agendar oAgendar = new model.Agendar();
                    oAgendar.CdCliente = cdCliente.Text;
                    oAgendar.CdCorretor = cdCorretor.Text;
                    oAgendar.CdImovel = cdImovel.Text;
                    oAgendar.DataAgendada = cmbValor.Text;



                    _ControlAgendar.Incluir(oAgendar);
                    MessageBox.Show("Dados salvos com sucesso!", "Salvamento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    model.Agendar oAgendarAlterado = new model.Agendar();

                    oAgendarAlterado.CdCliente = cdCliente.Text;
                    oAgendarAlterado.CdCorretor = cdCorretor.Text;
                    oAgendarAlterado.CdImovel = cdImovel.Text;
                    oAgendarAlterado.DataAgendada = cmbValor.Text;

                    oAgendarAlterado.CdAgendar = Convert.ToInt32(lbl1.Text);

                    _ControlAgendar.Alterar(oAgendarAlterado);

                    btnSalvar.Text = "Salvar";
                    MessageBox.Show("Dados alterados com sucesso!", "Alteração concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                HabilitaCampos();
                CarregaComboAgendar();
                limpaCampos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int ind = Dgv_Agendar.CurrentCell.RowIndex;

            string id = Convert.ToString(Dgv_Agendar.Rows[ind].Cells[0].Value);
            string CdCliente = Convert.ToString(Dgv_Agendar.Rows[ind].Cells[1].Value).TrimEnd();
            string CdCorretor = Convert.ToString(Dgv_Agendar.Rows[ind].Cells[2].Value).TrimEnd();
            string CdImovel = Convert.ToString(Dgv_Agendar.Rows[ind].Cells[3].Value).TrimEnd();
            string data = Convert.ToString(Dgv_Agendar.Rows[ind].Cells[4].Value).TrimEnd();

            lbl1.Text = id;
            btnSalvar.Text = "Modificar";
            cdImovel.Text = CdImovel;
            cdCliente.Text = CdCliente;
            cdCorretor.Text = CdCorretor;
            cmbValor.Text = data;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover esse registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exclusao == DialogResult.Yes)
            {
                int ind = Dgv_Agendar.CurrentCell.RowIndex;
                string cd = Convert.ToString(Dgv_Agendar.Rows[ind].Cells[0].Value);
                int cdCorretor = int.Parse(cd);
                _ControlAgendar.Remover(cdCorretor);
                CarregaComboAgendar();
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregaComboAgendar();
            HabilitaCampos();
            Dgv_Cliente.Visible = false;
            Dgv_Imoveis.Visible = false;
            Dgv_Agendar.Visible = true;
            Dgv_Corretor.Visible = false;
        }
    }
}
