ALTER TABLE Employees
ADD Raise_Percent int, Old_Salary int
UPDATE Employees SET Old_Salary = Annual_Salary
UPDATE Employees SET Annual_Salary *= 1.05, Raise_Percent = 0.05
WHERE Department_No = 20 AND Department_No = 10

SELECT * FROM Employees

