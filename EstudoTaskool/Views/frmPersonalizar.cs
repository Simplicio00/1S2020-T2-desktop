using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTaskool.Views
{
    public partial class frmPersonalizar : Form
    {
        public frmPersonalizar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmPersonalizar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            pbxBackColor.BackColor = this.BackColor;
            pbxForeColor.BackColor = Color.Black;

            salvarCor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            PictureBox pbx = sender as PictureBox;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pbx.BackColor = colorDialog.Color;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarCor();
            this.Close();
        }

        private void salvarCor()
        {
            Utils.backColor = pbxBackColor.BackColor;
            Utils.foreColor = pbxForeColor.BackColor;
        }
    }
}
