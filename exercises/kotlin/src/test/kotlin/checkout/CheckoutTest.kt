package checkout

import org.junit.jupiter.api.Assertions.*
import org.junit.jupiter.api.Test

internal class CheckoutTest {
    @Test
    fun oneA() {
        val checkout = Checkout()
        checkout.scan("A")
        assertEquals(checkout.total(), 50)
    }

    @Test
    fun twoA() {
        val checkout = Checkout()
        checkout.scan("A")
        checkout.scan("A")
        assertEquals(checkout.total(), 100)
    }

    @Test
    fun threeA() {
        val checkout = Checkout()
        checkout.scan("A")
        checkout.scan("A")
        checkout.scan("A")
        assertEquals(checkout.total(), 130)
    }


    @Test
    fun sixA() {
        val checkout = Checkout()
        checkout.scan("A")
        checkout.scan("A")
        checkout.scan("A")
        checkout.scan("A")
        checkout.scan("A")
        checkout.scan("A")
        assertEquals(checkout.total(), 260)
    }

    @Test
    fun oneB() {
        val checkout = Checkout()
        checkout.scan("B")
        assertEquals(checkout.total(), 30)
    }

    @Test
    fun twoB() {
        val checkout = Checkout()
        checkout.scan("B")
        checkout.scan("B")
        assertEquals(checkout.total(), 45)
    }

    @Test
    fun fourB() {
        val checkout = Checkout()
        checkout.scan("B")
        checkout.scan("B")
        checkout.scan("B")
        checkout.scan("B")
        assertEquals(checkout.total(), 90)
    }

    @Test
    fun simple() {
        val checkout = Checkout()
        checkout.scan("A")
        assertEquals(checkout.total(), 50)
        checkout.scan("B")
        assertEquals(checkout.total(), 80)
        checkout.scan("C")
        assertEquals(checkout.total(), 100)
        checkout.scan("D")
        assertEquals(checkout.total(), 115)
    }

    @Test
    fun incremental() {
        val checkout = Checkout()
        checkout.scan("A")
        assertEquals(checkout.total(),50)
        checkout.scan("B")
        assertEquals(checkout.total(),80)
        checkout.scan("A")
        assertEquals(checkout.total(),130)
        checkout.scan("A")
        assertEquals(checkout.total(),160)
        checkout.scan("B")
        assertEquals(checkout.total(),175)
        checkout.scan("C")
        assertEquals(checkout.total(),195)
        checkout.scan("B")
        assertEquals(checkout.total(),225)
        checkout.scan("C")
        assertEquals(checkout.total(),245)
        checkout.scan("D")
        assertEquals(checkout.total(),260)
        checkout.scan("D")
        assertEquals(checkout.total(),275)
        checkout.scan("D")
        assertEquals(checkout.total(),290)
        checkout.scan("C")
        assertEquals(checkout.total(),310)
    }
}