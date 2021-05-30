using NUnit.Framework;
using EmployeePayrollserviceADO.net;

namespace EmployeePayrollProblemTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //UC1:- Ability to create a payroll service database and have C# program connect to database.

        [Test]
        public void CheckConnection() //Create CheckConnection method to Check Connection
        {
            EmployeeRepository employeeRepository = new EmployeeRepository(); //create object EmployeeRepository class
            bool actual = employeeRepository.DataBaseConnection(); //call method
            bool expected = true; //expected true 
            Assert.AreEqual(expected, actual); // Check equal or not
        }
    }
}