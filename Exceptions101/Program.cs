// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// try
// {
//   Console.WriteLine(float1 / float2);
//   Console.WriteLine(number1 / number2);
// }
// catch
// {
//   Console.WriteLine("An exception has been caught");
// }

// eg2:
/*
try
{
  Process1();
}
catch
{
  Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

// static void Process1()
// {
//   try
//   {
//     WriteMessage();
//   }
//   catch
//   {
//     Console.WriteLine("Exception is handled in process 1");
//   }
// }
//Access the properties of an exception object
static void Process1()
{
  try
  {
    WriteMessage();
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Exception caught in Process1: {ex.Message}");
  }
}

static void WriteMessage()
{
  double float1 = 3000.0;
  double float2 = 0.0;
  int number1 = 3000;
  int number2 = 0;

  Console.WriteLine(float1 / float2);
  Console.WriteLine(number1 / number2);
}
//-Notice that your updated catch clause is catching an instance of the Exception class in an object named ex. Also notice that your Console.WriteLine() method is using ex to access the object's Message property and display the error message to the console.
*/
/////////////////////////////////////////////////////
///      Catch multiple exceptions in a code block
///     
//-Start debuguging
//-When the first exception occurs, control is passed to the first catch clause that can handle the exception. The code that would generate the second exception is never reached. This means that some of your code is never executed. This could lead to serious issues.

// try
// {
//   Process1();
// }
// catch
// {
//   Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");


// static void Process1()
// {
//   try
//   {
//     WriteMessage();
//   }
//   catch (Exception ex)
//   {
//     Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//   }
// }

// static void WriteMessage()
// {
//   double float1 = 3000.0;
//   double float2 = 0.0;
//   int number1 = 3000;
//   int number2 = 0;
//   byte smallNumber;

//   Console.WriteLine(float1 / float2);
//   Console.WriteLine(number1 / number2);
//   checked
//   {
//     smallNumber = (byte)number1;
//   }
// }

/////////////////////////////////////////////////
// Challenge:

// try
// {
//   int num1 = int.MaxValue;
//   int num2 = int.MaxValue;
//   int result = num1 + num2;
//   Console.WriteLine("Result: " + result);

//   string str = null;
//   int length = str.Length;
//   Console.WriteLine("String Length: " + length);

//   int[] numbers = new int[5];
//   numbers[5] = 10;
//   Console.WriteLine("Number at index 5: " + numbers[5]);

//   int num3 = 10;
//   int num4 = 0;
//   int result2 = num3 / num4;
//   Console.WriteLine("Result: " + result2);
// }
// catch (OverflowException ex)
// {
//   Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
// }
// catch (NullReferenceException ex)
// {
//   Console.WriteLine("Error: The reference is null." + ex.Message);
// }
// catch (IndexOutOfRangeException ex)
// {
//   Console.WriteLine("Error: Index out of range." + ex.Message);
// }
// catch (DivideByZeroException ex)
// {
//   Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
// }

// Console.WriteLine("Exiting program.");

// sol:
// checked
// {
//   try
//   {
//     int num1 = int.MaxValue;
//     int num2 = int.MaxValue;
//     int result = num1 + num2;
//     Console.WriteLine("Result: " + result);
//   }
//   catch (OverflowException ex)
//   {
//     Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
//   }
// }

// try
// {
//   string? str = null;
//   int length = str.Length;
//   Console.WriteLine("String Length: " + length);
// }
// catch (NullReferenceException ex)
// {
//   Console.WriteLine("Error: The reference is null. " + ex.Message);
// }

// try
// {
//   int[] numbers = new int[5];
//   numbers[5] = 10;
//   Console.WriteLine("Number at index 5: " + numbers[5]);
// }
// catch (IndexOutOfRangeException ex)
// {
//   Console.WriteLine("Error: Index out of range. " + ex.Message);
// }

// try
// {
//   int num3 = 10;
//   int num4 = 0;
//   int result2 = num3 / num4;
//   Console.WriteLine("Result: " + result2);
// }
// catch (DivideByZeroException ex)
// {
//   Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
// }

// Console.WriteLine("Exiting program.");

/////////////////////////////////////////////////////////////////


//-The new keyword is used to create an instance of an exception. For example, you can create an instance of the ArgumentException exception type as follows:

// ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");

// throw invalidArgumentException;

//-Methods should throw an exception whenever they can't complete their intended purpose. The exception thrown should be based on the most specific exception available that fits the error conditions.

try
{
  OperatingProcedure1();
}
catch (Exception ex)
{
  Console.WriteLine(ex.Message);
  Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
  string[][] userEnteredValues = new string[][]
  {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
  };

  foreach (string[] userEntries in userEnteredValues)
  {
    try
    {
      BusinessProcess1(userEntries);
    }
    catch (Exception ex)
    {
      if (ex.StackTrace.Contains("BusinessProcess1"))
      {
        if (ex is FormatException)
        {
          Console.WriteLine(ex.Message);
          Console.WriteLine("Corrective action taken in OperatingProcedure1");
        }
        else if (ex is DivideByZeroException)
        {
          Console.WriteLine(ex.Message);
          Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

          // re-throw the original exception
          throw;
        }
        else
        {
          // create a new exception object that wraps the original exception
          throw new ApplicationException("An error occurred - ", ex);
        }
      }
    }

  }
}

static void BusinessProcess1(String[] userEntries)
{
  int valueEntered;

  foreach (string userValue in userEntries)
  {
    try
    {
      valueEntered = int.Parse(userValue);

      checked
      {
        int calculatedValue = 4 / valueEntered;
      }
    }
    catch (FormatException)
    {
      FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
      throw invalidFormatException;
    }
    catch (DivideByZeroException)
    {
      DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
      throw unexpectedDivideByZeroException;

    }
  }
}