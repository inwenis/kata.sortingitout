﻿using NUnit.Framework;

namespace kata.sortingitout.Tests
{
    [TestFixture]
    public class RackTests
    {
        [Test]
        public static void Add_SingleBall_SavesBall()
        {
            // arrange
            var sut = new Rack();

            // act
            sut.Add(12);

            // assert
            CollectionAssert.AreEqual(new []{12}, sut.Balls);
        }

        [Test]
        public static void Add_TwoBalls_SavesBalls()
        {
            // arrange
            var sut = new Rack();

            // act
            sut.Add(12);
            sut.Add(22);

            // assert
            CollectionAssert.AreEqual(new []{12, 22}, sut.Balls);
        }

        [Test]
        public static void Add_BallOutOfOrder_SavesBallsInAscendingOrder()
        {
            // arrange
            var sut = new Rack();

            // act
            sut.Add(12);
            sut.Add(5);

            // assert
            CollectionAssert.AreEqual(new []{5, 12}, sut.Balls);
        }

        [Test]
        public static void Add_BallShouldGoInMiddle_SavesBallsInAscendingOrder()
        {
            // arrange
            var sut = new Rack();
            sut.Add(12);
            sut.Add(20);

            // act
            sut.Add(15);

            // assert
            CollectionAssert.AreEqual(new []{12, 15, 20}, sut.Balls);
        }

    }
}
