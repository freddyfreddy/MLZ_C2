-- Insert.sql
--
-- Autor		: Beni Egli
-- Projekt		: HBU
-- Version		: 1.0
-- 
-- Change log
-- 28/09/2017	BEGLI	Erstellt
-- 

-- DB anw�hlen
use Soccer;

-- neue Position erfassen

insert into Position (Position)
values		('Keeper'),
            ('Defender'),
            ('Middlefield'),
            ('Striker');


select * from Position

go


--erfassen einer Nationalit�t

insert into Team (Team)
values		('Schweiz'),
           ('Frankreich'),
           ('England');


select * from Team
go
--set identity_insert Player on;
