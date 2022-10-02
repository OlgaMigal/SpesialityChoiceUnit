// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой
// основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл КEADME.md)
// 4. Написать программу, решающую поставленную задачу.
// 5. Использовать контроль версий в работе над этим небольшим проектом ]
// (не должно быть так, что всё залито одним коммитом, как минимум
// этапы 2, 3, 4 должны быть расположены в разных коммитах)


//Камянецкий говорит, что если в консоли удобно, не нужно городить ввода с клавиатуры:

string[] matrix = { "hello", "Cпс", "world", "за", "C#!", "oneLove", "It", "is", "Асгард", "fun", "nomore", ":-)" };
int controlLength = 3; //элементы не более скольки символов станем отбирать в новый массив
int countTo3 = CountTo3Element(matrix);

void TaskSpecialization()
{
    PrintArray(matrix);
    string[] newMatrix = MatrixTo3(matrix);
    PrintArray(newMatrix);
}

//Счётчик элементов длиной не более 3 символов (аж с тернарным оператором)
int CountTo3Element(string[] array)
{
    int count = 0;
    foreach (string value in array)
    {
        count += value.Length <= controlLength ? 1 : 0;
    }
    return count;
}

//Создание матрицы из элементов не более 3 символов
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

// Метод печати массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

TaskSpecialization();