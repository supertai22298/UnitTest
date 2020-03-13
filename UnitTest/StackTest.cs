using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    class StackTest
    {
        private Stack _stack;

        [SetUp]
        public void Setup()
        {
            _stack = new Stack();
        }

        [Test]
        public void PushTest()
        {
            bool expected = _stack.Push("item");
            bool actual = true;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PopTest()
        {
            _stack.Push("item");
            string expected = _stack.Pop();
            string actual = "item";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsEmptyTest()
        {

            bool expected = _stack.IsEmpty();
            bool actual = true;
            Assert.IsTrue(expected == actual);
        }
        [Test]
        public void PeekTest()
        {

            string expected = _stack.Peek();
            string actual = null;
            Assert.AreEqual(expected, actual);
        }
    }
}
