namespace TotemPIMApresentacao.View
{
    public partial class ObraSuits : Form
    {
        public ObraSuits()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void Atalho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                this.Close();
        }

        private void BtnTesteConhecimento_Click(object sender, EventArgs e)
        {
          
                LoginSuits loginSuits = new LoginSuits();
                loginSuits.ShowDialog();
                this.Hide();

        }

        private void Atalho_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }

       
    }
}
