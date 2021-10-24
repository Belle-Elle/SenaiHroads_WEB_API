using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Domains
{
    public partial class TipoUsuarioDomain
    {
        public TipoUsuarioDomain()
        {
            Usuarios = new HashSet<UsuarioDomain>();
        }

        public byte IdTipoUsuario { get; set; }
        public string Titulo { get; set; }

        public virtual ICollection<UsuarioDomain> Usuarios { get; set; }
    }
}
