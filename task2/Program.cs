// На вход программа принемает три числа и выдает максимальное из этих чисел 
Console.Write("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c=Convert.ToInt32(Console.ReadLine());
int Max=a;
if (Max<b)
{
   Max=b; 
}
if (Max<c)  
{
    Max=c;
}
Console.Write($"Max = : {Max}");
