#include <stdio.h>
#include <stdlib.h>
#include "calculator.h"

int main()
{
    double x = 0.0;
    double y = 0.0;
    double result = 0.0;
    char oper = '+';

    printf("Calculator Console Application\n");
    printf("Please enter the operation to perform. Format: a+b | a-b | a*b | a/b\n");

    while (1)
    {
        scanf("%lf" "%c" "%lf", &x, &oper, &y);
        if (oper == '/' && y == 0)
        {
            printf("Division by 0 exception");
            continue;
        }
        else
        {
            result = Calculator(x, oper, y);
        }
        printf("Result is: %lf\n", result);
    }
}
