// // написать программу которая принимает на вход координаты двух точек и находит расстояние между ними 

int[] InputCoordinate()
{
    int[] coor = new int[2];
    System.Console.Write("Введите координату X: ");
    coor[0] = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату Y: ");
    coor[1] = int.Parse(Console.ReadLine()!);
    return coor;

}
double Distanse(int [] coordA, int [] coordB)
{
    double dist = Math.Sqrt(Math.Pow(coordA [0] - coordB [0], 2)+ Math.Pow(coordA [1] - coordB [1], 2));
    return dist;
}

int [] coordA = InputCoordinate();
int [] coordB = InputCoordinate();

double resultate = Distanse(coordA, coordB);
System.Console.WriteLine(resultate);