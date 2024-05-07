

namespace TotemPIMApresentacao.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnObra01_Click(object sender, EventArgs e)
        {
            Apollo_11 apollo11 = new Apollo_11();
            apollo11.ShowDialog();
        }

        private void btnObra02_Click(object sender, EventArgs e)
        {
            ObraDocumentos obraDocumentos = new ObraDocumentos();
            obraDocumentos.ShowDialog();
        }

        private void btnObra03_Click(object sender, EventArgs e)
        {
            ObraEquip obraEquip = new ObraEquip();
            obraEquip.ShowDialog();
        }

        private void btnObra04_Click(object sender, EventArgs e)
        {
            ObraFotos obraFotos = new ObraFotos();
            obraFotos.ShowDialog();
        }

        private void btnObra05_Click(object sender, EventArgs e)
        {
            ObraHistoria obraHistoria = new ObraHistoria();
            obraHistoria.ShowDialog();
        }

        private void btnObra06_Click(object sender, EventArgs e)
        {
            ObraReplica obraReplica = new ObraReplica();
            obraReplica.ShowDialog();
        }

        private void btnObra07_Click(object sender, EventArgs e)
        {
            ObraSuits obraSuits = new ObraSuits();
            obraSuits.ShowDialog();
        }
    }
}
