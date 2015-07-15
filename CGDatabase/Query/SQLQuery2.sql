SELECT First_Name, Last_Name, Job_Title, Annual_Salary FROM Employees, Jobs
WHERE Hire_Date > '1999' and Annual_Salary >= 7000 and Jobs.Job_ID = Employees.Job_ID
ORDER BY First_Name DESC