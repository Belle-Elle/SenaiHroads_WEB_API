using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Domains
{
    public partial class UsuarioDomain
    {
        public UsuarioDomain()
        {
            Personagens = new HashSet<PersonagemDomain>();
        }


        public int IdUsuario { get; set; }
        public byte? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuarioDomain IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<PersonagemDomain> Personagems { get; set; }
        public HashSet<PersonagemDomain> Personagens { get; }
    }
}
