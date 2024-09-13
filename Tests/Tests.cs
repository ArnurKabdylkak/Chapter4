using Library;


namespace Tests
{
    public class PrimeUtilsTests
    {
        [Fact]
        public void PrimeFactorsOf18()
        {
            int number = 18;
            string expected = "3 x 3 x 2";

            string actual = PrimeUtils.GetPrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf56()
        {
            int number = 56;
            string expected = "7 x 2 x 2 x 2";

            string actual = PrimeUtils.GetPrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf84()
        {
            int number = 84;
            string expected = "7 x 3 x 2 x 2";

            string actual = PrimeUtils.GetPrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf101()
        {
            int number = 101;
            string expected = "101";

            string actual = PrimeUtils.GetPrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf144()
        {
            int number = 144;
            string expected = "2 x 2 x 2 x 2 x 3 x 3";

            string actual = PrimeUtils.GetPrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf1501()
        {
            int number = 1501;
            string expected = "Number must be between 1 and 1000.";

            string actual = PrimeUtils.GetPrimeFactors(number);

            Assert.Equal(expected, actual);
        }
    }
}
