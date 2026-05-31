#include <iostream>

using namespace std;

int main()
{
    char op;
    double num1, num2;

    cout << "=== Simple C++ Calculator ===\n\n";

    cout << "Enter an operator (+, -, *, /): ";
    cin >> op;

    cout << "Enter two numbers: ";
    cin >> num1 >> num2;

    switch (op)
    {
        case '+':
            cout << "\nResult: " << num1 << " + " << num2 << " = " << (num1 + num2) << endl;
            break;

        case '-':
            cout << "\nResult: " << num1 << " - " << num2 << " = " << (num1 - num2) << endl;
            break;

        case '*':
            cout << "\nResult: " << num1 << " * " << num2 << " = " << (num1 * num2) << endl;
            break;

        case '/':
            if (num2 != 0)
            {
                cout << "\nResult: " << num1 << " / " << num2 << " = " << (num1 / num2) << endl;
            }
            else
            {
                cout << "\nError! Division by zero is not allowed." << endl;
            }
            break;

        default:
            cout << "\nError! Invalid operator." << endl;
            break;
    }

    return 0;
}