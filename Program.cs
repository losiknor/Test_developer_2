// Написать программу, которая из имеющегося массива из строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
Console.Write("Введите количество элементов массива : ");
int m = int.Parse(Console.ReadLine());

string[] array = new string[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    Console.Write($"Введите {i}-й элемент массива : ");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Из имеющегося массива : ");
for (int i = 0; i < m; i++)
    Console.Write($"  {array[i]}  ");
int count = 0;
int n = 3;
for (int i = 0; i < m; i++)
{
    if (array[i].Length <= n)
        count = count + 1;
}
string[] arrayMod = new string[count];
int j = 0;
for (int i = 0; i < m; i++)
{
    if (array[i].Length <= n)
    {
        arrayMod[j] = array[i];
        j = j + 1;
    }
}
Console.WriteLine();
Console.WriteLine("Сформирован массив : ");
for (int k = 0; k < count; k++)
    Console.Write($"  {arrayMod[k]}  ");
