SELECT CAST(SUM(e.Annual_Salary / 12) AS INT) Average_Total_Salary FROM Employees e
WHERE e.Department_No = 80 OR e.Department_No = 60