using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            //Not Found
            Assert.That(result, Is.TypeOf<NotFound>());

            //Not found for its derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
    }
}
