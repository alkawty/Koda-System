create table dpt (
    id       int           identity (1, 1) not null,
    name     nvarchar (50) not null,
    isactive int           default (1) not null
);

create table prd (
    id       int           identity (1, 1) not null,
    name     nvarchar (50) not null,
    price    int           not null,
    quantity int           not null,
    dept_id  int           not null,
);

CREATE TABLE susers (
    id       int           identity (1, 1) not null,
    name     nvarchar (30) null,
    email    nvarchar (30) null,
    password nvarchar (30) null,
);

CREATE TABLE TGR (
    id      int           NOT NULL,
    name    nvarchar (20) null,
    number1 int           null,
    number2 nvarchar (9)   null,
    adress  nvarchar (20) null,
);




