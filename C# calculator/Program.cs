using System;

class CalculatorProgram
{
    static void Main()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("    WELCOME TO C# CALCULATOR");
        Console.WriteLine("=====================================\n");

        bool continueCalculating = true;

        while (continueCalculating)
        {
            try
            {
                // Get first number
                Console.Write("Enter first number: ");
                double number1 = double.Parse(Console.ReadLine());

                // Get second number
                Console.Write("Enter second number: ");
                double number2 = double.Parse(Console.ReadLine());

                // Display operations
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("  + : Add");
                Console.WriteLine("  - : Subtract");
                Console.WriteLine("  * : Multiply");
                Console.WriteLine("  / : Divide");
                Console.Write("Enter operation: ");
                string operation = Console.ReadLine();

                double result = 0;
                bool validOperation = true;

                // Perform calculation
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"\n{number1} + {number2} = {result}\n");
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"\n{number1} - {number2} = {result}\n");
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"\n{number1} * {number2} = {result}\n");
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            Console.WriteLine("\n❌ Error: Cannot divide by zero!\n");
                        }
                        else
                        {
                            result = number1 / number2;
                            Console.WriteLine($"\n{number1} / {number2} = {result}\n");
                        }
                        break;
                    default:
                        Console.WriteLine("\n❌ Invalid operation! Use +, -, *, or /\n");
                        validOperation = false;
                        break;
                }

                // Ask if user wants to continue
                if (validOperation)
                {
                    Console.Write("Do you want to perform another calculation? (yes/no): ");
                    string response = Console.ReadLine().ToLower();

                    if (response != "yes" && response != "y")
                    {
                        continueCalculating = false;
                        Console.WriteLine("\n✅ Thank you for using the calculator. Goodbye!\n");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\n❌ Error: Please enter valid numbers!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Error: {ex.Message}\n");
            }
        }
    }
}

