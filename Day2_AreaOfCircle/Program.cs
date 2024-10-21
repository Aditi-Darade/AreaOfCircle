using System;
class AreaOfCircle
{
    static void Main()
    {
        System.Console.WriteLine("To find the area of a circle please enter the value of the radius:");

        string stringRadius = System.Console.ReadLine(); //ReadLine always uses string by default to store the input even if it is an integer, so input needs to be converted from string to integer  

        int radius = Convert.ToInt32(stringRadius);  //Converts strings to integers  

        System.Console.Clear();

        System.Console.WriteLine(radius);

        //To check if radius is converted from string to integer
        Console.WriteLine(radius.GetType());

        float pi = 3.14159F;

        System.Console.WriteLine("The area of circle with radius " + radius + " is: " + pi * radius * radius);

        System.Console.ReadKey();


    }
}