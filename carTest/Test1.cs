using prjIndexesIceTask;

namespace carTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestcarName()
        {
            CarService service = new CarService(15000, "Audi", "225/45/18", "Pink", "major");
            Assert.AreEqual(service[1], "Audi");
        }

        [TestMethod]
        public void updateServiceType()
        {
            CarService service = new CarService(15000, "Audi", "225/45/18", "Pink", "major");
            service[4] = "minor"; //int index
            Assert.AreEqual(service[4], "minor");
        }

        [TestMethod]
        public void TestTyreSize()
        {
            CarService service = new CarService(15000, "Audi", "225/45/18", "Pink", "major");
            Assert.AreEqual(service[2], "225/45/18");
        }

        public void updateTyreSize()
        {
            CarService service = new CarService(15000, "Audi", "225/45/18", "Pink", "major");
            service[2] = "225/35/19"; //int index
            Assert.AreEqual(service[2], "225/35/19");
        }

        public void updateCarColour()
        {
            CarService service = new CarService(15000, "Audi", "225/45/18", "Pink", "major");
            service[3] = "Purple"; //int index
            Assert.AreEqual(service[3], "Purple");
        }
    }
}
