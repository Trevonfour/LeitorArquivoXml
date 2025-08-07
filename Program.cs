using LeitorArquivoXml;
using LeitorArquivoXml.Data;

string nomeArquivo = "notafiscal2.xml";
string caminhoXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ArquivosXml", nomeArquivo);

NotaFiscalModel notaFiscal = new NotaFiscalConversao().LerNotaFiscal(caminhoXml);
NotaFiscalRepository notaFiscalRepository = new NotaFiscalRepository();


notaFiscalRepository.SalvarNotaFiscal(notaFiscal);
Console.WriteLine("Nota fiscal salva com sucesso!");


