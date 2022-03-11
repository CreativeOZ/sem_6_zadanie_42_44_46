// 42. Определить сколько чисел больше 0 введено с клавиатуры
Console.Clear();

int[] array = new int[3];
int result = 0;
for (int i = 0; i < array.Length; i++)
{
   Console.Write("Ввод числа: ");
   array[i] = int.Parse(Console.ReadLine());
   if (array[i] > 0)
   {
       result = result + 1;
   }
}
Console.WriteLine($"Колличество чисел больше 0 введено с клавиатуры = {result}");