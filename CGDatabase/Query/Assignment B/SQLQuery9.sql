SELECT d.Department_No, d.Department_Name, Count(*) Employees FROM Departments d
JOIN Employees e ON d.Department_No = e.Department_No
GROUP BY d.Department_No, d.Department_Name 
HAVING Count(*) < 4
