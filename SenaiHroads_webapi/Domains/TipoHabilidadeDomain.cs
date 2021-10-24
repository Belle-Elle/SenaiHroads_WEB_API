using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Domains
{
    public partial class TipoHabilidadeDomain
    {
        public TipoHabilidadeDomain()
        {
            Habilidades = new HashSet<HabilidadeDomain>();
        }

        public byte IdTipoHabilidade { get; set; }
        public string NomeTipoHabilidade { get; set; }

        public virtual ICollection<HabilidadeDomain> Habilidades { get; set; }
    }
}
