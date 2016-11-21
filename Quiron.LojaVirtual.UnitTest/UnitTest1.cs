using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Web;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using System.Linq; 

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void TestarSeaPaginacaoEstaSendoGeradaCorretamente()
        {
            //Arrange
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                itensPorPagina = 28,
                ItensTotal = 10              
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;


            //act
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            //Assert
            Assert.AreEqual
                (
                    @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                    + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                    + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
                );
        }
    }
}
