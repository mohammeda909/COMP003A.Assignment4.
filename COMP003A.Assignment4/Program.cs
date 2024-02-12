// Author: mohammed ali
// Course: COMP003AL01
// Purpose: loop statemnts

Console.WriteLine("Right Triangle:");
Console.Write("Enter a positive whole number: ");
int limit = int.Parse(Console.ReadLine());
string output = "#";
for (int i = 0; i < limit; i++)
{
    Console.WriteLine(output);
    output += "#";
}

// For Each Section 
Console.WriteLine("\nFriends:");
string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
foreach (string friend in friends)
{
    Console.WriteLine(friend);
}

// Do-While Loop Section 
Console.WriteLine("\nCounting by 5s:");
int counter = 0;
do
{
    Console.WriteLine(counter);
    counter += 5;
} while (counter <= 50);

// While Loop Section 
Console.WriteLine("\nFooBar:");
int counter2 = 1;
while (counter2 <= 20)
{
    if (counter2 % 2 == 0 && counter2 % 5 == 0)
    {
        Console.WriteLine("FooBar");
    }
    else if (counter2 % 2 == 0)
    {
        Console.WriteLine("Foo");
    }
    else if (counter2 % 5 == 0)
    {
        Console.WriteLine("Bar");
    }
    else
    {
        Console.WriteLine(counter2);
    }
    counter2++;
}
