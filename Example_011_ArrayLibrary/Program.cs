void FillArray(int[] collection)//FillArray наименование метода, в качестве аргумента здесь будет приниматься коллекция, м ы его так назвали
{
    int length = collection.Length; //находим длину массива
    int index = 0; // берём позицию и по умолчанию она будет начинаться с нуля
    while (index < length)//пока индекс меньше длины, будем что-то делать
    {
        collection[index] = new Random().Next(1, 10);// обращаемся к аргументу коллекшн на позицию индекс и положить туда новое  случайное целое число из диапозона от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)//метод, который будет печатать массив
{
    int count = col.Length;
    int position = 0; // переменная вместо индекс
    while(position<count)
    {
        Console.WriteLine(col[position]);//выводит на экран значение текущего элемента
        position++;
    }
}

int IndexOf(int[] collection, int find)
    {
        int count = collection.Length;
        int index = 0;
        int position = 0;

        while (index<count)
        {
            if(collection[index] == find)
            {
                position = index;
            }
            index++;
        }
        return position;
    }

int [] array = new int [10]; // создаем массив, в котором юудет 10 элементов. По умолчанию он будет занят нулями

FillArray (array);
PrintArray(array);
Console.WriteLine(); // вывод просто пустой строки

int pos = IndexOf(array, 4); //определим переменную поз и в неё положим результат работы метода индексОф, в качестве аргумента будет передаваться массив и будем искать 4
Console.WriteLine(pos);