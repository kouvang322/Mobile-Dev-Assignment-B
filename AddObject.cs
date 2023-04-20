using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B
{
    internal class AddObject
    {

        public List<ITalkable> zoo = new List<ITalkable>();
        public string userInput = "";
        public string userEnterName = "";

        public bool isFriendly = true;
        public int age = 1;

        public bool continueAdding = false;
        ITalkable newAnimal = null;

        public List<ITalkable> GatherUserInput(List<ITalkable> zoo)
        {
            do
            {
                while (newAnimal == null)
                {
                    Console.WriteLine("What type of animal would you like to add?");
                    Console.WriteLine("1. Cat");
                    Console.WriteLine("2. Dog");
                    Console.WriteLine("3. Teacher");

                    userInput = Console.ReadLine();

                    newAnimal = GetCreatedObject(userInput);

                    if (newAnimal == null)
                    {
                        Console.WriteLine("Please enter one of the choices provided.");
                    }
                }

                zoo.Add(newAnimal);

                Console.WriteLine("Animal added.");

                ContinueAdd();

            } while (continueAdding == true);


            return zoo;
        }

        //use if statements instead
        public ITalkable GetCreatedObject(string userInput)
        {
            if (userInput.ToLower() == "cat")
            {
                return newCat();
            }
            else if (userInput.ToLower() == "dog")
            {
                return newDog();

            }
            else if (userInput.ToLower() == "teacher")
            {
                return newTeacher();
            }

            return null;
        }

        public Cat newCat()
        {
            Console.WriteLine("Enter a name for new animal:");
            userEnterName = Console.ReadLine();


            while (string.IsNullOrWhiteSpace(userEnterName))
            {
                userEnterName = EnterName();
            }


            Console.WriteLine("How many mice did the cat kill? :");
            userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Please enter a number only.");
                Console.WriteLine("How many mice did the cat kill? :");
                userInput = Console.ReadLine();
            }

            int userEnteredMouseKilled = Convert.ToInt32(userInput);


            Cat newCat = new Cat(userEnteredMouseKilled, userEnterName);
            return newCat;
        }

        public Dog newDog()
        {
            bool enteredCorrectInput = false;


            Console.WriteLine("Enter a name for new animal: ");
            userEnterName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userEnterName))
            {
                userEnterName = EnterName();
            }

            do
            {
                Console.WriteLine("Is the dog friendly? (Y/N)");
                string userEnteredFriendly = Console.ReadLine();

                if (userEnteredFriendly.ToLower() == "y")
                {
                    isFriendly = true;
                    enteredCorrectInput = true;
                }
                else if (userEnteredFriendly.ToLower() == "n")
                {
                    isFriendly = false;
                    enteredCorrectInput = true;
                }
                else if (userEnteredFriendly.ToLower() != "y" || userEnteredFriendly.ToLower() != "n")
                {
                    Console.WriteLine("Please enter Y for yes and N for no.");
                }

            } while (enteredCorrectInput == false);

            Dog newDog = new Dog(isFriendly, userEnterName);
            return newDog;
        }

        public Teacher newTeacher()
        {

            Console.WriteLine("Enter a name for new animal:");
            userEnterName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userEnterName))
            {
                Console.WriteLine("Please enter a valid name.");
                Console.WriteLine("Enter a name for new animal:");
                userEnterName = Console.ReadLine();
            }

            Console.WriteLine("What is the teacher's age?");
            userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Please enter a number only.");
                Console.WriteLine("What is the teacher's age?");
                userInput = Console.ReadLine();
            }

            int userEnteredAge = Convert.ToInt32(userInput);


            Teacher newTeacher = new Teacher(userEnteredAge, userEnterName);

            return newTeacher;
        }

        public void ContinueAdd()
        {
            bool enteredCorrectInput = false;

            do
            {
                Console.WriteLine("Do you want to add another animal? (Y/N)");

                string userDecision = Console.ReadLine();

                if (userDecision.ToLower() == "y")
                {
                    continueAdding = true;
                    newAnimal = null;
                    enteredCorrectInput = true;

                }
                else if (userDecision.ToLower() == "n")
                {
                    continueAdding = false;
                    enteredCorrectInput = true;

                }
                else if (userDecision.ToLower() != "y" || userDecision.ToLower() != "n")
                {

                    Console.WriteLine("Please enter Y for yes or N for no.");
                }

            } while (enteredCorrectInput == false);

        }

        public string EnterName()
        {
            Console.WriteLine("Please enter a valid name.");
            Console.WriteLine("Enter a name for new animal: ");
            string userNameInput = Console.ReadLine();

            return userNameInput;
        }

    }
}
