using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MicroPropertiesManagement.Core.Entities;
using Xunit;

namespace MicroPropertiesManagement.Tests
{
    public class PropriedadeTests
    {
        [Fact]
        public void DeveCriarPropriedadeComNomeEProdutos()
        {
            var propriedade = new Propriedade
            {
                Nome = "Fazenda Modelo",
                Localizacao ="Interior",
                Produtos= new List<Produto>
                {
                    new Produto{Nome = "Milho",Tipo = "Insumo", Quantidade = 100}
                }
            
            };
            Assert.Equal("Fazenda Modelo", propriedade.Nome);
            Assert.Single(propriedade.Produtos);
        }
    }
}