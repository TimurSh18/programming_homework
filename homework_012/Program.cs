// // 12. Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное число -> {number}");

// Находим последнюю цифру числа
int lastDigit = number % 10;

//Находим первую цифру числа 
int firstDigit = number / 100;

//Выводим первоначальное число без второй цифры 
int result = firstDigit*10 + lastDigit;
Console.WriteLine($"Число после удаления второй цифры -> {result}");