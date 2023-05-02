CREATE DATABASE teoryB




CREATE TABLE endTestDto (
    id int NOT NULL,
    question varchar(255),
    anserUser varchar(255),
    raitAnser varchar(255),
	numAnser int,
	status varchar(255),
    PRIMARY KEY (id)
);



CREATE TABLE questionArr (
    id int NOT NULL,
    question varchar(255) NOT NULL,
    e1 varchar(255),
    e2 varchar(255),
    e3 varchar(255),
    e4 varchar(255),
	r int,
    img varchar(255),
    PRIMARY KEY (id)
);

CREATE TABLE alluser (
    ID int,
	password varchar(20),
	addres varchar(255),
	phon varchar(15),
	mail varchar(255),
	status int,
    PRIMARY KEY (mail)
);

CREATE TABLE sabjekTamrurim(
    id int,
	namee varchar(255),
	T_img varchar(255),
	PRIMARY KEY (id)
);

CREATE TABLE Tamrurim(
    i int,
	num int,
    description varchar(255),
	Smol_T_img varchar(255),
	status int,
	PRIMARY KEY (i)
);