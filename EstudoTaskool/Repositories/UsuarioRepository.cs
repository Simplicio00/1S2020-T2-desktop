using EstudoTaskool.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoTaskool.Repositories
{
    public class UsuarioRepository
    {

        public UsuarioRepository()
        {
            
        }

        public List<Usuario> buscarTodos()
        {
            //return usuarios;
            try
            {
                using (TaskoolEntities ent = new TaskoolEntities())
                {
                    return ent.Usuario.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void adicionar(Usuario usuario)
        {
            //usuario.Codigo = contador;

            //usuarios.Add(usuario);
            //contador++;

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
                Usuario u = ent.Usuario.FirstOrDefault(
                    x => x.Codigo == usuario.Codigo);

                if (u != null)
                {
                    u.Nome = usuario.Nome;
                    u.Email = usuario.Email;
                    u.Telefone = usuario.Telefone;
                    u.Senha = usuario.Senha;
                    u.Username = usuario.Username;
                    ent.SaveChanges(); 
                }
            }

        }

        public void deletar(int codigo)
        {
            //// recupero o usuário atraves do código
            //Usuario usuario = usuarios.Find(x => x.Codigo == codigo);

            //// removo o usuário da lista;
            //usuarios.Remove(usuario);

            using(TaskoolEntities ent = new TaskoolEntities())
            {
                Usuario usuario = ent.Usuario.First(
                    x => x.Codigo == codigo);

                if(usuario != null)
                {
                    ent.Usuario.Remove(usuario);
                    ent.SaveChanges();
                }
            }
        }
    }
}
