INSERT INTO Sal_History (Emp_ID, First_Name, Last_Name, Hire_Date, Sal)
SELECT Employee_No, First_Name, Last_Name, Hire_Date, Annual_Salary FROM Employees
WHERE Employee_No <= 130 