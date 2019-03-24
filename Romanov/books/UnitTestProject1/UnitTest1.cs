﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCatalog2;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Compare_Should_Return_false()
        {
            Catalog catalog = new Catalog() { };
            catalog.Add(new Book() { Id = 1, Title = "One" });
            catalog.Add(new Book() { Id = 2, Title = "two" });
            bool b = false;
            Assert.AreEqual(b, catalog.Compare(0, 1));
        }
        [TestMethod]
        public void Get_shouldBe_return_smth()
        {
            Catalog catalog = new Catalog() { };
            catalog.Add(new Book() { Id = 1, Title = "One" });
            catalog.Add(new Book() { Id = 2, Title = "two" });
            var indexForGet = 0;
            Assert.IsNotNull(catalog.GetT(indexForGet));
        }
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            var mock = new Mock<Catalog>();
            var act = mock.Object;
            // Act
            act.Add(new Book());
            act.Add(new Book());
            // Assert
            Assert.AreEqual(2, act.Books.Count);
        }
        [TestMethod]
        public void TestDel()
        {
            // Arrange
            var mock = new Mock<Catalog>();
            var act = mock.Object;
            act.Add(new Book());
            act.Add(new Book());
            // Act
            act.Del(0);
            // Assert
            Assert.AreEqual(1,act.Books.Count);
        }
        [TestMethod]
        public void TestGEt()
        {
            // Arrange
            var mock = new Mock<Catalog>();
            var act = mock.Object;
            var testBook = new Book() { Id = 1, Title = "test" };
            act.Add(new Book());
            act.Add(new Book());
            act.Add(new Book());
            // Act
            var t = act.GetT(0);
            // Assert
            Assert.IsNotNull(t);
        }
        
    }
}
