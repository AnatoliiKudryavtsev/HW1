// Задача 4:   Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
Console.Write("Введите второе число: "); 
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);
Console.Write("Введите третье число: "); 
string number3 = Console.ReadLine();
int num3 = Convert.ToInt32( number3);

int max = num1;
if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine(max);
