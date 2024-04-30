﻿

using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.View
{
    public partial class ResultadoFormSuit : Form
    {
        private ContadorRespostas contadorRespostas;
        public ResultadoFormSuit(ContadorRespostas contadorRespostas)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.contadorRespostas = contadorRespostas; // Atribua a instância fornecida ao campo contadorRespostas
            ExibirResultados();

        }
        private void ExibirResultados()
        {
            lblResultado.Text = $"Você acertou {contadorRespostas.RespostasCorretas} de 5 perguntas"; // Atualize o texto da lblResultado com o número atual de respostas corretas
        }

        private void btnObra_Click(object sender, EventArgs e)
        {
            ObraSuits ObraSuits = new ObraSuits();
            ObraSuits.ShowDialog();
            this.Hide();
        }
    }
}
