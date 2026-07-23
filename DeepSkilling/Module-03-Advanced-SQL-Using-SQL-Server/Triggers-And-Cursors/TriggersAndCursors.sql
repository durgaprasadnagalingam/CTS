-- Triggers and Cursors

USE CTSModule3;
GO

DROP TABLE IF EXISTS EmployeeAudit;
DROP TABLE IF EXISTS Employees;
GO

CREATE TABLE Employees
(
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT
);
GO

CREATE TABLE EmployeeAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    EmpID INT,
    ActionPerformed VARCHAR(20),
    ActionDate DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO Employees
VALUES
(101,'Raj','IT',60000),
(102,'Rahul','IT',75000),
(103,'Priya','HR',50000),
(104,'Sneha','HR',65000);
GO

-- Create Trigger
CREATE OR ALTER TRIGGER trg_AfterInsertEmployee
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeAudit(EmpID, ActionPerformed)
    SELECT EmpID, 'INSERT'
    FROM inserted;
END;
GO

-- Test Trigger
INSERT INTO Employees
VALUES
(105,'Kiran','Sales',55000);
GO

SELECT * FROM EmployeeAudit;
GO

--------------------------------------------------
-- Cursor Example
--------------------------------------------------

DECLARE @EmpName VARCHAR(50);

DECLARE EmployeeCursor CURSOR FOR
SELECT EmpName
FROM Employees;

OPEN EmployeeCursor;

FETCH NEXT FROM EmployeeCursor INTO @EmpName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @EmpName;
    FETCH NEXT FROM EmployeeCursor INTO @EmpName;
END

CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;
GO