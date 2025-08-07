using Microsoft.Data.SqlClient;
using Dapper;

namespace LeitorArquivoXml.Data
{
    public class NotaFiscalRepository
    {
        private readonly string conexaoString = @"Server=ALEXANDREDESK\SQLEXPRESS;Database=LEITORXML;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        
        public void SalvarNotaFiscal(NotaFiscalModel nota)
        {
            using (var conexao = new SqlConnection(conexaoString))
            {
                string query = @"
                    INSERT INTO NotasFiscais 
                    (Numero, CnpjPrestador, CnpjTomador, DataEmissao, DescricaoServico, ValorServico)
                    VALUES 
                    (@Numero, @CnpjPrestador, @CnpjTomador, @DataEmissao, @DescricaoServico, @ValorServico)";

                conexao.Execute(query, nota);
            }
        }
    }
}