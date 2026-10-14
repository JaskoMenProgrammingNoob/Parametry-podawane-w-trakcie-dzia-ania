using System;
class Pierwiastek
{
    public static double pobierzLiczbe(string param)
    {
        double liczba = 0;
        bool sukces;
        do
        {
            Console.Write("Proszę podać {0} parametr równania: ", param);
            try
            {
                liczba = Double.Parse(Console.ReadLine());
                sukces = true;
            }
            catch (Exception)
            {
                Console.WriteLine(
                "To nie jest prawidłowa liczba rzeczywista!");
                sukces = false;
            }
        }
        while (!sukces);
        return liczba;
    }
    public static void Main(string[] args)
    {
        double parametrA = pobierzLiczbe("pierwszy");
        double parametrB = pobierzLiczbe("drugi");
        double parametrC = pobierzLiczbe("trzeci");
        Console.WriteLine("Wprowadzone parametry równania:\n");
        Console.WriteLine("A = " + parametrA + ", B = " + parametrB +
        ", C = " + parametrC + "\n");
        if (parametrA == 0)
        {
            Console.WriteLine("To nie jest równanie kwadratowe: A = 0!");
        }
        else
        {
            double delta = parametrB * parametrB - 4 * parametrA * parametrC;
            double wynik;
            if (delta < 0)
            {
                Console.WriteLine("Delta < 0");
                Console.WriteLine(
                "Brak rozwiązań w zbiorze liczb rzeczywistych.");
            }
            else if (delta == 0)
            {
                wynik = -parametrB / (2 * parametrA);
                Console.WriteLine("Rozwiązanie: x = " + wynik);
            }
            else
            {
                wynik = (-parametrB + Math.Sqrt(delta)) / (2 * parametrA);
                Console.Write("Rozwiązanie: x1 = " + wynik);
                wynik = (-parametrB - Math.Sqrt(delta)) / (2 * parametrA);
                Console.WriteLine(", x2 = " + wynik);
            }
        }
    }
}
