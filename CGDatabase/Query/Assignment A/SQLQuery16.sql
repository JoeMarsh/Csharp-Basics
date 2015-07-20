ALTER TABLE Employees
ADD Raise_Percent decimal(2,2), Old_Salary decimal(8,2)
GO
UPDATE Employees
SET Raise_Percent = 
CASE
	WHEN Department_No = 20 THEN 0.05
	WHEN Department_No = 10 THEN 0.05
	WHEN Department_No = 50 THEN 0.10
	WHEN Department_No = 80 THEN 0.10
	WHEN Department_No = 90 THEN 0.10
	WHEN Department_No = 110 THEN 0.10
	ELSE 0.00
	END
GO
UPDATE Employees SET Old_Salary = Annual_Salary
UPDATE Employees SET Annual_Salary *= Raise_Percent 
SELECT Raise_Percent, Employee_No, Old_Salary, Annual_Salary FROM Employees

--Better Method:

--select e.Employee_No, e.Annual_Salary, 
--(
--	CASE
--	  WHEN e.Department_No in (10,20) THEN 0.05
--	  WHEN e.Department_No in (50,80,90,110) THEN 0.1
--	  ELSE 0
--	END
--) as raise
--, (e.Annual_Salary * (1+
--	(
--	CASE
--	  WHEN e.Department_No in (10,20) THEN 0.05
--	  WHEN e.Department_No in (50,80,90,110) THEN 0.1
--	  ELSE 0
--	END
--	))) as new_salary
--from Employees e;