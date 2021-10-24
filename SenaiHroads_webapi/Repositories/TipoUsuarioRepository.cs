using SenaiHroads_webapi.Domains;
using SenaiHroads_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        public void Atualizar(int idTipoUsuario, TipoUsuarioDomain tipoUsuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public TipoUsuarioDomain BuscarPorId(int idTipoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TipoUsuarioDomain novoTipoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idTipoUsuario)
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuarioDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
