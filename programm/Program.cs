// Программа, которая из имеющегося массива строк формирует массив из тех строк, длина которых меньше либо равна 3 символам

string[] a ={ "1234",
               "1567",
               "-2",
               "m",
               "computer science",
               "123"
               }; // задан массив рандомных строк

int number = 3; // задано число 3 из условия



string[] GetNewArray(string[] a, int number)
{
    string[] b = new string[a.Length];
    int j = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= number)
        {
            b[j] = a[i];
            j++;
        }
    }
    return b;
}
