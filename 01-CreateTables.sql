-- CreateTables.sql
--
-- Autor		: Beni Egli
-- Projekt		: HFU
-- Version		: 1.0
-- 
-- Change log
-- 21/06/2018	BEGLI	Erstellt
-- 

-- DB anwählen
use Soccer;

-- Tabellen erstellen (Step 1)

-- Tabelle Position erstellen
create table Position
(
	ID		int		identity(1,1)	not null,
	Position	varchar(20)				null
	CONSTRAINT PK_Position PRIMARY KEY (ID) 
);

-- Tabelle Team erstellen
create table Team
(
	ID			int	identity(1,1)	not null,
	Team			varchar (80)		null,
	Pictureflag		image				null
	CONSTRAINT PK_Team PRIMARY KEY (ID) 
);

-- Tabelle Player erstellen
create table Player
(
	ID			int	identity(1,1)	not null,
	Lastname			varchar (80)	null,
	Firstname			varchar(80)		null,
	Height				int				null,
	Birthdate			date			null,
	Jerseynumber		int				null,
	PositionID			int				null,
	Playedgames			int				null,
	Goals				int				null,
	Picture				image			null,
	TeamID				int				null
	CONSTRAINT PK_Player PRIMARY KEY (ID) 
);


-- ändern der Tabelle bzw. ergänzen mit Foreign Keys

alter table Player
add CONSTRAINT FK_Player_Position FOREIGN KEY (PositionID)
	REFERENCES Position(ID),
	CONSTRAINT FK_Player_Team FOREIGN KEY (TeamID)
	REFERENCES Team(ID)
go

-- ergänzen mit Unique constraints
alter Table Team
	add constraint uq_team unique(Team);

alter Table Position
	add constraint uq_position unique(Position);

go


