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

CREATE TABLE Post
(	
	p_id INT PRIMARY KEY IDENTITY(1,1),
	p_picture IMAGE,
	p_date DATETIME,
	p_content VARCHAR(200),
	p_likes INT,
	p_user INT FOREIGN KEY REFERENCES Users(u_id)
)

CREATE TABLE Comment
(	
	c_id INT PRIMARY KEY IDENTITY(1,1),
	c_content VARCHAR(50),
	c_date DATETIME,
	c_user INT FOREIGN KEY REFERENCES Users(u_id),
	c_post INT FOREIGN KEY REFERENCES Post(p_id)
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

drop table Comment
drop table Post

delete from messages

delete from users where u_id = 5

INSERT INTO Post(p_picture, p_date, p_content, p_likes, p_user) VALUES(null, null, 'hello', 0, 1)

DELETE FROM Post

SELECT p_picture, p_date FROM Post WHERE p_user = 1
DELETE FROM POST WHERE p_id > 9

DESKTOP-T96O8TL\SQLEXPRESS
SELECT p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id WHERE p_id = 7
SELECT p_id, p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id
SELECT p_id FROM Post