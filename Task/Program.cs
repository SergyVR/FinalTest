string[] arrayIn = new string[9] {"мир", "дружба", "жвачка", "GB", "8", "800", "700", "68", "41"};
string[] arrayOut = new string[arrayIn.Length];


    int count = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
    if(arrayIn[i].Length <= 3)
        {
        arrayOut[count] = arrayIn[i];
        count++;
        }
    }

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arrayOut);
