﻿namespace EstudoTaskool
{
    partial class frmLogin
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Label();
            this.lblCaps = new System.Windows.Forms.Label();
            this.btnTeclado = new System.Windows.Forms.Button();
            this.chxManterConectado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(188, 181);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(150, 23);
            this.btnEntrar.TabIndex = 11;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxUsuario.Location = new System.Drawing.Point(188, 119);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(150, 20);
            this.tbxUsuario.TabIndex = 10;
            this.tbxUsuario.Enter += new System.EventHandler(this.tbxUsuario_Enter);
            this.tbxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxUsuario_KeyDown);
            this.tbxUsuario.Leave += new System.EventHandler(this.tbxUsuario_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bem vindo ao Taskool";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuário";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(64, 227);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(385, 20);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastre-se";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCaps
            // 
            this.lblCaps.AutoSize = true;
            this.lblCaps.ForeColor = System.Drawing.Color.Yellow;
            this.lblCaps.Location = new System.Drawing.Point(343, 121);
            this.lblCaps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(58, 13);
            this.lblCaps.TabIndex = 12;
            this.lblCaps.Text = "Caps Lock";
            // 
            // btnTeclado
            // 
            this.btnTeclado.ForeColor = System.Drawing.Color.Black;
            this.btnTeclado.Location = new System.Drawing.Point(87, 118);
            this.btnTeclado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(96, 19);
            this.btnTeclado.TabIndex = 13;
            this.btnTeclado.Text = "Teclado Virtual";
            this.btnTeclado.UseVisualStyleBackColor = true;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // chxManterConectado
            // 
            this.chxManterConectado.AutoSize = true;
            this.chxManterConectado.Location = new System.Drawing.Point(346, 185);
            this.chxManterConectado.Name = "chxManterConectado";
            this.chxManterConectado.Size = new System.Drawing.Size(113, 17);
            this.chxManterConectado.TabIndex = 14;
            this.chxManterConectado.Text = "Manter conectado";
            this.chxManterConectado.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(526, 301);
            this.Controls.Add(this.chxManterConectado);
            this.Controls.Add(this.btnTeclado);
            this.Controls.Add(this.lblCaps);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCadastrar);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnCadastrar;
        private System.Windows.Forms.Label lblCaps;
        private System.Windows.Forms.Button btnTeclado;
        private System.Windows.Forms.CheckBox chxManterConectado;
    }
}

