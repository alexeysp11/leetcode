
-- Generate SQL commands for creating tables (CREATE command): 
-- you need to generate 10 tables that will be interconnected and contain information 
-- on financial transactions to pay for goods or services (it is also possible to generate 
-- tables that will display information on goods and services).
CREATE TABLE FinancialTransactions_Users (
    UserId SERIAL PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(50) UNIQUE,
    Password VARCHAR(50)
);
CREATE TABLE FinancialTransactions_Addresses (
    AddressId SERIAL PRIMARY KEY,
    UserId INT REFERENCES FinancialTransactions_Users(UserId),
    Street VARCHAR(50),
    City VARCHAR(50),
    State VARCHAR(50),
    ZipCode VARCHAR(10)
);
CREATE TABLE FinancialTransactions_ProductCategories (
    CategoryId SERIAL PRIMARY KEY,
    CategoryName VARCHAR(50)
);
CREATE TABLE FinancialTransactions_Products (
    ProductId SERIAL PRIMARY KEY,
    CategoryId INT REFERENCES FinancialTransactions_ProductCategories(CategoryId),
    ProductName VARCHAR(50),
    Price DECIMAL(10,2)
);
CREATE TABLE FinancialTransactions_Orders (
    OrderId SERIAL PRIMARY KEY,
    UserId INT REFERENCES FinancialTransactions_Users(UserId),
    OrderDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE FinancialTransactions_OrderDetails (
    OrderDetailId SERIAL PRIMARY KEY,
    OrderId INT REFERENCES FinancialTransactions_Orders(OrderId),
    ProductId INT REFERENCES FinancialTransactions_Products(ProductId),
    Quantity INT,
    Price DECIMAL(10,2)
);
CREATE TABLE FinancialTransactions_OrderStatuses (
    OrderStatusId SERIAL PRIMARY KEY,
    OrderStatusName VARCHAR(50)
);
CREATE TABLE FinancialTransactions_Payments (
    PaymentId SERIAL PRIMARY KEY,
    UserId INT REFERENCES FinancialTransactions_Users(UserId),
    PaymentDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PaymentAmount DECIMAL(10,2)
);
CREATE TABLE FinancialTransactions_PaymentMethods (
    PaymentMethodId SERIAL PRIMARY KEY,
    PaymentMethodName VARCHAR(50)
);
CREATE TABLE FinancialTransactions_PaymentHistory (
    PaymentHistoryId SERIAL PRIMARY KEY,
    PaymentId INT REFERENCES FinancialTransactions_Payments(PaymentId),
    PaymentMethodId INT REFERENCES FinancialTransactions_PaymentMethods(PaymentMethodId),
    PaymentStatus VARCHAR(50),
    PaymentDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE FinancialTransactions_DbgLogs
(
    Id SERIAL PRIMARY KEY,
	TransactionName VARCHAR(150),
	TransactionDetails TEXT,
	TransactionStatus VARCHAR(50),
    CreateDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    ChangeDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Generate SQL commands for filling tables (INSERT command): 
-- you need to fill tables associated with FinancialTransactions_Users and FinancialTransactions_Products: FinancialTransactions_Users, FinancialTransactions_Addresses, FinancialTransactions_ProductCategories, FinancialTransactions_Products.
-- The FinancialTransactions_Users and FinancialTransactions_Addresses tables should have 10 records, the FinancialTransactions_Products table should have 15 records, 
-- and the FinancialTransactions_ProductCategories table should have 5 records.
INSERT INTO FinancialTransactions_Users (FirstName, LastName, Email, Password)
VALUES
('John', 'Doe', 'johndoe@example.com', 'password1'),
('Jane', 'Doe', 'janedoe@example.com', 'password2'),
('Bob', 'Smith', 'bobsmith@example.com', 'password3'),
('Alice', 'Johnson', 'alicejohnson@example.com', 'password4'),
('David', 'Lee', 'davidlee@example.com', 'password5'),
('Emily', 'Wang', 'emilywang@example.com', 'password6'),
('Michael', 'Brown', 'michaelbrown@example.com', 'password7'),
('Sarah', 'Taylor', 'sarahtaylor@example.com', 'password8'),
('Daniel', 'Kim', 'danielkim@example.com', 'password9'),
('Olivia', 'Davis', 'oliviadavis@example.com', 'password10');
INSERT INTO FinancialTransactions_Addresses (UserId, Street, City, State, ZipCode)
VALUES
(1, '123 Main St', 'Anytown', 'CA', '12345'),
(2, '456 Oak St', 'Othertown', 'NY', '67890'),
(3, '789 Pine St', 'Another Town', 'TX', '23456'),
(4, '321 Maple St', 'Smalltown', 'FL', '78901'),
(5, '654 Elm St', 'Bigtown', 'IL', '34567'),
(6, '987 Cedar St', 'Cityville', 'WA', '89012'),
(7, '246 Birch St', 'Hometown', 'OH', '12367'),
(8, '369 Spruce St', 'Villagetown', 'MI', '89034'),
(9, '582 Walnut St', 'Metropolis', 'GA', '56789'),
(10, '715 Ash St', 'Capital City', 'DC', '90123');
INSERT INTO FinancialTransactions_ProductCategories (CategoryName)
VALUES
('Electronics'),
('Clothing'),
('Home and Garden'),
('Toys and Games'),
('Sports and Outdoors');
INSERT INTO FinancialTransactions_Products (CategoryId, ProductName, Price)
VALUES
(1, 'Smartphone', 500.00),
(1, 'Laptop', 1000.00),
(1, 'Tablet', 400.00),
(1, 'Smartwatch', 200.00),
(1, 'Headphones', 100.00),
(2, 'T-Shirt', 20.00),
(2, 'Jeans', 50.00),
(2, 'Dress', 80.00),
(2, 'Sweater', 60.00),
(2, 'Jacket', 100.00),
(3, 'Bedding Set', 80.00),
(3, 'Kitchen Utensils Set', 50.00),
(3, 'Vacuum Cleaner', 150.00),
(4, 'Board Game', 30.00),
(4, 'Action Figure', 10.00),
(5, 'Basketball', 25.00),
(5, 'Tennis Racket', 70.00),
(5, 'Hiking Boots', 100.00);

-- Generate SQL commands to fill tables (INSERT command): 
-- you need to fill the tables associated with orders: FinancialTransactions_Orders, FinancialTransactions_OrderDetails, FinancialTransactions_OrderStatuses.
-- The FinancialTransactions_Orders and FinancialTransactions_OrderDetails tables should have 10 records, and the FinancialTransactions_OrderStatuses table should have 5 records.
INSERT INTO FinancialTransactions_Orders (UserId)
VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10);
INSERT INTO FinancialTransactions_OrderDetails (OrderId, ProductId, Quantity, Price)
VALUES
(1, 1, 2, 1000.00),
(1, 3, 1, 400.00),
(2, 2, 1, 1000.00),
(2, 4, 2, 400.00),
(3, 5, 3, 100.00),
(3, 7, 1, 150.00),
(4, 6, 2, 50.00),
(4, 8, 1, 80.00),
(5, 9, 1, 60.00),
(5, 10, 1, 100.00),
(6, 11, 2, 80.00),
(6, 13, 1, 150.00),
(7, 12, 3, 30.00),
(7, 14, 2, 50.00),
(8, 15, 1, 25.00),
(8, 1, 1, 70.00),
(9, 12, 1, 100.00),
(9, 15, 1, 100.00),
(10, 7, 2, 30.00),
(10, 10, 1, 70.00);
INSERT INTO FinancialTransactions_OrderStatuses (OrderStatusName)
VALUES
('Pending'),
('Processing'),
('Shipped'),
('Delivered'),
('Canceled');

-- Generate SQL commands for filling tables (INSERT command): 
-- you need to fill in the tables related to payment: FinancialTransactions_Payments, FinancialTransactions_PaymentMethods, FinancialTransactions_PaymentHistory.
-- The FinancialTransactions_Payments and FinancialTransactions_PaymentHistory tables should have 10 records, and the FinancialTransactions_PaymentMethods table should have 5 records.
INSERT INTO FinancialTransactions_Payments (UserId, PaymentAmount)
VALUES
(1, 500.00),
(2, 750.00),
(3, 1000.00),
(4, 250.00),
(5, 800.00),
(6, 1200.00),
(7, 300.00),
(8, 900.00),
(9, 600.00),
(10, 1500.00);
INSERT INTO FinancialTransactions_PaymentMethods (PaymentMethodName)
VALUES
('Credit Card'),
('PayPal'),
('Apple Pay'),
('Google Wallet'),
('Bank Transfer');
INSERT INTO FinancialTransactions_PaymentHistory (PaymentId, PaymentMethodId, PaymentStatus)
VALUES
(1, 1, 'Pending'),
(2, 2, 'Processing'),
(3, 3, 'Shipped'),
(4, 4, 'Delivered'),
(5, 5, 'Canceled'),
(6, 1, 'Pending'),
(7, 2, 'Processing'),
(8, 3, 'Shipped'),
(9, 4, 'Delivered'),
(10, 5, 'Canceled');

-- Additional queries.
INSERT INTO FinancialTransactions_Orders (UserId) VALUES (4);
INSERT INTO FinancialTransactions_OrderDetails (OrderId, ProductId, Quantity, Price)
VALUES (11, 1, 2, 1100.00), (11, 3, 1, 450.00), (11, 9, 1, 61.00);