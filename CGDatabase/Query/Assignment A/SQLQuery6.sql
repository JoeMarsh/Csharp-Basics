SELECT Last_Name, CAST(ROUND(Annual_Salary/12, 2) as DECIMAL(10,2)) FROM Employees
WHERE Department_No = 50 or Department_No = 90
ORDER BY Last_Name ASC