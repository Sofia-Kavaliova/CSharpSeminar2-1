// exercise 17

Console.Write("Vvedite pervoe chislo: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite vtoroe chislo: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue == secondValue * secondValue || secondValue == firstValue * firstValue)
{
    System.Console.WriteLine("Da");
}
else
{
    System.Console.WriteLine("Net");
}