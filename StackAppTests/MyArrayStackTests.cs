using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackApp;

namespace StackAppTests
{
    [TestClass]
    public class MyArrayStackTests
    {
        [TestMethod]
        public void Push_FirstItem_ShouldAddOneItem()
        {
            // Arrange
            var myArrayStack = new MyArrayStack<int>();

            // Act
            myArrayStack.Push(3);

            // Assert
            Assert.AreEqual(1, myArrayStack.Count);
        }

        [TestMethod]
        public void Push_TwoItems_ShouldAddTwoitems()
        {
            // Arrange
            var myArrayStack = new MyArrayStack<int>();

            // Act
            myArrayStack.Push(1);
            myArrayStack.Push(2);

            // Assert
            Assert.AreEqual(2, myArrayStack.Count);
        }

        [TestMethod]
        public void Push_FiveItems_ShouldAddFiveItems()
        {
            // Arrange
            var myArrayStack = new MyArrayStack<int>();

            // Act
            myArrayStack.Push(1);
            myArrayStack.Push(2);
            myArrayStack.Push(3);
            myArrayStack.Push(4);
            myArrayStack.Push(5);

            // Assert
            Assert.AreEqual(5, myArrayStack.Count);
        }

        [TestMethod]
        public void Pop_OneItem_ShouldReturnLastAddedItem()
        {
            // Arrange
            var myArrayStack = new MyArrayStack<int>();
            myArrayStack.Push(1);
            myArrayStack.Push(2);
            myArrayStack.Push(3);
            myArrayStack.Push(4);
            myArrayStack.Push(5);

            // Act
            var item = myArrayStack.Pop();

            // Assert
            Assert.AreEqual(5, item);
        }

        [TestMethod]
        public void Pop_TwoItem_ShouldDecrementStackCountbyTwo()
        {
            // Arrange
            var myArrayStack = new MyArrayStack<int>();
            myArrayStack.Push(1);
            myArrayStack.Push(2);
            myArrayStack.Push(3);
            myArrayStack.Push(4);
            myArrayStack.Push(5);

            // Act
            myArrayStack.Pop();
            myArrayStack.Pop();

            // Assert
            Assert.AreEqual(3, myArrayStack.Count);
        }

        [TestMethod]
        public void Peek_ShouldNotChangeStackCount()
        {
            // Arrange
            var myArrayStack = new MyArrayStack<int>();
            myArrayStack.Push(1);
            myArrayStack.Push(2);
            myArrayStack.Push(3);
            myArrayStack.Push(4);
            myArrayStack.Push(5);
            var expectedCount = myArrayStack.Count;

            // Act
            myArrayStack.Peek();
            myArrayStack.Peek();

            // Assert
            Assert.AreEqual(expectedCount, myArrayStack.Count);
        }

        [TestMethod]
        public void Peek_ShouldReturnLastAddedItem()
        {
            // Arrange
            var myArrayStack = new MyArrayStack<int>();
            var expected = 0;
            myArrayStack.Push(++expected);
            myArrayStack.Push(++expected);
            myArrayStack.Push(++expected);
            myArrayStack.Push(++expected);
            myArrayStack.Push(++expected);

            // Act
            var actual = myArrayStack.Peek();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
