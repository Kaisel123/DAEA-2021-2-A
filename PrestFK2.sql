ALTER TABLE Prestamos
   ADD CONSTRAINT FK_Prestamos_usuario
   FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)