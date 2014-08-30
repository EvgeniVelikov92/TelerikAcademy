SELECT * FROM Departments

SELECT Name FROM Departments

SELECT Salary FROM Employees

SELECT FirstName + ' ' + LastName AS [Full Name] FROM Employees

SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Addresses] FROM Employees

SELECT Salary FROM Employees
ORDER BY Salary

SELECT * FROM Employees
WHERE JobTitle = 'Sales Representative'

SELECT FirstName + ' ' + LastName AS Name FROM Employees
WHERE FirstName LIKE 'SA%'

SELECT FirstName + ' ' + LastName AS Name FROM Employees
WHERE LastName LIKE '%ei%'

SELECT FirstName + ' ' + LastName AS Name, Salary FROM Employees
WHERE Salary >= 20000 AND Salary <= 30000

SELECT FirstName + ' ' + LastName AS Name, Salary FROM Employees
WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600

SELECT FirstName + ' ' + LastName AS Name, ManagerID FROM Employees
WHERE ManagerID IS NULL

SELECT FirstName + ' ' + LastName AS Name, Salary FROM Employees
WHERE Salary >= 50000
ORDER BY Salary DESC

SELECT TOP 5 Salary FROM Employees
ORDER BY Salary DESC

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], a.AddressText AS [Address]
FROM Employees e 
	JOIN Addresses a
		ON e.AddressID = a.AddressID

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], m.FirstName + ' ' + m.LastName AS [Manager Name]
FROM Employees e INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], m.FirstName + ' ' + m.LastName AS [Manager Name], a.AddressText AS [Address]
FROM Employees e 
	INNER JOIN Employees m
		ON e.ManagerID = m.EmployeeID
	JOIN Addresses a
		ON e.AddressID = a.AddressID

SELECT Name FROM Departments
UNION
SELECT Name FROM Towns

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], m.LastName AS [Manager Name] 
FROM Employees e RIGHT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], m.LastName AS [Manager Name] 
FROM Employees e LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

SELECT e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName AS Name, e.HireDate, d.Name
FROM Employees e 
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID 
WHERE (e.FirstName IS NOT NULL AND e.MiddleName IS NOT NULL AND e.LastName IS NOT NULL) 
	AND d.Name = 'Sales' OR d.Name = 'Finance' 
	AND (e.HireDate >= 1995 OR e.HireDate <= 2005)