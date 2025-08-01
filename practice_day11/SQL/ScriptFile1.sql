use sqlpractice;

select * from Agent;

select * from Emp;

select Empno 'Employ No', nam 'Name', basic 'Salary'
from Emp;

select * from Emp where basic >10000 and basic < 40000;

select * from Emp where dept='DOTNET';

select * from Emp where basic between 10000 and 50000;

select * from Emp where basic not between 10000 and 50000;

select * from Emp where nam in('satish', 'kalayan', 'Harry', 'Smitha');

select * from Emp where nam like 's%';

select * from Emp where nam like '%na%';

select distinct dept from Emp;

select * from Emp order by dept, nam;

select * from Emp order by nam desc;