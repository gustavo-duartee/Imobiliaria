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
    public partial class ReservarImoveis : Form
    {
        private ControleImoveis _ControlImoveis = new ControleImoveis();
        private ControleCliente _ControlCliente = new ControleCliente();
        private ControleCorretor _ControlCorretor = new ControleCorretor();
        private ControleReserva _ControlReserva = new ControleReserva();

        private bool Alterar = false;
        private ReservarImoveis oReservaAlterado = null;
        public ReservarImoveis()
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
        public void CarregaComboReserva()
        {
            Dgv_Reserva.DataSource = _ControlReserva.SelecionarTodos();

            Dgv_Cliente.Visible = false;
            Dgv_Imoveis.Visible = false;
            Dgv_Reserva.Visible = true;
            Dgv_Corretor.Visible = false;
        }
        public void DesabilitaCampos()
        {
            btnAlterar.Enabled = false;
            btnRemover.Enabled = false;
            Dgv_Reserva.Visible = false;
            Dgv_Imoveis.Visible = false;
            Dgv_Cliente.Visible = false;
            Dgv_Corretor.Visible = false;
        }
        public void HabilitaCampos()
        {
            btnAlterar.Enabled = true;
            btnRemover.Enabled = true;
            Dgv_Reserva.Visible = true;
        }
        public void limpaCampos()
        {
            cdCliente.Clear();
            cdCorretor.Clear();
            cdImovel.Clear();
            cmbValor.SelectedIndex = -1;
        }
        private void btnListarImovel_Click(object sender, EventArgs e)
        {
            CarregaComboImovel();
            Dgv_Cliente.Visible = false;
            Dgv_Imoveis.Visible = true;
            Dgv_Reserva.Visible = false;
            Dgv_Corretor.Visible = false;
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            CarregaComboCliente();
            Dgv_Cliente.Visible = true;
            Dgv_Imoveis.Visible = false;
            Dgv_Reserva.Visible = false;
            Dgv_Corretor.Visible = false;
        }

        private void btnListarCorretor_Click(object sender, EventArgs e)
        {                
            CarregaComboCorretor();
            Dgv_Cliente.Visible = false;
            Dgv_Imoveis.Visible = false;
            Dgv_Reserva.Visible = false;
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
                    model.Reserva oReserva = new model.Reserva();
                    oReserva.CdCliente = cdCliente.Text;
                    oReserva.CdCorretor = cdCorretor.Text;
                    oReserva.CdImovel = cdImovel.Text;
                    oReserva.Valor = cmbValor.Text;



                    _ControlReserva.Incluir(oReserva);
                    MessageBox.Show("Dados salvos com sucesso!", "Salvamento concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    model.Reserva oReservaAlterado = new model.Reserva();

                    oReservaAlterado.CdCliente = cdCliente.Text;
                    oReservaAlterado.CdCorretor = cdCorretor.Text;
                    oReservaAlterado.CdImovel = cdImovel.Text;
                    oReservaAlterado.Valor = cmbValor.Text;

                    oReservaAlterado.CdReserva = Convert.ToInt32(lbl1.Text);

                    _ControlReserva.Alterar(oReservaAlterado);

                    btnSalvar.Text = "Salvar";
                    MessageBox.Show("Dados alterados com sucesso!", "Alteração concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                HabilitaCampos();
                CarregaComboReserva();
                limpaCampos();
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int ind = Dgv_Reserva.CurrentCell.RowIndex;

            string id = Convert.ToString(Dgv_Reserva.Rows[ind].Cells[0].Value);
            string CdCliente = Convert.ToString(Dgv_Reserva.Rows[ind].Cells[1].Value).TrimEnd();
            string CdCorretor = Convert.ToString(Dgv_Reserva.Rows[ind].Cells[2].Value).TrimEnd();
            string CdImovel = Convert.ToString(Dgv_Reserva.Rows[ind].Cells[3].Value).TrimEnd();
            string Valor = Convert.ToString(Dgv_Reserva.Rows[ind].Cells[4].Value).TrimEnd();

            lbl1.Text = id;
            btnSalvar.Text = "Modificar";
            cdImovel.Text = CdImovel;
            cdCliente.Text = CdCliente;
            cdCorretor.Text = CdCorretor;
            cmbValor.Text = Valor;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover esse registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exclusao == DialogResult.Yes)
            {
                int ind = Dgv_Reserva.CurrentCell.RowIndex;
                string cd = Convert.ToString(Dgv_Reserva.Rows[ind].Cells[0].Value);
                int cdCorretor = int.Parse(cd);
                _ControlReserva.Remover(cdCorretor);
                CarregaComboReserva();
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
            CarregaComboReserva();
            HabilitaCampos();
            Dgv_Cliente.Visible = false;
            Dgv_Imoveis.Visible = false;
            Dgv_Reserva.Visible = true;
            Dgv_Corretor.Visible = false;
        }
    }
}
