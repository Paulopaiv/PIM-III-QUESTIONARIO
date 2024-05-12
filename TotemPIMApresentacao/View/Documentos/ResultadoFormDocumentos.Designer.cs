namespace TotemPIMApresentacao.View
{
    partial class ResultadoFormDocumentos
    {   
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoFormDocumentos));
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
            label2.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(381, 151);
            label2.Name = "label2";
            label2.Size = new Size(1577, 81);
            label2.TabIndex = 6;
            label2.Text = "Visão Geral dos Resultados Obtidos no Questionário\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(12, 105, 255);
            label3.Location = new Point(233, 300);
            label3.Name = "label3";
            label3.Size = new Size(741, 159);
            label3.TabIndex = 7;
            label3.Text = "Parabéns!!!";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.FromArgb(12, 105, 255);
            lblResultado.Location = new Point(509, 468);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(139, 159);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "5";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.BackColor = Color.Transparent;
            lblMedia.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedia.ForeColor = Color.FromArgb(12, 105, 255);
            lblMedia.Location = new Point(121, 936);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(162, 62);
            lblMedia.TabIndex = 8;
            lblMedia.Text = "media";
            // 
            // lblTextMedia
            // 
            lblTextMedia.AutoSize = true;
            lblTextMedia.BackColor = Color.Transparent;
            lblTextMedia.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTextMedia.ForeColor = SystemColors.ButtonFace;
            lblTextMedia.Location = new Point(121, 787);
            lblTextMedia.Name = "lblTextMedia";
            lblTextMedia.Size = new Size(1177, 106);
            lblTextMedia.TabIndex = 9;
            lblTextMedia.Text = "Resultado Médio das Respostas:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(643, 511);
            label1.Name = "label1";
            label1.Size = new Size(476, 81);
            label1.TabIndex = 10;
            label1.Text = "de 5 perguntas!";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.BackColor = Color.Transparent;
            lblRes.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblRes.ForeColor = Color.White;
            lblRes.Location = new Point(121, 511);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(418, 81);
            lblRes.TabIndex = 11;
            lblRes.Text = "Você acertou ";
            // 
            // ResultadoFormDocumentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(2194, 1372);
            Controls.Add(lblRes);
            Controls.Add(label1);
            Controls.Add(lblTextMedia);
            Controls.Add(lblMedia);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ResultadoFormDocumentos";
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