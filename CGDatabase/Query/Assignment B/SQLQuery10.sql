SELECT TOP 1 d.Department_No, d.Department_Name, Count(*) Employees 
FROM Departments d
JOIN Employees e ON d.Department_No = e.Department_No
GROUP BY d.Department_No, d.Department_Name 
ORDER BY Count(*) ASC