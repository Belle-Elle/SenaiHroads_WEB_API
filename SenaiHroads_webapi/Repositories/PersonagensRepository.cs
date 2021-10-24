using SenaiHroads_webapi.Domains;
using SenaiHroads_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Repositories
{
    public class PErsonagensRepository : IPersonagemRepository
    {
        public void Atualizar(int idPersonagem, PersonagemDomain personagemAtualizado)
        {
            throw new NotImplementedException();
        }

        public PersonagemDomain BuscarPorId(int idPersonagem)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PersonagemDomain novoPersonagem)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idPersonagem)
        {
            throw new NotImplementedException();
        }

        public List<PersonagemDomain> Listar()
        {
            throw new NotImplementedException();
        }

        public List<PersonagemDomain> ListarTudo()
        {
            throw new NotImplementedException();
        }
    }
}
