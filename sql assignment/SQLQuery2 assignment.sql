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

