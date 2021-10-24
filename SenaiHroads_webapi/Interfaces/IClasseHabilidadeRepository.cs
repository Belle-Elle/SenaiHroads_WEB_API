using SenaiHroads_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Interfaces
{
    interface IClasseHabilidadeRepository
    {

        List<ClasseHabilidadeDomain> Listar();

        ClasseHabilidadeDomain BuscarPorId(int idClasseHabilidade);

        void Cadastrar(ClasseHabilidadeDomain novaClasseHabilidade);

        void Atualizar(int idClasseHabilidade, ClasseHabilidadeDomain ClasseHabilidadeAtualizada);

        void Deletar(int idClasseHabilidade);

    }
}
