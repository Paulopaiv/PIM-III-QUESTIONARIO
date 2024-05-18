using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Model;
using WinFormsTimer = System.Windows.Forms.Timer;


namespace TotemPIMApresentacao.View
{
    public partial class LoginApollo_11 : Form
    {
        private PessoaModel pessoaModel;
        private PessoaController pessoa;
        private Teclado teclado;
        private WinFormsTimer timer;

       
        public LoginApollo_11()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pessoa = new PessoaController();
            pessoaModel = new PessoaModel();

            timer = new WinFormsTimer();
            timer.Interval = 60000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            // Verifica se o teclado ainda não foi instanciado
            if (teclado == null)
            {
                // Cria uma nova instância do teclado
                teclado = new Teclado();
            }

            // Define a TextBox clicada como o TextBox de destino do teclado
            teclado.SetTargetTextBox(sender as TextBox);

            teclado.Show();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            pessoa.Codigo = txbCodigoVisitante.Text;
            pessoaModel.Login(pessoa, "Apollo-11");

            if (pessoaModel.Mensagem.Equals(""))
            {              
                string codigoUsuario = pessoa.Codigo;
                ContadorRespostas contadorRespostas = new ContadorRespostas(codigoUsuario);

                QuestionarioApollo11 questionarioApollo11 = new QuestionarioApollo11(contadorRespostas, codigoUsuario);
                questionarioApollo11.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }
            LimparCampos();
        }

        private void LimparCampos()
        {
            txbCodigoVisitante.Text = string.Empty;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            timer.Stop();
        }

    }
}
