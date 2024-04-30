namespace TotemPIMApresentacao.View
{
    public partial class Teclado : Form
    {
        private bool shiftAtivado = false;
        private TextBox targetTextBox;

        public Teclado()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Load += Teclado_Load;
            this.Deactivate += Teclado_Deactivate;
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

        private void AdicionarLetra(string letra)
        {
            if (targetTextBox != null)
            {
                int cursorPositionFromStart = targetTextBox.SelectionStart;
                int cursorPositionFromEnd = targetTextBox.TextLength - cursorPositionFromStart;
                targetTextBox.Text = targetTextBox.Text.Insert(cursorPositionFromStart, letra);
                targetTextBox.SelectionStart = cursorPositionFromStart + letra.Length;
                targetTextBox.SelectionLength = 0;
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox clickedTextBox = sender as TextBox;
            SetTargetTextBox(clickedTextBox);
        }

        public void SetTargetTextBox(TextBox targetTextBox)
        {
            this.targetTextBox = targetTextBox;
             this.targetTextBox.HideSelection = false;
            this.targetTextBox.Focus();
        }

        // Evento para lidar com o teclado perdendo o foco
        private void Teclado_Deactivate(object sender, EventArgs e)
        {
            // Oculta o teclado quando ele perde o foco
            this.Hide();
        }

        #region Teclas
        private void btnLetraA_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "A" : "a");
            shiftAtivado = false;
        }

        private void btnLetraQ_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "Q" : "q");
            shiftAtivado = false;
        }

        private void btnLetraW_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "W" : "w");
            shiftAtivado = false;
        }

        private void btnLetraE_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "E" : "e");
            shiftAtivado = false;
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "R" : "r");
            shiftAtivado = false;
        }

        private void btnLetraT_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "T" : "t");
            shiftAtivado = false;
        }

        private void btnLetraY_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "Y" : "y");
            shiftAtivado = false;
        }

        private void btnLetraU_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "U" : "u");
            shiftAtivado = false;
        }

        private void btnLetraI_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "I" : "i");
            shiftAtivado = false;
        }

        private void btnLetraO_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "O" : "o");
            shiftAtivado = false;
        }

        private void btnLetraP_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "P" : "p");
            shiftAtivado = false;
        }

        private void btnLetraS_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "S" : "s");
            shiftAtivado = false;
        }

        private void btnLetraD_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "D" : "d");
            shiftAtivado = false;
        }

        private void btnLetraF_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "F" : "f");
            shiftAtivado = false;
        }

        private void btnLetraG_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "G" : "g");
            shiftAtivado = false;
        }

        private void btnLetraH_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "H" : "h");
            shiftAtivado = false;
        }

        private void btnLetraJ_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "J" : "j");
            shiftAtivado = false;
        }

        private void K_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "K" : "k");
            shiftAtivado = false;
        }

        private void btnLetraL_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "L" : "l");
            shiftAtivado = false;
        }

        private void btnLetraZ_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "Z" : "z");
            shiftAtivado = false;
        }

        private void btnLetraX_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "X" : "x");
            shiftAtivado = false;
        }

        private void btnLetraC_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "C" : "c");
            shiftAtivado = false;
        }

        private void btnLetraV_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "V" : "v");
            shiftAtivado = false;
        }

        private void btnLetraB_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "B" : "b");
            shiftAtivado = false;
        }

        private void btnLetraN_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "N" : "n");
            shiftAtivado = false;
        }

        private void btnLetraM_Click(object sender, EventArgs e)
        {
            AdicionarLetra(shiftAtivado ? "M" : "m");
            shiftAtivado = false;
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (targetTextBox != null && targetTextBox.Text.Length > 0)
            {
                int cursorPosition = targetTextBox.SelectionStart;
                if (cursorPosition > 0)
                {
                    // Move o cursor uma posição para trás
                    targetTextBox.SelectionStart = cursorPosition - 1;
                    // Remove o caractere na posição anterior ao cursor
                    targetTextBox.Text = targetTextBox.Text.Remove(cursorPosition - 1, 1);
                    // Define a posição do cursor de volta à posição correta
                    targetTextBox.SelectionStart = cursorPosition - 1;
                }
            }

        }

        private void btn123_Click(object sender, EventArgs e)
        {
            TecladoNumerico tecladoNumerico = new TecladoNumerico(targetTextBox,this);
            tecladoNumerico.Show();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            shiftAtivado = !shiftAtivado;
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (targetTextBox != null)
                targetTextBox.Text += "_";
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            if (targetTextBox != null)
                targetTextBox.Text += " ";
        }

        private void btnArroba_Click(object sender, EventArgs e)
        {
            if (targetTextBox != null)
                targetTextBox.Text += "@";
        }

        private void btnPontoCom_Click(object sender, EventArgs e)
        {
            if (targetTextBox != null)
                targetTextBox.Text += ".com";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}