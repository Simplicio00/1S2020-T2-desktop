namespace EstudoTaskool
{
    partial class frmCadastro
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label fotoLabel;
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnGerarAleatorio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblEmailValido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnSalvarFoto = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = System.Drawing.Color.White;
            nomeLabel.Location = new System.Drawing.Point(33, 64);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 24;
            nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(33, 90);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.ForeColor = System.Drawing.Color.White;
            usuarioLabel.Location = new System.Drawing.Point(33, 142);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 30;
            usuarioLabel.Text = "Usuario:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.ForeColor = System.Drawing.Color.White;
            telefoneLabel.Location = new System.Drawing.Point(33, 116);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 33;
            telefoneLabel.Text = "Telefone:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.ForeColor = System.Drawing.Color.White;
            fotoLabel.Location = new System.Drawing.Point(33, 195);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 34;
            fotoLabel.Text = "Foto:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(128, 169);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(120, 20);
            this.dtpNascimento.TabIndex = 28;
            this.dtpNascimento.Enter += new System.EventHandler(this.Inputs_Enter);
            this.dtpNascimento.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(128, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 23);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(254, 195);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(95, 23);
            this.btnSelecionar.TabIndex = 29;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnGerarAleatorio
            // 
            this.btnGerarAleatorio.Location = new System.Drawing.Point(334, 140);
            this.btnGerarAleatorio.Name = "btnGerarAleatorio";
            this.btnGerarAleatorio.Size = new System.Drawing.Size(95, 23);
            this.btnGerarAleatorio.TabIndex = 26;
            this.btnGerarAleatorio.Text = "Gerar Aleatório";
            this.btnGerarAleatorio.UseVisualStyleBackColor = true;
            this.btnGerarAleatorio.Click += new System.EventHandler(this.btnGerarAleatorio_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cadastre-se";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Data Nascimento";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(128, 64);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 21;
            this.nomeTextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            this.nomeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressioada);
            this.nomeTextBox.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(128, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 22;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(128, 142);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioTextBox.TabIndex = 25;
            this.usuarioTextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            this.usuarioTextBox.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(128, 116);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefoneTextBox.TabIndex = 23;
            this.telefoneTextBox.Enter += new System.EventHandler(this.Inputs_Enter);
            this.telefoneTextBox.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // lblIdade
            // 
            this.lblIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(262, 170);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(88, 19);
            this.lblIdade.TabIndex = 39;
            // 
            // lblEmailValido
            // 
            this.lblEmailValido.AutoSize = true;
            this.lblEmailValido.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValido.Location = new System.Drawing.Point(339, 92);
            this.lblEmailValido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailValido.Name = "lblEmailValido";
            this.lblEmailValido.Size = new System.Drawing.Size(64, 13);
            this.lblEmailValido.TabIndex = 41;
            this.lblEmailValido.Text = "Email Válido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.Location = new System.Drawing.Point(128, 195);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(120, 160);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 35;
            this.fotoPictureBox.TabStop = false;
            // 
            // btnSalvarFoto
            // 
            this.btnSalvarFoto.Location = new System.Drawing.Point(254, 224);
            this.btnSalvarFoto.Name = "btnSalvarFoto";
            this.btnSalvarFoto.Size = new System.Drawing.Size(95, 23);
            this.btnSalvarFoto.TabIndex = 42;
            this.btnSalvarFoto.Text = "Salvar foto";
            this.btnSalvarFoto.UseVisualStyleBackColor = true;
            this.btnSalvarFoto.Click += new System.EventHandler(this.btnSalvarFoto_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(495, 424);
            this.Controls.Add(this.btnSalvarFoto);
            this.Controls.Add(this.lblEmailValido);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnGerarAleatorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCadastro";
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnGerarAleatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblEmailValido;
        private System.Windows.Forms.Button btnSalvarFoto;
    }
}