-- Exercise 4 : Execute Stored Procedure

USE CTSModule3;
GO

CREATE OR ALTER PROCEDURE GetEmployeeByID
    @EmpID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE EmpID = @EmpID;
END;
GO

-- Execute Stored Procedure
EXEC GetEmployeeByID 101;
GO

EXEC GetEmployeeByID 104;
GO