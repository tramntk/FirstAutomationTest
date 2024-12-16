using ElectricCal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Test
{
    [TestClass]
    public class ValidTest : BaseTest
    {

        //Verify case tinh gia tien bac 1
        [TestMethod("TC1: Verify tinh gia tien bac 1")]
        public void TinhTienBac1()
        {
            //Khai bao chi so dau ky, chi so cuoi ky
            int chiSoDauKy = 0;
            int chiSoCuoiKy = 1;
             
            //Expect value cho gia tien phai tra
            int expected = 1678;
            
            //Run test
            int actual = testApp.Calculator(chiSoDauKy, chiSoCuoiKy);

            //Kiem tra
            Assert.AreEqual(expected, actual);

        }

        //Verify case tinh gia tien bac 1
        [TestMethod("TC3: Verify tinh gia tien bac 1 su dung DataRow")]
        [DataRow(100,100, DisplayName = "Tinh tien bac 1: input 100 va 100")]
        [DataRow(100, 101, DisplayName = "Tinh tien bac 1: input 100 va 101")]
        [DataRow(100, 150, DisplayName = "Tinh tien bac 1: input 100 va 150")]
        public void TinhTienBac1_DataRow(int chiSoDauKy,int chiSoCuoiKy)
        {
            //Expect value cho gia tien phai tra
            int expected = (chiSoCuoiKy - chiSoDauKy)* 1678;

            //Run test
            int actual = testApp.Calculator(chiSoDauKy, chiSoCuoiKy);

            //Kiem tra
            Assert.AreEqual(expected, actual);

        }

        //Verify case tinh gia tien bac 2
        [TestMethod("TC2: Verify tinh gia tien bac 2")]
        [DataRow(100, 100, DisplayName = "Tinh tien bac 1: input 100 va 151")]
        [DataRow(100, 101, DisplayName = "Tinh tien bac 1: input 100 va 199")]
        [DataRow(100, 150, DisplayName = "Tinh tien bac 1: input 100 va 200")]
        public void TinhTienBac2_DataRow(int chiSoDauKy, int chiSoCuoiKy)
        {
            //Expect value cho gia tien phai tra
            int expected = (chiSoCuoiKy - chiSoDauKy)* 1734;

            //Run test
            int actual = testApp.Calculator(chiSoDauKy, chiSoCuoiKy);

            //Kiem tra
            Assert.AreEqual(expected, actual);

        }
    }
}
