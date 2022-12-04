// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] stringArray = {"WoW", "12345", "Ford", "000", "Pie"};

void PrintStringArray (string[] stringArray)
{
    Console.WriteLine(string.Join(", ", stringArray));
}

Console.Write("Исходный массив: ");
PrintStringArray(stringArray);


string[] ChangeArray (string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            count++;
        }
    }

    int j = 0;
    string[] result = new string [count];
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            result[j] = stringArray[i];
            j++;
        }
    }
    return result;
}

string[] resultArray = ChangeArray(stringArray);

Console.Write("Новый массив: ");
PrintStringArray(resultArray);

