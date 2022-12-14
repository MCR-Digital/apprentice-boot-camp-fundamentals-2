<?php

namespace McrDigital\PhpFundamentals2\Checkout;

use PHPUnit\Framework\TestCase;

class ReceiptTest extends TestCase
{
    public function testSingleItem()
    {
        $checkout = new Checkout();

        $checkout->scan('A');

        $this->assertStringContainsString(
            "A: 50\n" . "Total: 50",
            $checkout->getReceipt()
        );
    }

    public function testOneOfEach()
    {
        $checkout = new Checkout();

        $checkout->scan('A');
        $checkout->scan('B');
        $checkout->scan('C');
        $checkout->scan('D');

        $this->assertEquals(
            "A: 50\n" . "B: 30\n" . "C: 20\n" . "D: 15\n" . "Total: 115",
            $checkout->getReceipt()
        );
    }

    public function testOffers()
    {
        $checkout = new Checkout();

        $checkout->scan('A');
        $checkout->scan('A');
        $checkout->scan('B');
        $checkout->scan('A');
        $checkout->scan('C');
        $checkout->scan('D');
        $checkout->scan('B');

        $this->assertEquals(
            "A: 50\n" .
            "A: 50\n" .
            "B: 30\n" .
            "A: 50 - 20 (3 for 130)\n" .
            "C: 20\n" .
            "D: 15\n" .
            "B: 30 - 15 (2 for 45)\n" .
            "Total: 210",
            $checkout->getReceipt()
        );
    }

}
