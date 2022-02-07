// 10. Показать вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное число {number}");

// Находим первые две цифры в числе:
int result = number / 10;


// Находим вторую цифру из имеюшихся двух:
result = result % 10;
Console.WriteLine($"Вторая цифра сгенерированного числа -> {result}");