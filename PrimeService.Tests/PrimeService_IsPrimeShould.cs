using System;
using Xunit;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        public PrimeService_IsPrimeShould()
        {
           _primeService = new PrimeService(); 
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var isPrime = _primeService.IsPrime(1);
            Assert.False(isPrime, "1 should not be prime");
        }

        [Fact]
        public void ReturnExceptionGivenValueDifferentThan1Or2()
        {
            Assert.Throws<ArgumentException>(() => _primeService.IsPrime(3));
        }

        [Fact]
        public void ReturnTrueGivenValueOf2()
        {
            var isPrime = _primeService.IsPrime(2);
            Assert.True(isPrime);
        }
    }
}
