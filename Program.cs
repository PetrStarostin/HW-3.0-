// Первое задание
// int SecondNumber(int num)
// {
// int result = num / 10 % 10 ;
// return result ;
// }
// int number =  new Random().Next(100,1000);
// Console.WriteLine($"Число: {number}");
// Console.WriteLine($"Второе число: {SecondNumber(number)}");

//Второе задание

// int ThirdNumber(int num)
// {
//     while(num > 999)
//     {
//         num = num / 10 ;
//     }
//     return num % 10 ;
// }
// bool IsThirdNumber(int num)
// {
//     if(num < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(IsThirdNumber(number))
//     Console.WriteLine($"Третье число: {ThirdNumber(number)}");