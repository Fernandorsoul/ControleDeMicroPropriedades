using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroPropertiesManagement.Core.Entities
{
    public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Tipo {get; set;}
        public int Quantidade {get; set;}
        public int PropriedadeId {get; set;}
        public Propriedade Propriedade {get; set;}
    }
}