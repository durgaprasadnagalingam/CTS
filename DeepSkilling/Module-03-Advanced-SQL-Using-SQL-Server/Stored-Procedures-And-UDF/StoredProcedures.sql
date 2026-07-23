DROP TABLE IF EXISTS Employees;

CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2)
);
GO

CREATE OR ALTER PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Employees(FirstName, LastName, DepartmentID, Salary)
    VALUES(@FirstName, @LastName, @DepartmentID, @Salary);
END;
GO

EXEC sp_InsertEmployee 'John', 'Smith', 1, 6000;
EXEC sp_InsertEmployee 'Jane', 'Wilson', 2, 7000;

SELECT *
FROM Employees;