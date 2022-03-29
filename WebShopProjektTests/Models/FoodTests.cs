using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShopProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopProjekt.Models.Tests
{
    [TestClass()]
    public class FoodTests
    {
        [TestMethod()]
        public void FoodConstructorTest()
        {

            string expectedName = "tej";
            int expectedUnitPrice = 459;
            double expectedVat = 0.055;
            string expectedMeasure = "liter";
            double expectedQuantity = 4;
            
            Food food = new Food(expectedName, expectedUnitPrice, expectedVat, expectedMeasure, expectedQuantity);

            string actualName = food.Name;
            int actualUnitPrice = food.UnitPrice;
            double actualVat = food.VAT;
            string actaulMeasure = food.Measure;
            double actaulQuantity = food.Quantity;

            string expectedToString = "Árú neve: tej, árú egységára:459, ÁFA:5,5%";
            string actaulToString = food.ToString();
            
            int compare = expectedToString.CompareTo(actaulToString);
            Assert.AreEqual(0, compare, "A ToString metódus kimenete nem megfelelő!");

            string expectedItem = "4liter tej -> 1936,96 Ft";
            string actaulItem = food.Item;
            compare = expectedItem.CompareTo(actaulItem);
            Assert.AreEqual(0, compare, "Az Item tulajdonság értéke nem megfelelő!");

            Assert.AreEqual(expectedName, actualName, "Az árú nevét nem állította be!");
            Assert.AreEqual(expectedUnitPrice,actualUnitPrice, "Az árú egységárát nem állította be!");
            Assert.AreEqual(expectedVat, actualVat, "Az árú ÁFÁ-ját nem állította be!");
            Assert.AreEqual(expectedMeasure, actaulMeasure, "Az árú egységét nem állította be!");
            Assert.AreEqual(expectedQuantity, actaulQuantity, "Az árú mennyiségét nem állította be!");

            double actualGrossPrice = 484.24;
            double expectedGrossPrice = food.GrossPrice;
            Assert.AreEqual(expectedGrossPrice, actualGrossPrice, "A két tizedes jegyre kerekített bruttó árat nem jól határozta meg");

            double actaulAmountToPaid = 1936.96;
            double expectedAmountToPaid = food.AmountToPaid;
            Assert.AreEqual(expectedAmountToPaid, actaulAmountToPaid, "A két tizedes jegyre kerekített fizetendő árat nem jól határozta meg");

            Food emptyFood = new Food();
            expectedName = string.Empty;
            expectedUnitPrice = 0;
            expectedVat = 0.0;
            expectedMeasure = string.Empty;
            expectedQuantity = 0.0;

            actualName = emptyFood.Name;
            actualUnitPrice = emptyFood.UnitPrice;
            actualVat = emptyFood.VAT;
            actaulMeasure = emptyFood.Measure;
            actaulQuantity = emptyFood.Quantity;

            Assert.AreEqual(expectedName, actualName, "Az árú nevét nem állította be!");
            Assert.AreEqual(expectedUnitPrice, actualUnitPrice, "Az árú egységárát nem állította be!");
            Assert.AreEqual(expectedVat, actualVat, "Az árú ÁFÁ-ját nem állította be!");
            Assert.AreEqual(expectedMeasure, actaulMeasure, "Az árú egységét nem állította be!");
            Assert.AreEqual(expectedQuantity, actaulQuantity, "Az árú mennyiségét nem állította be!");

        }
    }
}
