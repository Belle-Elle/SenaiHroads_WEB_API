using SpmedicalGroup_webApi_Proj_Senai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Interfaces
{
    interface IMedicoRepository
    {

        void Cadastrar(Medico novoMedico);
        List<Medico> ListarTodos();
        Medico BuscarPorId(int idMedico);
        void Atualizar(Medico medicoAtualizado);
        void Deletar(int idMedico);

    }
}
