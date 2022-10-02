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



string[] matrix = { "hello", "2", "world", ":-)", "abcdef", "zyx" };
int i = 0;
int j = 0;
PrintArray(matrix);
void TaskSpecialization()
{
    int countTo3 = CountTo3Element(matrix);
    Console.WriteLine($"Количество элементов не длиннее 3 символов = {countTo3}");
    //string[] newMatrix = MatrixTo3(matrix, countTo3);
    //PrintArray(newMatrix);

}

int CountTo3Element(string[] array)
{
    int count = 0;
    foreach (string value in array)
    {
    count += value.Length <= 3 ? 1 : 0;
    }
    return count;
}
// string MatrixTo3(string[] array, int count)
// {
//     string[] matr = new string[count];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             matr[j] = array[i];
//             j++;
//         }
//     }
//     return matr.ToArray;
// }

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

TaskSpecialization();