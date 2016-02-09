using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods
{
    class Program
    {
        //Take user’s name, phone number to save for later
        static string [] UserInfo (string name, string phoneNumber)
        {
            string[] userName = new string[2] { name, phoneNumber };

            return userName;
        }

        //UserInfo using a dictionary
        static Dictionary<string, string> UserInfo2 (string name, string phoneNumber)
        {
            Dictionary<string, string> userInfo = new Dictionary<string, string>();

            userInfo.Add(name, phoneNumber);

            return userInfo;
        }

        //goes through string array and prints one element per line
        static void PrintArray (string [] array)
        {
            foreach (string word in array)
            {
                Console.WriteLine(word);
            }
        }

        //print characters from family guy one per line
        static void FamilyGuy()
        {
            string[] familyGuy = { "Stewie", "Meg", "Brian", "Lois", "Peter", "Chris" }; //character names

            PrintArray(familyGuy); //uses the above method to print the family guy characters 
        }

        //take 3 grades for 2 students return who has a better average and what it was
        public static void TopStudent ()
        {
            //user inputs, takes name and grades separately, enter grades separated by a space
            Console.WriteLine("Enter a name for the first student:");
            string student1 = Console.ReadLine();

            Console.WriteLine("Enter the grades of the student separated by spaces:");
            string grades1 = Console.ReadLine();

            Console.WriteLine("Enter a name for the second student:");
            string student2 = Console.ReadLine();

            Console.WriteLine("Enter the grades of the second student separated by spaces:");
            string grades2 = Console.ReadLine();

            double avg1;
            double avg2;
            double sum1 = 0;
            double sum2 = 0;

            string[] grades1array = grades1.Split(' '); //split the string input into arrays
            string[] grades2array = grades2.Split(' ');

            foreach (var grade in grades1array) //adds up the grades
            {
                sum1 += int.Parse(grade); 
            }

            foreach (var grade in grades2array)
            {
                sum2 += int.Parse(grade);
            }

            avg1 = sum1 / grades1array.Length; //gets average of the grades
            avg2 = sum2 / grades2array.Length;

            //prints the top student info
            if (avg1 > avg2)
            {
                Console.WriteLine(student1 + " has the highest average grade of " + avg1 + ".");
            }
            else if (avg1 == avg2)
            {
                Console.WriteLine(student1 + " and " + student2 + " have equal averages of " + avg1 + ".");
            }
            else
            {
                Console.WriteLine(student2 + " has the highest average grade of " + avg2 +".");
            }
        }

        //takes string, returns (1 per line) alphabetized list of all words
        public static void AlphaSplitter (string splitter)
        {
            List<string> alpha = new List<string>();

            string[] array = splitter.Split(' '); //splits the input string into an array

            for (int i = 0; i < array.Length; i++) //adds each array element into a list for easy sorting
            {
                alpha.Add(array[i]);
            }

            alpha.Sort(); //sorts the list

            foreach(string word in alpha) //prints each item from the list
            {
                Console.WriteLine(word);
            }
        }

        // prints alphabet
        static void PrintAlpha() //prints the lowercase alphabet
        {
            for (int i = 65; i < 91; i--) //uses ASCII integral values for the chars to print the lowercase letters in ascending order
            {
                Console.WriteLine((char)i);
            }
        }

        //
        static void SobrietyTest ()
        {
            for (int i = 90; i > 64; i--) //uses ASCII integral values for the chars to print the uppercase alphabet 
            {
                Console.WriteLine((char)i);
            }
        }

        //takes info and prints into a coherent sentence
        static void NameAgeState ()
        {
            //user inputs
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Enter your state: ");
            string state = Console.ReadLine();

            Console.WriteLine("Hi there, " + name + ". You are " + age + " years old and live in " + state + ".");
        }

        //take a double, return area of circle
        public static double CircleAreaFromRadius (double radius)
        {
            double area = Math.PI * radius * radius; //circle area = pi * r^2
            return area;
        }

        //diameter method for circle area
        public static double CircleAreaFromDiameter (double diameter)
        {
            double radius = diameter / 2;
            double area = Math.PI * radius * radius;
            return area;
        }

        //takes first and last name separately, validates it for just letters. If valid, print them together, if not valid, ask again
        public static void ValidName()
        {
            while (true) //keeps the program running to wait for valid input
            {
                Console.WriteLine("Enter your first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();

                string checker = @"^[a-zA-Z]+[^\d]$"; //regex to check the names

                Match result = Regex.Match(firstName, checker); //checks first and last name separately
                Match result2 = Regex.Match(lastName, checker);

                if (result.Success && result2.Success) //both have to succeed to print the name
                {
                    Console.WriteLine(firstName + " " + lastName);
                    break;
                }
                else
                {
                    continue; //restarts if it doesnt succeed
                }
            }
        }
            //take user input, validate for just numbers, return int
           public static int NumberCheck()
        {
            Console.WriteLine("Enter a string to check for just numbers: ");
            string checky = Console.ReadLine();

            string pattern = @"^[\d]+$"; //regex to check for just numbers

            Match result = Regex.Match(checky, pattern);

            if (result.Success)
            {
                return int.Parse(checky); //since the author wanted an int, I just parsed the string into an int if the regex succceded and returned that
            }
            else
            {
                return -1; //returns negative one if it's not a number
            }
        }
        //calculate how many teeth you’ve lost to date, 4 years passing means you lost one tooth
        static void LostMyTeeth ()
        {
            Console.WriteLine("Enter your age in years: ");
            int age = int.Parse(Console.ReadLine());

           if (age >= 0 && age < 5)
            {
                Console.WriteLine("You have lost 0 teeth!");
            }
           else if (age >= 5 && age < 10)
            {
                Console.WriteLine("You have lost 5 teeth!");
            }
           else if (age >= 10 && age < 14)
            {
                Console.WriteLine("You have lost 20 teeth!");
            }
           else if (age >= 14 && age <50)
            {
                Console.WriteLine("You have lost 20 teeth and had about 40 fillings.");
            }
           else if (age >= 50 && age < 60)
            {
                Console.WriteLine("You have lost 25 teeth.");
            }
           else if (age >= 60 && age < 70)
            {
                Console.WriteLine("You have lost 30 teeth.");
            }
           else if (age >= 70 && age < 80)
            {
                Console.WriteLine("You have lost 40 teeth!");
            }
           else if (age >= 80 && age < 90)
            {
                Console.WriteLine("You have lost 50 teeth!");
            }
           else if (age >= 90)
            {
                Console.WriteLine("You have finally lost all of your teeth! IT'S DENTURE TIME BABY!");
            }
            else
            {
                Console.WriteLine("Call the dentist already.");
            }
        }

        
        static void FINALCOUNTDOWN ()
        {
            Console.WriteLine("Enter the number of days, hours, minutes, and seconds you want to countdown");
            Console.WriteLine("Enter the number of days: ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of hours:");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = seconds + (minutes * 60) + (hours * 3600) + (day * 86400);

            int dayCounter = day;
            int hourCounter = hours;
            int minCounter = minutes;
            int secondCounter = seconds; 
                
            for (int i = totalSeconds; i > 0; i--) //outer for loop runs for the total number of seconds
            {
                secondCounter--; //decrements the seconds counter each time
                if (secondCounter == -1)//only when second counter has hit 0, the next loop (where secondCounter would be -1) then it tries to decrement from minutes, etc
                {
                    if (minCounter > 0) //if there are minutes to subtract, it uses them to reset the seconds counter and decrements minutes by one
                    {
                        minCounter--;
                        secondCounter = 59;
                    }
                    else
                    {
                        if (hourCounter > 0) //if there are hours left to use, it resets the min and second counter and decrements hours by one, only checks days if there arent any hours left.
                        {
                            hourCounter--;
                            minCounter = 59;
                            secondCounter = 59;
                        }
                        else
                        {
                            if (dayCounter > 0) // if there are days left to subtract from, it resets all the counters to max - 1 
                            {
                                secondCounter = 59;
                                minCounter = 59;
                                hourCounter = 23;
                                dayCounter--;
                            }
                        }
                    }
                }
                if (minCounter == 0 && secondCounter == 0 && hourCounter == 0 && dayCounter == 0) //if all are 0, the counter is over
                {
                    Console.WriteLine("We're leaving together,\nBut still it's farewell.\nAnd maybe we'll come back\nTo earth, who can tell ?\nI guess there is no one to blame\nWe're leaving ground (leaving ground)\nWill things ever be the same again ?\n\nIt's the final countdown.\nThe final countdown\n\n\n");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("**guitaring intensifies**\n\n");
                    System.Threading.Thread.Sleep(1500);
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=9jK-NcRmVcw"); //opens a default brownser with the link running, http://stackoverflow.com/questions/4580263/how-to-open-in-default-browser-in-c-sharp
                    break;
                }
                Console.WriteLine();
                Console.WriteLine(dayCounter + ":" + hourCounter + ":" + minCounter +":" + secondCounter); //actually prints out each time
                System.Threading.Thread.Sleep(1000); // makes it count in real time 1000ms = 1 sec
                Console.Clear(); //clears the console
            }
        }

        //takes int, scales house picture based on int

        public static void BuildHouse (int scale) //right now this only works perfectly for a scale of 10
        {
            //modified this first for loop to print the roof from the asterisk pyramid in chapter 12 of the book
            for (int row = 1; row < (scale/2) + 1; row++)
            {
                for (int space = 5 - row; space > 0; space--)
                {
                    Console.Write(" "); 
                }
                for (int column = 1; column < (row * 2) +1; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //prints the walls of the house
            for (int k = 0; k < scale; k++) //outer loop controls the lines, inner loop controls printing the characters to build the house
            {
                for (int j = 0; j < scale; j++)
                {
                    if (j == 0) //when its the first index, print a bar
                    {
                        Console.Write("|");
                    }
                    else if (j > 0 && j < scale - 1) //checks to make sure it's not the first or last index
                    {
                        Console.Write(" "); //all intermediate indicies print a space
                    }
                    else if (j == scale - 1) //if its the last index, print a bar
                    {
                        Console.Write("|");
                    }
                }
                if (k < scale - 1) //once all the characters have been printed based on the scale, it makes a new line
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            //prints the floor of the house
            for (int i = 0; i < scale; i++)
            {
                Console.Write("="); //prints one floor tile per item in space
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            string phoneNumber = Console.ReadLine();

            string [] userName = UserInfo(name, phoneNumber);

            string[] familyGuy = { "Stewie", "Meg", "Brian", "Lois", "Peter", "Chris" };

            PrintArray(familyGuy);

            TopStudent();
            
            string alphasplitter = "cats dogs ice-cream donuts monkeys birds";
            AlphaSplitter(alphasplitter);

            SobrietyTest();
            NameAgeState();
            
            ValidName();
            */
            //FINALCOUNTDOWN();
            

            BuildHouse(15);
        }
    }
}
