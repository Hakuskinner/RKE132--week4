
Random rnd = new Random();
int myRandomNum;
int randomsum = 0;
for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomsum = myRandomNum + randomsum;
    Console.WriteLine($"My random number is {myRandomNum}");
}
Console.WriteLine($"Random number sum = {randomsum}");