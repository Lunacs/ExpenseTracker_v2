CREATE TABLE users(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(50) NOT NULL,
	password VARCHAR(25) NOT NULL,
	date_created DATE NULL
);

select * from users;