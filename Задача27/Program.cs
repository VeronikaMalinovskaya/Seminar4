// Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int counter = Convert.ToString(N).Length;
int advance = 0;
int result = 0;

for (int i = 0; i < counter; i++)
{
   advance = N - N % 10;
   result = result + (N - advance);
   N = N / 10;
}

Console.WriteLine("Сумма цифр в числе: " + result);