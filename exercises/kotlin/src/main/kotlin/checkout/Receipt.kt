package checkout

class Receipt {
    private var text = ""
    private var numberOfA = 0
    private var total = 0
    private var numberOfB = 0
    fun text(): String {
        return text + "Total: " + total
    }

    fun scannedA() {
        text += "A: 50"
        if (++numberOfA % 3 == 0) {
            text += " - 20 (3 for 130)"
            total += 30
        } else {
            total += 50
        }
        text += "\n"
    }

    fun scannedB() {
        text += "B: 30"
        if (++numberOfB % 2 == 0) {
            text += " - 15 (2 for 45)"
            total += 15
        } else {
            total += 30
        }
        text += "\n"
    }

    fun scannedC() {
        text += "C: 20\n"
        total += 20
    }

    fun scannedD() {
        text += "D: 15\n"
        total += 15
    }
}
