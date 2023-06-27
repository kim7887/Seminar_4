// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetObj(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int func_new(int A, int B)
{
    int result = 1;
    while (B != 0)
    {
        result *= A;
        B--;
    }
    return result;
}


int input = GetObj("Введите чилсо");
int degree = GetObj("в какую степень хотите возвести?");
Console.WriteLine("ответ:"+func_new(input,  degree));
