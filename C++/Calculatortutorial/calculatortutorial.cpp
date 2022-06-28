#include <iostream>
#include "calculator.h"

int main()
{
    double x = 0.0;
    double y = 0.0;
    double result = 0.0;
    char oper = '+';

    std::cout << "Calculator Console Application" << std::endl << std::endl;
    std::cout << "Please enter the operation to perform. Format: a+b | a-b | a*b | a/b"
              << std::endl;

    Calculator c;
    while (true)
    {
        std::cin >> x >> oper >> y;
        if (oper == '/' && y == 0)
        {
            std::cout << "Division by 0 exception" << std::endl;
            continue;
        }
        else
        {
            result = c.Calculate(x, oper, y);
        }
        std::cout << "Result is: " << result << std::endl;
    }
}
