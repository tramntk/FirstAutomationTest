using ElectricCal;
using Microsoft.Testing.Platform.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Test
{
    [TestClass]
    public class InvalidTest: BaseTest
    {
        [TestMethod("TC01: Verify message khi chi so dau ky lon hon chi so cuoi ky")]
        public void TestChiSoCuoiKy_BeHonChiSoDauKy()
        {
            int chiSoDauKy = 10;
            int chiSoCuoiKy = 1;

            //Cach 1: handle = try catch
            
            //Khoi tao application
            try
            {
                int actual = testApp.Calculator(chiSoDauKy, chiSoCuoiKy);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Chi so dau ky khong duoc lon hon chi so cuoi ki", ex.Message);
            }
            

            //Cách 2: handle = Assert
            //Assert.ThrowsException<Exception>(() => testApp.Calculator(chiSoDauKy, chiSoCuoiKy));
            
        }
    }
}
