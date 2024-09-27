
//int firstNumber = 5;
//int secondNumber = 20;
//int result = firstNumber + secondNumber;
//Console.WriteLine("The result of the two numbers is {0} ", result);
//Console.ReadKey();

Console.WriteLine("Type in the first number followed by the enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the third number followed by the enter key");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber + thirdNumber;

Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);
