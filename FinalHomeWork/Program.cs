// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
 //Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 //При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//["привет", "2", "мир", ":-)"] -> ["2", ":-)"]
//["1234", "1567", "-2", " информатика"] -> ["-2"]
//["Россия", "Дания", "Казань"] -> []


Console.Clear();

Console.Write("Введите данные через пробел: ");
string arr = Console.ReadLine();
string[] array = arr.Split(' ');
string[] result = Min(array, 3);

int n = 3;

string[] Min(string[] array, int n) 
{
    string[] result = new string[Count(array, n)];
    for(int i = 0, j = 0; i < array.Length; i++) 
    {
        if(array[i].Length <= n) 
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}
int Count(string[] array, int n) 
{
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i].Length <= n) 
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");