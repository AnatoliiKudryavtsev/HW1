// Задача 6:Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string number = Console.ReadLine();
 
int num = Convert.ToInt32(number);

if(num % 2 == 1)
{
    Console.WriteLine("число нечетное");
}
else
{
  Console.WriteLine("число четное");  
}
