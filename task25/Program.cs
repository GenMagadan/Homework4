Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

Console.Write($"-> {PowerNumber(A, B)}");

int PowerNumber(int number, int exponent)
{
   int result = 1;
   for (int i = 1; i <= exponent; i++)
   {
      result *= number;
   }
   return result;
}