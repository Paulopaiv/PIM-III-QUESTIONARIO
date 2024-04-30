namespace TotemPIMApresentacao.View
{
    public partial class TecladoNumerico : Form
    {
        private TextBox targetTextBox;
        private Teclado teclado;
        public TecladoNumerico(TextBox targetTextBox, Teclado teclado)
        {
            InitializeComponent();
            this.targetTextBox = targetTextBox;
            this.teclado = teclado;
            this.TopMost = true;
            this.Load += Teclado_Load;
            this.Deactivate += Teclado_Deactivate;
        }

        private void Teclado_Deactivate(object sender, EventArgs e)
        {         
            this.Hide();
        }

        public void FocusTargetTextBox()
        {
            targetTextBox.Focus();
        }

        private void Teclado_Load(object sender, EventArgs e)
        {
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            this.Location = new Point(x, y);
        }

        private void BtnTecla_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                string character = btn.Text;
                int cursorPosition = targetTextBox.SelectionStart;
                targetTextBox.Text = targetTextBox.Text.Insert(cursorPosition, character);
                targetTextBox.SelectionStart = cursorPosition + character.Length;
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(targetTextBox.Text))
            {
                int cursorPosition = targetTextBox.SelectionStart;
                if (cursorPosition > 0)
                {
                    targetTextBox.Text = targetTextBox.Text.Remove(cursorPosition - 1, 1);
                    targetTextBox.SelectionStart = cursorPosition - 1;
                }
            }
        }

        private void btnRun_Click_1(object sender, EventArgs e)
        {
            teclado.Show();
            this.Close();
        }
    }
}
