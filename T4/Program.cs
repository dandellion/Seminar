string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

for (int i = 2; i <= number; i+=2)
    Console.Write(" {0}",i);
