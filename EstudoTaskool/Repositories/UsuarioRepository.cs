using EstudoTaskool.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstudoTaskool.Repositories
{
    public class UsuarioRepository
    {
        private static List<Usuario> usuarios;
        private static int contador = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    Codigo = 1,
                    Nome = "Erik",
                    Email = "erik@email",
                    Senha = "1234",
                    Telefone = "123456789",
                    Username = "evitelli"
                }
               );
                contador++;
                usuarios.Add(new Usuario
                {
                    Codigo = 2,
                    Nome = "Marcelo",
                    Email = "marcelo@gmail",
                    Senha = "1234",
                    Telefone = "123456789",
                    Username = "marcelinho"
                }
                );
                contador++;
            }
        }

        public List<Usuario> buscarTodos()
        {
            // return usuarios;

            using (TaskoolEntities ent = new TaskoolEntities())
            {
                return ent.Usuario.ToList();
            }
        }

        public void adicionar(Usuario usuario)
        {
            using (TaskoolEntities ent = new TaskoolEntities())
            {
                ent.Usuario.Add(usuario);
                ent.SaveChanges();
            }
        }

        public void editar(Usuario usuario)
        {
            // pegar a posição o objeto dentro da lista
            //Usuario u = usuarios.Find(x => x.Codigo == usuario.Codigo);
            //usuarios[usuarios.IndexOf(u)] = usuario;

            using (TaskoolEntities ent = new TaskoolEntities())
            {
                Usuario u = ent.Usuario.FirstOrDefault(x => x.Codigo == usuario.Codigo);
                u.Nome = usuario.Nome;
                u.Email = usuario.Email;
                u.Telefone = usuario.Telefone;
                u.Senha = usuario.Senha;
                u.Username = usuario.Username;
                ent.SaveChanges();
            }
        }

        public void deletar(int codigo)
        {
            // recupero o usuário atraves do código
            //Usuario usuario = usuarios.Find(x => x.Codigo == codigo);

            //// removo o usuário da lista;
            //usuarios.Remove(usuario);

            using (TaskoolEntities ent = new TaskoolEntities())
            {
                Usuario usuario = ent.Usuario.First(x => x.Codigo == codigo);

                if (usuario != null)
                {
                    ent.Usuario.Remove(usuario);
                    ent.SaveChanges();
                }
            }
        }
    }
}
