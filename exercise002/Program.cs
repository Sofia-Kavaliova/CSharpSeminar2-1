// exercise001 
// 3-x znachnoe chislo -> poslednia zifra

System.Console.Write("Vvedite trehznachnoe chislo: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999 || number < 100)
{
    System.Console.WriteLine("Vi vveli ne trehznachnoe chislo!");
}
else
{
    System.Console.WriteLine(number%10);
}