using System;
using System.Collections.Generic;
using ListIterator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListIteratorTests
{
    [TestClass]
    public class ListIteratorTest
    {
        private Iterator listIterator;

        [TestInitialize]
        public void Init()
        {
            listIterator = new Iterator();
        }

        [TestMethod]
        public void ConstructorShouldInitializeCollectionWithGivenNonEmptyCollection()
        {
            List<string> expectedCollection = new List<string>() {"Pesho", "Gosho"};
            this.listIterator = new Iterator(expectedCollection);
            CollectionAssert.AreEqual(expectedCollection, this.listIterator.Collection, "Collections are not equal!");
        }

        [TestMethod]
        public void ConstructorShouldInitializeCollectionWithGivenEmptyCollection()
        {
            List<string> expectedCollection = new List<string>();
            this.listIterator = new Iterator(expectedCollection);
            Assert.AreEqual(0,this.listIterator.Collection.Count,"Collection is not empty.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CosnstructorShouldThrowWithNullCollection()
        {
            List<string> expectedCollection = null;
            this.listIterator = new Iterator(expectedCollection);
        }

        [TestMethod]
        public void OneMoveWithTwoElementsShouldReturnTrue()
        {
            List<string> expectedCollection = new List<string>() {"Pesho", "Gosho"};
            this.listIterator = new Iterator(expectedCollection);
            bool hasMoved = listIterator.Move();
            Assert.IsTrue(hasMoved);
        }

        [TestMethod]
        public void TwoMoveWithTwoElementsShouldReturnFalse()
        {
            List<string> expectedCollection = new List<string>() {"Pesho", "Gosho"};
            this.listIterator = new Iterator(expectedCollection);
            this.listIterator.Move();
            bool hasMoved = this.listIterator.Move();
            Assert.IsFalse(hasMoved);
        }

        [TestMethod]
        public void OneMoveShouldMoveInternalIndexByOne()
        {
            List<string> expectedCollection = new List<string>() {"Pesho", "Gosho"};
            this.listIterator = new Iterator(expectedCollection);
            var startIndex = this.listIterator.CurrentIndex;
            this.listIterator.Move();
            var nextIndex = this.listIterator.CurrentIndex;
            Assert.AreEqual(nextIndex, startIndex + 1,"Move doesn't move internal index!");
        }

        [TestMethod]
        public void HasNextWithNoMoveOnCollectionWithTwoElementsSHouldReturnTrue()
        {
            List<string> expectedCollection = new List<string>() { "Pesho", "Gosho" };
            this.listIterator = new Iterator(expectedCollection);
            bool hasNext = this.listIterator.HasNext();
            Assert.IsTrue(hasNext);
        }

        [TestMethod]
        public void HasNextWithOneMoveOnCollectionWithTwoElementsSHouldReturnFalse()
        {
            List<string> expectedCollection = new List<string>() { "Pesho", "Gosho" };
            this.listIterator = new Iterator(expectedCollection);
            this.listIterator.Move();
            bool hasNext = this.listIterator.HasNext();
            Assert.IsFalse(hasNext);
        }

        [TestMethod]
        public void PrintWithNoMoveShouldReturnZerothElement()
        {
            List<string> expectedCollection = new List<string>() { "Pesho", "Gosho" };
            this.listIterator = new Iterator(expectedCollection);
            string element = this.listIterator.Print();
            Assert.AreEqual(expectedCollection[0],element,"Print does not return the correct elemnt.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PrintShoulThrowWithEmptyCollection()
        {
            List<string> expectedCollection = new List<string>();
            this.listIterator = new Iterator(expectedCollection);
            this.listIterator.Print();
        }
    }
}
