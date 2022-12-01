// 25. Вывести на экран кубы чисел от 1 до N
int N=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<N;i++)
{
int b=(int)Math.Pow(i,3);
System.Console.WriteLine($"{b}");
}


