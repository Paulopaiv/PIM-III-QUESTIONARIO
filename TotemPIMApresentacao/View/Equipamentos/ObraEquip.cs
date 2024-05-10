namespace TotemPIMApresentacao.View
{
    public partial class ObraEquip : Form
    {
        public ObraEquip()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public LoginEquip LoginEquip
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
            LoginEquip LoginEquip = new LoginEquip();
            LoginEquip.ShowDialog();
            this.Hide();
        }

        private void Atalho_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Atalho_KeyDown;
        }


    }
}
