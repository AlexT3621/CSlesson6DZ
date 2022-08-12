/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, -567, 89, 223-> 3 */

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.WriteLine("Укажите сколько числе будете вводить");
int M = Convert.ToInt32(Console.ReadLine());

int[] matrix = new int[M];

for (int i = 0; i < M; i++)
{
    Console.WriteLine("введите число N" + (i + 1));
    int num = Convert.ToInt32(Console.ReadLine());
    matrix[i] = num;
}

PrintArray(matrix);
int count = 0;
for (int i = 1; i < M; i++)
{
    if (matrix[i - 1] > 0) count = count + 1;

}

Console.WriteLine("Вы ввели " + count + " чисел больше нуля.");



