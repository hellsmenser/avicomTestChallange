SELECT cs.status AS "������", COUNT(c.id) AS "����������� ��������" FROM ClientStatus AS cs, Clients AS C
WHERE cs.status = c.status
GROUP BY cs.status