create table [User](
	Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50),
    Email VARCHAR(100),
    Password varchar(50),
    IsBan bit default 0,
	IsAdmin bit default 0,
    CreatedAt datetime,
    UpdatedAt datetime null
);