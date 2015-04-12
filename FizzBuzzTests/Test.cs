using NUnit.Framework;
using FizzBuzz;
using System;

namespace FizzBuzzTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void FirstFizzBuzzIsOne()
        {
            Assert.That(GenerateFizzBuzzResults()[0], Is.EqualTo("1"));
        }

        [Test()]
        public void SecondFizzBuzzIsTwo()
        {
            Assert.That(GenerateFizzBuzzResults()[1], Is.EqualTo("2"));
        }

        [Test()]
        public void ThirdFizzBuzzIsFizz()
        {
            Assert.That(GenerateFizzBuzzResults()[2], Is.EqualTo("Fizz"));
        }

        [Test()]
        public void FifthFizzBuzzIsBuzz()
        {
            Assert.That(GenerateFizzBuzzResults()[4], Is.EqualTo("Buzz"));
        }

        public string[] GenerateFizzBuzzResults()
        {
            string sequence = FizzBuzz.FizzBuzz.Generate();
            string[] splitSequence = sequence.Split(',');
            return splitSequence;
        }
    }
}

