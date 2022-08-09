int [] array = {1, 22, 3, 65, 4, 32, 11, 31};

int n = array.Length; // возвращает длину массива
int find = 31; // ищем индекс числа 4

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // Остановка поиска, если есть одинаковые числа. Теперь ищется только первый элемент 
    }
    index++; //index = index + 1
}