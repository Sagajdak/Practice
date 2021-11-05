Console.Write("Размер массива = ");
int N = int.Parse(Console.ReadLine());
int[] Mass = new int[N];
//Заполнение массива случайными числами
int i = 0;

while (i<N)
{
    Mass[i] = new Random().Next(-9, 10);
    i++;
}
i = 0;
while (i<N)
{
Console.WriteLine(Mass[i]);
i++;
}


