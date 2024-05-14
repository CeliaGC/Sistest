-- Creation of table items
CREATE TABLE items (
    item_code INT AUTO_INCREMENT PRIMARY KEY,
    item_name VARCHAR(250)
);

-- Creationo of table orders
CREATE TABLE orders (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    distributor_id INT,
    item_ordered INT,
    quantity INT,
    FOREIGN KEY (item_ordered) REFERENCES items(item_code)
);

-- Insert data in table items
INSERT INTO items (item_name) VALUES
('chocolate'),
('juice'),
('cookies'),
('cake');

-- Insert data in table orders
INSERT INTO orders (distributor_id, item_ordered, quantity) VALUES
(501, 1, 250),
(502, 3, 100),
(503, 1, 200),
(502, 1, 150),
(502, 2, 300),
(504, 4, 200),
(503, 3, 250),
(503, 2, 250),
(501, 4, 180),
(503, 4, 350);
