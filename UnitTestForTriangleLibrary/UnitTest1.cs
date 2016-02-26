using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary;

namespace UnitTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TestCreateTriangleWithNegativeParametr() {
            double a = -13;
            double b = 12;
            double c = 5;
            Triangle triangle = Triangle.createTriangle(a, b, c);
            double square = triangle.getSquare();
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TestCreateTriangleWithOneZeroParametr() {
            double a = 13;
            double b = 12;
            double c = 0;
            Triangle triangle = Triangle.createTriangle(a, b, c);
            double square = triangle.getSquare();
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TestCreateTriangleWithZeroParametres() {
            Triangle triangle = Triangle.createTriangle(0, 0, 0);
            double square = triangle.getSquare();
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TestCreateNonTriangle() {
            double a = 13;
            double b = 12;
            double c = 122;
            Triangle triangle = Triangle.createTriangle(a, b, c);
            double square = triangle.getSquare();
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TestCalculateSquareNotRightTriangle() {
            double a = 13;
            double b = 12;
            double c = 15;
            Triangle triangle = Triangle.createTriangle(a, b, c);
            double square = triangle.getSquare();
        }

        [TestMethod]
        public void TestCalculateSquareRightTriangle() {
            double a = 13.0;
            double b = 12.0;
            double c = 5.0;
            double expectedSquare = 30.0;
            Triangle triangle = Triangle.createTriangle(a, b, c);
            double square = triangle.getSquare();
            Assert.AreEqual(square, expectedSquare);
        }
        [TestMethod]
        public void TestCalculateSquareWithFloatParametres() {
            float a = 13f;
            float b = 12f;
            float c = 5f;
            double expectedSquare = 30;
            Triangle triangle = Triangle.createTriangle(a, b, c);
            double square = triangle.getSquare();
            Assert.AreEqual(square, expectedSquare);
        }
        [TestMethod]
        public void TestForInitializeSidesOfTriangle() {
            double a = 5;
            double b = 12;
            double c = 13;
            double hypotenuse = 13;
            double leg1 = 5;
            double leg2 = 12;
            Triangle triangle = Triangle.createTriangle(a, b, c);
            double _hypotenuse;
            double _leg1;
            double _leg2;
            // надо модификатор доступа в библиотеке поменять чтоб работало!!!
            //triangle.initSides(a, b, c, out _hypotenuse, out _leg1, out _leg2);
            //Assert.AreEqual(hypotenuse, _hypotenuse);
            //Assert.AreEqual(leg1, _leg1);
            //Assert.AreEqual(leg2, _leg2);
        }
    }
}
