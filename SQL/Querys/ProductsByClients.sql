SELECT p.name AS "������������", COUNT(c.Client) AS "�������"
FROM Products AS p, BuyedProducts AS c
WHERE p.id = c.product
GROUP BY p.name