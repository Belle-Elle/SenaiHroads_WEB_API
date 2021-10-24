using SpmedicalGroup_webApi_Proj_Senai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Interfaces
{
    interface IEspecialidadeRepository
    {

        void Cadastrar(Especialidades novaEspecialidade);
        List<Especialidades> ListarTodas();
        Especialidades BuscarPorId(int idEspecialidade);
        void Atualizar(Especialidades especialidadeAtt);
        void Deletar(int idEspecialidade);

    }
}
