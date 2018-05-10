using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerLibrary;

namespace TestCases
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Name is null, empty or white space.")]
        public void B1()
        {
            Customer one = new Customer(null, "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Name is null, empty or white space.")]
        public void B2()
        {
            Customer one = new Customer("", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Name is null, empty or white space.")]
        public void B3()
        {
            Customer one = new Customer(" ", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for name.")]
        public void B4()
        {
            Customer one = new Customer("Max3", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for name.")]
        public void B5()
        {
            Customer one = new Customer("3Max", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for name.")]
        public void B6()
        {
            Customer one = new Customer("Max!", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for name.")]
        public void B7()
        {
            Customer one = new Customer("!Max", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for name.")]
        public void B8()
        {
            Customer one = new Customer("Ma.x", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        public void B9()
        {
            Customer one = new Customer("Max", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Surname is null, empty or white space.")]
        public void B10()
        {
            Customer one = new Customer("Max", null, "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Surname is null, empty or white space.")]
        public void B11()
        {
            Customer one = new Customer("Max", "", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Surname is null, empty or white space.")]
        public void B12()
        {
            Customer one = new Customer("Max", " ", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for surname.")]
        public void B13()
        {
            Customer one = new Customer("Max", "Mustermann3", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for surname.")]
        public void B14()
        {
            Customer one = new Customer("Max", "3Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for surname.")]
        public void B15()
        {
            Customer one = new Customer("Max", "Mustermann!", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for surname.")]
        public void B16()
        {
            Customer one = new Customer("Max", "!Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only letters of the alphabet allowed for surname.")]
        public void B17()
        {
            Customer one = new Customer("Max", "Must.ermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        public void B18()
        {
            Customer one = new Customer("Max", "Mustermann", "one@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Mail contains invalid symbol(s).")]
        public void B19()
        {
            Customer one = new Customer("Max", "Mustermann", "on)e@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Mail must contain exactly one @.")]
        public void B20()
        {
            Customer one = new Customer("Max", "Mustermann", "onetwo.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Mail must contain exactly one @.")]
        public void B21()
        {
            Customer one = new Customer("Max", "Mustermann", "on@e@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Mail must have at least one . after the @.")]
        public void B22()
        {
            Customer one = new Customer("Max", "Mustermann", "one@twocom", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "There must be at least one character before the @.")]
        public void B23()
        {
            Customer one = new Customer("Max", "Mustermann", "@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        public void B24()
        {
            Customer one = new Customer("Max", "Mustermann", "a@two.com", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "The part after the final . must be 2‐4 characters long and contain only letters.")]
        public void B25()
        {
            Customer one = new Customer("Max", "Mustermann", "a@two.c", 100, 1, DateTime.Today);
        }

        [TestMethod]
        public void B26()
        {
            Customer one = new Customer("Max", "Mustermann", "a@two.co", 100, 1, DateTime.Today);
        }

        [TestMethod]
        public void B27()
        {
            Customer one = new Customer("Max", "Mustermann", "a@two.comm", 100, 1, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "The part after the final . must be 2‐4 characters long and contain only letters.")]
        public void B28()
        {
            Customer one = new Customer("Max", "Mustermann", "a@two.commm", 100, 1, DateTime.Today);
        }
    }
}
