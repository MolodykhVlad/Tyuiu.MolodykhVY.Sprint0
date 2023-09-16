using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MolodykhVY.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolodykhVY.Sprint0.Task2.V0.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMassageValid()
        {

            // Область создания методов тестирования, методов из библиотеки
            var name = "Влад";
            var res = DataService.GetMassage(name);

            // вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет...., Влад", res);




        }
    }
}
