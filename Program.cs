using System;

namespace FieldPainting
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Develop a program that will give a customer the correct amount of paint to buy in order to paint a certain size field.
            //The cans of paint are different sizes depending on the color. So the color they want will affect how many cans they need.
            Console.WriteLine("What is the radius? Use a number in ft");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What paint do you want: red, blue, green, or yellow paint?");
            string color = Console.ReadLine();

            color = color.ToLower();

            int paint = 0;
            int cost = 0;
            double area = (Math.PI * (radius * radius));


            if (color == "red")
            {
                paint = (((int)area / 100) + 1);
                cost = (paint * 25);
            }
            if (color == "blue")
            {
                paint = (((int)area / 120) + 1);
                cost = (paint * 28);
            }
            if (color == "green")
            {
                paint = (((int)area / 90) + 1);
                cost = (paint * 33);
            }
            if (color == "yellow")
            {
                paint = (((int)area / 70) + 1);
                cost = (paint * 22);
            }

            Console.WriteLine("You will need " + paint + " buckets of " + color + " paint to paint the " + radius + " ft circle and it will cost $" + cost);

        }
    }
}