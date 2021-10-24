using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Domains
{
    public class Paciente
    {

        public Paciente()
        {
            Consulta = new HashSet<Consultas>();
        }

        public int IdPaciente { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Por favor, insira o CPF do paciente")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, insira o RG do paciente")]
        public string Rg { get; set; }
        public string Endereco { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultas> Consulta { get; set; }
    }

}

