using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void WhenADealerHasAdvertsWithOnePromotionProduct_ReturnsTotalCost()
        {
            //arrange
            var customer = new Customer();
            int numberOfAdverts = 20;
            int numberOfProducts = 1;
            int expectedBill = 1200;
            string dealer = "dealer";

            //act
            var getBill = Customer.GetBill(numberOfAdverts, numberOfProducts, dealer);

            //assert
            Assert.Equal(expectedBill, getBill);
        }

        [Fact]
        public void WhenADealerHasAdvertsWithTwoFinanceAndValuationProducts_ReturnsTotalCost()
        {
            //arrange
            var customer = new Customer();
            int numberOfAdverts = 1000;
            int numberOfProducts = 2;
            int expectedBill = 70000;
            string dealer = "dealer";

            //act
            var getBill = Customer.GetBill(numberOfAdverts, numberOfProducts, dealer);

            //assert
            Assert.Equal(expectedBill, getBill);
        }

        [Fact]
        public void WhenAPrivateSellerHasAdvertsWithNoProducts_ReturnsTotalCost()
        {
            //arrange
            var customer = new Customer();
            int numberOfAdverts = 3;
            int numberOfProducts = 0;
            int expectedBill = 60;
            string privateSeller = "privateSeller";

            //act
            var getBill = Customer.GetBill(numberOfAdverts, numberOfProducts, privateSeller);

            //assert
            Assert.Equal(expectedBill, getBill);
        }

        [Fact]
        public void WhenAPrivateSellerHasAdvertsWithOneImagesProduct_ReturnsTotalCost()
        {
            //arrange
            var customer = new Customer();
            int numberOfAdverts = 1;
            int numberOfProducts = 1;
            int expectedBill = 30;
            string privateSeller = "privateSeller";

            //act
            var getBill = Customer.GetBill(numberOfAdverts, numberOfProducts, privateSeller);

            //assert
            Assert.Equal(expectedBill, getBill);
        }
    }
}
