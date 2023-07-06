CREATE DATABASE TaskList;


CREATE TABLE Tasks (
    Id INT PRIMARY KEY IDENTITY,
    Title VARCHAR(100) NOT NULL,
    Description VARCHAR(500),
    DueDate DATE,
    Priority INT
);
