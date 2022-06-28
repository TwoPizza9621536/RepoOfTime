import java.lang.Double.parseDouble

fun main() {
    var endApp = false
    while (!endApp) {
        var result: Double

        println("Calculator\nType a number:")
        val a: String = readLine().toString()

        val cleana = tryParse(a)

        println("Type in a operator:")
        val oper: String = readLine().toString()

        println("Type in an another number:")
        val b: String = readLine().toString()

        val cleanb = tryParse(b)

        try {
            result = calculate(cleana, oper, cleanb)
            if (Double.isNaN()) {
                println("This operation will result in a mathematical error.\n")
            } else println("Your result: $result")
        } catch (e: Exception) {
            println("""Oh no! An exception occurred trying to do the math. - Details: ${e.message}""")
        }

        println("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ")
        if (readLine().toString() == "n") endApp = true
        println("\n")
    }
}

private fun calculate(a: Double, oper: String, b: Double): Double {
    var newb = b
    var cleanb: String
    var result = Double.NaN

    when (oper) {
        "+" -> result = a + newb
        "-" -> result = a - newb
        "*" -> result = a * newb
        "/" -> {
            while (newb == 0.0) {
                println("Enter a non-zero divisor: ")
                cleanb = readLine().toString()
                newb = tryParse(cleanb)
            }
            if (newb != 0.0)
                result = a / b
        }
    }
    return result
}

private fun tryParse(a: String): Double {
    var newa = a
    var cleana = 0.0
    var endParse = false

    while (!endParse) {
        if (parseDouble(newa) != null) {
            cleana = parseDouble(newa)
            endParse = true
        } else if (parseDouble(newa) == null) {
            println("\"This is not a valid input. Please enter an integer value: \"")
            newa = readLine().toString()
        }
    }
    return cleana
}
