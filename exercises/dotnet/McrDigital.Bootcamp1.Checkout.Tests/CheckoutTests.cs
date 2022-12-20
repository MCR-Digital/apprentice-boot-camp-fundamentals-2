namespace McrDigital.Bootcamp1.Checkout.Tests {
  using System;
  using Xunit;
  using McrDigital.Bootcamp1.Checkout;

  public class CheckoutTests {
    [Fact]
    public void OneA() {
      var checkout = new Checkout();

      checkout.Scan("A");

      Assert.Equal(50, checkout.Total);
    }

    [Fact]
    public void TwoA() {
      var checkout = new Checkout();

      checkout.Scan("A");
      checkout.Scan("A");

      Assert.Equal(100, checkout.Total);
    }

    [Fact]
    public void FiveA() {
      var checkout = new Checkout();

      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");

      Assert.Equal(220, checkout.Total);
    }

    [Fact]
    public void TenA() {
      var checkout = new Checkout();

      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");
      checkout.Scan("A");

            Assert.Equal(440, checkout.Total);
    }
    [Fact]
    public void OneB() {
      var checkout = new Checkout();

      checkout.Scan("B");

      Assert.Equal(30, checkout.Total);
    }

    [Fact]
    public void TwoB() {
      var checkout = new Checkout();

      checkout.Scan("B");
      checkout.Scan("B");

      Assert.Equal(45, checkout.Total);
    }

    [Fact]
    public void FourB() {
      var checkout = new Checkout();

      checkout.Scan("B");
      checkout.Scan("B");
      checkout.Scan("B");
      checkout.Scan("B");

      Assert.Equal(90, checkout.Total);
    }

    [Fact]
    public void FourC()
    {
        var checkout = new Checkout();

        checkout.Scan("C");
        checkout.Scan("C");
        checkout.Scan("C");
        checkout.Scan("C");

        Assert.Equal(70, checkout.Total);
    }

        [Fact]
    public void Simple() {
      var checkout = new Checkout();

      checkout.Scan("A");
      Assert.Equal(50, checkout.Total);

      checkout.Scan("B");
      Assert.Equal(80, checkout.Total);

      checkout.Scan("C");
      Assert.Equal(100, checkout.Total);

      checkout.Scan("D");
      Assert.Equal(115, checkout.Total);
    }

    [Fact]
    public void Incremental() {
      var checkout = new Checkout();

      checkout.Scan("A");
      Assert.Equal(50, checkout.Total);
      
      checkout.Scan("B");
      Assert.Equal(80, checkout.Total);
      
      checkout.Scan("A");
      Assert.Equal(130, checkout.Total);
      
      checkout.Scan("A");
      Assert.Equal(180, checkout.Total);
      
      checkout.Scan("B");
      Assert.Equal(195, checkout.Total);
      
      checkout.Scan("C");
      Assert.Equal(215, checkout.Total);
      
      checkout.Scan("B");
      Assert.Equal(245, checkout.Total);
      
      checkout.Scan("C");
      Assert.Equal(265, checkout.Total);
      
      checkout.Scan("D");
      Assert.Equal(280, checkout.Total);
      
      checkout.Scan("D");
      Assert.Equal(295, checkout.Total);
      
      checkout.Scan("D");
      Assert.Equal(310, checkout.Total);
      
      checkout.Scan("C");
      Assert.Equal(330, checkout.Total);

      checkout.Scan("C");
      Assert.Equal(340, checkout.Total);
    }
  }
}
