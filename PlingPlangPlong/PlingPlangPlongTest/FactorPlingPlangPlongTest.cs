using NUnit.Framework;
using PlingPlangPlongFactor;

namespace PlingPlangPlongTest
{
    public class FactorPlingPlangPlongTests
    {
        private Raindrops _sut = new Raindrops();

        [TestCase(3, "Pling")]
        [TestCase(12, "Pling")]
        [TestCase(9, "Pling")]
        [TestCase(-9, "Pling")]
        public void Given_A_Value_With_Factor_Of_3_Return_Pling(int number, string expected)
        {
            Assert.AreEqual(expected, _sut.PPPFactor(number));
        }

        [TestCase(5, "Plang")]
        [TestCase(25, "Plang")]
        [TestCase(-25, "Plang")]
        [TestCase(-55, "Plang")]
        public void Given_A_Value_With_Factor_Of_5_Return_Plang(int number, string expected)
        {
            Assert.AreEqual(expected, _sut.PPPFactor(number));
        }

        [TestCase(7, "Plong")]
        [TestCase(28, "Plong")]
        [TestCase(56, "Plong")]
        [TestCase(-77, "Plong")]
        public void Given_A_Value_With_Factor_Of_7_Return_Plong(int number, string expected)
        {
            Assert.AreEqual(expected, _sut.PPPFactor(number));
        }

        [TestCase(75, "PlingPlang")]
        [TestCase(30, "PlingPlang")]
        [TestCase(-15, "PlingPlang")]
        [TestCase(-15, "PlingPlang")]
        public void Given_A_Value_With_Factor_Of_3_AND_5_Return_PlingPlang(int number, string expected)
        {
            Assert.AreEqual(expected, _sut.PPPFactor(number));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(63, "PlingPlong")]
        [TestCase(-63, "PlingPlong")]
        [TestCase(-147, "PlingPlong")]
        public void Given_A_Value_With_Factor_Of_3_AND_7_Return_PlingPlong(int number, string expected)
        {
            Assert.AreEqual(expected, _sut.PPPFactor(number));
        }

        [TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(-70, "PlangPlong")]
        [TestCase(-175, "PlangPlong")]
        public void Given_A_Value_With_Factor_Of_5_AND_7_Return_PlangPlong(int number, string expected)//Given_A_Value_With_Factor_Of_5_OR_7_Return_PlingPlangPlong
        {
            Assert.AreEqual(expected, _sut.PPPFactor(number));
        }

        [TestCase(105, "PlingPlangPlong")]
        [TestCase(210, "PlingPlangPlong")]
        [TestCase(-315, "PlingPlangPlong")]
        [TestCase(-525, "PlingPlangPlong")]
        public void Given_A_Value_With_Factor_Of_3_AND_5_AND_7_Return_PlingPlangPlong(int number, string expected)
        {
            Assert.AreEqual(expected, _sut.PPPFactor(number));
        }

        [TestCase(34, "34")]
        [TestCase(152, "152")]
        [TestCase(-152, "-152")]
        [TestCase(-34, "-34")]
        public void Given_A_Value_Which_Is_NOT_Factor_Of_3_AND_5_AND_7_Return_Given_Value(int number, string expected)
        {
            Assert.AreEqual(expected, _sut.PPPFactor(number));
        }

        [TestCase]
        public void Given_A_Value_With_Factor_Of_0_Return_PlingPlangPlong()
        {
            Assert.AreEqual("PlingPlangPlong", _sut.PPPFactor(0));
        }

    }
}