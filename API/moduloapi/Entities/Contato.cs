using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moduloapi.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Telefone { get; set; }
        public int Ativo { get; set; }
    }
}