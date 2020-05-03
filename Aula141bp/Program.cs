using System;

namespace Aula141bp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("acessar um arquivo e pecorre");

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\temp\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
          //  System.Console.ReadLine();



        }
    }
}
