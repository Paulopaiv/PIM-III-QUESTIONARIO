using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.View
{
    public partial class ResultadoFormHistoria : Form
    {
        private ContadorRespostas contadorRespostas;
        public ResultadoFormHistoria(ContadorRespostas contadorRespostas)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.contadorRespostas = contadorRespostas; // Atribua a instância fornecida ao campo contadorRespostas
            ExibirResultados();

        }
        private void ExibirResultados()
        {
            contadorRespostas.SalvarResposta();
            MediaAcertos mediaAcertos = new MediaAcertos();
            mediaAcertos.MediaAcertosPorObra(contadorRespostas);
            lblResultado.Text = $"Você acertou {contadorRespostas.RespostasCorretas} de 5 perguntas"; // Atualize o texto da lblResultado com o número atual de respostas corretas
        }

        private void btnObra_Click(object sender, EventArgs e)
        {
            ObraHistoria ObraSuits = new ObraHistoria();
            ObraSuits.ShowDialog();
            this.Hide();
        }
    }
}
