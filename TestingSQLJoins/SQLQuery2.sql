SELECT l.description AS lefty, r.description AS righty
FROM left1 AS l
JOIN right2 AS r
ON l.id = r.id;

SELECT * FROM left1
SELECT * FROM right2