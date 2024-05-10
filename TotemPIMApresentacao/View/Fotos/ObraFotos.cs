namespace TotemPIMApresentacao.View
{
    public partial class ObraFotos : Form
    {
        public ObraFotos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public LoginFotos LoginFotos
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
            LoginFotos loginFotos = new LoginFotos();
            loginFotos.ShowDialog();
            this.Hide();
        }
        private void Atalho_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }

    }
}

