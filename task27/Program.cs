// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите любоу число: ");
int number = int.Parse(Console.ReadLine());

Console.Write(SumSimbols(ConvertToArray(number)));

int[] ConvertToArray(int number)
{
   int length = GetLengthNumber(number);
   int[] result = new int[length];
   for (int i = 0; i < length; i++)
   {
      result[i] = number % 10;
      number = number / 10;
   }
   return result;
}

int GetLengthNumber(int number)
{
   int length = 0;
   while (number != 0)
   {
      number = number / 10;
      length++;
   }
   return length;
}

int SumSimbols(int[] numbers)
{
   int result = 0;
   for (int i = 0; i < numbers.Length; i++)
   {
      result += numbers[i];
   }
   return result;
}