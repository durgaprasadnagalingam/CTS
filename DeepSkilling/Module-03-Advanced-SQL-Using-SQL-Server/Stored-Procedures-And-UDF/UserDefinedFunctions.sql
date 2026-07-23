IF OBJECT_ID('dbo.fn_CalculateBonus', 'FN') IS NOT NULL
    DROP FUNCTION dbo.fn_CalculateBonus;
GO

CREATE FUNCTION dbo.fn_CalculateBonus
(
    @Salary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @Salary * 0.10;
END;
GO

SELECT dbo.fn_CalculateBonus(50000) AS BonusAmount;