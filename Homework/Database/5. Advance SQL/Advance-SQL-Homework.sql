-- 1
SELECT e.FirstName + ' ' + e.LastName AS Name, e.Salary,  d.Name AS Department
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

-- 2
SELECT e.FirstName + ' ' + e.LastName AS Name, e.Salary,  d.Name AS Department
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE Salary =
	(SELECT (MIN(Salary) * 0.1 + MIN(Salary)) FROM Employees
	 WHERE DepartmentID = e.DepartmentID)
GROUP BY e.FirstName, e.LastName, e.Salary, d.Name
ORDER BY d.Name

-- 3
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary, d.DepartmentID, d.Name AS [Department]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees
	WHERE DepartmentID = e.DepartmentID)
ORDER BY e.Salary

-- 4
SELECT AVG(Salary) AS [Average Salary for Department 1]
FROM Employees
WHERE DepartmentID = 1

-- 5
SELECT AVG(e.Salary) AS [Average Salary for "Sales"]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- 6
SELECT COUNT(e.EmployeeID)
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- 7
SELECT FirstName + ' ' + LastName AS [Full Name], ManagerID 
FROM Employees
WHERE ManagerID IS NOT NULL
ORDER BY ManagerID

-- 8
SELECT FirstName + ' ' + LastName AS [Full Name], ManagerID
FROM Employees
WHERE ManagerID IS NULL

-- 9
SELECT AVG(e.Salary) AS [Average Salary], d.DepartmentID AS [ID], d.Name AS [Department]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentID, d.Name

-- 10
SELECT d.Name AS [Department], COUNT(e.EmployeeID) AS [Employee Count]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

SELECT t.Name AS [Town], COUNT(e.EmployeeID) AS [Employee Count]
FROM Employees e
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY t.Name

-- 11
SELECT m.FirstName + ' ' + m.LastName AS [Manager Name], COUNT(e.EmployeeID) AS [Employees Number]
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) = 5

-- 12
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], ISNULL(m.FirstName, 'NOT') + ' ' + ISNULL(m.LastName, 'Manager') AS [Manager Name]
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.EmployeeID

-- 13
SELECT FirstName + ' ' + LastName FROM Employees
WHERE LEN(LastName) = 5

-- 14
SELECT CONVERT(VARCHAR(24), GETDATE(), 113)

-- 15
CREATE TABLE Users (
	UserID INT IDENTITY(1,1),
	Username NVARCHAR(80) UNIQUE NOT NULL,
	[Password] NVARCHAR(30) NOT NULL,
	[FullName] NVARCHAR(50) UNIQUE NOT NULL,
	[LastTimeLogin] Date,
	CHECK (LEN([Password])>=5 ),
	PRIMARY KEY (UserID)
)

-- 16
SELECT * FROM Users
WHERE LastTimeLogin = GETDATE()

-- 17
CREATE TABLE Groups (
	GroupID INT IDENTITY(1,1),
	Name NVARCHAR(50) UNIQUE NOT NULL,
	PRIMARY KEY (GroupID)
)

-- 18
ALTER TABLE Users
ADD GroupID INT CONSTRAINT FK_Users_Groups FOREIGN KEY (GroupID) REFERENCES Groups(GroupID)

-- 19
INSERT Groups ([Name]) 
	VALUES ('Social')
INSERT Groups ([Name]) 
	VALUES ('School')
INSERT Groups ([Name]) 
	VALUES ('College')
INSERT Users ([Username], [Password], [LastTimeLogin], [FullName], [GroupID])
	VALUES ('Peshov', '123456', '2014-8-8', 'Pesho Peshov', 1)
INSERT Users ([Username], [Password], [LastTimeLogin], [FullName], [GroupID])
	VALUES ('Goshov', '123456', '2014-8-8', 'Gosho Goshov', 2)
INSERT Users ([Username], [Password], [LastTimeLogin], [FullName], [GroupID])
	VALUES ('Mosho', '123456', '2014-8-8', 'Mosho Moshov', 1)

-- 21
DELETE FROM Users
WHERE GroupID = 1

-- 22
INSERT INTO Users ([Username], [FullName], [Password], [LastTimeLogin], [GroupID])
	SELECT SUBSTRING(FirstName, 1, 1) + LOWER(LastName) + '_' + SUBSTRING(JobTitle, 2, 2), 
		FirstName + ' ' + LastName, 
		'1234567890', 
		NULL, 
		NULL 
	FROM Employees

-- 23
SELECT * FROM Users
WHERE LastTimeLogin < GETDATE()

-- 24
DELETE FROM Users
WHERE Password = '123456'

-- 25
SELECT AVG(e.Salary) AS [Average Employees Salary], d.Name AS [Department], e.JobTitle
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentID, d.Name, e.JobTitle

-- 26
SELECT 'Mrs. ' + MIN(e.LastName) AS [Name], MIN(e.Salary) AS [Minimal Employees Salary], d.Name AS [Department], e.JobTitle
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentID, d.Name, e.JobTitle

-- 27
SELECT t.Name AS [Town], COUNT(t.TownID) AS [Max number of employees works]
FROM Employees e
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY COUNT(t.TownID) DESC

-- 28
SELECT t.Name AS [Town], COUNT(t.TownID) AS [Max number of manager works] 
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.EmployeeID
	JOIN Addresses a
		ON m.AddressID = a.AddressID
	JOIN Towns t
		ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY COUNT(t.TownID) DESC

-- 29
CREATE TABLE WorkHours(
	WorkHoursID INT IDENTITY(1,1) NOT NULL,
	[Date] Date,
	Task NTEXT,
	Comments NTEXT,
	PRIMARY KEY(WorkHoursID)
)
ALTER TABLE WorkHours
ADD EmployeeID INT CONSTRAINT FK_Users_Employees FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) NOT NULL