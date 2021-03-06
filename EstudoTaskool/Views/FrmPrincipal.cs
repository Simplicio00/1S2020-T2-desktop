﻿using EstudoTaskool.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTaskool
{
    public partial class FrmPrincipal : Form
    {
        private string logHoraFileName = "log, true_hora.txt";
        string directoryPath = Utils.directoryPath;
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // verifica se o repositório existe e cria o repositório
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string fullFilePath = directoryPath + logHoraFileName;
            // verifica se o arquive existe e o cria
            if (!File.Exists(fullFilePath))
            {
                FileStream fs = File.Create(fullFilePath);

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(DateTime.Now);
                    sw.Close();
                }
            }
            else
            {
                // falar do true no construtor do streamwriter
                using (StreamWriter sw = new StreamWriter(fullFilePath, true))
                {
                    sw.WriteLine(DateTime.Now);
                    sw.Close();
                }
            }

            this.BackColor = Utils.backColor;

            foreach (Control item in this.Controls)
            {
                Label lbl = item as Label;

                if (lbl != null)
                    lbl.ForeColor = Utils.foreColor;
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaUsuario newMDIChild = new frmListaUsuario();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //para fechar o form principal
                this.Close();
                //para sair da aplicação
                Application.Exit();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSobre f = new frmSobre();
            f.ShowDialog(this);
        }
    }
}
