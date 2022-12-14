<?php

namespace McrDigital\PhpFundamentals2\Checkout;

class Receipt
{
    private string $text;
    private int $numberOfA;
    private int $numberOfB;
    private int $total;

    public function __construct()
    {
        $this->text = '';
        $this->numberOfA = 3;
        $this->numberOfB = 2;
        $this->total = 0;
    }

    public function getText(): string
    {
        return $this->text . "Total: " . $this->total;
    }

    public function scannedA(): void
    {
        $this->text .= 'A: 50';
        if (++$this->numberOfA % 3 === 0) {
            $this->text .= ' - 20 (3 for 130)';
            $this->total += 30;
        } else {
            $this->total += 50;
        }
        $this->text .= "\n";
    }

    public function scannedB(): void
    {
        $this->text .= 'B: 30';
        if (++$this->numberOfB % 2 === 0) {
            $this->text .= ' - 15 (2 for 45)';
            $this->total += 15;
        } else {
            $this->total += 30;
        }
        $this->text .= "\n";
    }

    public function scannedC(): void
    {
        $this->text .= 'C: 20' . "\n";
        $this->total += 20;
    }

    public function scannedD(): void
    {
        $this->text .= 'D: 15' . "\n";
        $this->total += 15;
    }

}