using System;
using System.Windows.Forms;
using Npgsql;
using TotemPIMApresentacao.Service;
using TotemPIMApresentacao.Servico;

namespace TotemPIMApresentacao.Model
{
    internal class MediaAcertos
    {
        private QuestionarioService avaliacaoService;
        private int quantidade;
        private int totalPessoas;
        private string mensagem;

        public MediaAcertos()
        {
            avaliacaoService = new QuestionarioService();
        }


        public void MediaAcertosPorObra(ContadorRespostas contador)
        {
            
            (quantidade,totalPessoas) = avaliacaoService.ObterInformacoesPorObra(contador.ObraAtual);

            double mediaAcertos = CalcularMediaAcertos();
            double totalPerguntasPorQuestionario = 5;

            // Exibir as informações em uma caixa de mensagem
            double porcentagemAcertos = (mediaAcertos/totalPerguntasPorQuestionario) * 100.0;

            // Exibir as informações em uma caixa de mensagem
            Mensagem = ($"A média de acertos para a obra é: {mediaAcertos:F1} \n\n Porcentagem de acertos: {porcentagemAcertos:F1} %");

        }

        private double CalcularMediaAcertos()
        {
            if (totalPessoas != 0)
            {
                double mediaAcertos = (double)quantidade/totalPessoas;
                return mediaAcertos;
            }
            else
            {
                return 0;
            }
        }


        public string Mensagem { get => mensagem; set => mensagem = value; }
    }
}
