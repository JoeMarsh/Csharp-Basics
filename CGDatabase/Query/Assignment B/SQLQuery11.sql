SELECT d.Department_No, d.Department_Name FROM Departments d
WHERE  d.Department_No NOT IN (SELECT DISTINCT(d.Department_No) FROM Employees e
JOIN Jobs j on e.Job_ID = j.Job_ID
JOIN Departments d on e.Department_No = d.Department_No
AND j.Job_Title = 'Sales Representative')