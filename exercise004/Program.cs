// exercise 13

System.Console.Write("vvedite pervoe chislo: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Vvedite vtoroe chislo: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue % secondValue ==0)
{
    System.Console.WriteLine("Kratno");
}
else
{
    System.Console.WriteLine("Ne kratno, ostatok "+firstValue % secondValue);
}