using SenaiHroads_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Interfaces
{
    interface IClasseRepository
    {
        Classe BuscarPorId(int idClasse);

        List<Classe> Listar();

        List<Classe> ListarAll();

        void Cadastrar(Classe novaClasse);

        void Atualizar(int idClasse, Classe classeAtualizada);

        void Deletar(int idClasse);
    }
}
