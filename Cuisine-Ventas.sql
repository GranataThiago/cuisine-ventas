drop database if exists Cuisine;
create database Cuisine;
use Cuisine;

create table persona(
    idPersona int auto_increment,
    nombreApe varchar(60),
    direccion varchar(40),
    telefono varchar(30),
    fecha_nac date,
    constraint pk_idPersona primary key (idPersona)
);

create table cliente(
    idCliente int auto_increment,
    idPersona int,
    constraint pk_idCliente primary key (idCliente),
    constraint fk_idPersona foreign key (idPersona) references persona(idPersona)
); 

create table encargado(
    idEncargado int auto_increment,
    idPersona int,
    constraint pk_idEncargado primary key (idEncargado),
    constraint fk_idPersona2 foreign key (idPersona) references persona(idPersona)
); 

create table caja(
    idCaja int auto_increment,
    idEncargado int,
    constraint pk_idCaja primary key (idCaja),
    constraint fk_idEncargado foreign key (idEncargado) references encargado(idEncargado)
);

/*
==========================================================================================================================
Tablas relacionadas a la atención por mostrador (mesas)
==========================================================================================================================
*/

/* Creo que hace falta una tabla mesa, por el ticket y saber a que mesa le corresponde pero no sabria que mas ponerle */
create table mesa(
    idMesa int auto_increment,
    constraint pk_idMesa primary key (idMesa)
);

/* Si el metodo de pago es efectivo o tarjeta, por ejemplo */
create table ticket(
    idTicket int auto_increment,
    idMesa int,
    idCaja int,
    metodoPago varchar(30),
    constraint pk_idTicket primary key (idTicket),
    constraint fk_idMesa foreign key (idMesa) references mesa(idMesa),
    constraint fk_idCaja3 foreign key (idCaja) references caja(idCaja)
);

create table comida(
    idComida int auto_increment,
    precio int,
    nombre varchar(30),
    constraint pk_idComida primary key (idComida)
);

create table detalle_ticket(
    idDetalleTicket int auto_increment,
    idTicket int,
    idComida int,
    cantidad int,
    constraint pk_idDetalleTicket primary key (idDetalleTicket),
    constraint fk_idTicket2 foreign key (idTicket) references ticket(idTicket),
    constraint fk_idComida2 foreign key (idComida) references comida(idComida)
);

/*
==========================================================================================================================
Tablas relacionadas al Delivery
==========================================================================================================================
*/

create table repartidor(
    idRepartidor int auto_increment,
    idPersona int,
    constraint pk_idRepartidor primary key (idRepartidor),
    constraint fk_idPersona3 foreign key (idPersona) references persona(idPersona)
);

/*
==========================================================================================================================
Tablas relacionadas a los pedidos
==========================================================================================================================
*/

create table pedido (
    idPedido int auto_increment,
    idRepartidor int,
    direccion varchar(30),
    entregado boolean,
    constraint pk_idPedido primary key (idPedido)
);

create table detalle_pedido(
    idDetallePedido int auto_increment,
    idPedido int,
    idComida int,
    cantidad int,
    constraint pk_idDetallePedido primary key (idDetallePedido),
    constraint fk_idPedido foreign key (idPedido) references pedido(idPedido) ON DELETE CASCADE,
    constraint fk_idComida3 foreign key (idComida) references comida(idComida)
);

