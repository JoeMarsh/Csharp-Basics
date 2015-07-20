SELECT e.Department_No, e.Last_Name, e.First_Name, e.Phone_Number, e.Hire_Date 
FROM Employees e
WHERE e.Hire_Date >= '1998-03-24'
ORDER BY Last_Name ASC