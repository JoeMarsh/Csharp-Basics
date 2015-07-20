SELECT DISTINCT j.Job_Title FROM Departments d
JOIN Employees e on d.Department_No = e.Department_No
JOIN Jobs j on e.Job_ID = j.Job_ID
WHERE d.Department_Name = 'Marketing' OR d.Department_Name = 'Accounting'