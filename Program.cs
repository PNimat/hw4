// Задача 25
Console.WriteLine("Задача 25");

Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num} в степени {num2}: {expon(num, num2)}");
int expon(int a, int b)
{
    int j = a;
    for(int i=1; i<b; i++) 
    {
        j *= a;
    }
    return j;
}
Console.WriteLine($"{expon(4, 5)}");

Console.WriteLine();



// Задача 27
Console.WriteLine("Задача 27");

Console.WriteLine("Введите число");
int numOf27 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 0 до {numOf27}: {sumOfNum(numOf27)}");

int sumOfNum(int number)
{
    int sum = 0;
    for(int i=1; i<=number; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine();



// Задача 29
Console.WriteLine("Задача 29");
{
    Random rnd = new Random();
    int[] arr = new int[8];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
        
    Console.Write($" {arr[i]} ");
    }
}