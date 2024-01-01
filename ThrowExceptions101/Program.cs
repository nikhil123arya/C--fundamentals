// Prompt the user for the lower and upper bounds
// Console.Write("Enter the lower bound: ");
// int lowerBound = int.Parse(Console.ReadLine());

// Console.Write("Enter the upper bound: ");
// int upperBound = int.Parse(Console.ReadLine());

// decimal averageValue = 0;

// // Calculate the sum of the even numbers between the bounds
// averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

// // Display the value returned by AverageOfEvenNumbers in the console
// Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

// // Wait for user input
// Console.ReadLine();

// static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// {
//   int sum = 0;
//   int count = 0;
//   decimal average = 0;

//   for (int i = lowerBound; i <= upperBound; i++)
//   {
//     if (i % 2 == 0)
//     {
//       sum += i;
//       count++;
//     }
//   }

//   average = (decimal)sum / count;

//   return average;
// }

//-challenage
string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
  Workflow1(userEnteredValues);
  Console.WriteLine("'Workflow1' completed successfully.");

}
catch (DivideByZeroException ex)
{
  Console.WriteLine("An error occurred during 'Workflow1'.");
  Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
  foreach (string[] userEntries in userEnteredValues)
  {
    try
    {
      Process1(userEntries);
      Console.WriteLine("'Process1' completed successfully.");
      Console.WriteLine();
    }
    catch (FormatException ex)
    {
      Console.WriteLine("'Process1' encountered an issue, process aborted.");
      Console.WriteLine(ex.Message);
      Console.WriteLine();
    }
  }
}

static void Process1(String[] userEntries)
{
  int valueEntered;

  foreach (string userValue in userEntries)
  {
    bool integerFormat = int.TryParse(userValue, out valueEntered);

    if (integerFormat == true)
    {
      if (valueEntered != 0)
      {
        checked
        {
          int calculatedValue = 4 / valueEntered;
        }
      }
      else
      {
        throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
      }
    }
    else
    {
      throw new FormatException("Invalid data. User input values must be valid integers.");
    }
  }
}