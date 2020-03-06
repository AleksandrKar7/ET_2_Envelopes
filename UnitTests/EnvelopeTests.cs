using System;

using NUnit.Framework;
using ET_2_Envelopes;

namespace UnitTests
{
    class EnvelopeTests
    {
        [Test]
        public void DoesFits_TryPutSmallRectangularToBigRectangular_True()
        {
            //arrange
            int length = 10;
            int height = 5;
            var small = new RectangularEnvelope(length, height);
            var big = new RectangularEnvelope(length * 2, height * 2);
            bool result;

            //act
            result = big.DoesFits(small);

            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void DoesFits_TryPutBigRectangularToSmallRectangular_False()
        {
            //arrange
            int length = 10;
            int height = 5;
            var small = new RectangularEnvelope(length, height);
            var big = new RectangularEnvelope(length * 2, height * 2);
            bool result;

            //act
            result = small.DoesFits(big);

            //assert
            Assert.IsFalse(result);
        }

        [Test]
        public void DoesFits_TryPutSmallRoundToBigRound_True()
        {
            //arrange
            int radius = 5;
            var small = new RoundEnvelope(radius);
            var big = new RoundEnvelope(radius * 2);
            bool result;

            //act
            result = big.DoesFits(small);

            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void DoesFits_TryPutBigRoundToSmallRound_False()
        {
            //arrange
            int radius = 5;
            var small = new RoundEnvelope(radius);
            var big = new RoundEnvelope(radius * 2);
            bool result;

            //act
            result = small.DoesFits(big);

            //assert
            Assert.IsFalse(result);
        }

        public void DoesFits_TryPutSmallRoundToBigRectangular_True()
        {
            //arrange
            int length = 10;
            int height = 5;

            int radius = 5;
            var small = new RoundEnvelope(radius);
            var big = new RectangularEnvelope(length, height);
            bool result;

            //act
            result = big.DoesFits(small);

            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void DoesFits_TryPutBigRoundToSmallRectangular_False()
        {
            //arrange
            int length = 10;
            int height = 5;

            int radius = 10;
            var small = new RectangularEnvelope(length, height);
            var big = new RoundEnvelope(radius);
            bool result;

            //act
            result = small.DoesFits(big);

            //assert
            Assert.IsFalse(result);
        }

        public void DoesFits_TryPutSmallRectangularToBigRound_True()
        {
            //arrange
            int length = 10;
            int height = 5;

            int radius = 5;
            var small = new RectangularEnvelope(length, height);
            var big = new RoundEnvelope(radius);
            bool result;

            //act
            result = big.DoesFits(small);

            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void DoesFits_TryPutBigRectangularToSmallRound_False()
        {
            //arrange
            int length = 10;
            int height = 5;

            int radius = 10;
            var small = new RectangularEnvelope(length, height);
            var big = new RoundEnvelope(radius);
            bool result;

            //act
            result = small.DoesFits(big);

            //assert
            Assert.IsFalse(result);
        }
    }
}
