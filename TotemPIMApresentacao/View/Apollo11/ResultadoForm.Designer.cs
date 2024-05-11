namespace TotemPIMApresentacao.View
{
    partial class ResultadoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoForm));
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            lblMedia = new Label();
            lblTextMedia = new Label();
            label1 = new Label();
            lblRes = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(511, 171);
            label2.Name = "label2";
            label2.Size = new Size(899, 50);
            label2.TabIndex = 6;
            label2.Text = "Visão Geral dos Resultados Obtidos no Questionário\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(681, 221);
            label3.Name = "label3";
            label3.Size = new Size(558, 128);
            label3.TabIndex = 7;
            label3.Text = "Parabéns!!!";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.DodgerBlue;
            lblResultado.Location = new Point(904, 366);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(112, 128);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "5";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.BackColor = Color.Transparent;
            lblMedia.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedia.ForeColor = Color.DodgerBlue;
            lblMedia.Location = new Point(842, 641);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(231, 86);
            lblMedia.TabIndex = 8;
            lblMedia.Text = "media";
            // 
            // lblTextMedia
            // 
            lblTextMedia.AutoSize = true;
            lblTextMedia.BackColor = Color.Transparent;
            lblTextMedia.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTextMedia.ForeColor = SystemColors.ButtonFace;
            lblTextMedia.Location = new Point(488, 524);
            lblTextMedia.Name = "lblTextMedia";
            lblTextMedia.Size = new Size(945, 86);
            lblTextMedia.TabIndex = 9;
            lblTextMedia.Text = "Resultado Médio das Respostas:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1022, 387);
            label1.Name = "label1";
            label1.Size = new Size(475, 86);
            label1.TabIndex = 10;
            label1.Text = "de 5 perguntas";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.BackColor = Color.Transparent;
            lblRes.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblRes.ForeColor = Color.White;
            lblRes.Location = new Point(465, 387);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(433, 86);
            lblRes.TabIndex = 11;
            lblRes.Text = "Você acertou ";
            // 
            // ResultadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1100);
            Controls.Add(lblRes);
            Controls.Add(label1);
            Controls.Add(lblTextMedia);
            Controls.Add(lblMedia);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResultadoForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObra;
        private Label label2;
        private Label label3;
        private Label lblResultado;
        private Label lblMedia;
        private Label lblTextMedia;
        private Label label1;
        private Label lblRes;
    }
}