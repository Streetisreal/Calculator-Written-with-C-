#include <iostream>

using namespace std;

int main() {
    char op;
    double num1, num2;

    cout << "=== Continuous C++ Calculator ===\n";
    cout << "(Type 'q' at the operator prompt to exit the program)\n\n";


    while (true) {


        cout << "Enter an operator (+, -, *, /) or 'q' to quit: ";
        cin >> op;


        if (op == 'q' || op == 'Q') {
            cout << "\nGoodbye!" << endl;
            break; 
        }


        cout << "Enter two numbers: ";
        cin >> num1 >> num2;


        switch (op) {
        case '+':
            cout << "Result: " << num1 << " + " << num2 << " = " << (num1 + num2) << "\n\n";
            break;

        case '-':
            cout << "Result: " << num1 << " - " << num2 << " = " << (num1 - num2) << "\n\n";
            break;

        case '*':
            cout << "Result: " << num1 << " * " << num2 << " = " << (num1 * num2) << "\n\n";
            break;

        case '/':
            if (num2 != 0) {
                cout << "Result: " << num1 << " / " << num2 << " = " << (num1 / num2) << "\n\n";
            }
            else {
                cout << "Error! Division by zero is not allowed.\n\n";
            }
            break;

        default:
            cout << "Error! Invalid operator.\n\n";
            break;
        }
    }

    return 0;
}
