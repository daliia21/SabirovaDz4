/*Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные
параметры метода – два целых числа. Протестировать метод.*/

//Console.WriteLine("Упражнение 5.1");




Task1();
Task2();
Task3();
Task4();
Task5_2();




static void Task1()
{
    /*Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные
    параметры метода – два целых числа. Протестировать метод.*/

    Console.WriteLine("Упражнение 5.1");

    Console.WriteLine("Введите первое число:");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int maxN = maxNumber(number1, number2);
    Console.WriteLine($"Наибольшее из двух чисел - {maxN}");

    static int maxNumber(int num1, int num2)
    {
        int number = Math.Max(num1, num2);
        return number;
    }
}




static void Task2()
{
    /*Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых
    параметров. Параметры передавать по ссылке. Протестировать метод.*/

    Console.WriteLine("Упражнение 5.2");



    Console.WriteLine("Введите первое число:");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"До замены: num1 = {num1}, num2 = {num2}");

    Swap(ref num1, ref num2);

    Console.WriteLine($"После замены: num1 = {num1}, num2 = {num2}");


    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
static void Task3()
{
    /*Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений
    передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
    если в процессе вычисления возникло переполнение, то вернуть значение false. Для
    отслеживания переполнения значения использовать блок checked.*/


    Console.WriteLine("Упражнение 5.3");



    
    Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());
    if (NumberFactorial(a, out long resultFactorial))
    {
        Console.WriteLine($"Факториал числа {a} равен {resultFactorial}");
    }
    else
    {
        Console.WriteLine("Переполнение при вычислении факториала!");
    }
    

    static bool NumberFactorial(int value, out long resultFactorial)
    {
        resultFactorial = 1;
        try
        {
            checked
            {
                for (int i = 1; i <= value; i++)
                {
                    resultFactorial *= i;
                }
            }
            return true;
        }
        catch (OverflowException)
        {
            resultFactorial = 0;
            return false;
        }
    }
}
/*Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа*/

static void Task4()
{
    /*Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа*/

    Console.WriteLine("Упражнение 5.4");


    
    Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());

    try
    {
        long resultFactorial = NumberFactorial(a);
        Console.WriteLine($"Факториал числа {a} равен {resultFactorial}");
    }
    catch (StackOverflowException)
    {
        Console.WriteLine("Рекурсия слишком глубокая.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Произошло переполнение при вычислении факториала.");
    }
    
    static long NumberFactorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
        if (n == 0 || n == 1)
            return 1;

        checked
        {
            return n * NumberFactorial(n - 1);
        }
    }
}





static void Task5_2()
{
    /*Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа
    ряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,
    13... Для таких чисел верно соотношение Fk = Fk-1 + Fk-2 .*/
        
    Console.WriteLine("Домашнее задание 5.2");
        

    
    Console.Write("Введите номер числа Фибоначчи: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 0)
    {
        Console.WriteLine("Введите натуральное число больше 0.");
    }
    else
    {
        int result = Fibonacci(n);
        Console.WriteLine($"Число Фибоначчи с номером {n} равно {result}.");
    }
    
    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

}





