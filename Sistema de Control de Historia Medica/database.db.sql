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
CREATE TABLE IF NOT EXISTS "Analiticas" (
	"idAnalitica"	INTEGER,
	"fecha"	TEXT NOT NULL,
	"proposito"	TEXT NOT NULL,
	"observaciones"	TEXT NOT NULL,
	"idUsuario"	INTEGER,
	PRIMARY KEY("idAnalitica" AUTOINCREMENT),
	FOREIGN KEY("idUsuario") REFERENCES "Usuarios"("idUsuario")
);
CREATE TABLE IF NOT EXISTS "Doctores" (
	"idDoctor"	INTEGER,
	"nombreDoctor"	TEXT NOT NULL,
	"centroMedico"	TEXT NOT NULL,
	"especialidad"	TEXT NOT NULL,
	"telefono"	TEXT NOT NULL,
	PRIMARY KEY("idDoctor" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Padecimientos" (
	"tipoPadecimiento"	TEXT NOT NULL,
	"nombrePadecimiento"	TEXT NOT NULL,
	"fecha"	TEXT,
	"descripcion"	TEXT NOT NULL,
	"idPadecimeinto"	INTEGER,
	"idUsuario"	INTEGER NOT NULL,
	PRIMARY KEY("idPadecimeinto" AUTOINCREMENT),
	FOREIGN KEY("idUsuario") REFERENCES "Usuarios"("idUsuario")
);
CREATE TABLE IF NOT EXISTS "Farmacos" (
	"nombreFarmaco"	TEXT NOT NULL,
	"frecuenciaFarmaco"	TEXT NOT NULL,
	"dosisFarmaco"	TEXT NOT NULL,
	"descripcionFarmaco"	TEXT NOT NULL,
	"veces"	TEXT NOT NULL,
	"idFarmaco"	INTEGER,
	"idUsuario"	INTEGER NOT NULL,
	PRIMARY KEY("idFarmaco" AUTOINCREMENT),
	FOREIGN KEY("idUsuario") REFERENCES "Usuarios"("idUsuario")
);
CREATE TABLE IF NOT EXISTS "Citas" (
	"doctorCita"	TEXT NOT NULL,
	"centroCita"	TEXT NOT NULL,
	"horario"	TEXT NOT NULL,
	"fecha"	TEXT NOT NULL,
	"idDoctor"	INTEGER NOT NULL,
	"idCita"	INTEGER,
	"idUsuario"	INTEGER,
	PRIMARY KEY("idCita" AUTOINCREMENT),
	FOREIGN KEY("idDoctor") REFERENCES "Doctores"("idDoctor"),
	FOREIGN KEY("idUsuario") REFERENCES "Usuarios"("idUsuario")
);
INSERT OR IGNORE INTO Usuarios(usuario, clave, nombre, apellido, cedula, fechaNacimiento, altura, peso, tipoSangre, seguroMedico, telefono)
VALUES("ADMIN", "1234", "ADMIN", "ADMIN", "00000000", "4/5/2022", 0, 0, "O+", "HUMANO", "809000000" );
COMMIT;
