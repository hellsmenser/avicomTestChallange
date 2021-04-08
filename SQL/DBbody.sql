CREATE TABLE Manager(
	id INT NOT NULL IDENTITY(0,1),
	name VARCHAR(30) NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE Client(
	id INT NOT NULL IDENTITY(0,1),
	name VARCHAR(30) NOT NULL,
	status VARCHAR(15) NOT NULL,
	manager VARCHAR(30) NOT NULL,
	buyedProduct INT,
	PRIMARY KEY(id)
);

CREATE TABLE ClientStatus(
	status VARCHAR(15) NOT NULL,
	PRIMARY KEY(status)
);

INSERT INTO ClientStatus(status) VALUES('Ключевой клиент');
INSERT INTO ClientStatus(status) VALUES('Обычный клиент');

CREATE TABLE Product(
	id INT NOT NULL IDENTITY(0,1),
	name VARCHAR(30) NOT NULL,
	type VARCHAR(8) NOT NULL,
	price INT NOT NULL,
	period VARCHAR(7) NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE BuyedProduct(
	Client INT NOT NULL,
	Product INT NOT NULL,
	PRIMARY KEY(Client, Product)
);
