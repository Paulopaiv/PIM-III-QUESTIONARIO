﻿using TotemPIMApresentacao.Controller;
using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.View
{
    public partial class QuestionarioSuits : Form
    {
        private PerguntasTrajesEspaciais perguntas;

        public QuestionarioSuits(ContadorRespostas contadorRespostas, string codigoUsuario)
        {
            InitializeComponent();
            perguntas = new PerguntasTrajesEspaciais(this, contadorRespostas, codigoUsuario, "Suits");
            this.WindowState = FormWindowState.Maximized;
            AtualizaPergunta();

        }

        internal PerguntasReplica PerguntasReplica
        {
            get => default;
            set
            {
            }
        }

        private void AtualizaPergunta()
        {
            perguntas.AtualizarPergunta(lblPergunta, lblNumeroPergunta, new Button[] 
            {
                btnAlternativaA,
                btnAlternativaB,
                btnAlternativaC,
                btnAlternativaD,
                btnAlternativaE
             });
        }



        private void ProximaPergunta()
        {
            perguntas.ProximaPergunta();
            AtualizaPergunta();
        }

        private void btnAlternativaA_Click(object sender, EventArgs e)
        {
            perguntas.VerificarResposta("A");
             ProximaPergunta();
        }

        private void btnAlternativaB_Click(object sender, EventArgs e)
        {
            perguntas.VerificarResposta("B");
            ProximaPergunta();
        }

        private void btnAlternativaC_Click(object sender, EventArgs e)
        {
            perguntas.VerificarResposta("C");
            ProximaPergunta();
        }

        private void btnAlternativaD_Click(object sender, EventArgs e)
        {
            perguntas.VerificarResposta("D");
            ProximaPergunta();
        }

        private void btnAlternativaE_Click(object sender, EventArgs e)
        {
            perguntas.VerificarResposta("E");
            ProximaPergunta();

        }
    }
}
