// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB)
{
Console.WriteLine($"Число {numberB} большее, а {numberA} - меньшее");
}
if (numberB < numberA)
{
Console.WriteLine($"Число {numberA} большее, а {numberB} - меньшее");
}
if (numberB == numberA)
{
Console.WriteLine($"Числа {numberA} и {numberB} равны");
}