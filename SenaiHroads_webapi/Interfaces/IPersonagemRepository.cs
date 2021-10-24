using SenaiHroads_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Interfaces
{
    interface IPersonagemRepository
    {

        List<PersonagemDomain> Listar();

        List<PersonagemDomain> ListarTudo();

        PersonagemDomain BuscarPorId(int idPersonagem);

        void Cadastrar(PersonagemDomain novoPersonagem);

        void Atualizar(int idPersonagem, PersonagemDomain personagemAtualizado);

        void Deletar(int idPersonagem);
    }
}
