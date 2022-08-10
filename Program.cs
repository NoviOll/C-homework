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