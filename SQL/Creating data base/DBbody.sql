CREATE TABLE Managers(
	id INT NOT NULL IDENTITY(0,1),
	name VARCHAR(30) NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE ClientStatus(
	status VARCHAR(15) NOT NULL,
	PRIMARY KEY(status)
);

CREATE TABLE Clients(
	id INT NOT NULL IDENTITY(0,1),
	name VARCHAR(50) NOT NULL,
	status VARCHAR(15) FOREIGN KEY REFERENCES ClientStatus(status) NOT NULL,
	manager INT FOREIGN KEY REFERENCES Managers(id) NOT NULL,
	PRIMARY KEY(id)
);


INSERT INTO ClientStatus(status) VALUES('Ключевой клиент');
INSERT INTO ClientStatus(status) VALUES('Обычный клиент');

CREATE TABLE Products(
	id INT NOT NULL IDENTITY(0,1),
	name VARCHAR(50) NOT NULL,
	type VARCHAR(8) NOT NULL,
	price INT NOT NULL,
	period VARCHAR(7),
	PRIMARY KEY(id)
);

CREATE TABLE BuyedProducts(
	client INT FOREIGN KEY REFERENCES Clients(id) NOT NULL,
	product INT FOREIGN KEY REFERENCES Products(id) NOT NULL,
	PRIMARY KEY(Client, Product)
);
