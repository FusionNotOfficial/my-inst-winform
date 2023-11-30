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
	checked TINYINT(1),
	room INT FOREIGN KEY REFERENCES Rooms(r_id)
)

INSERT INTO Rooms(sender, reciever) VALUES(1,2)
INSERT INTO Rooms(sender, reciever) VALUES(1,3)
INSERT INTO Rooms(sender, reciever) VALUES(2,3)
INSERT INTO Rooms(sender, reciever) VALUES(1,5)

INSERT INTO Messages(text_content, send_date, room, sender, checked) VALUES('Hello', GETTIME(), 1, 1, 0)

INSERT INTO Messages(text_content, send_date, room, sender, checked) VALUES('Hello', '2011-02-09 13:09:00' , 4, 1, 1)
delete from messages where checked = 4

SELECT * FROM Rooms INNER JOIN Users ON Rooms.reciever = Users.u_id WHERE sender = (SELECT u_id FROM Users WHERE u_username = 'admin')

SELECT u_username FROM Rooms INNER JOIN Users ON Rooms.reciever = Users.u_id WHERE sender = (SELECT u_id FROM Users WHERE r_id = 1)
SELECT * FROM Rooms INNER JOIN Users ON Rooms.reciever = Users.u_id WHERE r_id = 1

SELECT * FROM Rooms WHERE sender = 3 OR reciever = 3

SELECT * FROM Messages WHERE room = 1

SELECT * FROM Rooms WHERE sender = 2 OR reciever = 2

SELECT TOP 1 text_content FROM Messages WHERE room = 3 ORDER BY m_id DESC
SELECT COUNT(m_id) FROM Messages WHERE room = 1 AND checked = 0

ALTER TABLE Users 
ADD u_lastSeen datetime

ALTER TABLE Users
DROP COLUMN u_lastSeen;

drop table messages
drop table rooms
drop table users

delete from messages

delete from users where u_id = 5
delete from messages where room = 4