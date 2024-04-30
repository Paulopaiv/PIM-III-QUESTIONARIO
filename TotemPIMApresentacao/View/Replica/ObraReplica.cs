namespace TotemPIMApresentacao.View
{
    public partial class ObraReplica : Form
    {
        private LoginVisitante loginVisitante;
        public ObraReplica()
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
                QuestionarioReplica questionario = new QuestionarioReplica();
                questionario.ShowDialog();
                this.Hide();
            }
        }
        private void Atalho_Load_1(object sender, EventArgs e)
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
