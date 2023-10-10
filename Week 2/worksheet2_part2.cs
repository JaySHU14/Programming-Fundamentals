// TASK 5

/*
namespace Week_2_Worksheet_2;

class Program
{

    struct ImperialHeight // define a struct that will store feet and inches
    {
        public int Feet { get; set; }
        public int Inches { get; set; }
    }

    static void Main(string[] args)
    {
        ImperialHeight heightInImperial = GetHeightInImperial(); // get the user's height to imperial inches
        double heightInMetres = toMetres(heightInImperial); // convert height to metres
        DisplayHeightMetres(heightInMetres); // display the height in metres (to 2dp)
    }

    static ImperialHeight GetHeightInImperial()
    {
        Console.Write("Enter your height in feet: ");
        if (int.TryParse(Console.ReadLine(), out int feet))
        {
            Console.Write("\nEnter the remaining inches: ");
            if (int.TryParse(Console.ReadLine(), out int inches))
            {
                return new ImperialHeight { Feet = feet, Inches = inches }; // return the correct height
            }
        }

        Console.Write("\nInvalid input. \n"); // error handling
        return GetHeightInImperial(); // keep asking for height
    }

    static double toMetres (ImperialHeight height)
    {
        const double feetToMetres = 0.3048;
        const double inchesToMetres = 0.0254;

        double metresFromFeet = height.Feet * feetToMetres; // convert both feet and inches to metres. Add them together
        double metresFromInches = height.Inches * inchesToMetres;

        return metresFromFeet + metresFromInches; // return total height in metres
    }

    static void DisplayHeightMetres (double metres)
    {
        Console.Write($"\nYour height in metres: {metres:F2}"); // display the height in metres to 2dp
    }
}



// TASK 6

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("\nEnter the maximum length: ");
        if (int.TryParse(Console.ReadLine(), out int max))
        {
            string trunc = TruncateStringIfNecessary(input, max);

            Console.Write($"\nOriginal string: {input}");
            Console.Write($"\nTruncated string: {trunc}");
        }
        else
        {
            Console.Write("\nInvalid input for max length. ");
        }

        static string TruncateStringIfNecessary(string input, int max)
        {
            if (input.Length > max)
            {
                return input.Substring(0, max);
            }
            else
            {
                return input;
            }
        }
    }
}



// TASK 7

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string modifiedInput = GetInsideString(input);

        Console.Write($"\n{modifiedInput}");

        static string GetInsideString (string input)
        {
            input = input.Trim(); // remove any whitespace

            if (input.Length >= 2)
            {
                input = input.Substring(1, input.Length - 2); // starts a substring after the first character, ends at the second to last character. -2 because
            }                                                 // it takes the length of the overall string before the first char has been removed
            else
            {
                input = string.Empty; // else the string is empty, do action is desired
            }
            return input;
        }
    }
}




// TASK 8

class Program
{
    static void Main()
    {
        Console.Write("Enter a registration number: ");
        string reg = Console.ReadLine(); // create a variable that takes the registration as an input

        int manuYear = RegistrationToYear(reg); // call the function taking the input as a parameter

        if (manuYear != -1) // check if valid numbers have been taken
        {
            Console.Write($"\nManufacturing year: {manuYear:D2}"); // to 2 decimal numbers
        }
        else
        {
            Console.Write("\nInvalid car registration format. ");
        }


        static int RegistrationToYear(string registration) // function declaration, takes the registration as a parameter
        {
            int first = int.Parse(registration[2].ToString()); // take out the digits representing the year
            int second = int.Parse(registration[3].ToString());

            int firstDigit = (first >= 5) ? first - 5 : first; // -5 if first >= 5 else keep it the same

            int manuYear = 2000 + firstDigit + second; // 

            return manuYear;
        }
    }
}



// TASK 9

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            int cent = CalculateCentury(year);
            Console.Write($"\n{cent} century");
        }
        else
        {
            Console.Write("\nInvalid input. ");
        }
    }

    static int CalculateCentury(int year)
    {
        int cent = (year / 100) + 1;
        return cent;
    }
}

*/

// TASK 10

class Program
{
    static void Main()
    {
        int[] dataInput = getData();
        int[] dataEncrypted = encryptData(dataInput);
        string output = getOutput(dataEncrypted);

        Console.Write($"\nEncrypted data: {output}");
    }

    static int[] getData()
    {
        int[] data = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter number {i + 1} (0-9): ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                data[i] = Math.Clamp(num, 0, 9); // clamp the input to a number between 0 and 9
            }
            else
            {
                Console.Write("\nInvalid input. Enter a single-digit number. ");
                i--; // retry iteration
            }    
        }
        return data;
    }
    static int[] encryptData(int[] data)
    {
        int[] dataEncrypted = new int[3];

        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                dataEncrypted[i] = data[2]; // swap values
            }
            else if (i == 2)
            {
                dataEncrypted[i] = data[0];
            }
            else
            {
                dataEncrypted[i] = data[i];
            }

            dataEncrypted[i] = (dataEncrypted[i] + 5) % 10;
        }
        return dataEncrypted;
    }
    static string getOutput(int[] data)
    {
        return string.Join("", data); // add the encrypted digits to a string
    }
}

// TASK 11
