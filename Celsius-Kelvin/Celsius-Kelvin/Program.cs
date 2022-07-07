using System;
using static Generic.Kelvin;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(0);
            Kelvin kelvin = celsius;
            Console.WriteLine(kelvin.Degree);
        }
    }
    public class Kelvin
    {
        public double Degree { get; set; }

        public Kelvin(double degree)
        {
            Degree = degree;
        }



    }
    public class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }
    }
}
