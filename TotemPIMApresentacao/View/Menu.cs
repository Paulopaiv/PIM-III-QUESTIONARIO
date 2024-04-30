
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
            apollo11.Show();   
        }

        private void btnObra02_Click(object sender, EventArgs e)
        {
            ObraDocumentos obraDocumentos = new ObraDocumentos();
            obraDocumentos.Show();
        }

        private void btnObra03_Click(object sender, EventArgs e)
        {
            ObraEquip obraEquip = new ObraEquip();
            obraEquip.Show();
        }

        private void btnObra04_Click(object sender, EventArgs e)
        {
            ObraFotos obraFotos = new ObraFotos();
            obraFotos.Show();
        }

        private void btnObra05_Click(object sender, EventArgs e)
        {
            ObraHistoria obraHistoria = new ObraHistoria();
            obraHistoria.Show();
        }

        private void btnObra06_Click(object sender, EventArgs e)
        {
            ObraReplica obraReplica = new ObraReplica();
            obraReplica.Show();
        }

        private void btnObra07_Click(object sender, EventArgs e)
        {
            ObraSuits obraSuits = new ObraSuits();
            obraSuits.ShowDialog();
        }
    }
}
