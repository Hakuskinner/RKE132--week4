Random rnd = new Random();
int cpuRandom;
bool loopActive = true;
while (loopActive) {
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess, enter your number");
    int usernumber = Int32.Parse(Console.ReadLine());
    if (usernumber == cpuRandom)
    {
        Console.WriteLine("Gongratulations! You won!");
            loopActive = false;
    }
    else
        Console.WriteLine("Oooops... Try again");
}
Console.WriteLine("Have a nice day!");
