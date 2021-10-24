using Microsoft.AspNetCore.Http;
using SpmedicalGroup_webApi_Proj_Senai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Interfaces
{
    interface IUsuarioRepository
    {

        Usuario Login(string email, string senha);
        void Cadastrar(Usuario novoUsuario);
        List<Usuario> ListarTodos();
        Usuario BuscarPorId(int idUsuario);
        void Atualizar(Usuario usuarioAtualizado);
        void Deletar(int idUsuario);

        void SalvarPerfilDir(IFormFile foto, int idUsuario);
        string ConsultarPerfilDir(int idUsuario);

    }
}
