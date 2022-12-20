namespace McrDigital.Bootcamp1.Checkout {
  using System;

  public class Receipt { 
      
      public const int COST_OF_A = 50;
      public const int COST_OF_B = 30;
      public const int COST_OF_C = 20;
      public const int COST_OF_D = 15;
      public const string PRODUCT_A = "A";
      public const string PRODUCT_B = "B";
      public const string PRODUCT_C = "C";
      public const string PRODUCT_D = "D";
      public const int DISCOUNT_OF_A = 30;
      public const int DISCOUNT_OF_B = 15;
      public const int DISCOUNT_OF_C = 10;
      public const int MULTIBUY_OF_A = 5;
      public const int MULTIBUY_OF_B = 2;
      public const int MULTIBUY_OF_C = 4;

      private string _text = String.Empty;
    private int _total;
    private int _numberOfA;
    private int _numberOfB;
    private int _numberOfC;

    public string Text {
      get => $"{this._text}Total: {this._total}";
    }

    public void ScannedA() {
      ScanProduct(COST_OF_A, PRODUCT_A);
      this._numberOfA++;
      ApplyDiscount(this._numberOfA, DISCOUNT_OF_A, MULTIBUY_OF_A, COST_OF_A);
      this._text = $"{this._text}\n";
    }

    public void ScannedB() {
        ScanProduct(COST_OF_B, PRODUCT_B);
        this._numberOfB++;
        ApplyDiscount(this._numberOfB, DISCOUNT_OF_B, MULTIBUY_OF_B, COST_OF_B);
            this._text = $"{this._text}\n";
    }

    public void ScannedC() {
        ScanProduct(COST_OF_C, PRODUCT_C);
        this._numberOfC++;
        ApplyDiscount(this._numberOfC, DISCOUNT_OF_C, MULTIBUY_OF_C, COST_OF_C);

            this._text = $"{this._text}\n";
    }

    public void ScannedD() {
      ScanProduct(COST_OF_D, PRODUCT_D);
      this._text = $"{this._text}\n";
    }

    private void ScanProduct(int cost, string product)
    {
        this._text = $"{this._text}{product}: {cost}";
        this._total += cost;
    }

    private void ApplyDiscount(int numberOfProducts, int discount, int multipleForDiscount, int cost)
    {
        if (numberOfProducts % multipleForDiscount == 0)
        {
            this._text = $"{this._text} - {discount} ({multipleForDiscount} for {(numberOfProducts * cost) - discount})";
            this._total -= discount;
        }
    }
  }
}