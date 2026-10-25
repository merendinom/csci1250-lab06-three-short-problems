/*
 * Name:        Michael Merendino
 * Course:      CSCI 1250, Section 001
 * Assignment:  Lab 06, Three Short Problems
 * Date:        October 21, 2026
 * Description: A menu that keeps running until the user quits, offering three
 *              independent exercises or all three at once. Each exercise
 *              practices decisions and one of the four loops.
 */


int choice = 0;

Random rng = new Random(4000);

do
{
    choice = 0;

    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All Three");
    System.Console.WriteLine("5. Quit");

    while (choice < 1 || choice > 5)
    {
        System.Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32(Console.ReadLine());
    
        if (choice < 1 || choice > 5)
        {
            System.Console.WriteLine("Choose a number from 1 to 5. ");
        }
        
    }
System.Console.WriteLine();
        if (choice == 1 || choice == 4)
        {
            // Exercise 1
            System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");

            int score = -1;


            //While: We dont know how many wrong scores the users will input
            while (score < 0 || score > 100)
            {
                System.Console.WriteLine("Score: ");
                score = Convert.ToInt32(Console.ReadLine());


                if (score < 0 || score > 100)
                {
                 System.Console.WriteLine("A score must be between 0 and 100.");
                }
            }
                if (score >= 90)
                {
                   System.Console.WriteLine($"{score} earns an A."); 
                }
                else if (score >= 80)
                {
                    System.Console.WriteLine($"{score} earns a B.");
                }
                else if (score >= 70)
                {
                  System.Console.WriteLine($"{score} earns a C.");  
                }
                else if (score >= 60)
                {
                    System.Console.WriteLine($"{score} earns a D.");
                }
                else
                {
                  System.Console.WriteLine($"{score} earns an F.");  
                }
        }

System.Console.WriteLine();
        if (choice == 2 || choice == 4)
        {
            // Exercise 2
            System.Console.WriteLine("=== Exercise 2: The Dice Table ====");
            int rollCount = 0;
            int winCount = 0;
            string? answer;


            //The menu must show first and at least on roll must happen 
            do
            {
                int die1 = rng.Next(1,7);
                int die2 = rng.Next(1,7);
                
                int total = die1 + die2;

                rollCount++;
                System.Console.WriteLine($"Roll {rollCount}: {die1} and {die2}, total {total}");

                if (die1 == 1 && die2 == 1)
                {
                    System.Console.WriteLine("Snake eyes.");
                }

                else if (die1 == die2)
                {
                    System.Console.WriteLine("doubles!");
                }

                else if (total == 7 || total == 11)
                {
                    System.Console.WriteLine("A winner!");
                    winCount++;
                }

                else
                {
                    System.Console.WriteLine();
                }

                if (total == 7 || total == 11)
                {
                    winCount++;
                }
                
                System.Console.WriteLine("Roll again? (y/n): ");
                answer = Console.ReadLine();


            } while (answer == "y");
            System.Console.WriteLine($"You rolled {rollCount} times and won {winCount}.");
        }

System.Console.WriteLine();
        if (choice == 3 || choice == 4)
        {
            // Exercise 3
            System.Console.WriteLine("=== Exercise 3: The Score Report ===");

            int[] scores = new int[5];

            //for: this is used to get the sore numbers
            for (int i = 0; i < scores.Length; i++)
            {
                System.Console.WriteLine($"Score {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            int highest = scores[0];
            int passing = 0;


            //gives us eery alue but no position and we need eey value
            foreach (int score in scores)
            {
               total += score;

               if (score > highest)
                {
                    highest = score;
                }
                if (score >= 60)
                {
                    passing++;
                }
            }

            double average = (double)total / scores.Length;

            System.Console.WriteLine($"Scores entered: {scores.Length}");
            System.Console.WriteLine($"Total: {total}");
            System.Console.WriteLine($"Average: {average:F1}");
            System.Console.WriteLine($"Highest: {highest}");
            System.Console.WriteLine($"Passing: {passing} of {scores.Length}");

        }


} while (choice != 5);

System.Console.WriteLine("Goodbye.");


 



