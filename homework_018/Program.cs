// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// ⋀ - и; V - или; ¬ - не(инверсия)
// Расшифровка для удобства => НЕ(х ИЛИ у) = НЕ х И НЕ y
// 0 - false ; 1 - true
// Если ¬(X ⋁ Y) = 1, тогда x = 0, y = 0 или х = 1, y = 1
// Если ¬(X ⋁ Y) = 0, тогда x = 1, y = 0 или х = 0, y = 1
// Если ¬X ⋀ ¬Y = 1, тогда х = 0, y = 0 или x = 1, y = 1
// Если ¬X ⋀ ¬Y = 0, тогда х = 1, y = 0 или x = 0, y = 1


bool x = true;
bool y = true;

Console.WriteLine("Таблица истинности: ");
Console.WriteLine("------------------------------------");

Console.WriteLine($"НЕ(X ИЛИ Y) = true, при x = {x} y = {y}");
Console.WriteLine($"НЕ Х И НЕ Y = true, при x = {x} y = {y}");
Console.WriteLine("НЕ Х И НЕ Y = НЕ(X ИЛИ Y)");


Console.WriteLine("------------------------------------");

x = false;
y = false;


Console.WriteLine($"НЕ(X ИЛИ Y) = true, при x = {x} y = {y}");
Console.WriteLine($"НЕ Х И НЕ Y = true, при x = {x} y = {y}");
Console.WriteLine("НЕ Х И НЕ Y = НЕ(X ИЛИ Y)");


Console.WriteLine("------------------------------------");

x = true;
y = false;

Console.WriteLine($"НЕ(X ИЛИ Y) = false, при x = {x} y = {y}");
Console.WriteLine($"НЕ Х И НЕ Y = false, при x = {x} y = {y}");
Console.WriteLine("НЕ Х И НЕ Y = НЕ(X ИЛИ Y)");

Console.WriteLine("------------------------------------");

x = false;
y = true;

Console.WriteLine($"НЕ(X ИЛИ Y) = false, при x = {x} y = {y}");
Console.WriteLine($"НЕ Х И НЕ Y = false, при x = {x} y = {y}");
Console.WriteLine("НЕ Х И НЕ Y = НЕ(X ИЛИ Y)");
