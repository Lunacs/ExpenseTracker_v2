CREATE TABLE users(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(50) NOT NULL,
	password VARCHAR(25) NOT NULL,
	date_created DATE NULL
);

select * from users;
select * from categories;
select * from income;
select * from expenses;

CREATE TABLE categories(
id INT PRIMARY KEY IDENTITY(1,1),
category VARCHAR(50) NULL,
type VARCHAR(50) NULL,
status VARCHAR(50) NULL,
date_insert DATE NULL
);

CREATE TABLE income(
id INT PRIMARY KEY IDENTITY(1,1),
category VARCHAR(50) NULL,
item VARCHAR(50) NULL,
income FLOAT NULL,
description TEXT NULL,
date_income DATE NULL,
date_insert DATE NULL
);

CREATE TABLE expenses(
id INT PRIMARY KEY IDENTITY(1,1),
category VARCHAR(50) NULL,
item VARCHAR(50) NULL,
expense FLOAT NULL,
description VARCHAR(MAX) NULL,
date_expense DATE NULL,
date_insert DATE NULL
);

SELECT TOP 5 item as Item, description as About, category as Category, FORMAT(expense, 'N2') as Amount
FROM expenses
ORDER BY id DESC;



