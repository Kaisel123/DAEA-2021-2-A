ALTER TABLE Libro
	ADD CONSTRAINT FK_Libro 
	FOREIGN KEY (IdAutor) REFERENCES Autor(IdAutor)