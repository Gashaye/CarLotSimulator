using System;
using System.Data;

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

            Car car1 = new Car();
            Console.WriteLine($" Car Year: {car1.Year = 2009} \n Car make: {car1.Make = "Honda"} \n car model: {car1.Model = "Accord"} \n Car Engine:  {car1.EngineNoise = "Good"} \n Honk Noise: {car1.HonkNoise = "Great"}\n Is drivable?  {car1.IsDriveable = "Yes"} ");

            Console.WriteLine(car1.MakeEngineNoise("Very Nice"));
            Console.WriteLine(car1.MakeHonkNoise("Good Honk"));

            Car car2 = new Car();

            Car car3 = new Car();

            Console.WriteLine($"Number of car created: {CarLotSimulator.CarLot.numberOfCars}");



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
