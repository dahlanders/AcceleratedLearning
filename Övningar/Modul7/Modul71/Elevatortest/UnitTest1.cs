using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modul71;
namespace Elevatortest
{
    [TestClass]
    public class UnitTest1
    {
        string Name = "Kalle";
        int startfloor = 3;
        const int MinFloor = 2;
        const int MaxFloor = 8;
     

        [TestMethod]
        public void TestMethod1()
        {
            var e = new Elevator(Name, startfloor, MinFloor, MaxFloor);

            e.GoUp();
            e.GoUp();
            e.GoUp();
            e.GoUp();
            e.GoUp();
            Assert.AreEqual(e.MaxFloor, e.CurrentFloor);
         
        


        }
    }
}
