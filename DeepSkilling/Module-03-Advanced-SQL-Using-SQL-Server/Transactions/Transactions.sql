-- Transactions

USE CTSModule3;
GO

DROP TABLE IF EXISTS Accounts;
GO

CREATE TABLE Accounts
(
    AccountID INT PRIMARY KEY,
    AccountHolder VARCHAR(50),
    Balance DECIMAL(10,2)
);
GO

INSERT INTO Accounts
VALUES
(101,'Raj',50000),
(102,'Rahul',30000);
GO

-- Display initial data
SELECT * FROM Accounts;
GO

BEGIN TRANSACTION;

UPDATE Accounts
SET Balance = Balance - 5000
WHERE AccountID = 101;

UPDATE Accounts
SET Balance = Balance + 5000
WHERE AccountID = 102;

COMMIT TRANSACTION;
GO

-- Display updated data
SELECT * FROM Accounts;
GO