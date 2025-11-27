CREATE DATABASE CalculadoraDB;
GO

USE CalculadoraDB;
GO

CREATE TABLE Calculos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Numero1 FLOAT NOT NULL,
    Numero2 FLOAT NOT NULL,
    Operacion NVARCHAR(50) NOT NULL,
    Resultado FLOAT NOT NULL,
    FechaCalculo DATETIME NOT NULL
);