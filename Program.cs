//Задача№4. Напишите программу, которая на вход принимает
//число N, а на выходе показывает все четные числа от 1 до N
/* Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
if(number > 0)
    {
    while(count <= number)
        {
            if(count%2 == 0) Console.Write($"{count}  "); 
            count = count + 1;
        }
    }
else Console.WriteLine("Введите число от 1"); */


//Задача#3. Напишите программу, которая на вход принимает
//число и выдает, является ли число четным.
/* Console.Clear();
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
if(number% 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
else{
        Console.WriteLine("Число нечетное");
    } */
 
    
//Задача№2. Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.
/* Console.Clear();
Console.WriteLine("Введите первое число ");
string num1 = Console.ReadLine();
int number1 = int.Parse(num1);
Console.WriteLine("Введите второе число ");
string num2 = Console.ReadLine();
int number2 = int.Parse(num2);
Console.WriteLine("Введите третье число ");
string num3 = Console.ReadLine();
int number3 = int.Parse(num3);
int max = number1;
if(number2 > max)
   {
        if(number2 > number3)
        {
            max = number2;
        } 
        else 
        {
            max = number3;
        } 
    } 
else 
    {
            if(number3 > max) max = number3;
    }  
Console.WriteLine($"max={max}");  */


//Задача№1. Напишите программу,которая на вход принимае
//два числа и выдает, какое число больше, а какое меньше.
/* Console.Clear();
Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
    {
        Console.WriteLine($"max={number1}");
        Console.Write($"min={number2}");
    }
else{
        Console.WriteLine($"max={number2}");
        Console.Write($"min={number1}");
    } */

 