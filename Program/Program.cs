void PrintArray (string[] array, int length)

{
    Console.Write("[");
    for (int n = 0; n < length - 1; n++)
        Console.Write($"'{array[n]}', ");
    Console.WriteLine($"'{array[length - 1]}']");
}
int GenerateNewArray (string [] array, string [] newArray)

{
    int NewArrayCount = 0;               
    for (int n=0;n<array.Length;n++)
    
    {
        if (array[n].Length <=3)
        {
            newArray[NewArrayCount] = array[n];
            NewArrayCount++;
        }

    }
    return NewArrayCount;
} 
string[] stringArray = new string[] { "hello", "geekbrains", "world", ":)", "world" };

string [] resultArray = new string [100];
int countResult = GenerateNewArray (stringArray,resultArray);

Console.WriteLine ("Первоначальный массив:");
PrintArray (stringArray,stringArray.Length);

Console.WriteLine ("Новый массив:");
PrintArray (resultArray,countResult);
