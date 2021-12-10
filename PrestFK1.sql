ALTER TABLE Prestamos
	ADD CONSTRAINT FK_prestamos_libro
	FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro)