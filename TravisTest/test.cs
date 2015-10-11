using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TravisTest
{
    [TestFixture, Description("Tests Account")]
    public class Test
    {

        [Test, Description("Tests account")]
        public void TestGet()
        {
            var class1 = new Class1();
            Assert.IsNotNull(class1);
        }
    }
}
