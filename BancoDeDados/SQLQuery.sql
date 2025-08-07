CREATE TABLE NotasFiscais (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Numero NVARCHAR(50) NOT NULL,
    CnpjPrestador NVARCHAR(20) NOT NULL,
    CnpjTomador NVARCHAR(20) NOT NULL,
    DataEmissao DATETIME NOT NULL,
    DescricaoServico NVARCHAR(500),
    ValorServico DECIMAL(18, 2) NOT NULL
);

SELECT * FROM NotasFiscais

DELETE NotasFiscais