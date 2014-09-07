using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace KataPotter
{
    [TestClass]
    public class KataPotterTest
    {

        public int[] books;

        [TestMethod]
        public void HowMuchForOBook()
        {
            books = new int[] { };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(price, 0);
        }

        [TestMethod]
        public void HowMuchFor1Book()
        {
            books = new int[] { 1 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(price, 8);
        }

        [TestMethod]
        public void HowMuchFor2CopiesOfTheSameCollection()
        {
            books = new int[] { 0, 0 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(price, 16);
        }


        [TestMethod]
        public void HowMuchFor3CopiesOfTheSameCollection()
        {
            books = new int[] { 0, 0, 0 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(price, 24);
        }

        [TestMethod]
        public void HowMuchFor4CopiesOfTheSameCollection()
        {
            books = new int[] { 0, 0, 0, 0 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(price, 32);
        }

        [TestMethod]
        public void HowMuchFor5CopiesOfTheSameCollection()
        {
            books = new int[] { 0, 0, 0, 0, 0 };

            var price = KataPotter.getPrices(books);
            Assert.AreEqual(price, 40);
        }

        [TestMethod]
        public void HowMuchForTwoCollection()
        {
            books = new int[] { 0, 1 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(price, 15.2);
        }

        [TestMethod]
        public void HowMuchForThreeCollection()
        {
            books = new int[] { 0, 1, 2 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(price, 21.6);
        }

        [TestMethod]
        public void HowMuchForTwoCollectionAndForMultipleCopies()
        {
            books = new int[] { 0, 0, 1 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(23.2, price);
        }

        [TestMethod]
        public void HowMuchForTwoCollectionAndForTwoCopies()
        {
            books = new int[] { 0, 0, 1, 1 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(31.2, price);
        }

        [TestMethod]
        public void HowMuchForThreeCollectionAndForTwoCopies()
        {
            books = new int[] { 0, 0, 1, 1, 2, 2 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(45.6, price);
        }

        [TestMethod]
        public void HowMuchForFourCollectionAndMultipleCopies()
        {
            books = new int[] { 0, 0, 1, 1, 2, 2, 3 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(49.6, price);
        }

        [TestMethod]
        public void HowMuchForFiveCollectionAndForMultipleCopies()
        {
            books = new int[] { 0, 0, 1, 1, 2, 2, 3, 4 };
            var price = KataPotter.getPrices(books);
            Assert.AreEqual(51.2, price);
        }

    }
}
