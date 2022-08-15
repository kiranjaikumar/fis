create database assignmentdb
create table tbldept
(
  DeptId int primary key,
  DeptName varchar(20),
  DeptLocation varchar(30))
  select * from tbldept
  create table tblemp
(
    Empid int primary key,
	EmpName varchar(30),
	job char(20) not null,
	mgrid float(20),
	hiredate varchar(30),
	salary float,
	comm float(20),
	DId int references tbldept(deptid),
)
select * from tblemp
INSERT INTO tbldept
VALUES(10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')
alter table tblemp alter
column hiredate date;
insert into tblemp 
values(7369,'SMITH','CLERK',7902,'1980-12-17',800,NULL,20),
(7499,'ALLEN','SALESMAN',7698,'1981-02-20',1600,300,30),
(7521,'WARD','SALESMAN',7698,'1981-02-22',1250,500,30),
(7566,'JONES','MANAGER',7839,'1981-04-02',2975,NULL,20),
(7654,'MARTIN','SALESMAN',7698,'1981-10-28',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'1981-05-01',2850,NULL,30),
(7782,'CLARK','MANAGER',7839,'1981-06-09',2450,NULL,10),
(7788,'SCOTT','ANALYST',7566,'1987-04-19',3000,NULL,20),
(7839,'KING','PRESIDENT',NULL,'1981-11-17',5000,NULL,10),
(7844,'TURNER','SALESMAN',7698,'1981-10-08',1500,0,30),
(7876,'ADAMS','CLERK',7788,'1987-05-23',1100,NULL,20),
(7900,'JAMES','CLERK',7698,'1981-12-03',950,NULL,30),
(7902,'FORD','ANALYST',7566,'1981-12-03',3000,NULL,20),
(7934,'MILLER','CLERK',7782,'1982-01-23',1300,NULL,10)
SELECT * FROM tblemp WHERE EmpName LIKE 'A%';
SELECT * FROM tblemp WHERE MGRID IS NULL;
SELECT empname,EMPid,SALary FROM tbleMP WHERE salary BETWEEN 1200 AND 1400;
sELECT * FROM tblemp WHERE Did=20;
UPDATE tblemp
SET tblEMP.SALary += (salary*0.10)
WHERE tblEMP.Did=20;
SELECT COUNT(JOB) AS NO_OF_CLERKS
FROM tblemp
WHERE JOB='CLERK'
/*6. Find the average salary for each job 
type and the number of people employed in each job.*/
SELECT JOB,AVG(salary) AS NO_PEOPLE
FROM tblemp
GROUP BY JOB;
/*7. List the employees with the lowest and highest salary*/
SELECT MIN(SALary) AS LOWEST_SALARY,MAX(SALary) AS HIGHEST_SALARY
FROM tblemp;
/*8. List full details of departments that don't have any employees.*/
SELECT * FROM tbldept
WHERE DeptId
NOT IN (SELECT Did FROM tblemp)
/*9.Get the names and salaries of all the analysts earning more than 1200 
who are based in department 20. Sort the answer by ascending order of name.*/
SELECT EmpNAME,salary FROM tblemp
WHERE JOB = 'ANALYST' AND Did = 20
ORDER BY EmpNAME;
/* 10. For each department, list its name and number together with the 
total salary paid to employees in that department.*/
SELECT d.deptnAme,d.deptid,sum(e.salary) as' total salary' from tbldept d join tblemp e on d.DeptId=e.DId
group by d.DeptName,d.DeptId
/* 11. Find out salary of both MILLER and SMITH.*/
SELECT EmpNAME,salary FROM tblemp
WHERE EmpName= 'MILLER' OR EmpNAME='SMITH'
/*12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.*/
SELECT * FROM tblemp
WHERE EmpName LIKE 'A%' OR EmpName LIKE 'M%';
/*13. Compute yearly salary of SMITH.*/
SELECT EmpNAME,SUM(12*SALary) AS ANNUAL_SALARY
FROM tblemp
WHERE EmpName = 'SMITH'
GROUP BY EmpName;
/*14. List the name and salary for all employees 
whose salary is not in the range of 1500 and 2850*/
SELECT EmpNAME,SALary
FROM tblemp 
WHERE salary NOT IN 
(SELECT salary FROM tblemp WHERE salary BETWEEN 1500 AND 2850) 
GROUP BY EmpName,salary
Select did,avg(salary) from tblemp
group by did
/*assignment2*/
--1. Retrieve a list of MANAGERS. 
select distinct(mgrid) 
from tblemp

--2. Find out the names and salaries of all employees earning more than 1000 per month
select empname,salary
from tblemp
where salary>1000

--3. Display the names and salaries of all employees except JAMES. 
select empname,salary
from tblemp
where empname<>'JAMES'
order by EmpName

--4. Find out the details of employees whose names begin with ‘S’. 
select empname,empid
from tblemp
where EmpName like 'S%'

--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select empname
from tblemp
where empname like '%A%'

--6. Find out the names of all employees that have ‘L’ as their third character in their name
select empname 
from tblemp
where empname like '___L%'

--7. Compute daily salary of JONES. 
select empname,sum(salary/30) as daily_salary
from tblemp
where EmpName like 'JONES'
group by EmpName

--8. Calculate the total monthly salary of all employees. 
select sum(salary) as total
from tblemp
where Empid in (select distinct(empid) from tblemp)

--9. Print the average annual salary . 
select avg(salary*12) as avg_annual_salary
from tblemp

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select e.empname,e.job,e.salary,DId
from tblemp e
where job<>'SALESMAN' and did<>30
order by did


--11. List unique departments of the EMP table. 
select distinct(did) as departments 
from tblemp

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select empname as EMPLOYEE, salary as MONTHLY_SALARY
from tblemp
where salary>1500 and (did=10 or DId=30)

--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select empname, job,salary
from tblemp
where job='MANAGER' or job='ANALYST' and salary not in (1000,3000,5000)

--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 

select empname,salary,salary+salary*.1 as salll,comm
from tblemp
where comm > (salary+salary*.1)

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
select empname,mgrid
from tblemp
where empname like '%L%L%' and mgrid=7782

--16. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees. 
select empname,(YEAR(SYSDATETIME())-YEAR(hiredate) ) as Experience
from tblemp
where (YEAR(SYSDATETIME())-YEAR(hiredate) ) >10 and (YEAR(SYSDATETIME())-YEAR(hiredate) )<=20


--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select e.empname,d.deptname
from tblemp e, tbldept d
where d.DeptId=e.DId
order by DeptName asc, EmpName desc

--18. Find out experience of MILLER. 
select empname,(YEAR(SYSDATETIME())-YEAR(hiredate) ) as Experience
from tblemp
where EmpName='MILLER'