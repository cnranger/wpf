using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.UI;
using InventoryService;
using NUnit.Framework;

namespace Inventory.Test.Mapper
{
    public class When_specify_a_correct_wheel_count_property
    {
        [Test]
        public void should_extract_the_wheel_count_property()
        {
            var m1 = new Mapper<Aeroplane>("Plane", x => x.WheelCount);
            Assert.AreEqual("WheelCount", m1.WheelCountPropertyName);
        }
    }

    public class When_specify_a_null_expression
    {
        [Test]
        public void should_extract_the_wheel_count_property_as_null()
        {
            var m2 = new Mapper<Boat>("Boat", null);
            Assert.IsNull(m2.WheelCountPropertyName);
        }
    }

    public class When_specify_a_wheel_count_property_expression_with_null_property_name
    {
        [Test]
        public void should_extract_the_wheel_count_property_as_null()
        {
            var m2 = new Mapper<Boat>("Boat", x => null);
            Assert.IsNull(m2.WheelCountPropertyName);
        }
    }

    public class When_specify_a_wheel_count_property_expression_in_wrong_format
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void should_raise_argument_exception_and_prompt_users_the_correct_format()
        {
            new Mapper<Boat>("Boat", x => x.GuestCount + x.Engines);
        }
    }
}
