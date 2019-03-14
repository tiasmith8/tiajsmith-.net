
-- Switch to the system (aka master) database
USE master;
GO

-- Delete the DemoDB Database (IF EXISTS)
DROP DATABASE IF EXISTS HangmanDB
GO

-- Create a new DemoDB Database
CREATE DATABASE HangmanDB;
GO

-- Switch to the DemoDB Database
USE HangmanDB
GO

BEGIN TRANSACTION;

CREATE TABLE users
(
	id			int			identity(1,1),
	username	varchar(50)	not null,
	password	varchar(50)	not null,
	--salt		varchar(50)	not null,
	role		varchar(50)	default('user'),

	constraint pk_users primary key (id)
);


COMMIT TRANSACTION;