using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace TotemPIMApresentacao.Controller
{
    internal class PerguntasDocumentos
    {
        private string obra = "Documentos";
        private ObraDocumentos obraDocumentos;
        private ContadorRespostas contadorRespostas;
        private ResultadoFormDocumentos resultadosForm;
        private WinFormsTimer timer;
        private QuestionarioDocumentos questionarioForm;
        private string codigoUsuario;
        private int indicePergunta = 0;
        private string[] perguntas = {
            "Qual foi o principal documento que registrou a missão Apollo 11?", //1
            "Qual era o objetivo principal dos registros de comunicações da NASA durante a missão?  ", //2
            "Qual foi a importância dos memorandos internos da NASA para a missão Apollo 11?", //3
            "Quem era o principal destinatário dos memorandos internos da NASA durante a missão?", //4
            "Qual era a natureza dos documentos históricos relacionados à missão Apollo 11?" //5
        };

        private string[][] alternativas = {

            new string[] { "A) Relatório de missão  ",
                            "B) Registro de comunicações da NASA ",
                            "C) Memorando interno da NASA ",
                            "D) Diário dos astronautas  ",
                            "E) Carta do presidente dos EUA " }, // Resposta correta: A
          
            new string[] { "A) Documentar as conversas dos astronautas entre si ",
                            "B) Registrar as instruções da NASA para os astronautas ",
                            "C) Monitorar a saúde dos astronautas",
                            "D) Manter um registro de dados científicos",
                            "E) Comunicar com o público em geral" }, // Resposta correta: A
         
            new string[] { "A) Comunicar decisões e instruções importantes " ,
                            "B) Registrar eventos cotidianos da missão ", // Resposta correta: A
                            "C) Documentar descobertas científicas",
                            "D) Preservar a história da exploração espacial",
                            "E) Descrever os procedimentos de segurança " },

            new string[] { "A) Astronautas  ",
                           "B) Engenheiros da missão  ",
                           "C) Diretores da NASA ",
                           "D) Presidente dos EUA ",
                           "E) Público em geral " }, // Resposta correta: B
           
            new string[] { "A) Confidenciais ",
                           "B) Secretos  ",
                           "C) Públicos  ",
                            "D) Privados  ",
                           "E) Restritos " } // Resposta correta: C
        };

        private int[] posicoesRespostasCorretas = { 0, 0, 0, 1, 2 };

        public PerguntasDocumentos(QuestionarioDocumentos questionarioForm, ContadorRespostas contadorRespostas, string codigoUsuario, string obra)
        {
            this.questionarioForm = questionarioForm;
            this.contadorRespostas = contadorRespostas;
            this.codigoUsuario = codigoUsuario;
            contadorRespostas.ObraAtual = obra;

            timer = new WinFormsTimer();
            timer.Interval = 4000;
            timer.Tick += Timer_Tick;
        }

        public ResultadoFormDocumentos ResultadoFormDocumentos
        {
            get => default;
            set
            {
            }
        }

        //public PerguntasDocumentos(QuestionarioDocumentos questionarioForm)
        //{
        //    this.questionarioForm = questionarioForm;
        //    timer = new WinFormsTimer();
        //    timer.Interval = 4000;
        //    timer.Tick += Timer_Tick;
        //    //contadorRespostas = new ContadorRespostas(posicoesRespostasCorretas);
        //}
        public void VerificarResposta(string respostaUsuario)
        {
            string respostaCorreta = ObterRespostaCorreta(indicePergunta);

            int posicaoRespostaUsuario = respostaUsuario[0] - 'A';

            if (posicaoRespostaUsuario == posicoesRespostasCorretas[indicePergunta])
            {
                contadorRespostas.Incrementar();
            }

        }

        private string ObterRespostaCorreta(int indice)
        {
            if (indice < posicoesRespostasCorretas.Length)
            {
                return alternativas[indice][posicoesRespostasCorretas[indice]].Substring(0, 1);
            }
            else
            {
                return ""; // Sem resposta correta para o índice fornecido
            }
        }

        public string PerguntaAtual()
        {
            if (indicePergunta < perguntas.Length)
            {
                return perguntas[indicePergunta];
            }
            else
            {
                timer.Start();
                resultadosForm = new ResultadoFormDocumentos(contadorRespostas);
                resultadosForm.ShowDialog();
                questionarioForm.Hide();
                return "";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            resultadosForm.Close();
            obraDocumentos = new ObraDocumentos();
            obraDocumentos.Show();
            timer.Stop();
        }
        public string[] AlternativasAtual()
        {
            if (indicePergunta < alternativas.Length)
            {
                return alternativas[indicePergunta];
            }
            else
            {
                return null;
            }
        }
        public void ProximaPergunta()
        {
            indicePergunta++;
        }
        public void AtualizarPergunta(Label lblPergunta, Label lblNumeroPergunta, Button[] botoesAlternativas)
        {
            lblNumeroPergunta.Text = "Pergunta " + (indicePergunta + 1);
            lblPergunta.Text = PerguntaAtual();
            string[] alternativas = AlternativasAtual();

            if (alternativas != null && alternativas.Length == 5 && botoesAlternativas.Length >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    botoesAlternativas[i].Text = alternativas[i];
                }
            }
        }
    }
}

