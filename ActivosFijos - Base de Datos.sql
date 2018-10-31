USE master
GO

-- Drop then recreate the Database
DROP DATABASE IF EXISTS ActivosFijos
GO

CREATE DATABASE ActivosFijos
GO

USE ActivosFijos
GO

CREATE TABLE Departamento(
    Codigo_Departamento int IDENTITY(1,1) NOT NULL,
    Nombre varchar(50) NOT NULL,
    CONSTRAINT PK_Departamento PRIMARY KEY(Codigo_Departamento)
);

CREATE TABLE Empleado(
    Codigo_Empleado int IDENTITY(1,1) NOT NULL,
    Nombre varchar(40) NOT NULL,
    Apellido varchar(40) NOT NULL,
    Cedula char(11) NOT NULL,
    Codigo_Departamento int NOT NULL,
    Tipo_Persona varchar(40) NOT NULL,
    Fecha_Ingreso date NOT NULL,
    Estado varchar(20) NOT NULL,
    CONSTRAINT PK_Empleado PRIMARY KEY (Codigo_Empleado),
    CONSTRAINT FK_Empleado_Departamento FOREIGN KEY (Codigo_Departamento)
    REFERENCES Departamento(Codigo_Departamento),
    CONSTRAINT CHK_Tipo_Persona CHECK(Tipo_Persona IN ('Fisica', 'Juridica'))
);

CREATE TABLE Proveedor(
    Codigo_Proveedor int IDENTITY(1,1) NOT NULL,
    Nombre varchar(40) NOT NULL,
    Cedula_RNC char(11) NOT NULL,
    Tipo_Proveedor varchar(40) NOT NULL,
    Fecha_Registro date NOT NULL,
    Estado varchar(40) NOT NULL,
    CONSTRAINT PK_Proveedor PRIMARY KEY (Codigo_Proveedor),
    CONSTRAINT CHK_Tipo_Proveedor CHECK(Tipo_Proveedor IN ('Fisica', 'Juridica'))
);

CREATE TABLE Tipo_Activo (
    Codigo_TipoActivo int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Descripcion varchar(100),
    Cuenta_ContCompra varchar(10),
    Cuenta_ContDeprec varchar(10),
    Estado varchar(15)
);

CREATE TABLE Ubicacion (
    Codigo_Ubicacion int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Descripcion varchar(100),
    Direccion varchar(150),
    Edificio varchar(50),
    Estado varchar(30)
);

CREATE TABLE Activos_Fijos(
    Codigo_Activo int IDENTITY(1,1) NOT NULL,
    Descripcion varchar(100) NOT NULL,
    Codigo_Departamento int NOT NULL,
    Codigo_Ubicacion int NOT NULL,
    Codigo_TipoActivo int NOT NULL,
    Fecha_Registro date NOT NULL,
    Valor_Compra decimal(18,2) NOT NULL,
    Depreciacion_Acumulada decimal(18,2) NOT NULL,
    CONSTRAINT PK_Activos_Fijos PRIMARY KEY (Codigo_Activo),
    CONSTRAINT FK_Activos_Fijos_Departamento FOREIGN KEY (Codigo_Departamento)
    REFERENCES Departamento(Codigo_Departamento),
    CONSTRAINT FK_Activos_Fijos_Tipo_Activo FOREIGN KEY (Codigo_TipoActivo)
    REFERENCES Tipo_Activo(Codigo_TipoActivo),
    CONSTRAINT FK_Activos_Fijos_Ubicacion FOREIGN KEY (Codigo_Ubicacion)
    REFERENCES Ubicacion(Codigo_Ubicacion)
);

CREATE TABLE Calculo_Depreciacion(
    Codigo_Registro int IDENTITY(1,1) NOT NULL,
    Año_Proceso smallint NOT NULL,
    Mes_Proceso varchar(15) NOT NULL,
    Codigo_Activo int NOT NULL,
    Fecha_Proceso date NOT NULL,
    Monto_Depreciado decimal(18,2) NOT NULL,
    Depreciacion_Acumulada decimal(18,2) NOT NULL,
    Cuenta_Compra decimal(18,2) NOT NULL,
    Cuenta_Depreciacion decimal(18,2) NOT NULL,
    CONSTRAINT PK_Depreciacion PRIMARY KEY (Codigo_Registro),
    CONSTRAINT FK_Depreciacion_Activos_Fijos FOREIGN KEY (Codigo_Activo)
    REFERENCES Activos_Fijos(Codigo_Activo)
);

CREATE TABLE Parametro(
    Codigo_Parametro int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Ano_Mes_Proceso date,
    Deprec_Calculada bit,
    RNC_Empresa char(9),
    Met_Drepeciacion varchar(50)
);

CREATE TABLE Tipo_Pago (
    Codigo_TipoPago int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Descripcion varchar(50),
    Estado Varchar(15)
);

CREATE TABLE Usuarios (
    Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Usuario varchar(24) NOT NULL UNIQUE,
    Contrasena varchar(255) NOT NULL,
    Nombre varchar(30) NOT NULL,
    Apellido varchar(30) NOT NULL
);

CREATE TABLE Roles (
    Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nombre varchar(24) NOT NULL
);

CREATE TABLE Usuarios_Roles (
    Id_Usuario int NOT NULL,
    Id_Rol int NOT NULL,
    CONSTRAINT PK_Usuarios_Roles PRIMARY KEY (Id_Usuario, Id_Rol),
    CONSTRAINT FK_Usuarios_Roles_Usuarios FOREIGN KEY (Id_Usuario)
    REFERENCES Usuarios(Id) ON DELETE CASCADE,
    CONSTRAINT FK_Usuarios_Roles_Roles FOREIGN KEY (Id_Rol)
    REFERENCES Roles(Id)  ON DELETE CASCADE
)
GO

INSERT INTO Departamento VALUES
('Administración'), ('Finanzas'), ('Ventas'), ('Logistica'), ('Tecnología'), ('Recursos Humanos');

INSERT INTO Empleado VALUES
('Miguel', 'Araujo', '12345678910', 5, 'Fisica', '2018-09-17', 'Activo'),
('Luis', 'Laureano', '02840281920', 1, 'Juridica', '2016-02-20', 'Activo'),
('Winston', 'Cruz', '56329754102', 6, 'Fisica', '2017-11-05', 'Activo');

INSERT INTO Tipo_Pago VALUES
('Efectivo', 'Activo'), ('Tarjeta', 'Activo'), ('A Credito', 'Activo');

INSERT INTO Proveedor VALUES
('La Carretera', '40222011105', 'Fisica', '2008-05-20', 'Activo'),
('Walnir', '40265932515', 'Juridica', '2016-03-19', 'Activo'),
('Cypher, Inc', '40215896353', 'Juridica', '2018-11-16', 'Activo'),
('Guarionex Soluciones', '40278456321', 'Fisica', '2016-07-04', 'Inactivo');

INSERT INTO Ubicacion VALUES
('Casa de campo', 'Juan Dolio #102', 'No', 'Activo'),
('Terreno 100 metros cuadrados en Villa Mella', 'Villa Mella, Calle La Perdicion #9', 'No', 'Activo'),
('Garage de vehiculos "El patron"', 'San Isidro, Calle La Milagrosa #20', 'Marg IV', 'Activo');

INSERT INTO Parametro VALUES
('2014-12-21', 1, '192039409', 'Linea Recta'),
('2015-12-21', 1, '589632144', 'Linea Recta'),
('2016-12-21', 1, '984623149', 'Digito de los años'),
('2017-12-21', 1, '846056120', 'Digito de los años');
