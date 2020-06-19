using EstudoTaskool.Database;
using EstudoTaskool.Repositories;
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
    public partial class frmListaUsuario : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        public frmListaUsuario()
        {
            InitializeComponent();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            
            carregaLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
            carregaLista();
        }

        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvListaAluno.Rows[e.RowIndex];

            string nome = linha.Cells[1].Value.ToString();
            string email = linha.Cells[2].Value.ToString();
            string userName = linha.Cells[3].Value.ToString();
            string senha = linha.Cells[4].Value.ToString();
            string telefone = linha.Cells[5].Value.ToString();
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

            Usuario usuario = new Usuario
            {
                Codigo = codigo,
                Nome = nome,
                Email = email,
                Senha = senha,
                Telefone = telefone,
                Username = userName,

            };

            new frmCadastro(usuario).ShowDialog();

            carregaLista();
        }

        private void dgvListaAluno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvListaAluno.Rows[e.RowIndex];

                    int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
                    
                    repository.deletar(codigo);

                    carregaLista();
                }
            }
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListaAluno.DataSource = null;
            dgvListaAluno.DataSource = repository.buscarTodos();
            alterarContador();
        }

        private void filtroTextbox_TextChanged(object sender, EventArgs e)
        {
            dgvListaAluno.DataSource = null;

            // filtra as lista recebida do repositório, verificando se o nome, 
            // email, usuario, contém o que está no campo filtro.
            dgvListaAluno.DataSource = repository.buscarTodos().FindAll(x =>
                x.Nome.ToUpper().Contains(filtroTextbox.Text.ToUpper()) ||
                x.Email.ToUpper().Contains(filtroTextbox.Text.ToUpper()) ||
                x.Username.ToUpper().Contains(filtroTextbox.Text.ToUpper()) 
            );

            alterarContador();
            
        }

        private void alterarContador()
        {
            //2 itens de 10
            lblContador.Text = $"{dgvListaAluno.RowCount} itens de {repository.buscarTodos().Count}";
        }
    }
}
