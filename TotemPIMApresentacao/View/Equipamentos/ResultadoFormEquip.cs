using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.View
{
    public partial class ResultadoFormEquip : Form
    {
        private ContadorRespostas contadorRespostas;
        public ResultadoFormEquip(ContadorRespostas contadorRespostas)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.contadorRespostas = contadorRespostas; // Atribua a instância fornecida ao campo contadorRespostas
            ExibirResultados();

        }
        private void ExibirResultados()
        {
            contadorRespostas.SalvarResposta();
            lblResultado.Text = $"Você acertou {contadorRespostas.RespostasCorretas} de 5 perguntas"; // Atualize o texto da lblResultado com o número atual de respostas corretas
        }

        private void btnObra_Click(object sender, EventArgs e)
        {
            ObraEquip ObraSuits = new ObraEquip();
            ObraSuits.ShowDialog();
            this.Hide();
        }

        private void ResultadoFormEquip_Load(object sender, EventArgs e)
        {

        }
    }
}
