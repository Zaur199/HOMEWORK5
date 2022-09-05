// Написать программу копирования массива

int[] array = {4, 8, 3, -7, 0, -9, -3, 1, 1, 2};
int[] copy = new int[array.Length];

for(int i = 0; i < array.Length; i++)
{
    copy[i] = array[i];
}
Console.Write("Копия массива:");
Console.WriteLine(String.Join(", ", copy));
Console.WriteLine();
