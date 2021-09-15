using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PromotionEngineChallange.Models;
using PromotionEngineChallange.Promotions;

namespace PromotionEngineChallange.Test
{
    [TestClass]
    public class PromotionEngionTest
    {

        List<SkuOrder> SkuOrder = new List<SkuOrder>() {
            new SkuOrder("A"){ Quantity=3 },
            new SkuOrder("B"){ Quantity=5 },
            new SkuOrder("C"){ Quantity=1 },
            new SkuOrder("D"){ Quantity=1 },
        };

        List<SkuOrder> expectedSkuOrder = new List<SkuOrder>() {
            new SkuOrder("A"){ Price=130,Quantity=3 },
            new SkuOrder("B"){ Price=120,Quantity=5 },
            new SkuOrder("C"){ Price=0,Quantity=1},
            new SkuOrder("D"){ Price=30,Quantity=1 },
        };


        [TestMethod]
        public void Promotion1()
        {
            var promotion1 = new Promotion1();
            var result = promotion1.GetPrice(SkuOrder);
            Assert.AreEqual(expectedSkuOrder[0].Price, result[0].Price);
        }

        [TestMethod]
        public void Promotion2()
        {
            var promotion2 = new Promotion2();
            var result = promotion2.GetPrice(SkuOrder);
            Assert.AreEqual(expectedSkuOrder[1].Price, result[1].Price);
        }

        [TestMethod]
        public void Promotion3()
        {
            var promotion3 = new Promotion3();
            var result = promotion3.GetPrice(SkuOrder);
            Assert.AreEqual(expectedSkuOrder[2].Price, result[2].Price);
            Assert.AreEqual(expectedSkuOrder[3].Price, result[3].Price);

        }
    }
}
