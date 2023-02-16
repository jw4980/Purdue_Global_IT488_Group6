alter table product_category drop column category_desc;
alter table product_category add category_name varchar(255) not null, category_desc text;

select * from product_category

INSERT INTO product_category 
VALUES
    (1, 'Electronics', 'Electronic products including computers, smartphones, and televisions'),
    (2, 'Fashion', 'Clothing and accessory products for men and women'),
    (3, 'Home Goods', 'Products for the home including furniture, kitchen appliances, and bedding'),
    (4, 'Beauty', 'Personal care and beauty products including skincare, makeup, and hair care'),
    (5, 'Toys', 'Toys and games for children and adults'),
    (6, 'Sports', 'Products for various sports and outdoor activities'),
    (7, 'Books', 'Books and literary works for all ages'),
    (8, 'Music', 'Music and musical instruments for listening and playing'),
    (9, 'Movies', 'Movies and TV shows for home entertainment'),
    (10, 'Office Supplies', 'Products for the office including paper, pens, and desk organizers'),
    (11, 'Outdoor Gear', 'Products for outdoor activities such as camping, hiking, and mountaineering'),
    (12, 'Art Supplies', 'Supplies for artists, including canvas, paint, and brushes'),
    (13, 'Home Improvement', 'Supplies for home improvement projects, including tools, hardware, and paint'),
    (14, 'Pet Supplies', 'Supplies for pets, including food, toys, and grooming products');


	
select * from inventory

INSERT INTO inventory (item_name, item_quantity, category_id, list_price, item_cost, sale_start, sale_end)
VALUES
    ('Headphones', 50, 1, 129.99, 75.00, '2022-06-01', '2022-06-30'),
    ('Gaming Console', 30, 1, 299.99, 200.00, '2022-07-01', '2022-07-31'),
    ('Camera', 20, 1, 599.99, 400.00, '2022-08-01', '2022-08-31'),
    ('Bluetooth Speaker', 40, 1, 79.99, 50.00, '2022-09-01', '2022-09-30'),
    ('Luggage', 25, 5, 199.99, 150.00, '2022-10-01', '2022-10-31'),
    ('Watches', 35, 2, 199.99, 150.00, '2022-11-01', '2022-11-30'),
    ('Sneakers', 60, 2, 99.99, 75.00, '2022-12-01', '2022-12-31'),
    ('Perfume', 40, 4, 49.99, 30.00, '2022-12-15', '2022-12-31'),
    ('Vacuum Cleaner', 30, 3, 199.99, 150.00, '2022-12-01', '2022-12-31'),
    ('Blender', 45, 3, 79.99, 50.00, '2022-11-01', '2022-11-30'),
    ('Smart Watch', 25, 1, 249.99, 200.00, '2022-06-01', '2022-06-30'),
    ('Robot Vacuum Cleaner', 30, 3, 399.99, 300.00, '2022-07-01', '2022-07-31'),
    ('Drone', 20, 1, 799.99, 600.00, '2022-08-01', '2022-08-31'),
    ('Smart Home Hub', 15, 1, 199.99, 150.00, '2022-09-01', '2022-09-30'),
    ('Smart Thermostat', 20, 1, 249.99, 200.00, '2022-10-01', '2022-10-31'),
    ('Camping Tent', 20, 11, 199.99, 150.00, '2022-06-01', '2022-06-30'),
    ('Hiking Boots', 15, 11, 149.99, 100.00, '2022-07-01', '2022-07-31'),
    ('Sleeping Bag', 10, 11, 99.99, 75.00, '2022-08-01', '2022-08-31'),
    ('Camping Chair', 15, 11, 49.99, 40.00, '2022-09-01', '2022-09-30'),
    ('Camping Cookware Set', 20, 11, 49.99, 40.00, '2022-10-01', '2022-10-31'),
    ('Books (Fiction)', 25, 7, 19.99, 15.00, '2022-11-01', '2022-11-30'),
    ('Books (Non-Fiction)', 20, 7, 24.99, 20.00, '2022-12-01', '2022-12-31'),
    ('Books (Children)', 30, 7, 14.99, 10.00, '2022-12-15', '2022-12-31'),
    ('Art Supplies Set', 20, 12, 24.99, 20.00, '2022-12-01', '2022-12-31'),
    ('Canvas Paint Set', 15, 12, 49.99, 40.00, '2022-11-01', '2022-11-30'),
    ('Pet food', 50, 14, 12.99, 10.99, '2023-02-15', '2023-03-01'),
    ('Pet bed', 25, 14, 49.99, 39.99, '2023-02-15', '2023-03-01'),
    ('Hammer', 100, 13, 9.99, 7.99, '2023-02-15', '2023-03-01'),
    ('Paint brush set', 75, 13, 14.99, 11.99, '2023-02-15', '2023-03-01'),
    ('CD player', 25, 1, 39.99, 29.99, '2023-02-15', '2023-03-01'),
    ('Pet toys', 50, 14, 14.99, 12.99, '2023-02-15', '2023-03-01'),
    ('Home security system', 25, 1, 199.99, 159.99, '2023-02-15', '2023-03-01'),
    ('Light fixtures', 100, 14, 29.99, 24.99, '2023-02-15', '2023-03-01'),
    ('Guitar', 25, 18, 199.99, 159.99, '2023-02-15', '2023-03-01'),
    ('Blu-ray player', 50, 1, 89.99, 79.99, '2023-02-15', '2023-03-01');


	select * from users