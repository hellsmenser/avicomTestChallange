SELECT p.name AS "������������", COUNT(c.Client) as "�������"
FROM Products AS p, BuyedProducts as c
WHERE p.id = c.product
GROUP BY p.name