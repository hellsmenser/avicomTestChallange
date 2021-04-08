INSERT INTO Managers(name) VALUES('Иванов Иван Иванович');
INSERT INTO Managers(name) VALUES('Петров Петр Петрович');
INSERT INTO Managers(name) VALUES('Семенов Семен Семенович');
INSERT INTO Managers(name) VALUES('Менеджер для удаления');


INSERT INTO Products(name, type, price, period) VALUES('Антивирус "Кайзер"', 'Подписка', 2000, 'Месяц');
INSERT INTO Products(name, type, price, period) VALUES('Парсер котиков', 'Лицензия', 200, '');
INSERT INTO Products(name, type, price, period) VALUES('Фаервол "Дуршлаг"', 'Подписка', 100, 'Месяц');
INSERT INTO Products(name, type, price, period) VALUES('Калькулятор финансов "Нищенка"', 'Лицензия', 0, '');
INSERT INTO Products(name, type, price, period) VALUES('Управление персоналом "Пешка"', 'Подписка', 20000, 'Год');
INSERT INTO Products(name, type, price, period) VALUES('Товар для удаления', 'Подписка', 1, 'Год');


INSERT INTO Clients(name, status, manager) VALUES('Марк Цукенберг', 'Ключевой клиент', 0);
INSERT INTO Clients(name, status, manager) VALUES('Стив Джобс', 'Ключевой клиент', 0);
INSERT INTO Clients(name, status, manager) VALUES('Павел Дуров', 'Ключевой клиент', 1);
INSERT INTO Clients(name, status, manager) VALUES('Илон Маск', 'Ключевой клиент', 1);
INSERT INTO Clients(name, status, manager) VALUES('Билл Гейтс', 'Обычный клиент', 2);
INSERT INTO Clients(name, status, manager) VALUES('Бэнджамин', 'Обычный клиент', 2);
INSERT INTO Clients(name, status, manager) VALUES('Эллиот Алдерсон', 'Обычный клиент', 1);
INSERT INTO Clients(name, status, manager) VALUES('Кевин Митник', 'Обычный клиент', 2);
INSERT INTO Clients(name, status, manager) VALUES('Стив Возняк', 'Обычный клиент', 0);
INSERT INTO Clients(name, status, manager) VALUES('Клиент для удаления', 'Обычный клиент', 2);


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