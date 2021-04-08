SELECT cs.status AS "Статус", COUNT(c.id) AS "Колличество клиентов" FROM ClientStatus AS cs, Clients AS C
WHERE cs.status = c.status
GROUP BY cs.status