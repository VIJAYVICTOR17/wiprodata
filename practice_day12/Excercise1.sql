use EmpSample_#OK

SELECT * FROM tblEmployees;

--1.Write a query to Get a List of Employees who have a one part name

SELECT * FROM tblEmployees
WHERE Name LIKE '% %'      
  AND Name NOT LIKE '%.%';

--2.Write a query to Get a List of Employees who have a three part name

SELECT * FROM tblEmployees
WHERE Name LIKE '% % %'    
  AND Name NOT LIKE '%.%';
  

--3.write a query to get a list of Employees who have a First Middle Or last name as Ram, and not any thing else

SELECT * FROM tblEmployees
WHERE Name = 'Ram'                      
   OR Name LIKE 'Ram %' 
   OR Name LIKE '% Ram'  
   OR Name LIKE '% Ram %';  


 --4.Write the answers for  the Below

--65 OR 11	`	`
--65 XOR 11	^	74
--65 AND 11	&	1
--(12 AND 4) OR (13 AND 1)	&, `	`
--127 OR 64	`	`
--127 XOR 64	^	63
--127 XOR 128	^	255
--127 AND 64	&	64
--127 AND 128	&	0

select emp.EmployeeNumber, emp.Name, emp.CentreCode
from dbo.tblEmployees emp
where emp.CentreCode = 65 or emp.CentreCode = 11;

--4.2

select COUNT(*)
from dbo.tblEmployees emp
where (emp.CategoryCode = 65 and emp.CentreCode <> 11) or ((emp.CategoryCode <> 65 and emp.CentreCode = 11));
  
  --OR

select COUNT(*)
from tblEmployees emp
where (emp.CategoryCode = 65 or emp.CentreCode = 11) and ((emp.CategoryCode <> 65 and emp.CentreCode <> 11));  

--4.3

select emp.EmployeeNumber, emp.Name, emp.CentreCode, emp.CategoryCode
from tblEmployees emp
where emp.CategoryCode = 12 and emp.CentreCode = 4;

--4.4

select emp.EmployeeNumber, emp.Name, emp.CentreCode, emp.CategoryCode
from dbo.tblEmployees emp
where (emp.CategoryCode=12 and emp.CentreCode=4)or (emp.CategoryCode=13 and emp.CentreCode=1);

--4.5

select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 or emp.EmployeeNumber = 64;

--4.6

select emp.EmployeeNumber,emp.Name
from dbo.tblEmployees emp
where (emp.CategoryCode = 127 and emp.CentreCode <> 64) or ((emp.CategoryCode <> 127 and emp.CentreCode = 64));

--4.7

select emp.EmployeeNumber,emp.Name
from dbo.tblEmployees emp
where (emp.CategoryCode = 127 and emp.CentreCode <> 128) or ((emp.CategoryCode <> 127 and emp.CentreCode = 128));

--4.8

select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 and emp.AreaCode = 64;

--4.9

select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 and emp.AreaCode = 128;


--5.Write a query which returns data in all columns from the table dbo.tblCentreMaster

SELECT * FROM tblCentreMaster;


--6.Write a query which gives employee types in the organization.

SELECT *  from tblEmployees;

select * from tblEmployeeTypes;

SELECT EmployeeType, Description
FROM tblEmployeeTypes;

--7.Write a query which returns Name, FatherName, DOB of employees whose PresentBasic is
--a.Greater than 3000.

SELECT Name, FatherName, DOB, PresentBasic
FROM tblEmployees
WHERE PresentBasic > 3000;

--b.Less than 3000.

SELECT Name, FatherName, DOB, PresentBasic
FROM tblEmployees
WHERE PresentBasic < 3000;

--c.Between 3000 and 5000.

SELECT Name, FatherName, DOB, PresentBasic
FROM tblEmployees
WHERE PresentBasic BETWEEN 3000 AND 5000;

--8.Write a query which returns All the details of employees whose Name
--a.Ends with 'KHAN'

SELECT *
FROM tblEmployees
WHERE Name LIKE '%KHAN';

--b.Starts with 'CHANDRA'

SELECT *
FROM tblEmployees
WHERE Name LIKE 'CHANDRA%';

--c.Is 'RAMESH' and their initial will be in the rage of alphabets a-t.

SELECT *
FROM tblEmployees
WHERE Name LIKE '[A-T].RAMESH';

