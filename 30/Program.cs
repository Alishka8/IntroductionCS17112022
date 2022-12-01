// 30. Написать программу вычисления произведения чисел от 1 до N
int N=Convert.ToInt32(Console.ReadLine());
int p = 1;
for(int i=1;i<N;i++)
{
        p=p*i;   
}
System.Console.WriteLine(+p);

