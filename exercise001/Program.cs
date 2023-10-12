// exercise 5
// N -> zelie chisla ot -N do N

System.Console.Write("Vvedite chislo: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int i = -number;

while (i<= number)
{
    System.Console.Write(i+ "");
    i++;
}
