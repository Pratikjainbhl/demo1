CREATE TABLE userlogin (
    id int IDENTITY(1,1) PRIMARY KEY,
    username varchar(255) NOT NULL,
    password varchar(255)
);

INSERT INTO userlogin(username,password)
VALUES ('admin','12345');

select * from userlogin