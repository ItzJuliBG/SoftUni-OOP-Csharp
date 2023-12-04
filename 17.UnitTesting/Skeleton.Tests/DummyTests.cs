using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
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
        public void TestIf_DummyWill_Die()
        {
            dummy.TakeAttack(axe1.AttackPoints);
            var exception = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(0));
            Assert.AreEqual("Dummy is dead.", exception.Message);
        }
        [Test]
        public void TestIf_DummyWill_GiveExperience_WhenItsAlive()
        {
            var exception = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.AreEqual("Target is not dead.", exception.Message);
        }
        [Test]
        public void TestIf_DummyReturns_CorrectExperience()
        {
            dummy.TakeAttack(100);
            Assert.AreEqual(10, dummy.GiveExperience());
        }
    }
}