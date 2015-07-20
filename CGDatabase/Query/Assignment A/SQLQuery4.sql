SELECT Last_Name, First_Name, Job_ID, Commission_Percent FROM Employees
WHERE Commission_Percent IS NOT NULL
ORDER BY Last_Name, First_Name