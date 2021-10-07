using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEuclide_4_2__2()
        {
            // arrange 
            var gcd = new GCD();
            int x = 4;
            int y = 2;
            int expected = 2;
            // act
            double result = gcd.Euclide(x, y);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_2_0__2()
        {
            // arrange 
            var gcd = new GCD();
            int x = 2;
            int y = 0;
            int expected = 2;
            // act
            double result = gcd.Euclide(x, y);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_0_0__0()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = 0;
            int expected = 0;
            // act
            double result = gcd.Euclide(x, y);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_minus6_2__2()
        {
            // arrange 
            var gcd = new GCD();
            int x = -6;
            int y = 2;
            int expected = 2;
            // act
            double result = gcd.Euclide(x, y);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_minus6_minus3__3()
        {
            // arrange 
            var gcd = new GCD();
            int x = -6;
            int y = -3;
            int expected = 3;
            // act
            double result = gcd.Euclide(x, y);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_4_2_8__2()
        {
            // arrange 
            var gcd = new GCD();
            int x = 4;
            int y = 2;
            int z = 8;
            int expected = 2;
            // act
            double result = gcd.Euclide(x, y, z);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_0_2_8__2()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = 2;
            int z = 8;
            int expected = 2;
            // act
            double result = gcd.Euclide(x, y, z);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_0_minus10_15__5()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = -10;
            int z = 15;
            int expected = 5;
            // act
            double result = gcd.Euclide(x, y, z);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_0_0_0__0()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = 0;
            int z = 0;
            int expected = 0;
            // act
            double result = gcd.Euclide(x, y, z);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_22_0_11__11()
        {
            // arrange 
            var gcd = new GCD();
            int x = 22;
            int y = 0;
            int z = 11;
            int expected = 11;
            // act
            double result = gcd.Euclide(x, y, z);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_39_3_0__3()
        {
            // arrange 
            var gcd = new GCD();
            int x = 39;
            int y = 3;
            int z = 0;
            int expected = 3;
            // act
            double result = gcd.Euclide(x, y, z);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_60_48_12_24__12()
        {
            // arrange 
            var gcd = new GCD();
            int x = 60;
            int y = 48;
            int z = 12;
            int m = 24;
            int expected = 12;
            // act
            double result = gcd.Euclide(x, y, z, m);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_60_48_0_20__4()
        {
            // arrange 
            var gcd = new GCD();
            int x = 60;
            int y = 48;
            int z = 0;
            int m = 20;
            int expected = 4;
            // act
            double result = gcd.Euclide(x, y, z, m);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_minus60_48_0_20__6()
        {
            // arrange 
            var gcd = new GCD();
            int x = -60;
            int y = 48;
            int z = 0;
            int m = 30;
            int expected = 6;
            // act
            double result = gcd.Euclide(x, y, z, m);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_0_0_0_0__0()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = 0;
            int z = 0;
            int m = 0;
            int expected = 0;
            // act
            double result = gcd.Euclide(x, y, z, m);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_0_0_0_0_0__0()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = 0;
            int z = 0;
            int m = 0;
            int n = 0;
            int expected = 0;
            // act
            double result = gcd.Euclide(x, y, z, m, n);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_100_35_25_15_50__5()
        {
            // arrange 
            var gcd = new GCD();
            int x = 100;
            int y = 35;
            int z = 25;
            int m = 15;
            int n = 50;
            int expected = 5;
            // act
            double result = gcd.Euclide(x, y, z, m, n);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_100_0_25_75_50__25()
        {
            // arrange 
            var gcd = new GCD();
            int x = 100;
            int y = 0;
            int z = 25;
            int m = 75;
            int n = 50;
            int expected = 25;
            // act
            double result = gcd.Euclide(x, y, z, m, n);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_minus100_125_25_75_50__25()
        {
            // arrange 
            var gcd = new GCD();
            int x = -100;
            int y = 125;
            int z = 25;
            int m = 75;
            int n = 50;
            int expected = 25;
            // act
            double result = gcd.Euclide(x, y, z, m, n);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_minus100_125_25_2515_minus50__25()
        {
            // arrange 
            var gcd = new GCD();
            int x = -100;
            int y = 125;
            int z = 25;
            int m = 2525;
            int n = -50;
            int expected = 25;
            // act
            double result = gcd.Euclide(x, y, z, m, n);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_500_150_t__50()
        {
            // arrange 
            var gcd = new GCD();
            int x = 500;
            int y = 150;
            double t;
            int expected = 50;
            // act
            double result = gcd.Euclide(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_33_0_t__33()
        {
            // arrange 
            var gcd = new GCD();
            int x = 33;
            int y = 0;
            double t;
            int expected = 33;
            // act
            double result = gcd.Euclide(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestEuclide_0_0_t__0()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = 0;
            double t;
            int expected = 0;
            // act
            double result = gcd.Euclide(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestStein_0_0__0()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = 0;
            double t;
            int expected = 0;
            // act
            double result = gcd.Stein(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestStein_27_18__9()
        {
            // arrange 
            var gcd = new GCD();
            int x = 27;
            int y = 18;
            double t;
            int expected = 9;
            // act
            double result = gcd.Stein(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestStein_25_0__25()
        {
            // arrange 
            var gcd = new GCD();
            int x = 25;
            int y = 0;
            double t;
            int expected = 25;
            // act
            double result = gcd.Stein(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestStein_0_39__39()
        {
            // arrange 
            var gcd = new GCD();
            int x = 0;
            int y = 39;
            double t;
            int expected = 39;
            // act
            double result = gcd.Stein(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestStein_minus6_39__3()
        {
            // arrange 
            var gcd = new GCD();
            int x = -6;
            int y = 39;
            double t;
            int expected = 3;
            // act
            double result = gcd.Stein(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestStein_64_48__16()
        {
            // arrange 
            var gcd = new GCD();
            int x = 64;
            int y = 48;
            double t;
            int expected = 16;
            // act
            double result = gcd.Stein(x, y, out t);
            // assert            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTimesForGrafics_first_Not0()
        {
            // arrange 
            var gcd = new GCD();
            int x = 39;
            int y = 18;
            int expected = 0;
            // act
            double[] result = gcd.TimesForGrafics(x, y);
            // assert            
            Assert.IsTrue(result[0] > expected);
        }
        [TestMethod]
        public void TestTimesForGrafics_second_Not0()
        {
            // arrange 
            var gcd = new GCD();
            int x = 39;
            int y = 18;
            int expected = 0;
            // act
            double[] result = gcd.TimesForGrafics(x, y);
            // assert            
            Assert.IsTrue(result[1] > expected);
        }
    }
}
