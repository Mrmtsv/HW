Console.WriteLine("Введите цифру, обозначающую день недели");
int digit = Convert.ToInt32(Console.ReadLine());

if ((digit > 0) & (digit < 6))
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}