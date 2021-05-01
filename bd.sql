DROP DATABASE IF EXISTS parqueoFaustino;

create database parqueoFaustino;

use parqueoFaustino;

create table tipoVehiculo (
    id int NOT NULL AUTO_INCREMENT,
    nombre varchar(100),
    costoPorHora Decimal(5,2),
    costoPorDia Decimal(5,2),
    costoPorMes Decimal(5,2),
    PRIMARY KEY (id)
);

create table ticket (
    id int NOT NULL AUTO_INCREMENT,
    fechaIngreso datetime not null,
    fechaEgreso datetime,
    placa varchar(10),
    cobroTotal Decimal(5, 2),
    idTipoVehiculo int,
    PRIMARY KEY (id),
    FOREIGN KEY (idTipoVehiculo) REFERENCES tipoVehiculo(id)
);

insert into tipoVehiculo(nombre, costoPorHora, costoPorDia, costoPorMes)
    values ('Motocicleta', 10, 30, 200);

insert into tipoVehiculo(nombre, costoPorHora, costoPorDia, costoPorMes)
    values ('Vehículo', 10, 30, 200);


select
    *
from
    ticket
where
    MONTH(fechaEgreso) = MONTH(CURRENT_DATE)
    AND YEAR(fechaEgreso) = YEAR(CURRENT_DATE);

select
    *
from
    ticket
where
    DAY(fechaEgreso) = DAY(CURRENT_DATE)
    AND MONTH(fechaEgreso) = MONTH(CURRENT_DATE)
    AND YEAR(fechaEgreso) = YEAR(CURRENT_DATE);