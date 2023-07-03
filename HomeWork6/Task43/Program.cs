// Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if(ValidateLines(lineData1 , lineData2))
{
double[] coord = FindCoord( lineData1, lineData2);
Console.WriteLine($"точка пересечения уравнений y={lineData1[COEFFICIENT]}*x+{lineData1(CONSTANT)} и y={lineData2[COEFFICIEN]}*x+{lineData2[CONSTANT]}");
Console.WriteLine($"имеет координаты ({coord[X_COORD]},{coord[Y_COORD]})");
}

double Prompt(string messag)
{
    Sistem.Console.Write(messag);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"введите коэффициент для {numberOfLine} прямой >");
    return  lineDataine;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if(lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if(lineData1[CONSTANT] == lineData2[CONSTANT])
        {
        Console.WriteLine("прямые совпадают");
        }
    }
    else Console.WriteLine("прямые параллельны");
    return false;
}