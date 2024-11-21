
Task1();
Task2();


static void Task1()
{

    /*1.Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
    которые нужно поменять местами. Вывести на экран получившийся массив.*/

    Console.WriteLine("Задание 1");


    int[] array = new int[20];
    Random random = new Random();

    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 101);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    Console.WriteLine("Введите первое число из массива:");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число из массива:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int ind1 = Array.IndexOf(array, num1);
    int ind2 = Array.IndexOf(array, num2);

    if (ind1 == -1 || ind2 == -1)
    {
        Console.WriteLine("Число отсутсвует в массиве");
    }
    else
    {
        int temp = array[ind1];
        array[ind1] = array[ind2];
        array[ind2] = temp;

        Console.WriteLine("Массив после замены:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    
}

static void Task2()
{

    /*2.Написать метод, где в качества аргумента будет передан массив (ключевое слово
    params). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение
    массива. Вывести (out) среднее арифметическое в массиве.*/

    Console.WriteLine("Задание 2");

    
    int[] array = { 2, 4, 6, 8, 10 };

    int product = 1;
    double average;

    int sum = ProcessArray(array, ref product, out average);

    Console.WriteLine($"Сумма элементов массива: {sum}");
    Console.WriteLine($"Произведение элементов массива: {product}");
    Console.WriteLine($"Среднее арифметическое элементов массива: {average}");
    

    static int ProcessArray(int[] array, ref int product, out double average)
    {
        int sum = 0;

        foreach (int num in array)
        {
            sum += num;
            product *= num;
        }

        average = (double)sum / array.Length;

        return sum;
    }

}



