//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите первое число");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");

int c = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.Write("Большее число= "); 
    Console.Write(b);
}
 if (b < a)
 {
    Console.Write("Большее число= "); 
    Console.Write(a);
 }

 if (a < c)
{
    Console.Write("Большее число= "); 
    Console.Write(c);
}

if (b < c)
{
    Console.Write("Большее число= "); 
    Console.Write(c);
}