USE [DB_2024_13];
GO

CREATE TABLE Owner (
OwnerID INT PRIMARY KEY IDENTITY,
LastName NVarChar(200) NOT NULL,
FirstName NVarChar(200) NOT NULL,
Phone NVarChar(50),
Email NVarChar(300) NOT NULL
);

CREATE TABLE Pet (
PetID INT PRIMARY KEY IDENTITY,
Name NVarChar(100) NOT NULL,
Type NVarChar(50) NOT NULL,
Breed NVarChar(100), 
DateOfBirth DateTime2, 
Weight FLOAT,
OwnerID INT NOT NULL,

FOREIGN KEY (OwnerID) REFERENCES Owner(OwnerID)
);

CREATE TABLE Appointment (
AppointmentID INT PRIMARY KEY IDENTITY,
Service NVarChar(200) NOT NULL,
Date DateTime2 NOT NULL,
Charge FLOAT NOT NULL,
PetID INT,

FOREIGN KEY (PetID) REFERENCES Pet(PetID)
);

INSERT INTO Owner(LastName, FirstName, Phone, Email)
VALUES
	('Downs', 'Marsha', '555 537 8765', 'Marsha.Downs@somewhere.com')

INSERT INTO Pet(Name, Type, Breed, DateOfBirth, Weight, OwnerID)
VALUES
	('King', 'Dog', 'Std. Poodle', '20110221', 25.5, 1)

INSERT INTO Appointment(Service, Date, Charge, PetID)
VALUES
	('Ear Infection', '20140817', 65, 1)

--DROP TABLE Appointment
--DROP TABLE Pet
--DROP TABLE Owner