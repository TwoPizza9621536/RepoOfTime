
import java.util.Scanner;

import static java.lang.Double.parseDouble;


public class Calculator {
	public static void main(String[] args) {
		boolean endApp = false;
		while (!endApp) {
			String a = " ";
			String b = " ";
			String oper = " ";
			double result = 0.0;
			Scanner input = new Scanner(System.in);

			System.out.println("Calculator\nType in a number:");
			a = input.nextLine();

			double cleana = tryParse(a);

			System.out.println("Type in a operator:");
			oper = input.nextLine();

			System.out.println("Type in an another number:");
			b = input.nextLine();

			double cleanb = tryParse(b);

			try {
				result = Calculate(cleana, oper, cleanb);
				if (Double.isNaN(result)) {
					System.out.println("This operation will result in a mathematical error.\n");
				} else {
					System.out.println(result);
				}
			} catch (Exception e) {
				System.out.println("Oh no! An exception occurred trying to do the math.\n - Details: " + e.getMessage());
			}

			System.out.println("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
			if (input.nextLine() == "n") {
				input.close();
				endApp = true;
			}
			System.out.println("\n");
		}
	}

	private static double Calculate(double cleana, String oper, double cleanb) {
		double result = Double.NaN;
		switch (oper) {
		case "+":
			result = cleana + cleanb;
			break;
		case "-":
			result = cleana - cleanb;
			break;
		case "*":
			result = cleana * cleanb;
			break;
		case "/":
			Scanner nonzero = new Scanner(System.in);
			while (cleanb == 0) {
				System.out.println();
				cleanb = nonzero.nextInt();
			}
			nonzero.close();
			if (cleanb != 0)
				result = cleana / cleanb;
		default:
			break;
		}
		return result;
	}

	private static double tryParse(String a) {
		double cleana = 0.0;
		boolean endParse = false;
		Scanner Parse = new Scanner(System.in);

		while (!endParse) {
			if (parseDouble(a) != null) {

			}
		}
		return cleana;
	}
}
