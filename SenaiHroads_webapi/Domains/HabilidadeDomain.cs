using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Domains
{
    public partial class HabilidadeDomain
    {
        public HabilidadeDomain()
        {
            ClasseHabilidades = new HashSet<ClasseHabilidadeDomain>();
        }

        public byte IdHabilidade { get; set; }
        public byte? IdTipoHabilidade { get; set; }
        public string NomeHabilidade { get; set; }

        public virtual Tipohabilidade IdTipoHabilidadeNavigation { get; set; }
        public virtual ICollection<ClasseHabilidadeDomain> ClasseHabilidades { get; set; }
        public virtual ICollection<ClasseHabilidadeDomain> ClasseHabilidades { get; set; }
    }
}
