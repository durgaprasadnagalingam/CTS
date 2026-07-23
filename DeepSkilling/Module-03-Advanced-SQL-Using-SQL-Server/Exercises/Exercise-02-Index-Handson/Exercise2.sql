-- Exercise 2 : Index Handson

USE CTSModule3;
GO

-- Create Index
CREATE INDEX idx_Department
ON Employees(Department);
GO

-- View Indexes
EXEC sp_helpindex 'Employees';
GO

-- Test Query
SELECT *
FROM Employees
WHERE Department='IT';
GO

-- Drop Index
DROP INDEX idx_Department
ON Employees;
GO