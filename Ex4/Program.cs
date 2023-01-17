Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num2 = num*-1;
while (num2 <= num) 
{
    Console.Write(num2+", ");
    num2++;
}

