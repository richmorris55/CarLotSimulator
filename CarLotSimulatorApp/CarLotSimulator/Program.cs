using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

           CarLot carItems= new CarLot(); //Instanciated CarLot Class

            


            Console.WriteLine("This is Car 1");//called properties using dot notation 
            Car car1 = new Car();
            car1.HonkNoise = "beep beep";
            car1.MakeHonkNoise(car1.HonkNoise);
            car1.EngineNoise = "vroom vroom";
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.Year = 1985;
            car1.Make = "Cheverlet";
            car1.Model = "Blazer";
            car1.IsDriveable = true;



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This is car 2");
            Car car2 = new Car()//called properties using object initializer syntax.
            {

                Make = "Ford",

                Model = "Bronco",

                Year = 1989,

                IsDriveable = true,

                EngineNoise = "chugga chugga",

                HonkNoise = "aroooooooga"

                
            };

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This is car 3");
            Car car3 = new Car("Dodge", "Charger", 1972, true, "dixie", "grrrrrrr");// Called properties with custom constuctor.

            car3.MakeHonkNoise(car3.HonkNoise);
            car3.MakeEngineNoise(car3.EngineNoise);



            Console.WriteLine();
            Console.WriteLine();
            CarLot.CarList = new List<Car>() { car1,car2,car3};//Added cars to new list in CarLot class

            foreach (var car in CarLot.CarList)//called our CarList property located in our CarLot class. 
            {
                Console.WriteLine($" In our lot we have a beautiful: {car.Year}, {car.Make}, {car.Model}." );

                Console.WriteLine();
            }
        }
    }
}
