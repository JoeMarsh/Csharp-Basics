SELECT Last_Name, First_Name, Employee_No, Hire_Date FROM Employees
JOIN Jobs on Jobs.Job_ID = Employees.Job_ID
WHERE Hire_Date <= '1991-05-21' AND Job_Title = 'Programmer'
ORDER BY Last_Name ASC