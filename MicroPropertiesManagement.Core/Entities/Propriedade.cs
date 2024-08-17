using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroPropertiesManagement.Core.Entities
{
    public class Propriedade
    {
        public int Id {get; set;}
        public string Nome{get; set;}
        public string Localizacao {get; set;}
        public ICollection<Produto> Produtos{get; set;}
    }
}