using Pr33_delegates_bonusapp;

namespace Pr33_delegates_unittest
{
    [TestClass]
    public class UnitTest1
    {
        Order order;

        [TestInitialize]
        public void Init()
        {
            order = new Order();
            order.AddProduct(new Product { Name = "Mælk", Value = 10.0 });
            order.AddProduct(new Product { Name = "Smør", Value = 15.0 });
            order.AddProduct(new Product { Name = "Pålæg", Value = 20.0 });
        }
        [TestMethod]
        public void TenPercent_Test()
        {
            Assert.AreEqual(4.5, Bonuses.TenPercent(45.0));
            Assert.AreEqual(40.0, Bonuses.TenPercent(400.0));
        }
        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(2.0, Bonuses.FlatTwoIfAmountMoreThanFive(10.0));
            Assert.AreEqual(0.0, Bonuses.FlatTwoIfAmountMoreThanFive(4.0));
        }
        [TestMethod]
        public void GetValueOfProducts_Test()
        {
            Assert.AreEqual(45.0, order.GetValueOfProducts());
        }
        [TestMethod]
        public void GetBonus_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, order.GetBonus());
        }
        [TestMethod]
        public void GetTotalPrice_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(40.5, order.GetTotalPrice());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(43.0, order.GetTotalPrice());
        }

        [TestMethod]
        public void GetBonusAnonymous_Test()
        {
            order.Bonus = amount => amount / 10;   // oops i did lambda expressions
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = amount => amount > 5 ? 2 : 0;
            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]
        public void GetBonusLambda_Test()
        {
            order.Bonus = amount => amount / 10;   
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = amount => amount > 5 ? 2 : 0;
            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]
        public void GetBonusByLambdaParameter_Test()
        {
            // Use TenPercent lambda expresssion as parameter to GetBonus
            Assert.AreEqual(4.5, order.GetBonus(amount => amount / 10));   // this shit kinda cool no?

            // Use FlatTwoIfAmountMoreThanFive lambda expresssion as parameter to GetBonus
            Assert.AreEqual(2.0, order.GetBonus(amount => amount > 5 ? 2 : 0));
        }

        [TestMethod]
        public void GetTotalPriceByLambdaParameter_Test()
        {
            Assert.AreEqual(40.5, order.GetTotalPrice(amount => amount / 10));

            Assert.AreEqual(43.0, order.GetTotalPrice(amount => amount > 5 ? 2 : 0));
        }

    }

}