// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

double[] GetArray(int x)
{
    double[] arr = new double[x];

    WriteLine("Введите числа по порядку");
    for (int i = 0; i < x; i++)
    {
        arr[i] = Convert.ToDouble(ReadLine());
    }

    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write(arr[i]);
        if (i < arr.Length - 1)
        {
            Write(", ");
        }
    }
}

void CountDigits(double[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }

    WriteLine($"В заданной выборке {count} чисел больше нуля");
}


WriteLine("Сколько числе вы хотите ввести?");
int length = Convert.ToInt32(ReadLine());

double[] array = GetArray(length);
PrintArray(array);
WriteLine();
CountDigits(array);