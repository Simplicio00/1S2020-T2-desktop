using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace EstudoTaskool
{
    public partial class frmLogin : Form
    {
        private string directoryPath = Utils.directoryPath;
        private string fullFilePath;
        public frmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | Taskool";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //para bloquear o Ctrl C + Ctrl V
            tbxUsuario.ShortcutsEnabled = false;

            fullFilePath = directoryPath + "log_login.txt";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else
            {
                if (chxManterConectado.Checked)
                {
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    using (StreamWriter sw = new StreamWriter(fullFilePath))
                    {
                        sw.Write(tbxUsuario.Text);
                        sw.Close();
                    } 
                }
                MessageBox.Show("Bem Vindo", "Entrada");
                this.Hide();
                new FrmPrincipal().ShowDialog();
                this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(fullFilePath))
            {
                using(StreamReader sr = new StreamReader(fullFilePath))
                {
                    string username = sr.ReadToEnd();

                    if (username.Trim().Length != 0)
                    {
                        new FrmPrincipal().ShowDialog();
                        this.Close(); 
                    }
                }
            }

            //esconde a label
            lblCaps.Visible = isCapsLockActive();
        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }

        private bool isCapsLockActive()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }

        private void tbxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            lblCaps.Visible = false;
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            //para funcionar esse processo precisa alterar a configura
            System.Diagnostics.Process.Start("osk.exe");
            tbxUsuario.Focus();
        }
    }

}