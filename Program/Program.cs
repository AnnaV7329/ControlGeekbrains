void PrintArray (string[] array, int length)

{
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
        Console.Write($"'{array[i]}', ");
    Console.WriteLine($"'{array[length - 1]}']");
}
int GenerateNewArray (string [] array, string [] newArray)

{
    int NewArrayCount = 0;               
    for (int i=0;i<array.Length;i++)
    
    {
        if (array[i].Length <=3)
        {
            newArray[NewArrayCount] = array[i];
            NewArrayCount++;
        }

    }
    return NewArrayCount;
} 
string[] stringArray = new string[] { "hello", "geekbrains", "world", ":)", "git" };
string [] resultArray = new string [100];
int countResult = GenerateNewArray (stringArray,resultArray);
Console.WriteLine ("Первоначальный массив:");
PrintArray (stringArray,stringArray.Length);
Console.WriteLine ("Новый массив:");
PrintArray (resultArray,countResult);

