package blinmaker;

import java.util.Scanner;

public class Cooker 
{
	public static void main(String[] args) 
	{
		int eggsAmount;
		int eggsMin = 1;
		int milkAmount;
		int milkMin = 200; //milliliters
		int flourAmount;
		int flourMin = 100; //grams

		System.out.println("Hello Boris!");
		System.out.println("Blinmaker is starting up..");
		System.out.println("How many eggs do you have?");
		
		Scanner userInput = new Scanner(System.in);
		eggsAmount = userInput.nextInt();
		//System.out.println("you have " + eggsAmount + " eggs");
		userInput.close();
		
		System.out.println("How much milk do you have?");
		Scanner userInputmilk = new Scanner(System.in);
		milkAmount = userInputmilk.nextInt();
		//System.out.println("you have " + milkAmount + "ml milk");
		userInputmilk.close();
		
		System.out.println("How much flour do you have?");
		Scanner userInputflour = new Scanner(System.in);
		flourAmount = userInputflour.nextInt();
		//System.out.println("you have " + flourAmount + "g flour");
		userInputflour.close();
		
		// main code here
		if (eggsAmount < eggsMin || milkAmount < milkMin || flourAmount < flourMin)
		{
			System.out.println("no blin today :(");
		}
		else
		{
			// calculation
			flourAmount = flourAmount / flourMin;
			System.out.println("you have " + flourAmount + " portions of flour");
			
			milkAmount = milkAmount / milkMin;
			System.out.println("you have " + milkAmount + " portions of milk\n");
			
			int smallest;
			if (eggsAmount <= milkAmount && milkAmount <= flourAmount)
			{
				smallest = eggsAmount;
			}
			else if (milkAmount <= flourAmount && milkAmount <= eggsAmount)
			{
				smallest = milkAmount;
			}
			else
			{
				smallest = flourAmount;
			}
			//every portion is 4 blins
			System.out.println("You can make " + smallest + " portions of blins\n");
			System.out.println("You will need " + smallest*eggsMin + " eggs");
			System.out.println("You will need " + smallest*flourMin + " flour");
			System.out.println("You will need " + smallest*milkMin + " milk\n");
			System.out.println("Blinmaker shutting down..");
		}
	}

}
