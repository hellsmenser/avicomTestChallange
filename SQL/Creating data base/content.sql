INSERT INTO Managers(name) VALUES('������ ���� ��������');
INSERT INTO Managers(name) VALUES('������ ���� ��������');
INSERT INTO Managers(name) VALUES('������� ����� ���������');
INSERT INTO Managers(name) VALUES('�������� ��� ��������');


INSERT INTO Products(name, type, price, period) VALUES('��������� "������"', '��������', 2000, '�����');
INSERT INTO Products(name, type, price, period) VALUES('������ �������', '��������', 200, '');
INSERT INTO Products(name, type, price, period) VALUES('������� "�������"', '��������', 100, '�����');
INSERT INTO Products(name, type, price, period) VALUES('����������� �������� "�������"', '��������', 0, '');
INSERT INTO Products(name, type, price, period) VALUES('���������� ���������� "�����"', '��������', 20000, '���');
INSERT INTO Products(name, type, price, period) VALUES('����� ��� ��������', '��������', 1, '���');


INSERT INTO Clients(name, status, manager) VALUES('���� ���������', '�������� ������', 0);
INSERT INTO Clients(name, status, manager) VALUES('���� �����', '�������� ������', 0);
INSERT INTO Clients(name, status, manager) VALUES('����� �����', '�������� ������', 1);
INSERT INTO Clients(name, status, manager) VALUES('���� ����', '�������� ������', 1);
INSERT INTO Clients(name, status, manager) VALUES('���� �����', '������� ������', 2);
INSERT INTO Clients(name, status, manager) VALUES('���������', '������� ������', 2);
INSERT INTO Clients(name, status, manager) VALUES('������ ��������', '������� ������', 1);
INSERT INTO Clients(name, status, manager) VALUES('����� ������', '������� ������', 2);
INSERT INTO Clients(name, status, manager) VALUES('���� ������', '������� ������', 0);
INSERT INTO Clients(name, status, manager) VALUES('������ ��� ��������', '������� ������', 2);


INSERT INTO BuyedProducts(Client, Product) VALUES(0,0);
INSERT INTO BuyedProducts(Client, Product) VALUES(0,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(0,4);
INSERT INTO BuyedProducts(Client, Product) VALUES(1,4);
INSERT INTO BuyedProducts(Client, Product) VALUES(0,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(1,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(1,2);
INSERT INTO BuyedProducts(Client, Product) VALUES(1,0);
INSERT INTO BuyedProducts(Client, Product) VALUES(2,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(2,0);
INSERT INTO BuyedProducts(Client, Product) VALUES(3,4);
INSERT INTO BuyedProducts(Client, Product) VALUES(3,3);
INSERT INTO BuyedProducts(Client, Product) VALUES(2,4);
INSERT INTO BuyedProducts(Client, Product) VALUES(2,3);
INSERT INTO BuyedProducts(Client, Product) VALUES(3,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(4,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(4,3);
INSERT INTO BuyedProducts(Client, Product) VALUES(5,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(6,0);
INSERT INTO BuyedProducts(Client, Product) VALUES(6,2);
INSERT INTO BuyedProducts(Client, Product) VALUES(7,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(8,1);
INSERT INTO BuyedProducts(Client, Product) VALUES(8,4);
INSERT INTO BuyedProducts(Client, Product) VALUES(8,3);