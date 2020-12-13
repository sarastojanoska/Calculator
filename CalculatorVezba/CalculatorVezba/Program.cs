using System;

namespace CalculatorVezba
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator("Casio");
            Console.WriteLine(calc.add(1,2));
            Console.WriteLine(calc.pogolemo(56, 67));
            Console.WriteLine(calc.deli(562, 24));
            Console.WriteLine(calc.compare(1, 2));
            Console.WriteLine(calc.ostatok(254, 67));
            calc.Imence();
        }
    }

    class Calculator
    {
        string ime;

        public Calculator(string ime)
        {
            this.ime = ime;
        }

        public int add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Dokolku prviot broj e :" + a + "i vtoriot broj e :" + b + "nivniot zbir e :" + c);
            return c;
        }
        public bool compare(int a, int b)
        {
            return a > b;
        }
        public int pogolemo(int a, int b)
        {
            bool c = true;
            if(a > b)
            {
                Console.WriteLine("Brojot:" + a + "e pogolem od:" + b);
                return a;
            }
            else
            {
                Console.WriteLine("Brojot:" + b + "e pogolem od:" + a);
                return b;
            }
            
        }
        public float deli (int a, int b)
        {
            float c = a / b;
            Console.WriteLine("Dokolku prviot broj e :" + a + "i vtoriot broj e :" + b + "rezultat od delenje  e :" + c);
            return c;
        }
        public int ostatok(int a, int b)
        {
            int c = a % b;
            Console.WriteLine("Dokolku prviot broj e :" + a + "i vtoriot broj e :" + b + "nivniot modul e :" + c);
            return c;
        }
        public void Imence()
        {
            Console.WriteLine("Si printam");
        }
    }
}
