namespace Imobiliaria.view
{
    public partial class Imobiliaria : Form
    {
        public Imobiliaria()
        {
            InitializeComponent();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Cliente oCliente = new Cliente();
            oCliente.MdiParent = this;
            oCliente.Show();

        }

        private void cadastrarImovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Corretor oCorretor = new Corretor();
            oCorretor.MdiParent = this;
            oCorretor.Show();
        }

        private void cadastrarImóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imovel oImovel= new Imovel();
            oImovel.MdiParent = this;
            oImovel.Show();
        }

        private void reservarImóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservarImoveis oReserva = new ReservarImoveis();
            oReserva.MdiParent = this;
            oReserva.Show();
        }

        private void agendarVisitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendar oAgendar = new Agendar();
            oAgendar.MdiParent = this;
            oAgendar.Show();
        }
    }
}