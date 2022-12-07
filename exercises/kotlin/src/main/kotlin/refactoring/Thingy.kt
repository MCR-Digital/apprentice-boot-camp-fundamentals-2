package refactoring

internal class Thingy {
    private var foo = 0
    private var bar = 0
    private var foobar: Int = intArrayOf(0, 0, 0, 0, 0).size
    fun doTheThing(): String {
        var s = ""
        while (foo < Byte.MAX_VALUE - 27) {
            s += b(foo) + " "
            foo++
        }
        return s.substring(0, s.length - 1)
    }

    private fun b(foo: Int): String {
        bar++
        foobar--
        var s = if (bar == 3 || foobar == 0) "" else (foo + 1).toString()
        if (bar == 3) s += bar()
        if (foobar == 0) s += foo()
        return s
    }

    private fun foo(): String {
        foobar = intArrayOf(0, 0, 0, 0, 0).size
        return decode("42757a7a")
    }

    private fun bar(): String {
        bar = 0
        return decode("46697a7a")
    }

    companion object {
        fun decode(input: String): String {
            return String(input.chunked(2)
                .map { it.toInt(16).toChar() }
                .toCharArray())
        }
    }
}