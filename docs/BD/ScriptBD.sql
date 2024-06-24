create database energia;

CREATE TABLE Pessoa
(
    Id INT NOT NULL IDENTITY(1,1),
    Email NVARCHAR(50) NOT NULL,
    Telefone NVARCHAR(11)

    PRIMARY KEY (Id)
);

CREATE TABLE ContaDeEnergia 
(
    NumInstalacao NVARCHAR(20) NOT NULL,
    IdPessoa INT NOT NULL,
    KWhMesAtual INT,
    KWhMesAnterior INT,

    PRIMARY KEY(NumInstalacao),
    FOREIGN KEY(IdPessoa) REFERENCES Pessoa(Id)
);

CREATE TABLE PessoaFisica
(
    CPF NVARCHAR(11),
    IdPessoa INT NOT NULL,
    Nome NVARCHAR(80),

    PRIMARY KEY(CPF),
    FOREIGN KEY (IdPessoa) REFERENCES Pessoa(Id)
);

CREATE TABLE PessoaJuridica
(
    CNPJ NVARCHAR(14),
    IdPessoa INT NOT NULL,
    RazaoSocial NVARCHAR(80),

    PRIMARY KEY(CNPJ),
    FOREIGN KEY (IdPessoa) REFERENCES Pessoa(Id)
);

CREATE TABLE Login
(
    Id INT NOT NULL,
    Senha NVARCHAR(15),

    FOREIGN KEY(Id) REFERENCES Pessoa(Id),
    PRIMARY KEY (Id)
);

CREATE TABLE Administrador
(
    Matricula INT NOT NULL IDENTITY(100,2),
    IdPessoa INT NOT NULL,
    Nome NVARCHAR(80),

    FOREIGN KEY (IdPessoa) REFERENCES Pessoa(Id),
    PRIMARY KEY (Matricula)
);

CREATE TABLE Leiturista
(
    Matricula INT NOT NULL IDENTITY(101,2),
    IdPessoa INT NOT NULL,
    Nome NVARCHAR(80),

    FOREIGN KEY (IdPessoa) REFERENCES Pessoa(Id),
    PRIMARY KEY (Matricula)
);