CREATE VIEW ManagerInfo AS
(
SELECT * FROM Employees e
WHERE Job_ID like '%MGR'
)
WITH CHECK OPTION


