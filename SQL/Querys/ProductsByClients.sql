SELECT c.name as "������", COUNT(p.Product) AS "����������� �������"  FROM Clients AS c, BuyedProducts as p
WHERE c.id = p.Client
GROUP BY c.name