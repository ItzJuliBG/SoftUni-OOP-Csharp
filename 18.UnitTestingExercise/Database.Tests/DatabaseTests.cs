namespace Database.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using System;
    using System.Data.Common;
    using System.Linq;

    [TestFixture]
    /*Storing array's capacity must be exactly 16 integers
    If the size of the array is not 16 integers long, InvalidOperationException is throw*/
    public class DatabaseTests
    {
        private Database db;
        private Database emptyDb;
        private int[] newint;
        [SetUp]
        public void CreatingVariablesNeeded() 
        {
           newint = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            db = new Database(newint);
            emptyDb = new Database();
        }
        [Test]
        public void TestIf_DatabaseStoresExactly_16Ints()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => db.Add(1));
            Assert.AreEqual("Array's capacity must be exactly 16 integers!", ex.Message);

        }

        [Test]
        public void TestIf_DatabaseHasLimit_OfAddingInts_Of16Elements()
        {
            int[] newint = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            
            var ex = Assert.Throws<InvalidOperationException>(() => db = new Database(newint));
            Assert.AreEqual("Array's capacity must be exactly 16 integers!", ex.Message);
            
        }

        [Test]
        public void TestIf_RemoveCantRemoveFrom_EmptyDatabase()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => emptyDb.Remove());
            Assert.AreEqual("The collection is empty!", ex.Message);

        }
        [Test]
        public void TestIf_FetchReturn_Array()
        {
            Type expectedType = typeof(int[]);
            Assert.AreEqual(expectedType, db.Fetch().GetType());

        }
        [Test]
        public void TestIf_ConstructorTakes_OnlyInts()
        {
            int[] databaseData = db.Fetch();
            for (int i = 0; i < newint.Count(); i++)
            {
                Assert.AreEqual(newint[i], databaseData[i]);
            }
            Assert.NotNull(db);
            Assert.AreEqual(databaseData.Length, db.Count);
            Assert.Equal

        }
    }
}
