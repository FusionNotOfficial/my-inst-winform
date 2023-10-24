CREATE TABLE Messages
(	
	m_id INT PRIMARY KEY IDENTITY(1,1),
	text_content VARCHAR(200),
	send_date DATETIME,
	room INT FOREIGN KEY REFERENCES Rooms(r_id)
)

Delete * from users