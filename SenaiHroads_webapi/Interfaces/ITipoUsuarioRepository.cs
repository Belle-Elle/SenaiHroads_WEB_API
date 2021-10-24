using SenaiHroads_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Interfaces
{
    interface ITipoUsuarioRepository
    {

        List<TipoUsuarioDomain> Listar();

        TipoUsuarioDomain BuscarPorId(int idTipoUsuario);

        void Cadastrar(TipoUsuarioDomain novoTipoUsuario);

        void Atualizar(int idTipoUsuario, TipoUsuarioDomain tipoUsuarioAtualizado);

        void Deletar(int idTipoUsuario);

    }
}
