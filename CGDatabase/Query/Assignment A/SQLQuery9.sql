SELECT Departments.Department_No, Departments.Department_Name, COUNT(*) as Number_of_Employees FROM Departments
Join Employees ON Employees.Department_No = Departments.Department_No 
GROUP BY Departments.Department_No, Departments.Department_Name
HAVING COUNT(*) > 2


