SELECT name AS Employee
FROM Employee
JOIN Employee m ON managerId = m.id
WHERE m.salary < salary