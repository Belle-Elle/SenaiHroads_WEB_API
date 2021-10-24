using SpmedicalGroup_webApi_Proj_Senai.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Interfaces
{
    interface ITipoUsuarioRepositrory
    {

        void Cadastrar(TIpoUsuario novoTipo);
        List<TIpoUsuario> ListarTodos();
        TIpoUsuario BuscarPorId(int idTipo);
        void Atualizar(TIpoUsuario tipoAtualizado);
        void Deletar(int idTipo);


    }
}
