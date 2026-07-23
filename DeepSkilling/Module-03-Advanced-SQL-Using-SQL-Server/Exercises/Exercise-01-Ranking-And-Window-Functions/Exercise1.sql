-- Exercise 1.1
SELECT
    EmpID,
    EmpName,
    Department,
    Salary,
    ROW_NUMBER() OVER(ORDER BY Salary DESC) AS Row_Number
FROM Employees;

GO

-- Exercise 1.2
SELECT
    EmpID,
    EmpName,
    Department,
    Salary,
    RANK() OVER(ORDER BY Salary DESC) AS Rank_Number
FROM Employees;

GO

-- Exercise 1.3
SELECT
    EmpID,
    EmpName,
    Department,
    Salary,
    DENSE_RANK() OVER(ORDER BY Salary DESC) AS Dense_Rank
FROM Employees;