namespace TotemPIMApresentacao.View
{
    public partial class ObraDocumentos : Form
    {
        public ObraDocumentos()
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
            LoginDocumentos loginDocumentos = new LoginDocumentos();
            loginDocumentos.ShowDialog();
            this.Hide();
        }

        private void Atalho_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }
    }
}
