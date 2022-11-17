// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго (блок-схема)

double a=Convert.ToDouble(Console.ReadLine("Введите число a:"));
double b=Convert.ToDouble(Console.ReadLine("Введите число b"));
if (a*a==b) 
{
    System.Console.WriteLine($"{b} является квадратом {a}");
}
if (b*b==a)
{
 System.Console.WriteLine($"{a} является квадратом {b}");
}