select First_Name, Job_ID, Annual_Salary from Employees
where Hire_Date > '1999-01-01' and Annual_Salary >= 7000
order by First_Name desc