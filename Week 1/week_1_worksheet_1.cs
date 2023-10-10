// See https://aka.ms/new-console-template for more information

/*
decimal number = 2147483648;
Console.Write(number);
*/

/*
int intNum = 255;
float floatNum = intNum;
Console.Write(floatNum);
*/

/*
using System.Formats.Asn1;
using System.Transactions;

short shortNum = 258;
byte byteNum = (byte)shortNum;
Console.Write(byteNum);

// Task 2

/*
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Hi " + name + ". How old are you?: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"7 + {age} = {7 + age}");
Console.WriteLine($"7 - {age} = {7 - age}");
Console.WriteLine($"7 * {age} = {7 * age}");
Console.WriteLine($"7 / {age} = {7 / age}"); // error
Console.WriteLine($"7 % {age} = {7 % age}"); // error
*/

// Converting string value to numeric value

/*
string input = "o4";
bool isNumeric = int.TryParse(input, out int result);
Console.WriteLine(isNumeric); // False
Console.WriteLine(result); // 0

Console.WriteLine(isNumeric.ToString()); // False
Console.WriteLine(result.ToString()); // 0

// int.TryParse() takes two parameters and returns a True or False value
// Convert.ToInt32() takes a string and returns a 32-bit integer value
*/

// TASK 3

/*
double input1 = 49.0;
double input2 = 100;

/*
double input1= Math.Sqrt(input1); // Calculates square root
Console.WriteLine(input1);

*/
/*
// values returned by Sqrt is injected as a parameter of WriteLine().
Console.WriteLine(Math.Sqrt(input2));


// interpolating. F3 specifies 3 decimal places
Console.WriteLine($"{Math.Cos(input1):F3}");

// uses the string.format function
// the {0} represents the poisition of the parameters after the
// Formatting string. If the Format has a third parameter,
// it will be represented as {1} in the format string.
// The {F3} serves the same purpose
Console.WriteLine(String.Format("{0:F3}", Math.Cos(input1)));

/*
Console.WriteLine(Math.Min(input1)); // note more than 1 parameter available
Console.WriteLine(Math.Max(input1));
*/

// Methods can do something based on the parameter, 
// and the data of the variable

/*
string shuWebsite = "www.shu.ac.uk";
Console.WriteLine(shuWebsite.StartsWith("www."));
Console.WriteLine(shuWebsite.EndsWith("ac"));
Console.WriteLine(shuWebsite.Contains("shu"));

*/

// Task 4

/*
Console.WriteLine("Enter the length of a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the length of b: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
// to the power of 2
double length = (a * b) / 2;

Console.WriteLine($"Length of c is {c:F2}m"); // rounding to 2 dp
Console.WriteLine($"Area of the triangle is {length:F2}m");

// INSERT remove overwriting

// 1M = 100CM

Console.WriteLine($"Length of c in cm is {c * 100:F2}cm");
Console.WriteLine($"Area of the triangle in cm is {length * 100:F2}cm");

// TASK 5

*/
Console.WriteLine("Enter the temperature in Celcius: ");
double celcius = Convert.ToDouble(Console.ReadLine);
double kelvin = Convert.ToDouble(celcius) + 273;
double fahrenheit = Convert.ToDouble((celcius * 9) / 5) + 32;

Console.WriteLine($"The temperature in Kelvin is {kelvin}");
Console.WriteLine($"The temperature in Fahrenheit is {fahrenheit}");


