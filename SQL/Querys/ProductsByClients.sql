SELECT p.name AS "Наименование", COUNT(c.Client) AS "Покупок"
FROM Products AS p, BuyedProducts AS c
WHERE p.id = c.product
GROUP BY p.name