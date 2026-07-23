-- Exercise 5 : Return Data From Stored Procedure

USE CTSModule3;
GO

CREATE OR ALTER PROCEDURE GetEmployeesByDepartment
    @Department VARCHAR(30)
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE Department = @Department;
END;
GO

EXEC GetEmployeesByDepartment 'IT';
GO

EXEC GetEmployeesByDepartment 'HR';
GO