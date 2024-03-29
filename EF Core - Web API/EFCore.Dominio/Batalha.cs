﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Dominio {
    public class Batalha {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }

        /* Criando relacionamento muitos para muitos (many to many) */
        public List<HeroiBatalha> HeroisBatalhas { get; set; }
    }
}
