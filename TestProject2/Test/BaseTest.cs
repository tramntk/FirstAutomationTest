using ElectricCal;

namespace TestProject2.Test
{
    [TestClass]
    public class BaseTest
    {
        //khai bao bien de khoi tao application
        protected static TinhTienDien testApp;

        [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void SetUpTestApplication(TestContext testContext)
        {
            //Khoi tao application
            testApp = new TinhTienDien();
        }
    }
}
