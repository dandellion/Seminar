Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
int number1 = int.Parse(numberStr1);
Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
int number2 = int.Parse(numberStr2);
Console.WriteLine("Введите третье число");
string numberStr3 = Console.ReadLine();
int number3 = int.Parse(numberStr3);
int max1 = 0;
if (number1>number2)
     max1=number1;
else  max1 = number2;

if (max1>number3)
    Console.WriteLine("Максимальное число {0}",max1);
else Console.WriteLine("Максимальное число {0}",number3);