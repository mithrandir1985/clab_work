Console.WriteLine("Welcome to this Console Application");
Console.WriteLine("This Console app test if a number is Prime or Composite");

int num;
int counter = 0;
int choice = 0;
do
{
    Console.WriteLine("Please enter the number");
    num = Convert.ToInt32(Console.ReadLine());
    while (num <= 0 || num == 1)
    {
        if (num == 0)
            Console.WriteLine("Please enter a positive number");
        else if (num == 1)
            Console.WriteLine("1 is neither Prime nor Negative");
        else
            Console.WriteLine("Please enter a positive number");
        Console.WriteLine("Please re-enter the number");
        num = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 2; i < num / 2; i++)
    {
        if (num % i == 0)
            counter++;
    }
    if (counter == 0)
        Console.WriteLine("Prime");
    else
        Console.WriteLine("composite");
    Console.WriteLine("If you want to continue press 1");
    choice = Convert.ToInt32(Console.ReadLine());
} while (choice == 1);
