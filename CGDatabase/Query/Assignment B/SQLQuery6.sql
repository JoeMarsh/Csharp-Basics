SELECT e.Last_Name, e.First_Name
FROM Employees e
WHERE DATENAME(month, e.Hire_Date) = 'June' OR DATENAME(month, e.Hire_Date) = 'August'
ORDER BY e.Last_Name ASC