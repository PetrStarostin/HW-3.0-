int SecondNumber(int num)
{
int result = num / 10 % 10 ;
return result ;
}
int number =  new Random().Next(100,1000);
Console.WriteLine($"Число: {number}");
Console.WriteLine($"Второе число: {SecondNumber(number)}");


