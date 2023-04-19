using System.Collections;
using System.IO;

namespace Assignment_B
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string workingDirectory = Environment.CurrentDirectory;

            string filePath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\animals.txt";

            FileOutput outFile = new FileOutput(filePath);

            List<ITalkable> zoo = new List<ITalkable>();

            AddObject addObject = new AddObject();

            zoo = addObject.GatherUserInput(zoo);

            //zoo.Add(new Dog(true, "Bean"));
            //zoo.Add(new Cat(9, "Charlie"));
            //zoo.Add(new Teacher(44, "Stacy Read"));

            foreach(ITalkable thing in zoo)
            {
                PrintOut(thing, outFile);
            }

            outFile.FileClose();

            FileInput inFile = new FileInput(filePath);

            inFile.FileRead();
            inFile.FileClose();

            FileInput inData = new FileInput(filePath);
            string line;
            while((line = inData.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void PrintOut(ITalkable thing, FileOutput outFile)
        {
            Console.WriteLine(thing.GetName() + " says=" + thing.Talk());
            outFile.FileWrite(thing.GetName() + " | " + thing.Talk());
        }

    }
}