using FizzBuzzTDD101;
using NUnit.Framework;

namespace FizzBuzzerTests
{
    public class FizzBuzzerTests
    {
        [Test]
        public void FizzBuzzer_printsOne()
        {
            var fizzBuzzer = new FizzBuzzer();
            int result = fizzBuzzer.Print();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void NextPrint_returns2()
        {
            var fizzBuzzer = new FizzBuzzer();
            int result = fizzBuzzer.Print();

            result = fizzBuzzer.NextPrint(result);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void NextPrint_returns3()
        {
            var fizzBuzzer = new FizzBuzzer();
            int result = fizzBuzzer.Print();

            result = fizzBuzzer.NextPrint(2);


            Assert.AreEqual(3, result);
        }

        [Test]
        public void NextPrint_returns4()
        {
            var fizzBuzzer = new FizzBuzzer();
            int result = fizzBuzzer.Print();

            result = fizzBuzzer.NextPrint(3);

            Assert.AreEqual(4, result);
        }
        [Test]
        public void NextPrint_returns6()
        {
            var fizzBuzzer = new FizzBuzzer();
            int result = fizzBuzzer.Print();

            result = fizzBuzzer.NextPrint(5);

            Assert.AreEqual(6, result);
        }

    }
}
