ALTER TABLE Employees
ADD Raise_Percent int, Old_Salary int
UPDATE Employees SET Old_Salary = Annual_Salary
UPDATE Employees SET Raise_Percent = 0.0
UPDATE Employees SET Annual_Salary *= 1.05, Raise_Percent = 0.05 
	WHERE Department_No = 20 OR Department_No = 10
UPDATE Employees SET Annual_Salary *= 1.10, Raise_Percent = 0.10 
	WHERE Department_No = 50 OR Department_No = 80 OR Department_No = 90 OR Department_No = 110

SELECT * FROM Employees



