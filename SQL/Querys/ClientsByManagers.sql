SELECT m.name AS "��������", COUNT(c.name) AS "����������� ��������" FROM Clients AS c, Managers as m
WHERE c.manager = m.id
GROUP BY m.name