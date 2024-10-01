
using System.Xml.Serialization;

CalculatorApp();
void CalculatorApp()
{
    try
    {
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the operation (+, -, *, /):");

        char operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid Operation");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Please enter a valid number. ");
    }
    catch(DivideByZeroException ex)
    {
        Console.WriteLine($"You cannot divide by zero");
    }
    finally
    {
        Console.WriteLine("Operation Completed");
    }
}
        

