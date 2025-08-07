using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeitorArquivoXml
{
    public class NotaFiscalModel
    {
        public string Numero { get; set; }
        public string CnpjPrestador { get; set; }
        public string CnpjTomador { get; set; }
        public DateTime DataEmissao { get; set; }
        public string DescricaoServico { get; set; }
        public decimal ValorServico { get; set; }
    }
}