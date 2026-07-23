-- Views and Indexes : Views

USE CTSModule3;
GO

DROP VIEW IF EXISTS EmployeeDetails;
GO

DROP TABLE IF EXISTS Employees;
GO

CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);
GO

INSERT INTO Employees
VALUES
(1,'John','Smith','IT',4000),
(2,'Jane','Wilson','HR',6500),
(3,'David','Miller','Finance',7200),
(4,'Sara','Brown','IT',5500);
GO

CREATE VIEW EmployeeDetails
AS
SELECT
    EmployeeID,
    FirstName,
    LastName,
    Department,
    Salary
FROM Employees;
GO

SELECT *
FROM EmployeeDetails;
GO