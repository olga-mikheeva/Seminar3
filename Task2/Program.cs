// написать программу которая по заданному номеру четверти показывает диапазон возможных координат точек этой четверти

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void QuarterAvailable(int quarter)
{
    if (quarter == 1)
    {
       System.Console.WriteLine("x > 0, y > 0"); 
    }
    else if (quarter == 2)
    {
        System.Console.WriteLine("x < 0, y > 0");
    }
    else if (quarter == 3)
    {
       System.Console.WriteLine("x < 0, y < 0"); 
    }
    else if (quarter == 4)
    {
        System.Console.WriteLine("x > 0, y < 0");
    }
    else
    {
        System.Console.WriteLine("Нет такой четверти");
    }
}

int quarter = InputNum("Введите номер четверти: ");
QuarterAvailable(quarter);

