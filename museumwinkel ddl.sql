CREATE DATABASE museumwinkel;

USE museumwinkel;



CREATE TABLE animal(

	id INT NOT NULL AUTO_INCREMENT,

    	name CHAR(120) NOT NULL,
    
	country_of_origin CHAR(120) NOT NULL,
    
	primary key (id)
	);