create database eBIT;
go

use eBIT

-- Table: Inventory
create table inventory (
	item_id int identity (1,1) not null,
	item_name varchar(255),
	item_quantity int not null ,
	category_id int not null,
	list_price dec(10,2) not null,
	item_cost dec(10,2) not null,
	item_image image,
	sale_start datetime not null,
	sale_end datetime not null,
	primary key (item_id)
);

-- Table: Product Category
create table product_category (
	category_id int not null,
	category_name varchar(255) not null,
	category_desc text  not null,
	primary key (category_id)
);

-- Table: Orders
create table orders(
	order_id int identity (1,1) not null,
	customer_id int not null,
	sale_price dec (10,2) not null,
	order_quantity int not null,
	tax dec (10,2) not null,
	ship_cost dec (10,2) not null,
	order_total dec (10,2) not null,
	tracking varchar(255),
	primary key (order_id)
);
