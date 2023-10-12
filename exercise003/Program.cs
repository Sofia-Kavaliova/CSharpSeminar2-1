// exercise 11
// Sluchainoetrehznachnoe chislo, udalit vtoruu zifru

int randomNumber = new Random().Next(100,1000);
System.Console.WriteLine(randomNumber);
int leftNumber = randomNumber/100;
int rightNumber = randomNumber%10;

int res = leftNumber * 10 + rightNumber;
System.Console.WriteLine(res);