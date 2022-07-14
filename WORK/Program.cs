/*
Задача: 
Написать программу, 
которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиотуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры :

["hello","2","world",":-)"]->["2",":-)"]
["1234","1567","-2","computer science"]->["-2"]
["Russia","Denmark","Kazan"]->[]
*/

void FindТheЕlementsАrray(string[] arrayToFind, string[] ResArray)
{
    int count = 0;
    for (var i = 0; i < arrayToFind.Length; i++)
    {
        if (arrayToFind[i].Length < 4)
        {
            ResArray[count] = arrayToFind[i];
            count++;
        }
    }
}

void PrintArray(string[] arrayToPrint)
{
    System.Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write('\u0022' + arrayToPrint[i] + '\u0022');
        if (i < arrayToPrint.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
}

int FindSizeResultАrray(string[] arrayFindSize)
{
    int count = 0;
    for (var i = 0; i < arrayFindSize.Length; i++)
    {

        if (arrayFindSize[i].Length < 4)
        {
            count++;
        }
    }
    return count;
}

string[] initialArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
int sizeResultArray = FindSizeResultАrray(initialArray);
string[] resultArray = new string[sizeResultArray];
PrintArray(initialArray);
System.Console.Write(" -> ");
FindТheЕlementsАrray(initialArray, resultArray);
PrintArray(resultArray);

