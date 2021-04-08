SELECT m.name AS "Менеджер", COUNT(c.name) AS "Колличество клиентов" FROM Clients AS c, Managers as m
WHERE c.manager = m.id
GROUP BY m.name