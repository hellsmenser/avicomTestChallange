SELECT c.id, c.name, c.status, m.name AS 'manager' FROM Clients AS c, Managers AS m
WHERE c.manager = m.id