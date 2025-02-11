namespace COMP003A.LectureActivity5_1;

    internal class Program
    {
        
        static void Main(string[] args)
        {
           

            Car myCar = new Car("Honda", "Civic", 2021); // Create a new Car object using the constructor
            myCar.DisplayInfo(); // Display the car's information

            myCar.Make = "Toyota"; // Change the make of the car
            myCar.Model = "Corolla"; // Change the model of the car
            myCar.year = 2020; // Change the year of the car
            myCar.DisplayInfo(); //Display the car information
        }

        internal class Car
        {
            //Fields
            public string make;
            public string model;
            public int year;
            
            //Properties
            public string Make
            {
                get { return make;  }
                set { make = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public int Year
            {
                get { return year; }
                set { if (value >= 1886) year = value; }
            }

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