SELECT DISTINCT Job_Title FROM Employees 
JOIN Jobs ON Employees.Job_ID = Jobs.Job_ID
JOIN Departments ON Employees.Department_No = Departments.Department_No 
WHERE Department_Name = 'IT' OR Department_Name = 'Sales'
