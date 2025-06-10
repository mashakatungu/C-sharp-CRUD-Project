CREATE TABLE clients (
      id INT NOT NULL PRIMARY KEY IDENTITY,
      firstname VARCHAR (100) NOT NULL,
      lastname VARCHAR (100) NOT NULL,
      email VARCHAR (100) NOT NULL,
      phone VARCHAR (100) NOT NULL,
      address VARCHAR (200) NOT NULL,
      created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
      );
INSERT INTO clients (firstname, lastname, email, phone, address)
VALUES 
('John', 'Doe', 'john.doe@example.com', '123-456-7890', '123 Main St'),
('Jane', 'Smith', 'jane.smith@example.com', '234-567-8901', '456 Oak Ave'),
('Alice', 'Brown', 'alice.brown@example.com', '345-678-9012', '789 Pine Rd'),
('Bob', 'Johnson', 'bob.johnson@example.com', '456-789-0123', '101 Maple Dr'),
('Eve', 'Davis', 'eve.davis@example.com', '567-890-1234', '202 Cedar Ln'),
('Charlie', 'Taylor', 'charlie.taylor@example.com', '678-901-2345', '303 Birch Pl'),
('Grace', 'Lee', 'grace.lee@example.com', '789-012-3456', '404 Willow St'),
('Henry', 'Martin', 'henry.martin@example.com', '890-123-4567', '505 Spruce Ct'),
('Ivy', 'Clark', 'ivy.clark@example.com', '901-234-5678', '606 Elm Way'),
('Jake', 'Hall', 'jake.hall@example.com', '012-345-6789', '707 Cherry Blvd'),
('Liam', 'Lewis', 'liam.lewis@example.com', '111-222-3333', '808 Aspen Trl'),
('Mia', 'Young', 'mia.young@example.com', '222-333-4444', '909 Fir Cir'),
('Noah', 'Walker', 'noah.walker@example.com', '333-444-5555', '111 Magnolia Ct'),
('Olivia', 'King', 'olivia.king@example.com', '444-555-6666', '222 Poplar Ln'),
('Paul', 'Scott', 'paul.scott@example.com', '555-666-7777', '333 Redwood Rd');
