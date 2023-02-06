//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (i != array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.Write($"{array[i]}.");
	}
	Console.WriteLine();
}

int CountChar(string[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3) count++;
	}
	return count;
}

string[] ResultArray(string[] array, int count)
{
	string[] result = new string[count];
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
		{
			result[result.Length - count] = array[i];
			count--;
		}
	}
	return result;
}

string[] array = { "hello", "2", "world", ":-)" };
int count = CountChar(array);
string[] result = ResultArray(array, count);
PrintArray(result);

string[] array2 = { "1234", "1567", "-2", "computer science" };
int count2 = CountChar(array2);
string[] result2 = ResultArray(array2, count2);
PrintArray(result2);

string[] array3 = { "Russia", "Denmark", "Kazan" };
int count3 = CountChar(array3);
string[] result3 = ResultArray(array3, count3);
PrintArray(result3);
Console.ReadLine();