int N = 10;
int[] A = new int[N];
//Заполнение массива случайными числами
int i = 0;

while (i<N)
{
    A[i] = new Random().Next(10, 99);
    i++;
}
i = 0;
while (i<N)
{
Console.Write(A[i]);
Console.Write(" ");
i++;
}
Console.WriteLine(" ");
Console.WriteLine("Массив с нарушением порядка возрастания: ");

//Составление массива с исключениями, нарушает порядок возрастания 
i = 1;
int currentElement = A[0];
Console.WriteLine(currentElement);
while (i<=9)
{
    if (A[i]>currentElement)
    {
        Console.Write(A[i]);
        Console.WriteLine(" ");
        currentElement = A[i];
        
    }
  i++;
}

//2 больше среднего арафметического элементов массива А
i = 1;
int summ = A[0];
while (i<10)
{ 
    summ = summ + A[i];
    i++;
}
Console.Write("Summ = ");
Console.WriteLine(summ);

int avrg = summ / N;
Console.Write("Средн.Фрефметич. = ");
Console.Write(avrg);
Console.WriteLine(" ");

//3.Чётные
i = 0;
Console.WriteLine("Чётные элементы: ");
while (i<10)
{
    if (A[i]%2 == 0)
    {
    Console.Write(A[i]);
    Console.Write(" ");
    }
i++;
}