TRUNCATE TABLE dbo.persons
GO

TRUNCATE TABLE dbo.persons_jobs
GO

TRUNCATE TABLE dbo.jobs
GO

-- Insert some random people

INSERT INTO [dbo].[persons]
VALUES('John Smith', '2, RoadClose, Coventry, CV1')
GO

INSERT INTO [dbo].[persons]
VALUES('Jane Doe', 'Flat 12, Building 6, Birmingham, BH3')
GO

INSERT INTO [dbo].[persons]
VALUES('Ricardo Dero', 'NOT TELLING')
GO

INSERT INTO [dbo].[persons]
VALUES('Victoria Hemmingway', null)
GO

INSERT INTO [dbo].[jobs]
VALUES('Customer Service', 'Greeting front of house')
GO

INSERT INTO [dbo].[jobs]
VALUES('Bus Driver', 'Driving people on the bus, taking money, checking tickets')
GO

-- Insert some random people with jobs
INSERT INTO [dbo].[persons_jobs]
VALUES('John Smith', 'Customer Service')
GO

INSERT INTO [dbo].[persons_jobs]
VALUES('Jane Doe', 'Bus Driver')
GO

INSERT INTO [dbo].[persons_jobs]
VALUES('Ricardo Dero', 'Customer Service')
GO

INSERT INTO [dbo].[persons_jobs]
VALUES('Victoria Hemmingway', 'No job')
GO