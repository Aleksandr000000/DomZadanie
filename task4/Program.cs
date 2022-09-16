// На вход программа принемает число N,  а выдает все четные числа от 1 дл N
Console.Write("Введите N: ");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"четные числа в диапозоне от 1 до {N} ");
for (int i = 0; i < N; i=i+2)
            {
             
Console.Write($"{i} ");
            }