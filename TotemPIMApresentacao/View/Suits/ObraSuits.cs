namespace TotemPIMApresentacao.View
{
    public partial class ObraSuits : Form
    {
        private LoginVisitante loginVisitante;
        public ObraSuits()
        {
            InitializeComponent();
            loginVisitante = new LoginVisitante();
            this.WindowState = FormWindowState.Maximized;
        }
        private void Atalho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                this.Close();
        }

        private void BtnTesteConhecimento_Click(object sender, EventArgs e)
        {
            if (VerificarLogin())
            {
                QuestionarioSuits questionario = new QuestionarioSuits();
                questionario.ShowDialog();
                this.Hide();
            }
        }

        private void Atalho_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }

        private bool VerificarLogin()
        {
            loginVisitante.ShowDialog();
            return loginVisitante.LoginStatus == "Logado";
        }
    }
}
