// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine());

int[] myArray = new int[length];
GetArray(myArray);
PrintArray(myArray);

void GetArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"Введите элементов массива под индексом {i}: ");
      array[i] = int.Parse(Console.ReadLine());
   }
}


void PrintArray(int[] array)
{
   Console.Write("Вывод массива: [ ");
   for (int i = 0; i < array.Length; i++)
   {
      if (i != array.Length - 1)
      {
         Console.Write($"{array[i]}, ");
      }
      else
      {
         Console.Write($"{array[i]} ]");
      }
   }
}
