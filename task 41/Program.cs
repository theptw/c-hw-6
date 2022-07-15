// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] arr = new int[99];

int swiitch = 0;
int count = 0;


for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Введите одно число");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Для ввода следующего числа введите 1, для остановки ввода введите 0");
    swiitch = Convert.ToInt32(Console.ReadLine());
    if (swiitch == 0) break;
}
// Покопался в интернете, не нашёл лучшего способо сделать конец ввода по сигналу пользователя, реализовал как получилось,
//  жду критики(если есть другие варианты хотел бы посмотреть)



int NumAboveZero(int[] array)
{
for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}


NumAboveZero(arr);

Console.WriteLine($"Вы ввели {count} положительных чисел");