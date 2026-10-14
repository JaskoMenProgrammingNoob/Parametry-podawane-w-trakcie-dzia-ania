class Program
{
    bool sukces;


    double a = 0;
    double b = 0;
    double c = 0;
    double delta = 0;
    double x1 = 0;
    double x2 = 0;
    double x0 = 0;
    string[] zmienne = { "a", "b", "c" };
    int numer_zmiennej = 0;
    double liczba = 0;
    public void Pobierz_liczbę()
    {
        do
        {
            try
            {
                Console.WriteLine("Podaj zmienną: " + zmienne[(int)numer_zmiennej]);
                liczba = double.Parse(Console.ReadLine());
                switch (numer_zmiennej)
                {
                    case 0:
                        if (liczba == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("To nie jest równanie kwadratowe: A = 0!");
                            
                        }
                        
                            a = liczba;
                            
                        
                        break;
                    case 1:
                        b = liczba;
                        
                        break;
                    case 2:
                        c = liczba;
                        


                        sukces = true;
                        break;
                }
                numer_zmiennej++;
                
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("To nie jest prawidłowa liczba rzeczywista!");

                sukces = false;
                //return 
                //program ma zaczynac prace od nowa jakby;
            }
        } while (sukces == false);
    }
    public void Oblicz_i_wyswietl()
    {
        Console.WriteLine($"A: {a}");
        Console.WriteLine($"B: {b}");
        Console.WriteLine($"C: {c}");
        Console.WriteLine();
        delta = (b * b) - (4 * a * c);
        Console.WriteLine();
        if (a == 0)
        {
            Console.WriteLine("To funkcja liniowa!");
            return;
        }
        else
        {
            Console.WriteLine($"Delta: {delta}");
        }
        if (delta < 0)
        {
            Console.WriteLine("Brak pierwiastków rzeczywistych");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Obliczam jedno miejsce zerowe: ");
            x0 = -b / (2 * a);
            Console.WriteLine($"x0: {x0:F2}");
        }
        else if (delta > 0)
        {
            Console.WriteLine("Obliczam dwa miejsca zerowe: ");
            x1 = (-b - Math.Sqrt(delta) / (2 * a));
            x2 = (-b + Math.Sqrt(delta) / (2 * a));
            Console.WriteLine($"x1: {x1:F2}");
            Console.WriteLine($"x2: {x2:F2}");
        }

    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Pobierz_liczbę();
        program.Oblicz_i_wyswietl();

    }
}





















