CREATE TABLE clients (
	id INT NOT NULL PRIMARY KEY IDENTITY,
	name VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	phonenumber VARCHAR(100) NOT NULL,
	address VARCHAR(200) NOT NULL,
);

INSERT INTO clients(name, email, phonenumber, address)
VALUES
('John Smith', 'johnsmith@email.com', '777-888-9999', 'York, England'),
('Sarah Lyle', 'sarahlyle@email.com', '777-888-9999', 'London, England'),
('Maya Smith', 'mayasmith@email.com', '777-888-9999', 'Doncaster, England')