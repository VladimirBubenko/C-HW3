// HW 3
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Вариант 1: 
// bool Poly(int number)
// {
//     int newnumber = (number%10*10000 + number/10%10*1000+number/100%10*100+number/1000%10*10+number/10000);
//     if (number == newnumber) return true;
//     else return false;
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Poly(number));

// Вариант 2:
void Poly(int number)
{
    int newnumber = (number%10*10000 + number/10%10*1000+number/100%10*100+number/1000%10*10+number/10000);
    if (number == newnumber) Console.WriteLine("Yes, it is palindrome");
    else Console.WriteLine("No, it is random number");
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Poly(number);

