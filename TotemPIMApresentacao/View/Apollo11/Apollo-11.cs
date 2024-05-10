using TotemPIMApresentacao.Controller;

namespace TotemPIMApresentacao.View
{
    public partial class Apollo_11 : Form
    {
        public Apollo_11()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public LoginApollo_11 LoginApollo_11
        {
            get => default;
            set
            {
            }
        }

        private void Atalho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                this.Close();
        }

        private void BtnTesteConhecimento_Click(object sender, EventArgs e)
        {
            LoginApollo_11 loginApollo_11 = new LoginApollo_11();
            loginApollo_11.ShowDialog();
            this.Hide();
        }

        private void Atalho_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }
    }
}
