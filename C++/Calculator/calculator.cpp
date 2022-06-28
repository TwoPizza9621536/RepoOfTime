#include <iostream>
#include <ostream>
#include <string>
#include <math.h>
#include <stdexcept>

double Calculate(double a, char oper, double b);

int main()
{
    bool endApp = 0;
    while (!endApp)
    {
        std::string a = "";
        std::string b = "";
        char oper = ' ';
        std::string key = "";
        double result = 0;

        std::cout << "Calculator\nType a number:" << std::endl;
        std::cin >> a;

        double cleana = 0;

        cleana = std::stod(a);

        std::cout << "Type a operator:" << std::endl;
        std::cin >> oper;

        std::cout << "Type another number:" << std::endl;
        std::cin >> b;

        double cleanb = 0;

        cleanb = std::stod(b);

        try
        {
            result = Calculate(cleana, oper, cleanb);
            if (isnan(result))
            {
                std::cout << "This operation will result in a mathematical error." << std::endl << std::endl;
            }
            else std::cout << "Your result: " << result << std::endl << std::endl;
        }
        catch (std::runtime_error& e)
        {
            std::cout << "Oh no! An exception occurred trying to do math." << std::endl << e.what();
        }

        std::cout << "Press 'n' and Enter to close the app or press any other key and Enter to continue: ";
        std::cin >> key;
        if (key == "n")
        {
            endApp = 1;
        }

        std::cout << std::endl;
    }
}

double Calculate(double a, char oper, double b)
{
    double result = -NAN;
    std::string newb = "";

    switch ((int)oper)
    {
    case '+':
        result = a + b;
        break;
    case '-':
        result = a - b;
        break;
    case '*':
        result = a * b;
        break;
    case '/':
        while (b == 0)
        {
            std::cout << "Enter a non - zero divisor: " << std::endl;
            std::cin >> newb;
            b = std::stod(newb);
        }
        if (b != 0)
        {
            result = a / b;
        }
        break;
    }

    if (result == -NAN)
    {
        throw std::runtime_error("An unknown error has occurred, use the CSharp version of this code.");
    }

    return result;
}
