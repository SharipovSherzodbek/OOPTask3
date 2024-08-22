using System;
using System.Diagnostics;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to OOP Task 3");
        Console.WriteLine("\n_____________________Task 1_____________________ ");
        Console.WriteLine("Enter a grade (Excellent, Good, Average, Poor):");
        string inputMark = Console.ReadLine();

        List<Student> students = new List<Student>()
        {
            new Student(){ Id = Guid.NewGuid(), Name = "Dilshod", SurName = "Qobulov", Class = 11, StudentMark = Mark.Good},
            new Student(){ Id = Guid.NewGuid(), Name = "Sobir", SurName = "Makarov", Class = 9, StudentMark = Mark.Average},
            new Student(){ Id = Guid.NewGuid(), Name = "Raim", SurName = "Baratov", Class = 10, StudentMark = Mark.Poor},
            new Student(){ Id = Guid.NewGuid(), Name = "Dilshoda", SurName = "Shokirova", Class = 7, StudentMark = Mark.Excellent},
            new Student(){ Id = Guid.NewGuid(), Name = "Mamur", SurName = "Jabborov", Class = 9, StudentMark = Mark.Poor},
            new Student(){ Id = Guid.NewGuid(), Name = "Anora", SurName = "Abdullayeva", Class = 8, StudentMark = Mark.Excellent},
            new Student(){ Id = Guid.NewGuid(), Name = "Nodir", SurName = "Muratov", Class = 7, StudentMark = Mark.Good},
            new Student(){ Id = Guid.NewGuid(), Name = "Sardor", SurName = "Urakov", Class = 11, StudentMark = Mark.Excellent},
            new Student(){ Id = Guid.NewGuid(), Name = "Nigora", SurName = "Avulqosimov", Class = 9, StudentMark = Mark.Average},
            new Student(){ Id = Guid.NewGuid(), Name = "Kamol", SurName = "Baybabayev", Class = 8, StudentMark = Mark.Average},
        };

        if (Enum.TryParse(inputMark, true, out Mark selectedMark))
        {
            List<Student> filteredStudents = students.Where(s => s.StudentMark == selectedMark).ToList();

            if (filteredStudents.Count > 0)
            {
                Console.WriteLine("Students with " + selectedMark + " mark:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"Name: {student.Name + " " + student.SurName}, Class: {student.Class}, and Id: {student.Id}");
                }
            }
            else
            {
                Console.WriteLine($"There is no student with {selectedMark} mark");
            }

        }
        else
        {
            Console.WriteLine("Invalid grade entered");
        }


        Console.WriteLine("\n_____________________Task 2_____________________ ");
        Console.WriteLine("Enter a min. price of car you want to buy...");
        int minValue;
        while(!int.TryParse(Console.ReadLine(), out minValue))
        {
            Console.WriteLine("Invalid number! Enter again...");
        }

        Console.WriteLine("Enter a max. price of car you want to buy...");
        int maxValue;
        while (!int.TryParse(Console.ReadLine(), out maxValue))
        {
            Console.WriteLine("Invalid number! Enter again...");
        }

        List<Car> cars = new List<Car>()
        {
            new Car { Brand = "BMW", Name = "X2", Cost = 42450 },
            new Car { Brand = "Ford", Name = "Aspire", Cost = 35000 },
            new Car { Brand = "Audi", Name = "Q6", Cost = 63000 },
            new Car { Brand = "Honda", Name = "Prologue", Cost = 47400 },
            new Car { Brand = "Daewoo", Name = "Damas", Cost = 9000 },
            new Car { Brand = "Chevrolet", Name = "Gentra", Cost = 15000 },
            new Car { Brand = "Mercedes", Name = "EQE 500", Cost = 85900 },
            new Car { Brand = "BMW", Name = "X7", Cost = 129700 },
            new Car { Brand = "BMW", Name = "X2", Cost = 42450 },
            new Car { Brand = "BYD", Name = "Chazor", Cost = 18600 },           
        };

        List<Car> filteredCars = cars.FindAll(c => c.Cost >= minValue && c.Cost <= maxValue).ToList();
        if(filteredCars.Count > 0)
        {
            foreach (Car car in filteredCars)
            {
                Console.WriteLine($"Brand: {car.Brand}, Name: {car.Name}, Cost: {car.Cost}$");
            }
        }
        else { Console.WriteLine("Cars not found!"); }
        Console.ReadLine();
        Console.Clear();



        Console.WriteLine("\n_____________________Task 3_____________________ ");
        Console.WriteLine("The program which sorts a weight category of boxers");
        
        List<Boxers> boxers = new List<Boxers>() 
        {
            new Boxers{Id = 1, Name = "Baxodir", Surname = "Jalolov", Age = 27, Weight = 97.2},
            new Boxers{Id = 2, Name = "Shoxrux", Surname = "Nazarov", Age = 23, Weight = 114},
            new Boxers{Id = 3, Name = "Isroil", Surname = "Rahmonaliyev", Age = 24, Weight = 84},
            new Boxers{Id = 4, Name = "Gulom", Surname = "Tahmanov", Age = 19, Weight = 97.2},
            new Boxers{Id = 5, Name = "Saloh", Surname = "Ulugbekov", Age = 21, Weight = 47},
            new Boxers{Id = 6, Name = "Nodir", Surname = "Sherov", Age = 32, Weight = 58},
            new Boxers{Id = 7, Name = "Rajm", Surname = "Tulaganov", Age = 27, Weight = 68},
            new Boxers{Id = 8, Name = "Nazokat", Surname = "Firdavsova", Age = 22, Weight = 43},
            new Boxers{Id = 9, Name = "Kil", Surname = "Yanozek", Age = 29, Weight = 45},
            new Boxers{Id = 10, Name = "Nozima", Surname = "Jalolova", Age = 26, Weight = 56},
        };    
           
        //Approach 1
        List<Boxers> lightWeight = boxers.FindAll(b => b.Weight <= 50).ToList();
        List<Boxers> middleWeight = boxers.FindAll(b => b.Weight > 50 && b.Weight <= 76).ToList();
        List<Boxers> heavyWeight = boxers.FindAll(b => b.Weight >= 90).ToList();
        Console.WriteLine("\nBoxers in light weight(<50kg):");
        foreach (Boxers box in lightWeight)
        {
            Console.WriteLine($"Id: {box.Id}, Name: {box.Name} {box.Surname}, Weight: {box.Weight} kg");
        }

        Console.WriteLine("\nBoxers in middle weight(50-76)kg:");
        foreach (Boxers box in middleWeight)
        {
            Console.WriteLine($"Id: {box.Id}, Name: {box.Name} {box.Surname}, Weight: {box.Weight} kg");
        }

        Console.WriteLine("\nBoxers in heavy weight(>90)kg:");
        foreach (Boxers box in heavyWeight)
        {
            Console.WriteLine($"Id: {box.Id}, Name: {box.Name} {box.Surname}, Weight: {box.Weight} kg");
        }


        //Approach 2 
        /*
          foreach (Boxers box in boxers)
        {
            if (box.Weight <= 50)
            {
                Console.WriteLine($"Id: {box.Id}, Name: {box.Name} {box.Surname}, Weight: {box.Weight} kg (Light Weight)");
            }
            else if (box.Weight > 50 && box.Weight <= 76)
            {
                Console.WriteLine($"Id: {box.Id}, Name: {box.Name} {box.Surname}, Weight: {box.Weight} kg (Middle Weight)");
            }
            else if (box.Weight >= 90)
            {
                Console.WriteLine($"Id: {box.Id}, Name: {box.Name} {box.Surname}, Weight: {box.Weight} kg (Heavy Weight)");
            }
        }
         */
        Console.ReadKey();
    }
}

