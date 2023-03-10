CREATE TABLE [dbo].[Stanovi] (
    [Stan_ID]                INT             IDENTITY (1, 1) NOT NULL,
    [Ime_stanara]            VARCHAR (20)    NOT NULL,
    [Prezime_stanara]        VARCHAR(20)   NOT NULL,
    [JMBG]                   NVARCHAR (13)   NULL,
    [Sprat]                  SMALLINT        NULL,
    [Broj_stana]             INT             NOT NULL,
    [Datum_useljenja]        DATE            NULL,
    [Broj_soba]              SMALLINT        NULL,
    [Posjedovanje_ljubimca]  BIT             NULL,
    [Cijene_rezija_mjesecno] DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([Stan_ID] ASC)
);

