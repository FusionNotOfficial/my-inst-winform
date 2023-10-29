CREATE TABLE Users
(
	u_id INT PRIMARY KEY IDENTITY(1, 1),
	u_username VARCHAR(50),
	u_password VARCHAR(50),
	u_email VARCHAR(30),
	u_picture IMAGE,
	u_description VARCHAR(40)
);

CREATE TABLE Rooms
(
	r_id INT PRIMARY KEY IDENTITY(1,1),
	sender INT FOREIGN KEY REFERENCES Users(u_id),
	reciever INT FOREIGN KEY REFERENCES Users(u_id)
)

CREATE TABLE Messages
(	
	m_id INT PRIMARY KEY IDENTITY(1,1),
	text_content VARCHAR(200),
	send_date DATETIME,
	room INT FOREIGN KEY REFERENCES Rooms(r_id)
)


drop table messages
drop table rooms
drop table users

delete from users where u_id = 5