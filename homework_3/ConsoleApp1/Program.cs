using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastest
{
    class Program
    {

        static string RaceCars(Car one, Car two)
        {
            if (one.CalculateSpeed(one.Driver) > two.CalculateSpeed(two.Driver))
            {
                return $"Car 1 was faster. Model: {one.Model}, speed: {one.CalculateSpeed(one.Driver)}, driven by: {one.Driver.Name}";
            }
            else
            {
                return $"Car 2 was faster. Model: {two.Model}, speed: {two.CalculateSpeed(two.Driver)}, driven by: {two.Driver.Name}";
            }
        }


        static void Main(string[] args)
        {

            Driver bob = new Driver("Bob", 4);
            Driver greg = new Driver("Greg", 5);
            Driver jill = new Driver("Jill", 6);
            Driver anne = new Driver("Anne", 7);


            Car porsche = new Car("Porsche", 220);
            Car ferrari = new Car("Ferrari", 200);
            Car hyundai = new Car("Hyundai", 180);
            Car mazda = new Car("Mazda", 150);


            Car selectedFirstCar;
            Driver selectedFirstDriver;

            Car selectedSecondCar;
            Driver selectedSecondDriver;

            bool InputCar1 = false;
            bool InputDriver1 = false;
            bool InputCar2 = false;
            bool Inputriver2 = false;
            int Car1 = 0;
            int Driver1 = 0;
            int Car2 = 0;
            int Driver2 = 0;


            Console.WriteLine("1) Porsche \n 2) Ferrari \n 3) Hyundai \n 4) Mazda");
            Console.Write("Choose first car: ");
            InputCar1 = int.TryParse(Console.ReadLine(), out Car1);

            if (Car1 == 1)
            {
                selectedFirstCar = porsche;
            }
            else if (Car1 == 2)
            {
                selectedFirstCar = ferrari;
            }
            else if (Car1 == 3)
            {
                selectedFirstCar = hyundai;
            }
            else if(Car1 == 4)
            {
                selectedFirstCar = mazda;
            }  
            else
            {
                selectedFirstCar = null;
                Console.WriteLine("Not valid input ");
            }


            Console.WriteLine("1) Bob \n 2) Greg \n 3) Jill \n 4) Anne");
            Console.Write("Choose first Driver: ");
            InputDriver1 = int.TryParse(Console.ReadLine(), out Driver1);
           
                if (Driver1 == 1)
                {
                    selectedFirstDriver = bob;
                }
                else if (Driver1 == 2)
                {
                    selectedFirstDriver = greg;
                }
                else if (Driver1 == 3)
                {
                    selectedFirstDriver = jill;
                }
                else if (Driver1 == 4)
                {
                    selectedFirstDriver = anne;
                }
                else
                {
                selectedFirstDriver = null;
                Console.WriteLine("Not valid input ");
                }

            if (Car1 == 1 && Driver1 == 1)
            {
                Console.WriteLine($"Model: {porsche.Model} \nSpeed: {porsche.CalculateSpeed(bob)} ");
                Console.WriteLine("Do you want to Race Again? (Y/N)");
                string answer = Console.ReadLine();
                if (answer == "N")
                {
                    Console.WriteLine("goodbye");
                }
                else
                {
                    Console.WriteLine("Here we go again");
                }
            }

           
           
                Console.WriteLine("1) Porsche\n2) Ferrari\n3) Hyundai\n4) Mazda");
                Console.Write("Choose a second car: ");
                InputCar2 = int.TryParse(Console.ReadLine(), out Car2);
                
                    if (Car2 == 1)
                    {
                        selectedSecondCar = porsche;
                    }
                    else if (Car2 == 2)
                    {
                        selectedSecondCar = ferrari;
                    }
                    else if (Car2 == 3)
                    {
                        selectedSecondCar = hyundai;
                    }
                    else if (Car2 == 4)
                    {
                        selectedSecondCar = mazda;
                    }
                    else
                    {
                    selectedSecondCar = null;
                    Console.WriteLine("Not a valid input for car no.2!");
                    }
            

           
                Console.WriteLine("1) Bob\n2) Greg\n3) Jill\n4) Anne");
                Console.Write("Choose Driver 2: ");
                Inputriver2 = int.TryParse(Console.ReadLine(), out Driver2);
              
                    if (Driver2 == 1)
                    {
                        selectedSecondDriver = bob;
                    }
                    else if (Driver2 == 2)
                    {
                        selectedSecondDriver = greg;
                    }
                    else if (Driver2 == 3)
                    {
                        selectedSecondDriver = jill;
                    }
                    else if (Driver2 == 4)
                    {
                        selectedSecondDriver = anne;
                    }
                    else
                    {
                     selectedSecondDriver = null;
                    Console.WriteLine("Not a valid input for driver 2.");
                    }
           

            
            selectedFirstCar.Driver = selectedFirstDriver;
            selectedSecondCar.Driver = selectedSecondDriver;

            Console.WriteLine(RaceCars(selectedFirstCar, selectedSecondCar));

            Console.WriteLine("Do you want to Race Again? (Y/N)");
            if (Console.ReadLine() == "N")
            {
                Console.WriteLine("goodbye");
            }

            Console.ReadLine();
        }
    }
}
        
   
