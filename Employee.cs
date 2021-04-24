using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collectionlib
{
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    [TestFixture]
    public class EmployeeManager1
    {
        private readonly List<Employee1> employees;
        public int HeadCount { get; set; }
        public EmployeeManager1()
        {
            employees = new List<Employee1>();
            HeadCount = employees.Count;
        }
        [Test]
        [TestCase(new Employee1{Id=100, Name ="Rishi"}]
        public void AddEmployee(Employee1 empObj)
        {
            Assert.That(HeadCount,Is.EqualTo(0));
            employees.Add(empObj);
            HeadCount++;
            Assert.That(HeadCount, Is.EqualTo(1));
        }

    }
}
