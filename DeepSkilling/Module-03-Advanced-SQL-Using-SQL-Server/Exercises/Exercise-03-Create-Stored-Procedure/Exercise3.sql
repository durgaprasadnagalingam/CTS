-- Exercise 3 : Create Stored Procedure

USE CTSModule3;
GO

CREATE OR ALTER PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT *
    FROM Employees;
END;
GO

-- Execute Stored Procedure
EXEC GetAllEmployees;
GO