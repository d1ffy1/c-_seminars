Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool checkSquare = CheckSquare(firstNumber, secondNumber);
Console.WriteLine(checkSquare ? "да" : "нет");

bool CheckSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}