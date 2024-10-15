CREATE TABLE Admins(
	admin_ID INT PRIMARY KEY IDENTITY(5000,1),
	adminUsername VARCHAR(20) NOT NULL,
	adminPW VARCHAR(20) NOT NULL,
	adminContactNum INT NOT NULL
);

CREATE TABLE Mechanics(
	mechanic_ID INT PRIMARY KEY IDENTITY(10000,1),
	mechanicUsername VARCHAR(20) NOT NULL,
	mechanicPW VARCHAR(20) NOT NULL,
	mechanicContactNum INT NOT NULL
);

CREATE TABLE Receptionists(
	rcptionist_ID INT PRIMARY KEY IDENTITY(15000,1),
	rcptionistUsername VARCHAR(20) NOT NULL,
	rcptionistPW VARCHAR(20) NOT NULL,
	rcptionistContactNum VARCHAR(20) NOT NULL
);
	
