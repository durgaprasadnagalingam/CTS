-- Exercise 6 : Scalar Function

USE CTSModule3;
GO

CREATE OR ALTER FUNCTION GetAnnualSalary
(
    @Salary INT
)
RETURNS INT
AS
BEGIN
    RETURN @Salary * 12;
END;
GO

SELECT
    EmpName,
    Salary,
    dbo.GetAnnualSalary(Salary) AS AnnualSalary
FROM Employees;
GO