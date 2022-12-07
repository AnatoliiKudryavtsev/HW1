// Задача 2:Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
Console.Write("Введите второе число: "); 
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);

if (num1 > num2)
    Console.WriteLine(num1);
else
   Console.WriteLine(num2);
   