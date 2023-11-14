-- Bảng Admin
CREATE TABLE Admin(
    admin_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL,
    PASSWORD NVARCHAR(255) NOT NULL,
    full_name NVARCHAR(100),
    email NVARCHAR(100),
    phone NVARCHAR(20),
    last_login DATETIME,
    created_at DATETIME2 DEFAULT CURRENT_TIMESTAMP,
    deleted_at DATETIME
);
Go
-- Bảng Customer
CREATE TABLE Customer(
    customer_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL,
    PASSWORD NVARCHAR(255) NOT NULL,
    avatar NVARCHAR(255),
    address NVARCHAR(255),
    full_name NVARCHAR(100),
    email NVARCHAR(100),
    phone NVARCHAR(20),
    birthday DATE,
    last_login DATETIME,
    created_at DATETIME2 DEFAULT CURRENT_TIMESTAMP,
    active BIT
);
Go
-- Bảng Brand
CREATE TABLE Brand(
    brand_id INT IDENTITY(1,1) PRIMARY KEY,
    brand_name NVARCHAR(50)
);
Go
-- Bảng Category
CREATE TABLE Category(
    category_id INT IDENTITY(1,1) PRIMARY KEY,
    category_name NVARCHAR(50)
);
Go

-- Bảng Product
CREATE TABLE Product(
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    product_name NVARCHAR(100),
    title NVARCHAR(255),
    description NVARCHAR(MAX),
    price DECIMAL(10, 2),
    image NVARCHAR(255),
    video NVARCHAR(255),
    category_id INT,
    brand_id INT,
    stock_quantity INT,
    created_at DATETIME2 DEFAULT CURRENT_TIMESTAMP,
    deleted_at DATETIME,
    active BIT,
    FOREIGN KEY(category_id) REFERENCES Category(category_id)
);
Go
-- Bảng Feedback
CREATE TABLE Feedback(
    feedback_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT,
    product_id INT,
    feedback_text NVARCHAR(MAX),
    rating INT,
    created_at DATETIME2 DEFAULT CURRENT_TIMESTAMP,
    deleted_at DATETIME,
    FOREIGN KEY(user_id) REFERENCES Customer(customer_id),
    FOREIGN KEY(product_id) REFERENCES Product(product_id)
);
Go
-- Bảng Shipper
CREATE TABLE Shipper(
    shipper_id INT IDENTITY(1,1) PRIMARY KEY,
    shipper_name NVARCHAR(100),
    phone NVARCHAR(20),
    company NVARCHAR(100),
    ship_date DATETIME
);
Go
-- Bảng Order
CREATE TABLE [Order](
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT,
    order_date DATETIME,
    ship_date DATETIME,
    static_order BIT,
    paid BIT,
    payment_date DATETIME,
    payment_id INT,
    note NVARCHAR(MAX),
    created_at DATETIME2 DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY(customer_id) REFERENCES Customer(customer_id)
);
Go
-- Bảng Orderdetails
CREATE TABLE Orderdetails(
    orderdetail_id INT IDENTITY(1,1) PRIMARY KEY,
    order_id INT,
    product_id INT,
    order_number INT,
    quantity INT,
    discount DECIMAL(10, 2),
    total DECIMAL(10, 2),
    ship_date DATETIME,
    created_at DATETIME2 DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY(order_id) REFERENCES [Order](order_id)
);
