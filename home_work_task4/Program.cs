//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
 int a = Convert.ToInt32(Console.ReadLine());

 int count = 1;

 while ((count*2) <= a)
 {

    Console.Write(count *2 +" ");
    count++;
   
 }
