namespace COMP003A.LectureActivity5_1;

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Car myCar = new Car(); // Create a new Car object
            myCar.Make = "Toyota"; // Set the car's make
            myCar.Model = "Supra"; // Set the car's model
            myCar.Year = 2024; // Set the car's year
            
            myCar.DisplayInfo(); // Display the car's information
        }

        internal class Car
        {
            //Fields
            public string Make;
            public string Model;
            public int Year;

            ///<summary>
            /// Default constructor
            /// </summary>
            /// <param name="make"></param>
            /// <param name="model"></param>
            /// <param name="year"></param>

            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }

            /// <summary>
            /// Display the car information
            /// </summary>

            public void DisplayInfo()
            {
                Console.WriteLine($"Car: {Year} {Make} {Model}");
            }
        }


    }