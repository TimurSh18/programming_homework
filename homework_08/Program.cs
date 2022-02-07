// Задача 8. Показать четные числа от 1 до N

Console.Write("Введите число до которого вы хотите посмотреть чётные числа: ");
string nStr = Console.ReadLine();


int n = int.Parse(nStr);

int even = 2;
while(even <= n)
{
   Console.WriteLine(even);
   even += 2;
}
 