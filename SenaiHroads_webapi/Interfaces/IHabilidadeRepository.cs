using SenaiHroads_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Interfaces
{
    interface IHabilidadeRepository
    {

        List<HabilidadeDomain> Listar();

        List<HabilidadeDomain> ListarTudo();

        HabilidadeDomain BuscarPorId(int idHabilidade);

        void Cadastrar(HabilidadeDomain novaHabilidade);

        void Atualizar(int idHabilidade, HabilidadeDomain HabilidadeAtualizada);

        void Deletar(int idHabilidade);

    }
}
