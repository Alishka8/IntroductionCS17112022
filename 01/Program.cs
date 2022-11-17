// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
int a,b=0,c=0;//целый
float f=20.4f;// 32 бит
double d=3.14;//вещественный, 64 бит
string s="gjhgl";
char c0='a';
bool flag=true;
*/
// 1. С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)

int a;
a=10;
System.Console.WriteLine("Введите число:");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(b);

