using SenaiHroads_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Interfaces
{
    interface IUsuarioRepository_cs
    {

        List<UsuarioDomain> Listar();

        List<UsuarioDomain> ListarComTipo();

        List<UsuarioDomain> ListarTudo();

        UsuarioDomain BuscarPorId(int idUsuario);

        void Cadastrar(UsuarioDomain novoUsuario);

        void Atualizar(int idUsuario, UsuarioDomain usuarioAtualizado);

        void Deletar(int idUsuario);

        UsuarioDomain BuscarPorEmailSenha(string email, string senha);

    }
}
