using NUnit.Framework;
using PlingPlangPlongFactor;

namespace PlingPlangPlongTest
{
    public class Tests
    {
        PlingPlangPlong ppp = new PlingPlangPlong();

        [TestCase(3, "Pling")]
        [TestCase(12, "Pling")]
        [TestCase(9, "Pling")]
        [TestCase(-9, "Pling")]
        public void NumberFactorOf3(int number, string expected)
        {
            Assert.AreEqual(expected, ppp.PPPFactor(number));
        }

        [TestCase(5, "Plang")]
        [TestCase(25, "Plang")]
        [TestCase(-25, "Plang")]
        [TestCase(-55, "Plang")]
        public void NumberFactorOf5(int number, string expected)
        {
            Assert.AreEqual(expected, ppp.PPPFactor(number));
        }

        [TestCase(7, "Plong")]
        [TestCase(14, "Plong")]
        [TestCase(56, "Plong")]
        [TestCase(-77, "Plong")]
        public void NumberFactorOf7(int number, string expected)
        {
            Assert.AreEqual(expected, ppp.PPPFactor(number));
        }

        [TestCase(75, "PlingPlang")]
        [TestCase(30, "PlingPlang")]
        [TestCase(-15, "PlingPlang")]
        [TestCase(-15, "PlingPlang")]
        public void NumberFactorOf_3_5(int number, string expected)
        {
            Assert.AreEqual(expected, ppp.PPPFactor(number));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(63, "PlingPlong")]
        [TestCase(-63, "PlingPlong")]
        [TestCase(-147, "PlingPlong")]
        public void NumberFactorOf_3_7(int number, string expected)
        {
            Assert.AreEqual(expected, ppp.PPPFactor(number));
        }

        [TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(-70, "PlangPlong")]
        [TestCase(-175, "PlangPlong")]
        public void NumberFactorOf_5_7(int number, string expected)
        {
            Assert.AreEqual(expected, ppp.PPPFactor(number));
        }

        [TestCase(105, "PlingPlangPlong")]
        [TestCase(210, "PlingPlangPlong")]
        [TestCase(-315, "PlingPlangPlong")]
        [TestCase(-525, "PlingPlangPlong")]
        public void NumberFactorOf_3_5_7(int number, string expected)
        {
            Assert.AreEqual(expected, ppp.PPPFactor(number));
        }

        [TestCase]
        public void NumberFactorOf0()
        {
            Assert.AreEqual("PlingPlangPlong", ppp.PPPFactor(0));
        }
    }
}