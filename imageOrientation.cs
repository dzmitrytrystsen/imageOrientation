using System;

namespace Image
{
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter width of your image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter height of your image:");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Your image is: {0}", orientation);

            Main();
        }
    }
}
