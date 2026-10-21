/*
* Name: Chris Lehman
* Course: CSCI 1250, Section 002
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
int choice = 0;

// do while: this do while runs the entire program while choice is between 1 and 4, when someone enters 5, the program ends
do
{
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All Three");
System.Console.WriteLine("5. Quit");
System.Console.Write("Choose 1 through 5: ");
choice = Convert.ToInt32(Console.ReadLine());
// while: this while loop ensures that numbers less than 1 and greater than 5 aren't entered and won't continue until a valid answer is entered
while (choice > 5 || choice < 0)
{
        System.Console.WriteLine("Choose a number from 1 to 5.");
}
if (choice == 1 || choice == 4)
{
    // exercise 1
        int score = 0;
        System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        System.Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());
        // while: this is a while loop because an if statement reads top to bottom and accepts the first useable statement, a while loop tells you to get good before it can run
        while (score > 100 || score < 0)
        {
            System.Console.WriteLine("A score must be between 0 and 100.");
            score = 0;
            System.Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());
        }
        if (score < 60)
        {
            System.Console.WriteLine(score + " earns an F.");
        }
        else if (score >= 60 && score < 70)
        {
            System.Console.WriteLine(score + " earns a D.");
        }
        else if (score >= 70 && score < 80)
        {
            System.Console.WriteLine(score + " earns a C.");
        }
        else if (score >= 80 && score < 90)
        {
            System.Console.WriteLine(score + " earns a B.");
        }
        else if (score >= 90)
        {
            System.Console.WriteLine(score + " earns an A.");
        }
}

if (choice == 2 || choice == 4)
{
    // exercise 2
}

if (choice == 3 || choice == 4)
{
    // exercise 3
}
} while (choice != 5);

System.Console.WriteLine("Goodbye.");