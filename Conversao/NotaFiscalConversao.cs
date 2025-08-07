using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeitorArquivoXml
{
    public class NotaFiscalConversao
    {
        public NotaFiscalModel LerNotaFiscal(string caminhoXml)
        {
            XDocument doc = XDocument.Load(caminhoXml);
            var nota = doc.Descendants("NotaFiscal").FirstOrDefault();
            DateTime.TryParse(nota.Element("DataEmissao")?.Value, out DateTime dataEmissao);
            decimal.TryParse(nota.Element("Servico")?.Element("Valor")?.Value, out decimal valorServico);

            return new NotaFiscalModel
            {
                Numero = nota.Element("Numero")?.Value,
                CnpjPrestador = nota.Element("Prestador")?.Element("CNPJ")?.Value,
                CnpjTomador = nota.Element("Tomador")?.Element("CNPJ")?.Value,
                DataEmissao = dataEmissao,
                DescricaoServico = nota.Element("Servico")?.Element("Descricao")?.Value,
                ValorServico = valorServico
            };
        }
    }
}