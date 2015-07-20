SELECT DISTINCT Departments.Department_No, Departments.Department_Name FROM Departments
JOIN Employees ON Departments.Department_No = Employees.Department_No
WHERE Employees.Department_No not in 
(SELECT Employees.Department_No from Employees where Job_ID like '%prog%')


--Better Method:

--SELECT d2.Department_No, d2.Department_Name FROM Departments d2
--WHERE  d2.Department_No NOT IN (SELECT DISTINCT(d.Department_No) FROM Employees e
--JOIN Jobs j on e.Job_ID = j.Job_ID
--JOIN Departments d on e.Department_No = d.Department_No
--AND j.Job_Title = 'Programmer'
--)