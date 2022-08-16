using lab3;
{
    Console.WriteLine("WELCOME");
    Console.WriteLine("Click the number that preceedes your desired operation");
    Console.WriteLine("1. Circle Area");
    Console.WriteLine("2. Square Area");
    double choice;
    choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Circle c = new Circle();
        Console.WriteLine("Please enter the radius");
        c.radius = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the circle is: " + c.calculatearea());
        Console.WriteLine("The perimeter of the circle is: " + c.calculateperimeter());
    }
    else if (choice == 2)
    {
        Square s = new Square();
        Console.WriteLine("Please enter the length of the side");
        s.length = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the square is: " + s.calculatearea());
        Console.WriteLine("The perimeter of the square is: " + s.calculateperimeter());
    }
    else
        Console.WriteLine("Please choose the write number");
}