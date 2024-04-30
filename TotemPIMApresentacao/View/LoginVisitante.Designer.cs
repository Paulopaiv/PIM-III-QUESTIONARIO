namespace TotemPIMApresentacao.View
{
    partial class LoginVisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVisitante));
            lblLogin = new Label();
            txbCodigoVisitante = new TextBox();
            BtnEntrar = new Button();
            pictureBox1 = new PictureBox();
            lblNome = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ControlLightLight;
            lblLogin.Location = new Point(1452, 346);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(64, 28);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // txbCodigoVisitante
            // 
            txbCodigoVisitante.Anchor = AnchorStyles.Right;
            txbCodigoVisitante.ForeColor = SystemColors.ActiveCaptionText;
            txbCodigoVisitante.Location = new Point(1452, 417);
            txbCodigoVisitante.Name = "txbCodigoVisitante";
            txbCodigoVisitante.Size = new Size(180, 23);
            txbCodigoVisitante.TabIndex = 2;
            txbCodigoVisitante.Click += TextBox1_Click;
            // 
            // BtnEntrar
            // 
            BtnEntrar.Anchor = AnchorStyles.Right;
            BtnEntrar.BackColor = Color.Black;
            BtnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEntrar.ForeColor = SystemColors.ButtonFace;
            BtnEntrar.Location = new Point(1465, 508);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(160, 57);
            BtnEntrar.TabIndex = 3;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = false;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1272, 876);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(1452, 399);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(105, 15);
            lblNome.TabIndex = 14;
            lblNome.Text = "Token Visitante";
            // 
            // panel1
            // 
            panel1.Location = new Point(1348, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 336);
            panel1.TabIndex = 15;
            // 
            // LoginVisitante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1825, 875);
            Controls.Add(txbCodigoVisitante);
            Controls.Add(BtnEntrar);
            Controls.Add(lblLogin);
            Controls.Add(lblNome);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginVisitante";
            Text = "LoginVisitante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txbNomeCompleto;
        private TextBox txbCodigoVisitante;
        private Button BtnEntrar;
        private PictureBox pictureBox1;
        private Label lblNome;
        private Panel panel1;
    }
}