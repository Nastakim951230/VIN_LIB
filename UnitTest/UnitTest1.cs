using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        //Низкие тесты
        //Проверяет корректность метода (что vin состоит из 17 правильных букв)
        [TestMethod]
        public void CheckVIN_IsTrue()
        {
            string vin = "JHMCM56557C404453";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }

        //Проверяет корректность метода (что vin состоит из 17 букв, но некоторые буквы не являются правильными)
        [TestMethod]
        public void CheckVIN_IsFalse()
        {
            string vin = "OHMCM56557C404453";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }
        //Проверяет корректность метода (что vin состоит из 17 букв, хотя введем всего лишь 16)
        [TestMethod]
        public void CheckVIN_IsFalse_16bykv()
        {
            string vin = "HMCM56557C404453";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }
        //Проверяет корректность метода (Выведет Африку)
        [TestMethod]
        public void GetVINCountry_Africa()
        {
            string vin = "JHMCM5655AAAA4453";
            string conutry = "Африка";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry,actual);
        }
        //Проверяет корректность метода (Выведет Азию)
        [TestMethod]
        public void GetVINCountry_Azia()
        {
            string vin = "JHMCM5655AKKA4453";
            string conutry = "Азия";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Европа)
        [TestMethod]
        public void GetVINCountry_Evropa()
        {
            string vin = "JHMCM5655AKTA4453";
            string conutry = "Европа";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Северная Америка)
        [TestMethod]
        public void GetVINCountry_Severnay_America()
        {
            string vin = "JHMCM5655AK1A4453";
            string conutry = "Северная Америка";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Океания)
        [TestMethod]
        public void GetVINCountry_Okeania()
        {
            string vin = "JHMCM5655AK6A4453";
            string conutry = "Океания";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Южная Америка)
        [TestMethod]
        public void GetVINCountry_South_America()
        {
            string vin = "JHMCM5655AK9A4453";
            string conutry = "Южная Америка";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry, actual);
        }

        //Проверяет корректность метода (Выдает данные)
        [TestMethod]
        public void GetVINCountry_IsNotNull()
        {
            string vin = "JHMCM5655AK9A44";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }

        //Сложные тесты
        //Проверяет какой тип данных выдаст
        [TestMethod]
        public void GetVINCountry_Type()
        {
            string vin = "JHMCM5655AK9A44";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        [TestMethod]
        //Проверяет какой тип данных выдаст
        public void GetVIN_Type()
        {
            string vin = "JHMCM5655AK9A44";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        //Проверяет корректность метода если ввести не существующию географическую зону (Выведет null)
        [TestMethod]
        public void GetVINCountry_NULL()
        {
            string vin = "JHMCM5655A00A4453";
            string conutry = "";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry, actual);
        }

        //Проверяет корректность метода, если отправить не 17 буквенный vin (Выведет null)
        [TestMethod]
        public void GetVINCountry_NULL_Not17()
        {
            string vin = "JHMCM5655A00A445";
            string conutry = "";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода, если отправить пустой vin (Выведет null)
        [TestMethod]
        public void GetVINCountry_NULL_Vin_Pysto()
        {
            string vin = "";
            string conutry = "";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(conutry, actual);
        }
    }
}
