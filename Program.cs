﻿// Сравнение двух чисел
Console.WriteLine("Введите первое число");
﻿int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Number2 = Convert.ToInt32(Console.ReadLine());
{
    if(Number2 > Number1)
    {
        Console.WriteLine("Большее число " + Number2);
        Console.WriteLine("Меньшее число " + Number1);
    }
    else {
        Console.WriteLine("Большее число "+ Number1);
        Console.WriteLine("Меньшее число "+ Number2);
    }
}

// Нахождение макс из трех чисел
Console.WriteLine("Введите первое число");
﻿int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int Number3 = Convert.ToInt32(Console.ReadLine());
int NumberMax = Number1;
{
    if (Number2 > NumberMax)
    {
        NumberMax = Number2;
        {
        if (Number3 > NumberMax)
        {
        NumberMax = Number3;
        }
        }
    }
    else if (Number3 > NumberMax)
    {
        NumberMax = Number3;
    }
    Console.WriteLine("Максимальное число " + NumberMax);
}


// Определение четности числа
Console.WriteLine("Введите число");
﻿int Number = Convert.ToInt32(Console.ReadLine());
{
    if(Number % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
    else {
        Console.WriteLine("Число нечетное");
    }
}

// Нахождение четных чисел в периоде
Console.WriteLine("Введите число");
﻿int N = Convert.ToInt32(Console.ReadLine());
while(N > 0)
{
    if (N % 2 ==0) 
    {
        Console.Write(N + ", ");
        } 
    N--;
}