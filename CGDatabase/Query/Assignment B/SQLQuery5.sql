SELECT d.Department_Name, d.Location_ID, e.Last_Name, e.Annual_Salary 
FROM Departments d
JOIN Employees e ON d.Department_No = e.Department_No
WHERE d.Location_ID = 1700
ORDER BY d.Department_Name ASC