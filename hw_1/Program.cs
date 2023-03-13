// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] FillArray(int size)
{
   Console.WriteLine("Введите элементы массива: ");
   int [] array = new int[size];
   for(int i = 0; i < size; i++)
   {
    array[i] = Convert.ToInt32(Console.ReadLine());
   }
   return array;
}

int CountPositiveNumbers(int[] array) 
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество чисел больше 0: " + count);
    return count;
}


Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(size);
CountPositiveNumbers(arr);
