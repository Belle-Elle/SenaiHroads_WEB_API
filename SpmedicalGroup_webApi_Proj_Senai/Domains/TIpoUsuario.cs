using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Domains
{
    public class TIpoUsuario
    {

        public TIpoUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public byte IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O título do tipo usuário é necessário")]
        public string TituloTipoUsuario { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}
