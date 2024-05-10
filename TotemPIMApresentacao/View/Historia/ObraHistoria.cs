namespace TotemPIMApresentacao.View
{
    public partial class ObraHistoria : Form
    {
        public ObraHistoria()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public LoginSuits LoginSuits
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
            LoginHistoria loginHistoria = new LoginHistoria();
            loginHistoria.ShowDialog();
                this.Hide();   
        }
        private void Atalho_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }   
    }
}
