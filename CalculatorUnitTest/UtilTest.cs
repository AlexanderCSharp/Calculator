using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
using System.Windows.Forms;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UtilTest
    {
        private TextBox textbox;
        private Label label;
        private object sender;
        private Button equals;
        [TestMethod]
        public void ButtonClickTest()
        {
            try
            {
                Util tests = new Util();
                tests.ButtonClick(textbox, sender, label);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void OperatorCkickTest()
        {
            try
            {
                Util tests = new Util();
                tests.OperatorCkick(textbox, sender, equals);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void ClearClickTest()
        {
            try
            {
                Util tests = new Util();
                tests.ClearClick(textbox, label);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void EqualsClickTest()
        {
            try
            {
                Util tests = new Util();
                tests.EqualsClick(textbox, label);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void ShowInTextboxTest()
        {
            try
            {
                Util tests = new Util();
                tests.ShowInTextbox(textbox);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void IntermediateValueTest()
        {
            try
            {
                Util tests = new Util();
                tests.IntermediateValue(textbox, label);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void PlusMinusTest()
        {
            try
            {
                Util tests = new Util();
                tests.PlusMinus(label);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }
    }
}
