// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.


// Камянецкий говорит, что если в консоли удобно, не нужно городить ввода с клавиатуры:

string[] matrix = { "hello", "Cпс", "world", "за", "C#!", "oneLove", "It", "is", "Асгард", "fun", "Peace", ":-)" };
int controlLength = 3; // элементы не более скольки символов станем отбирать в новый массив
int countTo3 = CountTo3Element(matrix);

void TaskSpecialization()
{
    PrintArray(matrix);
    string[] newMatrix = MatrixTo3(matrix);
    PrintArray(newMatrix);
}

// Счётчик элементов длиной не более 3 символов (аж с тернарным оператором):
int CountTo3Element(string[] array)
{
    int count = 0;
    foreach (string value in array)
    {
        count += value.Length <= controlLength ? 1 : 0;
    }
    return count;
}

// Создание матрицы из элементов не более 3 символов:
string[] MatrixTo3(string[] array)
{
    int j = 0;
    string[] matr = new string[countTo3];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= controlLength)
        {
            matr[j] = array[i];
            j++;
        }
    }
    return matr;
}

// Метод печати массива:
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

TaskSpecialization();