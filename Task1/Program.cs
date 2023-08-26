// программа принимает на вход координаты точки (x, y)  при чем х не равен 0 и у не равен 0, 
// и выдает номер четверти плоскости в которой находится эта точка

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// функция координат каждой четверти
int Quarter(int axisX, int axisY)
{
    int num = (0);
    if (axisX > 0 && axisY > 0)
        num = 1;
    else if (axisX < 0 && axisY > 0)
        num = 2;
    else if (axisX < 0 && axisY < 0)
        num = 3;
    else if (axisX > 0 && axisY < 0)
        num = 4;
    return num;
}

// запрашиваем два числа

int x = InputNum("Введите координату X: ");
int y = InputNum("Введите координату Y: ");

// Объявляем переменную и присваиваем ей результат функции, передав ей два аргумента Х и У
int res = Quarter(x, y);
// прописываем условие
if (res == 0) System.Console.WriteLine("Точка лежит на границе четвертей");
else System.Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в четверти {res}");

