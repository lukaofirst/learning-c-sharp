using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EFCore.Dominio {
    public class Heroi {
        public int Id { get; set; }
        public string Nome { get; set; }

        /* Criando relacionamento um para muitos (one to one) */
        public IdentidadeSecreta Identidade { get; set; }

        /* Criando relacionamento muitos para muitos (many to many) */
        public List<Arma> Armas { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }
    }
}
