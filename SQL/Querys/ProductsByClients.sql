SELECT c.name as "Клиент", COUNT(p.Product) AS "Колличество покупок"  FROM Clients AS c, BuyedProducts as p
WHERE c.id = p.Client
GROUP BY c.name