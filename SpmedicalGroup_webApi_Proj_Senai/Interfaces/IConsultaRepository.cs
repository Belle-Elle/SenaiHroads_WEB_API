using SpmedicalGroup_webApi_Proj_Senai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Interfaces
{
    interface IConsultaRepository
    {

        void Cadastrar(Consultas novaConsulta);
        List<Consultas> ListarTodas();
        Consultas BuscarPorId(int idConsulta);
        void Atualizar(Consultas consultaAtt);
        void Deletar(int idConsulta);
        List<Consultas> ListarMinhasPaciente(int idPaciente);
        List<Consultas> ListarMinhasMedico(int idMedico);
        void AddDescricao(int idConsulta, string descricao, int id);
        void MudarSituacao(int idConsulta, string status);

    }
}
