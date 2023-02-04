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
// void Poly(int number)
// {
//     int newnumber = (number%10*10000 + number/10%10*1000+number/100%10*100+number/1000%10*10+number/10000);
//     if (number == newnumber) Console.WriteLine("Yes, it is palindrome");
//     else Console.WriteLine("No, it is random number");
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Poly(number);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double result(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double lenth = Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB-yA),2) + Math.Pow((zB-zA),2));
    return lenth;
}
Console.Write("Input xA ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB ");
double zB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Round(result(xA,yA,zA,xB,yB,zB),2));



