using System;
using System.Windows.Forms;
using Npgsql;
using TotemPIMApresentacao.Service;
using TotemPIMApresentacao.Servico;

namespace TotemPIMApresentacao.Model
{
    internal class MediaAcertos
    {
        private AvaliacaoService avaliacaoService;
        private int quantidade;
        private int totalPessoas; // Total de pessoas é igual à quantidade de códigos distintos

        public MediaAcertos()
        {
            avaliacaoService = new AvaliacaoService();
        }

        public void MediaAcertosPorObra(ContadorRespostas contador)
        {
            // Obter a quantidade de acertos e o total de pessoas (quantidade de códigos distintos)
            (quantidade, totalPessoas) = avaliacaoService.ObterInformacoesPorObra(contador.ObraAtual);

            // Calcular a média de acertos por pessoa
            double mediaAcertos = CalcularMediaAcertos();

            // Exibir as informações em uma caixa de mensagem
            MessageBox.Show($"Quantidade de Acertos: {quantidade}\nMédia de Acertos por Pessoa: {mediaAcertos}");
        }

        private double CalcularMediaAcertos()
        {
            // Certifique-se de verificar se o total de pessoas é diferente de zero para evitar divisão por zero
            if (totalPessoas != 0)
            {
                // Calcular a média de acertos por pessoa
                double mediaAcertos = (double)quantidade / totalPessoas;
                return mediaAcertos;
            }
            else
            {
                return 0; // Se não houver pessoas, a média é zero
            }
        }
    }
}
