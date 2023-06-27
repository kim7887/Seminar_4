// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetObj(string msg)
{
    Console.WriteLine(msg);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int SumOfDigits(int qNumber)
{
    int sum = 0;
    while(qNumber!=0)
    {
        sum += qNumber %10;
        qNumber /= 10;
    }
    return sum;
}
string ss = "Введите целое число!";
int newIntegerNewEraOfCode = GetObj(ss);
Console.WriteLine("ответ:"+SumOfDigits(newIntegerNewEraOfCode));