
/*

// TASK 1.2

class Rectangle
{
    private float width; // create two private variables to store both height and width
    private float height;

    public Rectangle(float w, float h) // create a constructor that will automatically be invoked upon when we call it
    {
        width = w;
        height = h;
    }

    public float CalculateArea() // main method to return the area when called 
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(8.0f, 5.0f); // creates a Rectangle object

        float result = rectangle.CalculateArea(); // stores the result of passing the method onto the Rectangle object
        Console.Write($"The area of the rectangle is {result}"); // prints result
    }
}

// TASK 1.3

class Person
{
    public string Name { get; set; } // declare two class members
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name; // parse the variables to a function to then be called later on
        Age = age;
    }

    public void Greet() // function that interpolates both attributes
    {
        Console.Write($"\nHello, my name is {Name}, and I am {Age} years old. "); 
    }
}

class Program
{
    static void Main() 
    {
        Person[] people = new Person[3]; // create an array in the Person class to store 3 separate people

        for (int i = 0; i < 3; i++) // iterate 3 times for the amount of people
        {
            Console.Write($"Enter the name of person {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"\nEnter the age of person {i + 1}: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("\nInvalid age. ");
            }

            people[i] = new Person(name, age); // add these specific characteristics to the array
        }

        Console.Write("\nGreeting from each person: \n");

        foreach (Person person in people) // goes through every person in the array and displays their specific characteristics
        {
            person.Greet();
        }
    }
}



// TASK 1.4

class Address
{
    public string HouseNo { get; set; } // setting address attributes
    public string StreetName { get; set; }
    public string Postcode { get; set; }
}

class Program
{
    static void Main()
    {
        Address userAddress = new Address(); // create a new variable of the Address class to store the user address using the Address object

        Console.Write("Enter the house number: ");
        userAddress.HouseNo = Console.ReadLine();

        Console.Write("\nEnter the street name: ");
        userAddress.StreetName = Console.ReadLine();

        Console.Write("\nEnter the postcode: ");
        userAddress.Postcode = Console.ReadLine();

        Console.Write($"\nAddress: {userAddress.HouseNo}, {userAddress.StreetName}, {userAddress.Postcode} ");
    }
}



// TASK 2

class Point
{
    private float x;
    private float y;

    public Point()
    {
        x = 0.0f; // declare initial positions in float type
        y = 0.0f;
    }

    public void SetPosition (float newX, float newY)
    {
        if (newX < 0) // ensure that both x and y are 0 or greater
        {
            newX = 0;
        }

        if (newY < 0)
        {
            newY = 0;
        }

        x = newX; // update positions
        y = newY;
    }

    public float GetX()
    {
        return x; // literally obtain x
    }

    public float GetY()
    {
        return y; // same with y
    }
}

class Program
{
    static void Main()
    {
        Point point = new Point(); // new Point object

        point.SetPosition(-9, 42); // run method to ensure both no's are 0 or above

        float xPos = point.GetX(); // call the Get method to obtain both x and y
        float yPos = point.GetY();

        Console.Write($"X position: {xPos} "); // display both positions
        Console.Write($"\nY position: {yPos} ");
    }
}



// TASK 3

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; } // access the property of the Address class

    public Person (string name, int age, Address address)
    {
        Name = name;
        Age = age;
        Address = address;
    }

    public void Display()
    {
        Console.Write($"{Name}, {Age}, Street No. {Address.HouseNo}, Postcode {Address.Postcode}");
    }
}

class Address
{
    public string HouseNo { get; set; }
    public string Postcode { get; set; }
}

class Program
{
    static void Main()
    {
        Address userAddress = new Address // create new 
        {
            HouseNo = "9",
            Postcode = "KS06 PQT"
        };

        Person person = new Person("Nick", 26, userAddress);

        person.Display();
    }
}



// TASK 4

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }

    public Person(string name, int age, Address address)
    {
        Name = name;
        Age = age;
        Address = address;
    }

    public void Display()
    {
        Console.Write($"\n{Name}, {Age}, House No. {Address.HouseNo}, Postcode{Address.Postcode}");
    }
}

class Address
{
    public string HouseNo { get; set; }
    public string Postcode { get; set; }
}

class Program
{
    static void Main()
    {
        bool running = true;
        Person[] people = new Person[7];

        while (running)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("\nEnter an age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("\nInvalid input. ");
            }

            Console.Write("\nEnter a house number: ");
            string houseNo = Console.ReadLine();

            Console.Write("\nEnter a postcode: ");
            string postcode = Console.ReadLine();

            Address userAddress = new Address
            {
                HouseNo = houseNo,
                Postcode = postcode
            };

            people[0] = new Person(name, age, userAddress);
            
            Console.Write("\nWould you like to continue? ");
            string input = Console.ReadLine();

            if (input == "no")
            {
                running = false;
            }

            foreach (Person person in people)
            {
                person.Display();
            }
        }
    }
}



// TASK 5


class Program
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int d, int m, int y)
        {
            SetYear(y);
            SetMonth(m);
            SetDay(d);
        }


        public void SetDay(int d)
        {
            if (d >= 1 && d <= 30)
            {
                day = d;
            }
            else
            {
                Console.Write("\nInvalid day value. ");
            }
        }

        public void SetMonth(int m)
        {
            if (m >= 1 && m <= 12)
            {
                month = m;
            }
            else
            {
                Console.Write("\nInvalid month value. ");
            }
        }

        public void SetYear(int y)
        {
            if (y >= 1 && y <= 9999)
            {
                year = y;
            }
            else
            {
                Console.Write("\nInvalid year value. ");
            }
        }

        public void AddDays(int n)
        {
            day += n;
            while (day > 30)
            {
                day -= 30;
                AddMonths(1);
            }
        }

        public void AddMonths(int n)
        {
            month += n;
            while (month > 12)
            {
                month -= 12;
                AddYears(1);
            }
        }

        public void AddYears(int n)
        {
            year += n;
            if (year > 9999)
            {
                year = 9999;
            }
        }

        public string Formatted()
        {
            return ($"{year:D4}-{month:D2}-{day:D2}"); // format to year-month-day
        }

        public bool IsBefore(Date d)
        {
            if (year < d.year || (year == d.year && month < d.month) || (year == d.year && month == d.month && day < d.day))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAfter(Date d)
        {
            if (year > d.year || (year == d.year && month > d.month) || (year == d.year && month == d.month && day > d.day))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public bool IsTheSameAs(Date d)
        {
            if (year == d.year && month == d.month && day == d.day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    static void Main()
    {
        Date date1 = new Date(10, 10, 2023);
        Console.Write("Initial Date: " + date1.Formatted());

        date1.AddDays(4);
        Console.Write("\nModified days: " + date1.Formatted());

        date1.AddMonths(4);
        Console.Write("\nModified months: " + date1.Formatted());

        date1.AddYears(5);
        Console.Write("\nModified years: " + date1.Formatted());

        Date date2 = new Date(5, 3, 1958);

        Console.Write("\nIs date 1 before date 2?: " + date1.IsBefore(date2));
        Console.Write("\nIs date 1 after date 2?: " + date1.IsAfter(date2));
        Console.Write("\nIs date 1 the same as date 2?: " + date1.IsTheSameAs(date2));
    }
}

*/

// TASK 6

class Item
{
    public string Name { get; }
    public bool IsTicked { get; set; }

    public Item(string name, bool isTicked = false)
    {
        Name = name;
        IsTicked = isTicked;
    }
}

class ShoppingList
{
    private List<Item> items = new List<Item>();

    public void AddItem(string itemName)
    {
        Item existingItem = items.FirstOrDefault(item => item.Name == itemName);
        if (existingItem != null)
        {
            existingItem.IsTicked = false; // if the item still exists it isn't ticked off
        }
        else
        {
            items.Add(new Item(itemName));
        }
    }

    public void TickItem(string itemName)
    {
        Item item = items.FirstOrDefault(i => i.Name == itemName);
        if (item != null)
        {
            item.IsTicked = true;
        }    
    }

    public void DisplayList()
    {
        Console.Write("Shopping List: ");
        foreach (var item in items.OrderBy(i => i.Name))
        {
            string check = item.IsTicked ? "[X]" : "[ ]";
            Console.Write($"\n{check} {item.Name}");
        }
    }
}

class Program
{
    static void Main()
    {
        ShoppingList shoppingList = new ShoppingList();

        shoppingList.AddItem("Chicken");
        shoppingList.AddItem("Nutella");
        shoppingList.AddItem("Noodles");
        shoppingList.AddItem("Nutella"); // testing to see if the item remains unticked

        shoppingList.TickItem("Chicken");
        shoppingList.TickItem("Noodles");

        shoppingList.DisplayList();

    }
}