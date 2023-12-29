using System.Runtime.CompilerServices;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Csharp!!");

// string firstName = "Deepali";
// int age = 24;
// decimal temp = 24.23m;
// string message = $"{firstName} is a good girl. she is {age} years old. The temperature is {temp} degree celsius.";
// Console.WriteLine(message);

//***********************************
// Random dice = new Random();
// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// int result = Random.Next();

// overloading
/*The first version of the Next() method doesn't set an upper and lower boundary, so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.

The second version of the Next() method specifies the maximum value as an upper boundary, so in this case, you can expect a random value between 0 and 100.

The third version of the Next() method specifies both the minimum and maximum values, so in this case, you can expect a random value between 50 and 100.*/

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(51, 59);

// Console.WriteLine($"First roll : {roll1}");
// Console.WriteLine($"Second roll : {roll2}");
// Console.WriteLine($"Third roll : {roll3}");

//Challenge

// int firstValue = 500;
// int secondValue = 600;
// int largest = Math.Max(firstValue, secondValue);

// Console.WriteLine(largest);

//*******************************

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// if (total > 14) {
//   Console.WriteLine("You Win!");
// }
// if (total < 15) {
//   Console.WriteLine("Sorry you Loose.");
// }
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }
// if ((roll1 == roll2) && (roll2 == roll3)) 
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// }
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");



// string message = "The quick brown fox jumps over the lazy dog";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox")) {
//   Console.WriteLine("What is fox doing?");
// }


//**************************************
//      if statements
//*************************************

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

//**************************************
//      if statements
//*************************************
// string[] orderIds = new string[3];

// orderIds[0] = "ABC";
// orderIds[1] = "KBC";
// orderIds[2] = "HIJ";

// // string[] orderIds = { "A123", "B456", "C789" };

// Console.WriteLine($"first: {orderIds[0]}");
// Console.WriteLine($"second: {orderIds[1]}");
// Console.WriteLine($"third: {orderIds[2]}");

// Console.WriteLine($"Total Numbers of Orders : {orderIds.Length}");

/*
string[] names = ["bob", "tom", "alpha"];
foreach(string name in names) {
Console.WriteLine(name);
}

//**************************************
//      Arrays foreach
//*************************************

int[] inventory = [34, 22, 55, 64, 23, 78];
int sum = 0;

foreach( int item in inventory) {
sum += item;
}

Console.WriteLine ($"we have {sum} items in inventory");



// Challenge

string[] orderIds = ["B123", "C234", "A345", "C15","B177", "G3003", "C235", "B179"];

foreach(string order in orderIds) {
if(order.StartsWith("B")) {
Console.WriteLine(order);
}
}
*/

//************************************
/*
This code reverses a message, counts the number of times 
a particular character appears, then prints the results
to the console window.


string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
if (letter == 'o')
{
    letterCount++;
}
}

string newMessage = new String(message);

Console.WriteLine("newMessage");
Console.WriteLine($"'o' appears {letterCount} times.");
*/

///////////////////////////////////////////////////////////////////
/////           Grading system Console App            /////////////
/*
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
// Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit");

foreach (string name in studentNames)
{
string currentStudent = name;

if (currentStudent == "Sophia")
   studentScores = sophiaScores;

else if (currentStudent == "Andrew")
    studentScores = andrewScores;

else if (currentStudent == "Emma")
    studentScores = emmaScores;

else if (currentStudent == "Logan")
    studentScores = loganScores;

// initialize/reset the sum of scored assignments
int sumAssignmentScores = 0;

// initialize/reset the calculated average of exam + extra credit scores
decimal currentStudentGrade = 0;

//
decimal overallGrade = 0;

//
decimal extraCredit = 0;

// initialize/reset a counter for the number of assignment 
int gradedAssignments = 0;

// loop through the scores array and complete calculations for currentStudent
foreach (int score in studentScores)
{
    // increment the assignment counter
    gradedAssignments += 1;

    if (gradedAssignments <= examAssignments)
        // add the exam score to the sum
        sumAssignmentScores += score;

    else
        // add the extra credit points to the sum - bonus points equal to 10% of an exam score
        sumAssignmentScores += score / 10;
}

currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

overallGrade = currentStudentGrade + (currentStudentGrade / 100 * 10) / examAssignments;

extraCredit = overallGrade - currentStudentGrade;

if (currentStudentGrade >= 97)
    currentStudentLetterGrade = "A+";

else if (currentStudentGrade >= 93)
    currentStudentLetterGrade = "A";

else if (currentStudentGrade >= 90)
    currentStudentLetterGrade = "A-";

else if (currentStudentGrade >= 87)
    currentStudentLetterGrade = "B+";

else if (currentStudentGrade >= 83)
    currentStudentLetterGrade = "B";

else if (currentStudentGrade >= 80)
    currentStudentLetterGrade = "B-";

else if (currentStudentGrade >= 77)
    currentStudentLetterGrade = "C+";

else if (currentStudentGrade >= 73)
    currentStudentLetterGrade = "C";

else if (currentStudentGrade >= 70)
    currentStudentLetterGrade = "C-";

else if (currentStudentGrade >= 67)
    currentStudentLetterGrade = "D+";

else if (currentStudentGrade >= 63)
    currentStudentLetterGrade = "D";

else if (currentStudentGrade >= 60)
    currentStudentLetterGrade = "D-";

else
    currentStudentLetterGrade = "F";

// Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{overallGrade}\t{currentStudentLetterGrade}\t{extraCredit}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
/////////////////////////////////////////////////////////////
*/

////////////////////////////////////////////////////////////

// Console.WriteLine("a" == "A");
// Console.WriteLine("a" == "a");
// Console.WriteLine(1 == 2);

// string myValue = "b";
// Console.WriteLine(myValue == "b");

// "Massaging" the data means that you perform some cleanup before you perform a comparison for equality.

// string value1 = " y";
// string value2 = "Y ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

////////////////////////////////////////////////////////////////

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////

// string pangram = "The quick brown fox jumps over the lazy dog";
// Console.WriteLine(pangram.Contains("fox"));

// Logical Negation or NOT operator

// Console.WriteLine(!pangram.Contains("cow"));

//////////////////////////////////////////////////////////

// int salesAmount = 1001;
// int discount = salesAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount : {discount}");

// Challange

// Random coin = new Random();

// int result = coin.Next(0,2);

// Console.WriteLine((result == 0) ? "heads" : "tails");

///////////////////////////////////////////////////////
//       Variable Scope

// int outerValue = 20;

// if(true) {
//     int innerValue = 10;
//     Console.WriteLine("local variable: " + innerValue);
//     Console.WriteLine("global variable: " +outerValue);
//     outerValue = outerValue + innerValue;
// }
// // Console.WriteLine("Outside the code block: " + innerValue);
// Console.WriteLine("after sum: "+ outerValue);

///////////////////////////////////////////////////////////

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// bool found = false;
// int total = 0;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//        found = true;
// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");

/////////////////////////////////////////////////////////////

// int day = 4;
// switch (day) 
// {
//   case 1:
//     Console.WriteLine("Monday");
//     break;
//   case 2:
//     Console.WriteLine("Tuesday");
//     break;
//   case 3:
//     Console.WriteLine("Wednesday");
//     break;
//   case 4:
//     Console.WriteLine("Thursday");
//     break;
//   case 5:
//     Console.WriteLine("Friday");
//     break;
//   case 6:
//     Console.WriteLine("Saturday");
//     break;
//   case 7:
//     Console.WriteLine("Sunday");
//     break;
// }

//////////////////////////////////////////////////////////
/*
// string stockKeepingUnit = "01-MN-L";
string stockKeepingUnit = "02-GH-M";

string[] product = stockKeepingUnit.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0]) {
case "01":
    type = "sweat shirt";
    break;
case "02":
    type = "T-Shirt";
    break;
case "03":
    type = "Sweet Potato";
    break;
default:
    type = "other";
    break;

}

switch(product[1]) {
case "BL": 
    color = "Black";
    break;
case "MN":
    color = "Maroon";
    break;
default:
    color = "White";
    break;
}

switch (product[2])
{
case "S":
    size = "Small";
    break;
case "M":
    size = "Medium";
    break;
case "L":
    size = "Large";
    break;
default:
    size = "One Size Fits All";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

///////////////////////////////////////////////////////////

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

//-challenge
for (int i = 1; i < 101; i++)
{

    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine(i + " fizzbuzz");
    }

    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

/////////////////////////////////////////////////

Random random = new Random();
int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

while (current != 7)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

//-Challange

int monster = 10;
int hero = 10;

Random attack = new Random();

do
{
    int attackPoints = attack.Next(1, 11);
    monster = monster - attackPoints;
    Console.WriteLine($"Monster was damaged and lost {attackPoints} health and now has {monster} health.");

    attackPoints = attack.Next(1, 11);
    hero = hero - attackPoints;
    Console.WriteLine($"Hero was damaged and lost {attackPoints} health and now has {hero} health.");
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

////////////////////////////////////////////////////////////////////////

String? readString;
readString = Console.ReadLine();
Console.WriteLine(readString);

sum of two numbers 
Console.WriteLine("Enter the first integer:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second integer:");
int num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;

Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");

/////////////////////////////////////////////////////////
//************ Guided Projects *************************
////////////////////////////////////////////////////////


// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    readResult = Console.ReadLine(); if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
        //  use a conditional statement below that only processes the valid entry values, so the do statement 
        //  is not required here. 
    }


    switch (menuSelection)
    {
        // case "1":
        //     // List all of our current pet information
        //     Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        //     Console.WriteLine("Press the Enter key to continue.");
        //     readResult = Console.ReadLine();
        //     break;

        // case "2":
        //     // Add a new animal friend to the ourAnimals array
        //     Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        //     Console.WriteLine("Press the Enter key to continue.");
        //     readResult = Console.ReadLine();
        //     break;
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;

                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            //Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            //Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            //Edit an animal’s age"
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            //Edit an animal’s personality description
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            //Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            //Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
    }

} while (menuSelection != "exit");



////////////////////////////////////////////////////////////////
//            Arrays in c#

//eg1:
string[] cars = { "volvo", "mercedies", "supra", "mustang" };

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

foreach (string car in cars)
{
    Console.WriteLine(car);
}

//eg2:
int[] numbers = [3, 6, 8, 4, 34, 6, 77, 89, 193];
Array.Sort(numbers);

foreach (int num in numbers)
{
    Console.Write(num + " ");
}

////////////////////////////////////////////////////////////////
//             Multidimentional Arrays in c#

//-syntax
int[,] arr2d = new int[2, 3];

int[,] arr2D = { { 1, 4, 2 }, { 3, 6, 8 }, { 8, 3, 2 } };

int[,,] arr3d1 = new int[1, 2, 2]{
                { { 1, 2}, { 3, 4} }
            };

Console.WriteLine(arr2D[0, 0]);
Console.WriteLine(arr2D[0, 1]);
Console.WriteLine(arr2D[1, 2]);

foreach (int num in arr2D)
{
    Console.WriteLine(num);
}

//print 2d array in matrix form
for (int i = 0; i < arr2D.GetLength(0); i++)
{
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        Console.Write(arr2D[i, j] + " ");
    }

    Console.WriteLine(" ");
}

////////////////////////////////////////////////////////////
//           Data Types in c#
/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//An unsigned type uses its bytes to represent only positive numbers. The remainder of the exercise introduces the unsigned integral types in C#.
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
*/
////////////////////////////////////////////////////////////
//     Data type casting and conversion

int first = 2;
string second = "4";

Console.WriteLine($"{first + second}");

// implict conversion / widening conversion : are handled by compiler
int num = 4;
decimal num2 = num;

Console.WriteLine(num2);


// explicit type conversion / narrowing conversion
decimal myDecimal = 3.14m;
int myInt = (int)myDecimal;

Console.WriteLine(myInt);

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

////////////////////////////////////
//  int to string conversions

int num1 = 3;
int num2 = 5;

string result = num1.ToString() + num2.ToString();
Console.WriteLine(result);

////////////////////////////////////
//  string to int conversion

string first = "3";
string second = "53";

int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

// using  convert class
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// () cast operator
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string[] values = { "My", "234", "Account", "242", "Balance", "733", "is" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message = {message}");
Console.WriteLine($"Total = {total}");

// challenge
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = value1 / (int)value2;
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// 1,
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2); // delete two elements of array statring from zero index
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// 2,
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);

Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

// Challenge to reverse each word of the string and display them
using System.ComponentModel;

string sentence = "The quick brown fox jumps over the lazy dog";

string[] words = sentence.Split(" ");
int length = words.Length;

// char[] charinWord = words[0].ToCharArray();
// Array.Reverse(charinWord);
// Console.WriteLine(words[0]);

for (int i = 0; i < length; i++)
{
    char[] charinWord = words[i].ToCharArray();
    Array.Reverse(charinWord);
    Console.Write(charinWord);
    Console.Write(" ");

}


//Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.

string first = "Hello";
string second = "World";

string result = string.Format("{0} {1}!", first, second);
string result2 = string.Format("{0} {0} {0}!", first, second);
string result3 = string.Format("{1} {0}", first, second);
Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);

// string interpolation

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// :C currency format specifier
decimal price = 112.346763m;
Console.WriteLine($"price of the package is {price:c}");
Console.WriteLine($"field length {price:N3}");
Console.WriteLine($"rate of intrest is {price:P}");


// eg: problem
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"         share: {productShares:N3}");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"  Total Billed: {total:C}");


// Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
// Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
// Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
// Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
// Methods that turn a string into an array of strings or characters (Split(), ToCharArray())

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadRight(12));

// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

////////////////////////////////////////////////////
// IndexOf() and Substring() method

// LastIndexOf() returns the last position of a character or string inside of another string.
// IndexOfAny() returns the first position of an array of char that occurs inside of another string.

string message = "find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine($"Opening position: {openingPosition}");
// Console.WriteLine($"Closing position: {closingPosition + 1} character");

openingPosition += 1;

int lengthOfSubstring = closingPosition - openingPosition;
string substring = message.Substring(openingPosition, lengthOfSubstring);

Console.WriteLine(substring);

// eg 2:

string message = "(What if) I am (only interested) in the (last set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));



////////////////////////////////////////////////////////////
//       remove() and replace()
//The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
//The Replace() method swaps all instances of a string with a new string.

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

//eg2:
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);


// challenge
// output: Quantity: 5000
//        < h2 > Widgets & reg;</ h2 >< span > 5000 </ span >

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// extract quantity
string openSpan = "<span>";
string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);

// replacing &trade with &reg
output = input.Replace("&trade", "&reg");

// removing div tags
const string openDiv = "<div>";
const string closeDiv = "</div>";

int divCloseStart = output.IndexOf(closeDiv);
int divOpenStart = output.IndexOf(openDiv);

output = output.Remove(divCloseStart, closeDiv.Length);
output = output.Remove(divOpenStart, openDiv.Length);

Console.WriteLine($" Quantity: {quantity}");
Console.WriteLine($" Output:   {output}");


///////////////////////////////////////////////////////
//               Guided project
///////////////////////////////////////////////////////

using System;

// ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// array used to store runtime data
string[,] ourAnimals = new string[maxPets, 7];

// sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "lion";
            suggestedDonation = "";

            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }

            Console.WriteLine("\r\nPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // #1 Display all dogs with a multiple search characteristics

            string dogCharacteristic = "";

            while (dogCharacteristic == "")
            {
                // #2 have user enter multiple comma separated characteristics to search for
                Console.WriteLine($"\r\nEnter one desired dog characteristic to search for");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                    Console.WriteLine();
                }
            }

            bool noMatchesDog = true;
            string dogDescription = "";

            // #4 update to "rotating" animation with countdown
            string[] searchingIcons = { ".  ", ".. ", "..." };

            // loop ourAnimals array to search for matching animals
            for (int i = 0; i < maxPets; i++)
            {

                if (ourAnimals[i, 1].Contains("dog"))
                {

                    // Search combined descriptions and report results
                    dogDescription = ourAnimals[i, 4] + "\r\n" + ourAnimals[i, 5];

                    for (int j = 5; j > -1; j--)
                    {
                        // #5 update "searching" message to show countdown 
                        foreach (string icon in searchingIcons)
                        {
                            Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {dogCharacteristic} {icon}");
                            Thread.Sleep(250);
                        }

                        Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                    }

                    // #3a iterate submitted characteristic terms and search description for each term

                    if (dogDescription.Contains(dogCharacteristic))
                    {
                        // #3b update message to reflect term 
                        // #3c set a flag "this dog" is a match
                        Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");

                        noMatchesDog = false;
                    }

                    // #3d if "this dog" is match write match message + dog description
                }
            }

            if (noMatchesDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        default:
            break;
    }

} while (menuSelection != "exit");

///////////////////////////////////////////////////////////////
///                    Methods in c#

void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{random.Next(1, 100)}");
    }

    Console.WriteLine();
}

Console.WriteLine("Generating Random Numbers");
DisplayRandomNumbers();


//eg:
int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

void DisplayTimes()
{
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}



void AdjustTimes()
{
    //  Adjust the times by adding the difference, keeping the value within 24 hours
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    //  Adjust the times by adding the difference, keeping the value within 24 hours
    AdjustTimes();
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    // Adjust the times by adding the difference, keeping the value within 24 hours 
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");

DisplayTimes();

Console.WriteLine();


//-Problem: method to determine whether or not an IPv4 address is valid.

// if ipAddress consists of 4 numbers
// and
// if each ipAddress number has no leading zeroes
// and
// if each ipAddress number is in range 0 - 255

// then ipAddress is valid

// else ipAddress is invalid

// solution:
string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength()
{
    validLength = address.Length == 4;
};

void ValidateZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}

////////////////////////////////////////////////////////
//-eg:
Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++)
{
    Console.Write($"{text[i]} {fortune[i]} ");
}


/////////////////////////////////////////////////////////////////

Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

// TellFortune();
luck = random.Next(100);
TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}

///////////////////////////////////////////////////////////////
/

int[] schedule = { 800, 1200, 1600, 2000 };
DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

///////////////////////////////////////////////////////////

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

//////////////////////////////////////////////////////////////
///

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

Console.WriteLine($"Total: ${total}");

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

////////////////////////////////////////////////////

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}

////////////////////////////////////////////////////////
//  method to reverse a string 

string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

//////////////////////////////////////////////////////
///   Method to reverse word in sentence
///   
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

///////////////////////////////////////////////////////
//             return array from method
///////////////////////////////////////////////////////

int target = 30;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
    }
}

int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0, 0] : result;
}

///////////////////////////////////////////////////////
//             Guided projects
///////////////////////////////////////////////////////

// -There will be three visiting schools
//     - School A has six visiting groups (the default number)
//     - School B has three visiting groups
//     - School C has two visiting groups

// - For each visiting school, perform the following tasks
//     - Randomize the animals
//     - Assign the animals to the correct number of groups
//     - Print the school name
//     - Print the animal groups
using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group1 = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] groups)
{
    for (int i = 0; i < groups.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++)
        {
            Console.Write($"{groups[i, j]}  ");
        }
        Console.WriteLine();
    }
}

////////////////////////////////////////////////////////
///  challenge project
