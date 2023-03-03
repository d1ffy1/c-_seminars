// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string QuaterNumber(int quater)
{ 
   
    if(quater == 1) return ("numX > 0 && numY > 0");
    if(quater == 2) return ("numX < 0 && numY > 0");
    if(quater == 3) return ("numX < 0 && numY < 0");
    if(quater == 4) return ("numX > 0 && numY < 0");
    return ("0");
}

Console.WriteLine("Введите номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());


string quaterNumber = QuaterNumber(number);
string result = number > 0 && number < 5
                ? $"Указанный соответстувует следующим координатам: {quaterNumber} "
                : "Введен некорректный номер";

Console.WriteLine(result);
