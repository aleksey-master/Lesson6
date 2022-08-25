/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

Console.Write($"Сколько чисел Вы будете вводить?: ");
//Prompt("Сколько чисел Вы будете вводить?: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[M];

void InputNumbers(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0)
            count += 1;
    }
    return count;
}

InputNumbers(M);

Console.WriteLine($"Введено больше 0 чисел (колличество): {Comparison(arrayNumbers)} ");
