using SenaiHroads_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Interfaces
{
    interface ITipoHabilidadeRepository
    {

        List<TipoHabilidadeDomain> Listar();

        TipoHabilidadeDomain BuscarPorId(int idTipohabilidade);

        void Cadastrar(TipoHabilidadeDomain novoTipohabilidade);

        void Atualizar(int idTipohabilidade, TipoHabilidadeDomain TipohabilidadeAtualizada);

        void Deletar(int idTipohabilidade);
    }
}
