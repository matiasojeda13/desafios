using System;

namespace desafio5
{
    public class Rectangulo
    {
        private double LadoA { get; set;}
        private double LadoB { get; set;}
        public Rectangulo(double ladoA, double ladoB)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
        }

        public double GetArea()
        {
        return LadoA * LadoB;
        }
        public double GetPerimeter()
        {
        return (LadoA + LadoB) * 2;
        }
    }

    public class Circulo 
    {
		double Radio { get; set;}
  	    public Circulo (double radio)
        {
      	    this.Radio = radio;
        }
  
  	    public double GetArea() => Radio * Radio * Math.PI;
		public double GetPerimeter() => 2 * Radio * Math.PI;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var circulo1 = new Circulo(4.55);
            var rectangulo1 = new Rectangulo(5,13);
            Console.WriteLine(circulo1.GetArea());
            Console.WriteLine(circulo1.GetPerimeter());
            Console.WriteLine(rectangulo1.GetArea());
            Console.WriteLine(rectangulo1.GetPerimeter());
        }
    }
}
