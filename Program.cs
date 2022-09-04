// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
string name = Console.ReadLine();
int numberA = Convert.ToInt32(name);

Console.WriteLine("Введите второе число");
string nameB = Console.ReadLine();
int numberB = Convert.ToInt32(nameB);
if(numberA > numberB)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}