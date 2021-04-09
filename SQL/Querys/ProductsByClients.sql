SELECT p.name AS "Наименование", COUNT(c.Client) as "Покупок"
FROM Products AS p, BuyedProducts as c
WHERE p.id = c.product
GROUP BY p.name