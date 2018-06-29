using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {

        [TestMethod]
        public void CheckSpecialCharacters_CheckIfTrue_True()
        {
            RepeatCounter repeat = new RepeatCounter();
            Assert.AreEqual(false, repeat.CheckSpecialCharacters("word is a good word"));
        }

        [TestMethod]
        public void RemoveSpecialCharacters_EnsureRemoved()
        {
            RepeatCounter repeat = new RepeatCounter();
            Assert.AreEqual("word is great how", repeat.RemoveSpecialCharacters("word is!! great&& how!@"));
        }

        [TestMethod]
        public void RemoveWhiteSpace_EnsureRemoved()
        {
            RepeatCounter repeat = new RepeatCounter();
            Assert.AreEqual("word123", repeat.RemoveWhiteSpace("word   123"));
        }

        [TestMethod]
        public void SplitPhrase_MakeStringArray_ReturnsArray()
        {
            RepeatCounter repeat = new RepeatCounter();
            Assert.AreEqual("this", repeat.SplitPhrase("this is a great word phrase")[0]);
        }
    }
}
