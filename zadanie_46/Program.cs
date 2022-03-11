// 46. Написать программу масштабирования фигуры
Console.Clear();

string num = "(0,0) (2,0) (2,2) (0,2)";
Console.Write("Введите множитель: ");
int k = int.Parse(Console.ReadLine());
num = num.Replace("(", "").Replace(")", "").Replace(",", " ");
string[] array = num.Split(" "); 

for (int i = 0; i < array.Length; i=i+2)
{
    int x = k * int.Parse(array[i]);
    int y = k * int.Parse(array[i + 1]);
    Console.Write($"({x},{y})");
}