CREATE TABLE Users
(
	u_id INT PRIMARY KEY IDENTITY(1, 1),
	u_username VARCHAR(50) NOT NULL,
	u_password VARCHAR(50) NOT NULL,
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
	send_date DATETIME NOT NULL,
	checked TINYINT(1) NOT NULL,
	room INT FOREIGN KEY REFERENCES Rooms(r_id)
)

CREATE TABLE Post
(	
	p_id INT PRIMARY KEY IDENTITY(1,1),
	p_picture IMAGE NOT NULL,
	p_date DATETIME NOT NULL,
	p_content VARCHAR(200),
	p_likes INT,
	p_user INT FOREIGN KEY REFERENCES Users(u_id)
)

CREATE TABLE Comment
(	
	c_id INT PRIMARY KEY IDENTITY(1,1),
	c_content VARCHAR(50),
	c_date DATETIME NOT NULL,
	c_user INT FOREIGN KEY REFERENCES Users(u_id),
	c_post INT FOREIGN KEY REFERENCES Post(p_id)
)

CREATE TABLE Likes
(
	l_id INT PRIMARY KEY IDENTITY(1,1),
	l_userId INT,
	l_postId INT
)

CREATE TABLE Followers
(
	f_id INT PRIMARY KEY IDENTITY(1,1),
	f_userId INT,
	f_followingId INT
)

SELECT * FROM Followers
DELETE FROM Followers

SELECT COUNT(f_followingId) FROM Followers WHERE f_followingId = 1

INSERT INTO Rooms(sender, reciever) VALUES(1,2)
INSERT INTO Rooms(sender, reciever) VALUES(1,3)
INSERT INTO Rooms(sender, reciever) VALUES(2,3)
INSERT INTO Rooms(sender, reciever) VALUES(1,5)

INSERT INTO Messages(text_content, send_date, room, sender, checked) VALUES('Hello', GETTIME(), 1, 1, 0)

SELECT * FROM Likes WHERE l_postId = 1 AND l_userId = 3


SELECT * FROM Rooms WHERE sender = 2 OR reciever = 2

SELECT TOP 1 text_content FROM Messages WHERE room = 3 ORDER BY m_id DESC
SELECT COUNT(m_id) FROM Messages WHERE room = 1 AND checked = 0

SELECT COUNT(f_id) FROM Followers WHERE f_userId = 1 AND f_followingId = 19
SELECT * FROM Followers
DELETE FROM Followers
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

--DESKTOP-T96O8TL\SQLEXPRESS--
SELECT p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id WHERE p_id = 7
SELECT p_id, p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id
SELECT p_id FROM Post

INSERT INTO Likes(l_userId, l_postId) VALUES(1, 1)
SELECT * FROM Post WHERE p_id = 18
DELETE FROM Likes

UPDATE Post SET p_likes = 3 WHERE p_id = 18