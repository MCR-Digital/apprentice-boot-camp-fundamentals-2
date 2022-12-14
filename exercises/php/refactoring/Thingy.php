<?php

namespace McrDigital\PhpFundamentals2\Refactoring;

const BYTE_MAX_VALUE = 127;

class Thingy
{
    private int $foo;
    private int $bar;
    private int $foobar;

    public function __construct()
    {
        $this->foo = 0;
        $this->bar = 0;
        $this->foobar = count([0, 0, 0, 0, 0]);
    }

    public function doTheThing(): string
    {
        $s = "";
        for (; $this->foo < BYTE_MAX_VALUE - 27; $this->foo++) $s .= $this->b($this->foo) . " ";
        return substr($s, 0, strlen($s) - 1);
    }

    private function b(int $foo): string
    {
        $this->bar++;
        $this->foobar--;
        $s = $this->bar == 0b11 || $this->foobar == 0 ? "" : strval($foo + 1);
        if ($this->bar == 0b11) $s .= $this->bar();
        if ($this->foobar == 0) $s .= $this->foo();
        return $s;
    }

    private function bar(): string
    {
        $this->bar = 0;
        return strval(hex2bin("46697a7a"));
    }

    private function foo(): string
    {
        $this->foobar = count([0, 0, 0, 0, 0]);
        return strval(hex2bin("42757a7a"));
    }

}