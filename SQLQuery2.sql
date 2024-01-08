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
	f_userId INT FOREIGN KEY REFERENCES Users(u_id),
	f_followingId INT FOREIGN KEY REFERENCES Users(u_id)
)


--DESKTOP-T96O8TL\SQLEXPRESS--
--SELECT p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id WHERE p_id = 7
--SELECT p_id, p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id
--SELECT p_id FROM Post
--SELECT COUNT(f_id) FROM Followers WHERE f_followingId = 1

--SELECT u_id, u_username, u_picture FROM Followers INNER JOIN Users ON Followers.f_userId = Users.u_id WHERE f_followingId = 1
--SELECT * FROM Followers

--UPDATE Post SET p_likes = 3 WHERE p_id = 18
--SELECT DISTINCT u_id, u_username FROM Followers INNER JOIN Users ON Followers.f_followingId = Users.u_id WHERE u_username LIKE 'c%'

--SELECT u_id, u_username FROM Rooms INNER JOIN Users ON Rooms.reciever = Users.u_id WHERE u_username LIKE 'c%' AND (sender = 1 OR reciever = 1)
