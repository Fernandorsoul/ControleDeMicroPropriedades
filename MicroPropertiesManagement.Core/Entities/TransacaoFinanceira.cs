using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroPropertiesManagement.Core.Entities
{
    public class TransacaoFinanceira
    {
        public int Id{get; set;}
        public decimal Valor {get; set;}
        public DateTime Data {get; set;}
        public string Tipo {get; set;}
        public int PropriedadeId {get; set;}
        public Propriedade propriedade {get; set;}


    }
}