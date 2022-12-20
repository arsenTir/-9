void Task(int number)
{
    int n = number;
    switch (n)
    {
        case 1: Task64(); break;
        case 2: Task66(); break;
        case 3: Task68(); break;
        default: Console.WriteLine("Такого задания нет"); break;
    }
}
Console.WriteLine("Введите(1) для задачи #64'");
Console.WriteLine("Введите(2) для задачи #66'");
Console.WriteLine("Введите(3) для задачи #68'");
Task(ReadInt());


int ReadInt()
{
    Console.WriteLine("Введите не отрицательное число:");
    int a = int.Parse(Console.ReadLine());
        return a;
        
}


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.  
//m = 2, n = 3->A(m, n) = 9    
//m = 3, n = 2->A(m, n) = 29 
void Task68()
{
    int AckermannFunction(int numberA, int numberB)
    {
        if (numberA == 0) return numberB + 1;
        if (numberA > 0 && numberB == 0) return AckermannFunction(numberA - 1, 1);
        if (numberA > 0 && numberB > 0) return AckermannFunction(numberA - 1, AckermannFunction(numberA, numberB - 1));
        return AckermannFunction(numberA, numberB);
    }
    Console.WriteLine("Введите числа функции аккермана!");
    Console.WriteLine($"A(a,b)={AckermannFunction(ReadInt(),ReadInt())}");
}

//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии. 
//N = 5-> "5, 4, 3, 2, 1"
void Task64()
{
    string MethodRecursionNumbers(int a, int b)
    {
        if (a <= b) return MethodRecursionNumbers(a + 1, b) + $"{a} ";
        else return string.Empty;
    }
    Console.WriteLine("Порядок чисел в обртаной последовательности.Вводите числа от минимальной к максимальной!");
    Console.WriteLine($"Введите число от и до: {MethodRecursionNumbers(ReadInt(), ReadInt())}");
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120  
//M = 4; N = 8. -> 30 

void Task66()
{
   int SumElement(int numberone, int numbertwo)
    {
        int sum = numberone;
        while (numberone < numbertwo)
        {
            sum = sum + (numberone + 1);
            numberone++;
            Console.WriteLine(sum);
        }
        Console.WriteLine($"Сумма = {sum}");
    }
}
Console.WriteLine("Находит сумму всех чисел в промежутке от и до.Вводите числа минимальное,максимальное!");
Console.WriteLine($"{SumElement(ReadInt(), ReadInt())} "); 

