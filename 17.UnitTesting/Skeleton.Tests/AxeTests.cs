using Microsoft.VisualBasic;
using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Dummy dummy;
        private Axe axe1;
        private Axe axe2;
        [SetUp]
        public void CreatingNessesaryItems()
        {
            dummy = new Dummy(100, 10);
        axe1 = new Axe(100, 20);
        axe2 = new Axe(50, 0);
        }
    [Test]
        public void TestIfAxe_WillBrokeCorrectly_WhenDurabillityEnds()
        {
            var exception = Assert.Throws<InvalidOperationException>(() => axe2.Attack(dummy));
            Assert.AreEqual("Axe is broken.", exception.Message);
        }
        [Test]
        public void TestIfAxeDurability_LowersWhen_ItAttackSomeoneSuccessfully() 
        { 
            axe1.Attack(dummy);
            int axeDurability = axe1.DurabilityPoints;
            Assert.AreEqual(19, axeDurability);
        }
    }
}