<?php

namespace McrDigital\PhpFundamentals2\Checkout;

class Checkout
{
    private int $total;
    private int $numberOfA;
    private int $numberOfB;
    private Receipt $receipt;

    public function __construct()
    {
        $this->total = 0;
        $this->numberOfA = 0;
        $this->numberOfB = 0;
        $this->receipt = new Receipt();
    }

    public function scan(string $sku): void
    {
        if ('A' === $sku) {
            $this->total += 50;
            if (++$this->numberOfA % 3 === 0) {
                $this->total -= 20;
            }
            $this->receipt->scannedA();
        } else if ('B' === $sku) {
            $this->total += 30;
            if (++$this->numberOfB % 2 === 0) {
                $this->total -= 15;
            }
            $this->receipt->scannedB();
        } else if ('C' === $sku) {
            $this->total += 20;
            $this->receipt->scannedC();
        } else if ('D' == $sku) {
            $this->total += 15;
            $this->receipt->scannedD();
        }
    }

    public function getTotal(): int
    {
        return $this->total;
    }

    public function getReceipt(): string
    {
        return $this->receipt->getText();
    }

}