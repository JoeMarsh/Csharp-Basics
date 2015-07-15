Select * from Jobs
where Min_Salary IS NOT NULL AND Min_Salary> 5000 AND Job_Title LIKE '%manage%' 
order by Min_Salary DESC
