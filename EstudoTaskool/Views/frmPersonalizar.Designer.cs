namespace EstudoTaskool.Views
{
    partial class frmPersonalizar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxBackColor = new System.Windows.Forms.PictureBox();
            this.pbxForeColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForeColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 232);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(93, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cor background";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cor text ";
            // 
            // pbxBackColor
            // 
            this.pbxBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxBackColor.Location = new System.Drawing.Point(12, 9);
            this.pbxBackColor.Name = "pbxBackColor";
            this.pbxBackColor.Size = new System.Drawing.Size(20, 20);
            this.pbxBackColor.TabIndex = 2;
            this.pbxBackColor.TabStop = false;
            this.pbxBackColor.Click += new System.EventHandler(this.pbxColor_Click);
            // 
            // pbxForeColor
            // 
            this.pbxForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxForeColor.Location = new System.Drawing.Point(12, 40);
            this.pbxForeColor.Name = "pbxForeColor";
            this.pbxForeColor.Size = new System.Drawing.Size(20, 20);
            this.pbxForeColor.TabIndex = 2;
            this.pbxForeColor.TabStop = false;
            this.pbxForeColor.Click += new System.EventHandler(this.pbxColor_Click);
            // 
            // frmPersonalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 267);
            this.Controls.Add(this.pbxForeColor);
            this.Controls.Add(this.pbxBackColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonalizar";
            this.Text = "frmPersonalizar";
            this.Load += new System.EventHandler(this.frmPersonalizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForeColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxBackColor;
        private System.Windows.Forms.PictureBox pbxForeColor;
    }
}