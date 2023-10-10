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

