SELECT DISTINCT Departments.Department_No, Departments.Department_Name FROM Departments
JOIN Employees ON Departments.Department_No = Employees.Department_No
WHERE Employees.Department_No not in 
(SELECT Employees.Department_No from Employees where Job_ID like '%prog%')