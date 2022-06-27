Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
int number1 = int.Parse(numberStr1);
Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
int number2 = int.Parse(numberStr2);
if (number1==number2)
    Console.WriteLine("Числа равны");
else if (number1>number2)
    Console.WriteLine("Максимальное число {0}",number1);
else
    Console.WriteLine("Максимальное число {0}",number2);