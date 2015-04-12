using System;
using NUnit.Framework;

namespace Exercise2
{
    [TestFixture]
    public class FibonacciTest
    {
        int[] sequence;

        [SetUp]
        public void SetUp()
        {
            sequence = new Fibonacci().SequenceGenerator(8);
        }

        [Test]
        public void FirstFibonacciIsZero()
        {
            Assert.That(sequence[0], Is.EqualTo(0));
        }


        [Test]
        public void SecondFibonacciIsOne()
        {
            Assert.That(sequence[1], Is.EqualTo(1));
        }

        [Test]
        public void ThirdFibonacciIsOne()
        {
            Assert.That(sequence[2], Is.EqualTo(1));
        }

    }
}

