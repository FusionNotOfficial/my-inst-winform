CREATE TABLE Users
(
	u_id INT PRIMARY KEY IDENTITY(1, 1),
	u_username VARCHAR(50),
	u_password VARCHAR(50),
	Email VARCHAR(30),
);

Delete from Users where u_id = 1;

INSERT INTO [Users] values('2', 'abobaboba', 'aboba')