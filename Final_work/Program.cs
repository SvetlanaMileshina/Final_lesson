string[] GetArrayThreeSimvol(string[] array)
{
    int countLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            countLength++;
        }
        
    }
    string[] arrayThreeSimvol = new string[countLength];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            arrayThreeSimvol[j] = simvol;
            j++;
        }
        
    }
    return arrayThreeSimvol;
}

Console.Write("Введите строку, разделенную запятыми:");
string? arrayElement = Console.ReadLine();
string[] arraySimvol = arrayElement.Split(',');