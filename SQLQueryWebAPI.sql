Create Database APIWebRest

USE Polls

Create Table Polls 
(
Poll_id int Identity primary key,
    Poll_description varchar(200)not null,
	options varchar(100), 
    Votes_qty int,
	Visualizacao int
);

INSERT INTO Polls( Poll_description,options,Votes_qty, visualizacao)
VALUES('This is thess question','option1', 2, 4)






