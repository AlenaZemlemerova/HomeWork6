// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Ввод чисел происходит через Enter, останавливается при 
//введении слова "stop"

int Exercice41()
{
    Console.WriteLine("Введите числа(для завершения введите 'stop'): ");
    int count = 0;
    for(int i = 0; ; i++)
    {
        string a = Console.ReadLine();
        if(a == "stop") break;
        else 
        {
            int b = Convert.ToInt32(a);
            if(b > 0) count++;         
        }
    }    
    Console.WriteLine($"Введено {count} положительных чисел");
    return count;
}

//Задача 43: Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void Exercice43()
{
    Console.WriteLine("Введите значение b1:");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1:");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2:");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2:");
    int k2 = Convert.ToInt32(Console.ReadLine());

    double x0;
    double y0;
    double b = b2 - b1;
    double k = k1 - k2;
    if(k == 0)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else 
    {
        x0 = b / k;
        y0 = k1 * x0 + b1;
        System.Console.WriteLine($"Точка пересечения ({Math.Round(x0, 2)}; {Math.Round(y0, 2)})");
    }    
}

Exercice43();
Exercice41();