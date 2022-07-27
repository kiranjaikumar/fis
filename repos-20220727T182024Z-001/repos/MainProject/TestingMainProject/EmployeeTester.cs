using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MainProject;


namespace TestingMainProject
{
    [TestFixture]
    public class EmployeeTester
    {

        //Arrange
        List<Employee> elist;

        [Test]
        public void CheckAllEmployeedetails()
        {
            //Arrange

            Employee emp = new Employee();
            //Act
            elist = emp.AllEmployess();

            //Assert
            foreach (var v in elist)
            {
                Assert.IsNotNull(v.ID);
                Assert.IsNotNull(v.Fname);
                Assert.IsNotNull(v.Salary);
            }
        }

        [Test]
        public void TestTheEmployeeLoginFunction()
        {
            //arrange

            Employee emp = new Employee();

            //act

            string s1 = emp.Login("Deepak", "Admin123");
            string s2 = emp.Login("", "");
            string s3 = emp.Login("Admin", "Admin123");

            //assert
            Assert.AreEqual("Invalid User Id or Password", s1);
            Assert.AreEqual("Welcome Admin", s3);
            Assert.AreEqual("User Id or Password cannot be Empty", s2);

        }

        [Test]

        public void GetEmployeebyid_should_return_empty_if_id_doesnotmatch()
        {
            //arrange
            Employee emp = new Employee();

            //act
            List<Employee> returnedemp = emp.GetEmployeeById(1);
            //assert
            Assert.IsNotNull(returnedemp);

            List<Employee> returnedemp1 = emp.GetEmployeeById(101);
            Assert.IsNotNull(returnedemp1);

        }
        [Test]
        public void GetConcatinatedName()
        {
            //Arrange
            Employee emp = new Employee();

            //Act
            string fname = "Deepak";
            string lname = " Baravkar";
            string s1 = emp.GetName("Deepak", "Baravkar");
            string s2 = emp.GetName(fname, lname);

            //Assert
            Assert.IsNotNull(s1);
            Assert.AreEqual(s2, fname + lname);
        }
        public static void Main()
        {

        }
    }
}