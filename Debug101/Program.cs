// int productCount = 2000;
// string[,] products = new string[productCount, 2];

// LoadProducts(products, productCount);

// for (int i = 0; i < productCount; i++)
// {
//   string result;
//   result = Process1(products, i);

//   if (result != "obsolete")
//   {
//     result = Process2(products, i);
//   }
// }

// bool pauseCode = true;
// while (pauseCode == true) ;

// static void LoadProducts(string[,] products, int productCount)
// {
//   Random rand = new Random();

//   for (int i = 0; i < productCount; i++)
//   {
//     int num1 = rand.Next(1, 10000) + 10000;
//     int num2 = rand.Next(1, 101);

//     string prodID = num1.ToString();

//     if (num2 < 91)
//     {
//       products[i, 1] = "existing";
//     }
//     else if (num2 == 91)
//     {
//       products[i, 1] = "new";
//       prodID = prodID + "-n";
//     }
//     else
//     {
//       products[i, 1] = "obsolete";
//       prodID = prodID + "-0";
//     }

//     products[i, 0] = prodID;
//   }
// }

// static string Process1(string[,] products, int item)
// {
//   Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

//   return products[item, 1];
// }

// static string Process2(string[,] products, int item)
// {
//   Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
//   if (products[item, 1] == "new")
//     Process3(products, item);

//   return "continue";
// }

// static void Process3(string[,] products, int item)
// {
//   Console.WriteLine($"Process3 message - processing product information for 'new' product");
// }

/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
// int x = 5;

// ChangeValue(x);

// Console.WriteLine(x);

// void ChangeValue(int value)
// {
//   value = 10;
// }

// sol
// int x = 5;
// x = ChangeValue(x);
// Console.WriteLine(x);

// int ChangeValue(int value)
// {
//   value = 10;
//   return value;
// }

/*Common scenarios that require exception handling include:

User input: Exceptions can occur when code processes user input. For example, exceptions occur when the input value is in the wrong format or out of range.

Data processing and computations: Exceptions can occur when code performs data calculations or conversions. For example, exceptions occur when code attempts to divide by zero, cast to an unsupported type, or assign a value that's out of range.

File input/output operations: Exceptions can occur when code reads from or writes to a file. For example, exceptions occur when the file doesn't exist, the program doesn't have permission to access the file, or the file is in use by another process.

Database operations: Exceptions can occur when code interacts with a database. For example, exceptions occur when the database connection is lost, a syntax error occurs in a SQL statement, or a constraint violation occurs.

Network communication: Exceptions can occur when code communicates over a network. For example, exceptions occur when the network connection is lost, a timeout occurs, or the remote server returns an error.

Other external resources: Exceptions can occur when code communicates with other external resources. Web Services, REST APIs, or third-party libraries, can throw exceptions for various reasons. For example, exceptions occur due to network connections issues, malformed data, etc.

The C# language also enables your code to generate an exception object by using the throw keyword
*/

////////////////////////////////////////////////////////////////////
///           Exception handling Try() catch() finally()
////////////////////////////////////////////////////////////////////


try
{
  // try code block - code that may generate an exception
}
catch
{
  // catch code block - code to handle an exception
}
finally
{
  // finally code block - code to clean up resources
}

/*The try code block contains the guarded code that may cause an exception. If the code within a try block causes an exception, the exception is handled by a corresponding catch block.

The catch code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it. A catch block can be configured to execute when any exception type occurs, or only when a specific type of exception occurs.

The finally code block contains code that executes whether an exception occurs or not. The finally block is often used to clean up any resources that are allocated in a try block. For example, ensuring that a variable has the correct or required value assigned to it.

The try-catch pattern consists of a try block followed by one or more catch clauses. Each catch clause specifies the handler for a different exception type.
*/

/*Compiler-generated exceptions

The .NET runtime throws exceptions when basic operations fail. Here's a short list of runtime exceptions and their error conditions:

ArrayTypeMismatchException: Thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array.

DivideByZeroException: Thrown when an attempt is made to divide an integral value by zero.

FormatException: Thrown when the format of an argument is invalid.

IndexOutOfRangeException: Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.

InvalidCastException: Thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime.

NullReferenceException: Thrown when an attempt is made to reference an object whose value is null.

OverflowException: Thrown when an arithmetic operation in a checked context overflows.*/