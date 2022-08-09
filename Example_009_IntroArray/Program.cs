int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6  7   8
int [] array = {11, 21, 31, 41, 15, 61, 55, 1, 65};
array[0] = 12; // нулевому члену массива присвоить значение 12

Console.WriteLine (array[4]); //выводит на экран четвёртый элемент массива
