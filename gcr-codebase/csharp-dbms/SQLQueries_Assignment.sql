

/*
=================================================>

DDL – Data Definition Language

-- SYNTAX:
-- CREATE TABLE table_name (column_name datatype, column_name datatype, ...);

CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT
);

*/

/*
-- SYNTAX:
-- ALTER TABLE table_name ADD column_name datatype;

ALTER TABLE Employees
ADD Email VARCHAR(100);
*/

/*

-- SYNTAX:
-- DROP TABLE table_name;

DROP TABLE Employees;

*/


/*

-- SYNTAX:
-- TRUNCATE TABLE table_name;

TRUNCATE TABLE Employees;

=======================================================>
*/




/*
==============================================>

DML – Data Manipulation Language


-- SYNTAX:
-- INSERT INTO table_name VALUES (value1, value2, value3, ...);

INSERT INTO Employees VALUES (1, 'Sahil', 'HR', 25000, 'Sahil@gmail.com');
INSERT INTO Employees VALUES (2, 'Sajal', 'IT', 30000, 'Sajal@gmail.com');

*/

/*

-- SYNTAX:
-- UPDATE table_name SET column_name = value WHERE condition;

UPDATE Employees
SET Salary = 35000
WHERE EmpID = 2;

*/

/*
-- SYNTAX:
-- DELETE FROM table_name WHERE condition;

DELETE FROM Employees
WHERE EmpID = 1;

=============================================>
*/

/*
==============================================>
DQL – Data Query Language

-- SYNTAX:
-- SELECT column_name FROM table_name;

SELECT *
FROM Employees;

==============================================>
*/


/*
==============================================>

DCL – Data Control Language

-- SYNTAX:
-- GRANT permission ON object TO user;

GRANT SELECT
ON Employees
TO StudentUser;


*/


/*

-- SYNTAX:
-- REVOKE permission ON object FROM user;

REVOKE SELECT
ON Employees
FROM StudentUser;

===========================================>
*/


/*
============================================>
TCL – Transaction Control Language

-- SYNTAX:
-- COMMIT;

BEGIN TRANSACTION;

INSERT INTO Employees VALUES (3, 'New Student', 'Finance', 40000, 'amit@gmail.com');

COMMIT;

*/


/*

-- SYNTAX:
-- ROLLBACK;

BEGIN TRANSACTION;

DELETE FROM Employees WHERE EmpID = 2;

ROLLBACK;


*/

/*

-- SYNTAX:
-- SAVE TRANSACTION savepoint_name;

BEGIN TRANSACTION;

INSERT INTO Employees VALUES (4, 'Karan', 'Sales', 28000, 'karan@gmail.com');

SAVE TRANSACTION SavePoint1;

DELETE FROM Employees WHERE EmpID = 4;

ROLLBACK TRANSACTION SavePoint1;

COMMIT;

===========================================>
*/