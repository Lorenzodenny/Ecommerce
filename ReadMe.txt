CREATE TABLE prodotti (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100),
    descrizione VARCHAR(200),
    prezzo DECIMAL(10, 2)
);

Ho aggiiuto la possibilità di inserire dati nel database,  anche se sò che un ecommerce ovviament lato client non ce l'ha era tanto per semplificare l'inserimento post creazione del DB