use eBIT


-- Users Table
create table users(
	user_id int identity (1,1) not null,
	user_name varchar(50) not null,
	email varchar (255) not null,
	password varchar (255) not null, --Will include encryption at a later date
	primary key (user_id)
);

-- Customer Table
create table customers(
	customer_id int identity (1,1) not null,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	ebay_username varchar(50) not null,
	address_id int not null,
	primary key (customer_id)
);

-- Customer contact
-- combined customer_contact and contact_type tables for simplicity
create table customer_contact(
	contact_id int identity (1,1) not null,
	customer_id int not null,
	phone int not null,
	email varchar(255) not null,
	primary key (contact_id)
);

--Customer Address
create table customer_address(
	address_id int identity (1,1) not null,
	customer_id int not null,
	address_line_1 varchar(255) not null,
	address_line_2 varchar(255),
	city varchar(100) not null,
	state char(2) not null,
	zip smallint not null,
	primary key (address_id)
);

select * from customers