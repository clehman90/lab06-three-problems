System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
int choice = 0;

do
{
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All Three");
System.Console.WriteLine("5. Quit");
System.Console.WriteLine("Choose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());
while (choice > 5 || choice < 0)
{
        System.Console.WriteLine("Choose a number from 1 to 5.");
}
if (choice == 1 || choice == 4)
{
    // exercise 1
        System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        while (score)
        {
            
        }
}

if (choice == 2 || choice == 4)
{
    // exercise 2
    do
        {
            
        } while ();
}

if (choice == 3 || choice == 4)
{
    // exercise 3
}
} while (choice != 5);

System.Console.WriteLine("Goodbye.");