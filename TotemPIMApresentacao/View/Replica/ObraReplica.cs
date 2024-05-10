namespace TotemPIMApresentacao.View
{
    public partial class ObraReplica : Form
    {
        public ObraReplica()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public LoginHistoria LoginHistoria
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

            LoginReplica loginReplica = new LoginReplica();
            loginReplica.ShowDialog();
                this.Hide();

        }
        private void Atalho_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }

     
    }
}
