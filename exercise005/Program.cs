// exercise 15

System.Console.Write("Vvedite chislo: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 ==0 && number % 23 ==0)
{
    System.Console.WriteLine("Chislo kratno 7 i 23");
}
else
{
    System.Console.WriteLine("Chislo ne kratno 7 i 23");
}