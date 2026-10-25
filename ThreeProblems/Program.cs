/*
* Name: Chris Lehman
* Course: CSCI 1250, Section 002
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System.Net.Sockets;
using System.Numerics;

System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
int choice = 0;
Random rng = new Random(4000);

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
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");
    int roll = 0;
    string rollAgain;
    int winners = 0;
    // this is a do while because it runs the code of rolling the dice as long as the user does not enter "n" to end it
    do
        {
            roll ++;
            int dice1 = rng.Next(1,7);
            int dice2 = rng.Next(1,7);
            System.Console.Write("Roll " + roll + ": " + dice1 + " and " + dice2 + ", " + "total " + (dice1 + dice2) + ". ");
            if (dice1 + dice2 == 7 || dice1 + dice2 == 11)
            {
             System.Console.WriteLine(" A winner.");
             winners++;
            }
            else if (dice1 == 2 && dice2 == 2 || dice1 == 3 && dice2 == 3 || dice1 == 4 && dice2 == 4 ||dice1 == 5 && dice2 == 5 ||dice1 == 6 && dice2 == 6)
            {
                System.Console.WriteLine(" Doubles!");
            }
            else if (dice1 == 1 && dice2 == 1)
            {
                System.Console.WriteLine(" Snake eyes.");
            }
            System.Console.Write("Roll again? (y/n): ");
            rollAgain = Console.ReadLine();
        } while (rollAgain != "n");
        System.Console.WriteLine("You rolled " + roll + " times and won " + winners + " times.");
}

if (choice == 3 || choice == 4)
{
    // exercise 3
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");
    int score = 0;
    int[] scores;
    scores = new int[5];
    int passing = 0;
    int highest = scores[0];
    // this is a for loop because it runs this code for each value in the array
    for (int i = 0; score < scores.Length; i++)
        {
            System.Console.Write("Score " + score + ": ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
            score++;
        }
        // similar to the previous loop, this foreach looks at each value in the array although it doesn't need an array
    foreach (int value in scores)
        {
            if (score >= 60)
            {
                passing++;
            }
            highest = Math.Max(highest, Convert.ToByte(scores));
        }
        int total = scores[0] + scores[1] + scores[2] + scores[3] + scores[4];
        double average = total / scores.Length;
        System.Console.WriteLine("Scores entered: " + scores.Length);
        System.Console.WriteLine("Total: " + total);
        System.Console.WriteLine("Average: " + average.ToString("F1"));
        System.Console.WriteLine($"Highest: {highest}");
        System.Console.WriteLine($"Passing: {passing} of {scores.Length}");
        }
} while (choice != 5);

System.Console.WriteLine("Goodbye.");