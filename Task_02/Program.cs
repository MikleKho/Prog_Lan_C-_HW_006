// Задача 2. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * 
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double[] CrossPointCulculate(int k1, int b1, int k2, int b2)
{
    double[] crossPoint = new double[2];
    crossPoint[0] = Math.Round((double)(b2 - b1) / (k1 - k2), 4);
    crossPoint[1] = (k1 * crossPoint[0] + b1);
    return crossPoint;
}



int k1 = Prompt("Введите k1 -->  ");
int b1 = Prompt("Введите b1 -->  ");
int k2 = Prompt("Введите k2 -->  ");
int b2 = Prompt("Введите b2 -->  ");
if (k1 == k2)
{
    System.Console.WriteLine("Прямые параллельны и не пересекаются");
}
else
{
    double[] crossPoint = new double[2];
    crossPoint = CrossPointCulculate(k1, b1, k2, b2);
    System.Console.WriteLine($"Прямые пересекаются в точке X --> {crossPoint[0]} Y --> {crossPoint[1]} ");
}
