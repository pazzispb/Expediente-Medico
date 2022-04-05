BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Usuarios" (
	"idUsuario"	INTEGER,
	"usuario"	TEXT NOT NULL UNIQUE,
	"clave"	TEXT NOT NULL,
	"nombre"	TEXT NOT NULL,
	"apellido"	TEXT NOT NULL,
	"cedula"	TEXT NOT NULL,
	"fechaNacimiento"	TEXT NOT NULL,
	"altura"	REAL NOT NULL,
	"peso"	REAL NOT NULL,
	"tipoSangre"	TEXT NOT NULL,
	"seguroMedico"	TEXT NOT NULL,
	"telefono"	TEXT NOT NULL,
	PRIMARY KEY("idUsuario")
);
INSERT OR IGNORE INTO Usuarios(usuario, clave, nombre, apellido, cedula, fechaNacimiento, altura, peso, tipoSangre, seguroMedico, telefono)
VALUES("ADMIN", "1234", "ADMIN", "ADMIN", "00000000", "4/5/2022", 0, 0, "O+", "HUMANO", "809000000" );
CREATE TABLE IF NOT EXISTS "Analiticas" (
	"idAnalitica"	INTEGER,
	"fecha"	TEXT NOT NULL,
	"proposito"	TEXT NOT NULL,
	"observaciones"	TEXT NOT NULL,
	"idUsuario"	INTEGER,
	FOREIGN KEY("idUsuario") REFERENCES "Usuarios"("idUsuario"),
	PRIMARY KEY("idAnalitica" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Doctores" (
	"idDoctor"	INTEGER,
	"nombreDoctor"	TEXT NOT NULL,
	"centroMedico"	TEXT NOT NULL,
	"especialidad"	TEXT NOT NULL,
	"telefono"	TEXT NOT NULL,
	PRIMARY KEY("idDoctor" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Citas" (
	"horario"	TEXT NOT NULL,
	"fecha"	TEXT NOT NULL,
	"idDoctor"	INTEGER NOT NULL,
	"centroMedico"	TEXT NOT NULL,
	"idCita"	INTEGER,
	FOREIGN KEY("idDoctor") REFERENCES "Doctores"("idDoctor"),
	PRIMARY KEY("idCita" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Padecimientos" (
	"tipoPadecimiento"	TEXT NOT NULL,
	"nombrePadecimiento"	TEXT NOT NULL,
	"fecha"	TEXT,
	"descripcion"	TEXT NOT NULL,
	"idPadecimeinto"	INTEGER,
	"idUsuario"	INTEGER NOT NULL,
	FOREIGN KEY("idUsuario") REFERENCES "Usuarios"("idUsuario"),
	PRIMARY KEY("idPadecimeinto" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Farmacos" (
	"nombreFarmaco"	TEXT NOT NULL,
	"frecuenciaFarmaco"	TEXT NOT NULL,
	"dosisFarmaco"	TEXT NOT NULL,
	"descripcionFarmaco"	TEXT NOT NULL,
	"veces"	TEXT NOT NULL,
	"idFarmaco"	INTEGER,
	"idUsuario"	INTEGER NOT NULL,
	FOREIGN KEY("idUsuario") REFERENCES "Usuarios"("idUsuario"),
	PRIMARY KEY("idFarmaco" AUTOINCREMENT)
);
COMMIT;
